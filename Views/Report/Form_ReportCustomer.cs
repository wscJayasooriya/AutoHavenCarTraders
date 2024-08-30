using CarTraders.Data;
using CarTraders.Helpers;
using CarTraders.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CarTraders.Helpers.NotificationUtil;

namespace CarTraders
{
    public partial class Form_ReportCustomer : Form
    {
        public string selectFromDate;
        public string selectToDate;
        public Form_ReportCustomer()
        {
            InitializeComponent();
        }

        private void Form_ReportCustomer_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime fromDate = dateFromDate.Value.Date;
            DateTime toDate = dateToDate.Value.Date.AddDays(1).AddTicks(-1);
            selectFromDate = fromDate.ToString("yyyy-MM-dd HH:mm:ss");
            selectToDate = toDate.ToString("yyyy-MM-dd HH:mm:ss");

            LoadItemWiseSalesTable(selectFromDate, selectToDate);

        }

        private void LoadItemWiseSalesTable(string from_date, string to_date)
        {
            try
            {
                using (var dbContext = new ApplicationDBContext())
                {

                    var startDate = DateTime.ParseExact(from_date, "yyyy-MM-dd HH:mm:ss", null);
                    var endDate = DateTime.ParseExact(to_date, "yyyy-MM-dd HH:mm:ss", null);
                    var excludedItems = new List<string> { "CAR" };

                    var salesQuery = dbContext.orderItemDetails
                                        .Where(o => o.OrderDate >= startDate && o.OrderDate <= endDate && !excludedItems.Contains(o.ItemCode.Trim().ToUpper()))
                                        .Join(dbContext.orderDetails,
                                              o => o.OrderCode,
                                              d => d.OrderCode,
                                              (o, d) => new { o, d })
                                        .Where(joined => joined.d.IsApproved == 1)
                                        .GroupBy(joined => joined.o.ItemCode)
                                        .Select(g => new
                                        {
                                            ItemCode = g.Key,
                                            ItemName = g.Max(x => x.o.ItemName),
                                            Price = g.Max(x => x.o.Price),
                                            Quantity = g.Sum(x => x.o.Quantity),
                                            TotalAmount = g.Sum(x => x.o.Quantity * x.o.Price)
                                        }).ToList();

                    if (salesQuery.Count == 0)
                    {
                        NotificationUtil.ShowNotification(NotificationType.INFO, "No data found for the selected date range.");
                        dataGridView.DataSource = null;
                        btnPrint.Visible = false;
                        return;
                    }

                    DataTable salesTable = new DataTable();
                    salesTable.Columns.Add("ItemCode", typeof(string));
                    salesTable.Columns.Add("ItemName", typeof(string));
                    salesTable.Columns.Add("Price", typeof(double));
                    salesTable.Columns.Add("Quantity", typeof(int));
                    salesTable.Columns.Add("Total", typeof(double));

                    foreach (var sales in salesQuery)
                    {
                        DataRow row = salesTable.NewRow();
                        row["ItemCode"] = sales.ItemCode;
                        row["ItemName"] = sales.ItemName;
                        row["Price"] = sales.Price;
                        row["Quantity"] = sales.Quantity;
                        row["Total"] = sales.TotalAmount;

                        salesTable.Rows.Add(row);

                    }
                    dataGridView.DataSource = salesTable;

                    ConfigureDataGridView();
                    btnPrint.Visible = true;
                }
            }
            catch (Exception ex)
            {
                NotificationUtil.ShowNotification(NotificationType.ERROR, "An error occurred while loading car data: " + ex.Message);
                btnPrint.Visible = false;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                // Initialize Excel application
                Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
                xlApp.Visible = false; // Keep it invisible while processing

                Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel.Worksheet xlWorksheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkbook.Worksheets[1];

                // Set the report title
                xlWorksheet.Cells[1, 1] = "Item Wise Sales Details Report";
                xlWorksheet.Cells[1, 1].Font.Bold = true;
                xlWorksheet.Cells[1, 1].Font.Size = 16;

                // Set the date range as a header
                xlWorksheet.Cells[2, 1] = $"From Date: {selectFromDate}  To Date: {selectToDate}";
                xlWorksheet.Cells[2, 1].Font.Bold = true;

                // Set column headers
                for (int i = 0; i < dataGridView.Columns.Count; i++)
                {
                    xlWorksheet.Cells[4, i + 1] = dataGridView.Columns[i].HeaderText;
                    xlWorksheet.Cells[4, i + 1].Font.Bold = true;
                }

                // Add rows of data
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView.Columns.Count; j++)
                    {
                        xlWorksheet.Cells[i + 5, j + 1] = dataGridView.Rows[i].Cells[j].Value?.ToString();
                    }
                }

