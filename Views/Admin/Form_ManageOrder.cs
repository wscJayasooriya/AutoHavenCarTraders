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

namespace CarTraders.Views
{
    public partial class Form_ManageOrder : Form
    {
        public string currentUser;
        public Form_ManageOrder(string username)
        {
            InitializeComponent();
            LoadPendingOrders(false);
            btnPendingOrder.BackColor = Color.FromArgb(33, 97, 140);
            currentUser = username;
            dataGridView.CellClick += TablePendingOrderView_CellClick;
        }

        private void Form_ManageOrder_Load(object sender, EventArgs e)
        {
            using (var context = new ApplicationDBContext())
            {
                pendingOrderCount.Text = context.orderDetails.Count(o => o.IsApproved == 0).ToString();
                completeOrderCount.Text = context.orderDetails.Count(o => o.IsApproved == 1).ToString();
            }
        }


        private void btnPendingOrder_Click(object sender, EventArgs e)
        {
            LoadPendingOrders(false);
            btnPendingOrder.BackColor = Color.FromArgb(33, 97, 140);
            btnCompleteOrder.BackColor = Color.FromArgb(23, 32, 42);
        }
        private void btnCompleteOrder_Click(object sender, EventArgs e)
        {
            btnPendingOrder.BackColor = Color.FromArgb(23, 32, 42);
            btnCompleteOrder.BackColor = Color.FromArgb(33, 97, 140);
            LoadPendingOrders(true);
        }

        private void LoadPendingOrders(bool a)
        {
            try
            {
                using (var dbContext = new ApplicationDBContext())
                {

                    List<OrderDetails> pendingOrders;

                    if (a)
                    {
                        pendingOrders = dbContext.orderDetails
                   .Where(u => u.Is_active == 1 && u.IsApproved == 1)
                   .OrderBy(u => u.OrderDate)
                   .ToList();
                    }
                    else
                    {
                        pendingOrders = dbContext.orderDetails
                   .Where(u => u.Is_active == 1 && u.IsApproved == 0)
                   .OrderBy(u => u.OrderDate)
                   .ToList();
                    }

                    DataTable pendingOrderTable = new DataTable();
                    pendingOrderTable.Columns.Add("Id", typeof(string));
                    pendingOrderTable.Columns.Add("OrderCode", typeof(string));
                    pendingOrderTable.Columns.Add("CustomerCode", typeof(string));
                    pendingOrderTable.Columns.Add("GrossAmount", typeof(double));
                    pendingOrderTable.Columns.Add("PaidAmount", typeof(double));
                    pendingOrderTable.Columns.Add("ChangeAmount", typeof(double));
                    pendingOrderTable.Columns.Add("OrderStatus", typeof(string));
                    pendingOrderTable.Columns.Add("IsPayment", typeof(int));
                    pendingOrderTable.Columns.Add("IsApproved", typeof(int));
                    pendingOrderTable.Columns.Add("IsDelivered", typeof(int));
                    pendingOrderTable.Columns.Add("Is_active", typeof(int));
                    pendingOrderTable.Columns.Add("OrderDate", typeof(DateTime));
                    pendingOrderTable.Columns.Add("ApprovedDate", typeof(DateTime));
                    pendingOrderTable.Columns.Add("DeliveredDate", typeof(DateTime));
                    pendingOrderTable.Columns.Add("ApprovedBy", typeof(string));
                    pendingOrderTable.Columns.Add("OrderType", typeof(string));

                    foreach (var pendingOrder in pendingOrders)
                    {
                        DataRow row = pendingOrderTable.NewRow();
                        row["Id"] = pendingOrder.Id;
                        row["OrderCode"] = pendingOrder.OrderCode;
                        row["CustomerCode"] = pendingOrder.CustomerCode;
                        row["GrossAmount"] = pendingOrder.GrossAmount;
                        row["PaidAmount"] = pendingOrder.PaidAmount;
                        row["ChangeAmount"] = pendingOrder.ChangeAmount;
                        row["OrderStatus"] = pendingOrder.OrderStatus;
                        row["IsPayment"] = pendingOrder.IsPayment;
                        row["IsApproved"] = pendingOrder.IsApproved;
                        row["IsDelivered"] = pendingOrder.IsDelivered;
                        row["Is_active"] = pendingOrder.Is_active;
                        row["OrderDate"] = pendingOrder.OrderDate;
                        row["ApprovedDate"] = pendingOrder.ApprovedDate;
                        row["DeliveredDate"] = pendingOrder.DeliveredDate;
                        row["ApprovedBy"] = pendingOrder.ApprovedBy;
                        row["OrderType"] = pendingOrder.OrderType;

                        pendingOrderTable.Rows.Add(row);
                    }
                    dataGridView.DataSource = pendingOrderTable;
                    if (dataGridView.Columns.Contains("ApprovedDate"))
                    {
                        dataGridView.Columns["ApprovedDate"].Visible = a;
                    }
                    if (a)
                    {
                        if (dataGridView.Columns.Contains("Action"))
                        {
                            dataGridView.Columns["Action"].Visible = false;
                        }
                    }
                    else
                    {
                        if (!dataGridView.Columns.Contains("Action"))
                        {
                            DataGridViewButtonColumn approveButtonColumn = new DataGridViewButtonColumn
                            {
                                Name = "Action",
                                HeaderText = "Action",
                                Text = "Action",
                                UseColumnTextForButtonValue = true
                            };
                            dataGridView.Columns.Add(approveButtonColumn);
                        }
                        else
                        {
                            dataGridView.Columns["Action"].Visible = true; // Ensure the column is visible if 'a' is false
                        }
                    }

                    if (!dataGridView.Columns.Contains("View"))
                    {
                        DataGridViewButtonColumn viewButtonColumn = new DataGridViewButtonColumn
                        {
                            Name = "View",
                            HeaderText = "View",
                            Text = "View",
                            UseColumnTextForButtonValue = true
                        };
                        dataGridView.Columns.Add(viewButtonColumn);
                    }
                    ConfigureDataGridView();

                }
            }
            catch (Exception ex)
            {
                NotificationUtil.ShowNotification(NotificationType.ERROR, "An error occurred while loading car data: " + ex.Message);
            }
        }