                // Determine the range for the table (including headers and data)
                int lastRow = dataGridView.Rows.Count + 4;
                int lastCol = dataGridView.Columns.Count;

                Microsoft.Office.Interop.Excel.Range tableRange = xlWorksheet.Range[xlWorksheet.Cells[4, 1], xlWorksheet.Cells[lastRow, lastCol]];

                // Create the table
                Microsoft.Office.Interop.Excel.ListObject excelTable = xlWorksheet.ListObjects.Add(
                    Microsoft.Office.Interop.Excel.XlListObjectSourceType.xlSrcRange,
                    tableRange,
                    Type.Missing,
                    Microsoft.Office.Interop.Excel.XlYesNoGuess.xlYes,
                    Type.Missing);

                // Name the table
                excelTable.Name = "SalesData";

                // Apply table style
                excelTable.TableStyle = "TableStyleMedium9"; // You can change to any other built-in style

                // Auto-fit columns
                xlWorksheet.Columns.AutoFit();

                // Save File Dialog
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Files|*.xlsx;*.xls";
                saveFileDialog.Title = "Save an Excel File";
                saveFileDialog.FileName = "SalesReport.xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Save the Excel workbook to the chosen file path
                    xlWorkbook.SaveAs(saveFileDialog.FileName);
                    NotificationUtil.ShowNotification(NotificationType.SUCCESS, "Excel file saved successfully!");
                }

                // Clean up
                xlWorkbook.Close(false, Type.Missing, Type.Missing);
                xlApp.Quit();

                // Release COM objects
                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorksheet);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkbook);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp);
            }
            catch (Exception ex)
            {
                NotificationUtil.ShowNotification(NotificationType.ERROR, "An error occurred while exporting to Excel: " + ex.Message);
            }
        }

        private void ConfigureDataGridView()
        {
            dataGridView.AutoGenerateColumns = true;
            Padding cellPadding = new Padding(10, 5, 10, 5); // Left, Top, Right, Bottom
            dataGridView.RowTemplate.DefaultCellStyle.Padding = cellPadding;

            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView.ColumnHeadersHeight = 70;

            dataGridView.Columns["ItemCode"].Width = 250;
            dataGridView.Columns["ItemCode"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridView.Columns["ItemCode"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns["ItemCode"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns["ItemName"].Width = 350;
            dataGridView.Columns["ItemName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridView.Columns["ItemName"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns["ItemName"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns["Price"].Width = 300;
            dataGridView.Columns["Price"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridView.Columns["Price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns["Price"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns["Quantity"].Width = 200;
            dataGridView.Columns["Quantity"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridView.Columns["Quantity"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns["Quantity"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns["Total"].Width = 300;
            dataGridView.Columns["Total"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridView.Columns["Total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns["Total"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView.Columns["ItemCode"].HeaderText = "Item Code";
            dataGridView.Columns["ItemName"].HeaderText = "ItemName";
            dataGridView.Columns["Price"].HeaderText = "Price";
            dataGridView.Columns["Quantity"].HeaderText = "Quantity";
            dataGridView.Columns["Total"].HeaderText = "Total Amount";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dateFromDate.Value = DateTime.Now;
            dateToDate.Value = DateTime.Now;
            dataGridView.DataSource = null;
            btnPrint.Visible = false;
        }
    }
}