        private void ConfigureDataGridView()
        {
            dataGridView.AutoGenerateColumns = true;
            Padding cellPadding = new Padding(10, 5, 10, 5); // Left, Top, Right, Bottom
            dataGridView.RowTemplate.DefaultCellStyle.Padding = cellPadding;

            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView.ColumnHeadersHeight = 50;
            dataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView.Columns["Id"].Visible = false;
            dataGridView.Columns["PaidAmount"].Visible = false;
            dataGridView.Columns["ChangeAmount"].Visible = false;
            dataGridView.Columns["IsPayment"].Visible = false;
            dataGridView.Columns["IsApproved"].Visible = false;
            dataGridView.Columns["IsDelivered"].Visible = false;
            dataGridView.Columns["Is_active"].Visible = false;
            dataGridView.Columns["DeliveredDate"].Visible = false;
            dataGridView.Columns["ApprovedBy"].Visible = false;

            dataGridView.Columns["OrderDate"].Width = 200;
            dataGridView.Columns["OrderDate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridView.Columns["OrderDate"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns["OrderDate"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns["ApprovedDate"].Width = 200;
            dataGridView.Columns["ApprovedDate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridView.Columns["ApprovedDate"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns["ApprovedDate"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns["OrderCode"].Width = 150;
            dataGridView.Columns["OrderCode"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridView.Columns["OrderCode"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns["OrderCode"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns["CustomerCode"].Width = 150;
            dataGridView.Columns["CustomerCode"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridView.Columns["CustomerCode"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns["CustomerCode"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns["OrderStatus"].Width = 180;
            dataGridView.Columns["OrderStatus"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridView.Columns["OrderStatus"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns["OrderStatus"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns["OrderType"].Width = 180;
            dataGridView.Columns["OrderType"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridView.Columns["OrderType"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns["OrderType"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns["GrossAmount"].Width = 180;
            dataGridView.Columns["GrossAmount"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridView.Columns["GrossAmount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns["GrossAmount"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView.Columns["OrderDate"].HeaderText = "Order Date";
            dataGridView.Columns["ApprovedDate"].HeaderText = "Approved Date";
            dataGridView.Columns["OrderCode"].HeaderText = "Invoice No";
            dataGridView.Columns["CustomerCode"].HeaderText = "Customer Code";
            dataGridView.Columns["OrderStatus"].HeaderText = "Status";
            dataGridView.Columns["GrossAmount"].HeaderText = "Gross Amount (Rs)";
            dataGridView.Columns["OrderType"].HeaderText = "Order Type";

            dataGridView.RowTemplate.Height = 75;

            dataGridView.CellFormatting += (sender, e) =>
            {
                if (e.ColumnIndex == dataGridView.Columns["Action"].Index && e.RowIndex >= 0)
                {
                    DataGridViewButtonCell? buttonCell = dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewButtonCell;
                    if (buttonCell != null)
                    {
                        dataGridView.Rows[e.RowIndex].Height = 70;
                        dataGridView.Columns[e.ColumnIndex].Width = 200;
                        dataGridView.Cursor = Cursors.Hand;
                    }
                }
                if (e.ColumnIndex == dataGridView.Columns["View"].Index && e.RowIndex >= 0)
                {
                    DataGridViewButtonCell? buttonCell = dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewButtonCell;
                    if (buttonCell != null)
                    {
                        dataGridView.Rows[e.RowIndex].Height = 70;
                        dataGridView.Columns[e.ColumnIndex].Width = 200;
                        dataGridView.Cursor = Cursors.Hand;
                    }
                }
            };

        }

        private void TablePendingOrderView_CellClick(object? sender, DataGridViewCellEventArgs e)
        {


            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView.Columns["View"].Index)
            {
                // Extract OrderCode from the row
                var row = dataGridView.Rows[e.RowIndex];
                string orderCode = row.Cells["OrderCode"].Value.ToString();

                Form_View_Order view_Order = new Form_View_Order(orderCode, currentUser, false);
                view_Order.Show();
            }

            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView.Columns["Action"].Index)
            {
                // Extract OrderCode from the row
                var row = dataGridView.Rows[e.RowIndex];
                string orderCode = row.Cells["OrderCode"].Value.ToString();

                Form_View_Order view_Order = new Form_View_Order(orderCode, currentUser, true);
                view_Order.Show();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }
    }
}
