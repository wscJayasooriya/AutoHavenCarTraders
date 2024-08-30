using CarTraders.Data;
using CarTraders.Helpers;
using CarTraders.Migrations;
using CarTraders.Model;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CarTraders.Helpers.NotificationUtil;

namespace CarTraders
{
    public partial class Form_CarParts : Form
    {
        private bool isExpanding = true;
        private string hiddenCarPartId;
        private CodeGenerateUtil generateUtil;
        private ExportDataPdfUtil exportPdfUtil;
        public string currentUser;
        public Form_CarParts(string username)
        {
            InitializeComponent();
            generateUtil = new CodeGenerateUtil();
            exportPdfUtil = new ExportDataPdfUtil();
            pictureBoxLoading.Location = new Point((this.Width - pictureBoxLoading.Width) / 2, (this.Height - pictureBoxLoading.Height) / 2);
            currentUser = username;
        }

        private void Form_CarParts_Load(object sender, EventArgs e)
        {
            panelFull.Width = 0;
            tableCarPartView.Width = 1600;
            tableCarPartView.Height = 650;
            if (tableCarPartView.Parent is Panel parentPanel)
            {

                parentPanel.HorizontalScroll.Enabled = true;
                parentPanel.HorizontalScroll.Visible = true;
                parentPanel.VerticalScroll.Enabled = false;
                parentPanel.VerticalScroll.Visible = false;
            }

            tableCarPartView.CellClick += TableCarPartView_CellClick;

            LoadCarPartsData();
        }

        private void TableCarPartView_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            // Remove Button 
            if (e.ColumnIndex == tableCarPartView.Columns["Remove"].Index && e.RowIndex >= 0)
            {
                var result = MessageBox.Show("Are you sure you want to remove this car part?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result != DialogResult.Yes) return;

                if (Guid.TryParse(tableCarPartView.Rows[e.RowIndex].Cells["Id"].Value.ToString(), out Guid partGuid))
                {
                    using (var dbContext = new ApplicationDBContext())
                    {
                        var parts = dbContext.carParts.SingleOrDefault(c => c.Id == partGuid);
                        var users = dbContext.users.SingleOrDefault(u => u.Username == currentUser);

                        if (parts == null)
                        {
                            NotificationUtil.ShowNotification(NotificationType.INFO, "Car Part not found in the database.");
                            return;
                        }
                        NotificationUtil.ShowNotification(NotificationType.DELETE, "Car Part successfully deleted in the database.");
                        parts.IsDeleted = 1;
                        parts.DeletedDate = DateTime.Now;
                        parts.DeletedBy = users.UserCode;
                        dbContext.carParts.Update(parts);
                        dbContext.SaveChanges();

                        LoadCarPartsData();
                    }
                }
                else
                {
                    NotificationUtil.ShowNotification(NotificationType.ERROR, "Invalid Car Part ID format.");
                }
            }

            // Edit Button
            if (e.RowIndex >= 0 && e.ColumnIndex == tableCarPartView.Columns["Edit"].Index)
            {
                // Get the selected car's data from the DataGridView row
                DataGridViewRow selectedRow = tableCarPartView.Rows[e.RowIndex];

                // Assuming you have textboxes, combo boxes, etc., in the panel to fill with data
                txtCarModel.Text = selectedRow.Cells["CarModel"].Value.ToString();
                txtManufacture.Text = selectedRow.Cells["Manufacture"].Value.ToString();
                txtPartName.Text = selectedRow.Cells["PartName"].Value.ToString();
                txtColor.Text = selectedRow.Cells["Color"].Value.ToString();
                txtPrice.Text = selectedRow.Cells["Price"].Value.ToString();
                txtQty.Text = selectedRow.Cells["Quantity"].Value.ToString();
                comboCategory.Text = selectedRow.Cells["PartCategory"].Value.ToString();
                comboCondition.Text = selectedRow.Cells["Condition"].Value.ToString();
                txtDescription.Text = selectedRow.Cells["Description"].Value.ToString();

                // Display the image if needed
                if (selectedRow.Cells["Image"].Value != null)
                {
                    pictureBox.Image = (Image)selectedRow.Cells["Image"].Value;

                }


                // Optionally, store the car's ID in a hidden field or a variable for future reference
                hiddenCarPartId = selectedRow.Cells["Id"].Value.ToString();

                // Open or make visible the panel for editing
                isExpanding = true;
                TimerAdd.Start();
                TLPanelTop.Enabled = false;

                // Optionally change the button text to "Update" instead of "Add"
                btnCarSave.Visible = false;
                btnModify.Visible = true;
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                labelHead.Text = "Edit Car Part Details";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            isExpanding = true;
            TimerAdd.Start();
            TLPanelTop.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearForm();
            isExpanding = false;
            TimerAdd.Start();
            TLPanelTop.Enabled = true;
        }
        private void ClearForm()
        {
            txtCarModel.Clear();
            txtManufacture.Clear();
            txtColor.Clear();
            comboCondition.SelectedIndex = -1;
            comboCondition.Text = "- Choose One -";
            txtPartName.Clear();
            txtQty.Clear();
            comboCategory.SelectedIndex = -1;
            comboCategory.Text = "- Choose One -";
            txtDescription.Clear();
            txtPrice.Clear();
            pictureBox.Image = null; // Optionally, clear the picture box
        }


        private void TimerAdd_Tick(object sender, EventArgs e)
        {
            if (isExpanding)
            {
                if (panelFull.Width < 634)
                {
                    panelFull.Width += 634;
                }
                else
                {
                    panelFull.Width = 634;
                    TimerAdd.Stop();
                    panelBody.Visible = true;
                }
            }
            else
            {
                if (panelFull.Width > 0)
                {
                    panelFull.Width -= 634;
                }
                else
                {
                    panelFull.Width = 0;
                    TimerAdd.Stop();
                    panelBody.Visible = false;
                }
            }
        }

        private void buttonChooseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox.ImageLocation = openFileDialog.FileName;
            }
        }

        private void btnCarSave_Click(object sender, EventArgs e)
        {
            var carModel = txtCarModel.Text;
            var partName = txtPartName.Text;
            var manufacture = txtManufacture.Text;
            var color = txtColor.Text;
            var price = txtPrice.Text;
            var qty = txtQty.Text;
            var partCategory = comboCategory.Text;
            var condition = comboCondition.Text;
            var description = txtDescription.Text;

            try
            {
                using (var dbContext = new ApplicationDBContext())
                {
                    var carPartCode = generateUtil.GetNextCarCode();

                    var parts = new CarParts
                    {
                        CarModel = carModel,
                        PartName = partName,
                        Manufacture = manufacture,
                        Color = color,
                        Price = double.Parse(price),
                        Quantity = int.Parse(qty),
                        PartCategory = partCategory,
                        Condition = condition,
                        Description = description,
                        Status = 1,
                        CarPartCode = carPartCode,
                        CreateDate = DateTime.Now,
                        Image = CarPartsImageToByteArray(pictureBox.Image)
                    };

                    var validationResults = new List<ValidationResult>();
                    var validationContext = new ValidationContext(parts, null, null);
                    if (!Validator.TryValidateObject(parts, validationContext, validationResults, true))
                    {
                        foreach (var validationResult in validationResults)
                        {
                            NotificationUtil.ShowNotification(NotificationType.ERROR, "Validation Error: " + validationResult.ErrorMessage);
                        }
                        return;
                    }

                    dbContext.carParts.Add(parts);
                    dbContext.SaveChanges();
                    NotificationUtil.ShowNotification(NotificationType.SUCCESS, "Car Parts Saved Successfully.");

                    LoadCarPartsData();
                    ClearForm();
                    isExpanding = false;
                    TimerAdd.Start();
                    TLPanelTop.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                NotificationUtil.ShowNotification(NotificationType.ERROR, "An error occurred while saving car parts data: " + ex.Message);
            }
        }

        private void LoadCarPartsData(string searchTerm = "")
        {
            try
            {
                using (var dbContext = new ApplicationDBContext())
                {

                    var partsQuery = dbContext.carParts
                    .Where(u => u.Status == 1 && u.IsDeleted == 0);

                    if (!string.IsNullOrEmpty(searchTerm))
                    {
                        partsQuery = partsQuery.Where(u =>
                            u.CarModel.Contains(searchTerm) ||
                            u.PartName.Contains(searchTerm) ||
                            u.Color.Contains(searchTerm) ||
                            u.PartCategory.Contains(searchTerm) ||
                            u.Condition.Contains(searchTerm) ||
                            u.Description.Contains(searchTerm) ||
                            u.Manufacture.Contains(searchTerm));
                    }

                    var carParts = partsQuery.ToList();
                    var setImage = dbContext.defaultImage.FirstOrDefault();

                    DataTable carPartsTable = new DataTable();

                    carPartsTable.Columns.Add("Id", typeof(string));
                    carPartsTable.Columns.Add("Image", typeof(Image));
                    carPartsTable.Columns.Add("CarModel", typeof(string));
                    carPartsTable.Columns.Add("PartName", typeof(string));
                    carPartsTable.Columns.Add("Manufacture", typeof(string));
                    carPartsTable.Columns.Add("Color", typeof(string));
                    carPartsTable.Columns.Add("Price", typeof(double));
                    carPartsTable.Columns.Add("Quantity", typeof(int));
                    carPartsTable.Columns.Add("PartCategory", typeof(string));
                    carPartsTable.Columns.Add("Condition", typeof(string));
                    carPartsTable.Columns.Add("Description", typeof(string));
                    carPartsTable.Columns.Add("CreateDate", typeof(DateTime));
                    carPartsTable.Columns.Add("Status", typeof(int));
                    carPartsTable.Columns.Add("UpdateDate", typeof(DateTime));

                    foreach (var parts in carParts)
                    {
                        DataRow row = carPartsTable.NewRow();
                        row["Id"] = parts.Id;
                        row["CarModel"] = parts.CarModel;
                        row["PartName"] = parts.PartName;
                        row["Manufacture"] = parts.Manufacture;
                        row["Color"] = parts.Color;
                        row["Price"] = parts.Price;
                        row["Quantity"] = parts.Quantity;
                        row["PartCategory"] = parts.PartCategory;
                        row["Condition"] = parts.Condition;
                        row["Description"] = parts.Description;
                        row["CreateDate"] = parts.CreateDate;
                        row["Status"] = parts.Status;
                        row["UpdateDate"] = parts.UpdateDate;

                        Image imageValue = null;
                        if (parts.Image != null && parts.Image.Length > 0)
                        {
                            imageValue = ByteArrayToImage(parts.Image);
                        }
                        else
                        {
                            imageValue = ByteArrayToImage(setImage.Image);
                        }
                        row["Image"] = imageValue;

                        carPartsTable.Rows.Add(row);

                    }
                    tableCarPartView.DataSource = carPartsTable;

                    if (!tableCarPartView.Columns.Contains("Edit"))
                    {
                        DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
                        editButtonColumn.Name = "Edit";
                        editButtonColumn.HeaderText = "Edit";
                        editButtonColumn.Text = "Edit";
                        editButtonColumn.UseColumnTextForButtonValue = true;
                        tableCarPartView.Columns.Add(editButtonColumn);
                    }

                    if (!tableCarPartView.Columns.Contains("Remove"))
                    {
                        DataGridViewButtonColumn removeButtonColumn = new DataGridViewButtonColumn();
                        removeButtonColumn.Name = "Remove";
                        removeButtonColumn.HeaderText = "Remove";
                        removeButtonColumn.Text = "Remove";
                        removeButtonColumn.UseColumnTextForButtonValue = true;
                        tableCarPartView.Columns.Add(removeButtonColumn);
                    }

                    ConfigureDataGridView();
                }

            }
            catch (Exception ex)
            {
                NotificationUtil.ShowNotification(NotificationType.ERROR, "An error occurred while loading car parts data: " + ex.Message);
            }
        }

        private void ConfigureDataGridView()
        {
            tableCarPartView.AutoGenerateColumns = true;
            Padding cellPadding = new Padding(10, 5, 10, 5); // Left, Top, Right, Bottom
            tableCarPartView.RowTemplate.DefaultCellStyle.Padding = cellPadding;

            tableCarPartView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            tableCarPartView.ColumnHeadersHeight = 50;

            tableCarPartView.Columns["Image"].Width = 150;
            tableCarPartView.Columns["Image"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            tableCarPartView.Columns["Image"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tableCarPartView.Columns["Image"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tableCarPartView.Columns["CarModel"].Width = 250;
            tableCarPartView.Columns["CarModel"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            tableCarPartView.Columns["CarModel"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tableCarPartView.Columns["CarModel"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tableCarPartView.Columns["PartName"].Width = 250;
            tableCarPartView.Columns["PartName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            tableCarPartView.Columns["PartName"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tableCarPartView.Columns["PartName"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tableCarPartView.Columns["Color"].Width = 150;
            tableCarPartView.Columns["Color"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            tableCarPartView.Columns["Color"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tableCarPartView.Columns["Color"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tableCarPartView.Columns["PartCategory"].Width = 200;
            tableCarPartView.Columns["PartCategory"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            tableCarPartView.Columns["PartCategory"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tableCarPartView.Columns["PartCategory"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tableCarPartView.Columns["Quantity"].Width = 120;
            tableCarPartView.Columns["Quantity"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            tableCarPartView.Columns["Quantity"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tableCarPartView.Columns["Quantity"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tableCarPartView.Columns["Price"].Width = 200;
            tableCarPartView.Columns["Price"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            tableCarPartView.Columns["Price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tableCarPartView.Columns["Price"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            tableCarPartView.Columns["Id"].Visible = false;
            tableCarPartView.Columns["Condition"].Visible = false;
            tableCarPartView.Columns["Description"].Visible = false;
            tableCarPartView.Columns["CreateDate"].Visible = false;
            tableCarPartView.Columns["Status"].Visible = false;
            tableCarPartView.Columns["UpdateDate"].Visible = false;
            tableCarPartView.Columns["Manufacture"].Visible = false;

            tableCarPartView.Columns["Image"].HeaderText = "Image";
            tableCarPartView.Columns["CarModel"].HeaderText = "Car Model";
            tableCarPartView.Columns["PartName"].HeaderText = "Part Name";
            tableCarPartView.Columns["Color"].HeaderText = "Color";
            tableCarPartView.Columns["PartCategory"].HeaderText = "Partner Category";
            tableCarPartView.Columns["Quantity"].HeaderText = "Quantity";
            tableCarPartView.Columns["Price"].HeaderText = "Selling Price";


            tableCarPartView.RowTemplate.Height = 75;
            tableCarPartView.CellFormatting += (sender, e) =>
            {
                if (e.ColumnIndex == tableCarPartView.Columns["Edit"].Index && e.RowIndex >= 0)
                {
                    DataGridViewButtonCell? buttonCell = tableCarPartView.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewButtonCell;
                    if (buttonCell != null)
                    {
                        tableCarPartView.Rows[e.RowIndex].Height = 70;
                        tableCarPartView.Columns[e.ColumnIndex].Width = 100;
                        tableCarPartView.Cursor = Cursors.Hand;
                    }
                }
                if (e.ColumnIndex == tableCarPartView.Columns["Remove"].Index && e.RowIndex >= 0)
                {
                    DataGridViewButtonCell? buttonCell = tableCarPartView.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewButtonCell;
                    if (buttonCell != null)
                    {
                        tableCarPartView.Rows[e.RowIndex].Height = 70;
                        tableCarPartView.Columns[e.ColumnIndex].Width = 100;
                        tableCarPartView.Cursor = Cursors.Hand;
                    }
                }
            };
            tableCarPartView.CellPainting += new DataGridViewCellPaintingEventHandler(tableCarPartView_CellPainting);
        }

        private void tableCarPartView_CellPainting(object? sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == tableCarPartView.Columns["Image"].Index && e.RowIndex >= 0)
            {
                e.PaintBackground(e.ClipBounds, true);

                if (e.Value != null)
                {
                    Image img = e.Value as Image;
                    if (img != null)
                    {
                        // Calculate the dimensions to maintain aspect ratio
                        float imageAspect = img.Width / (float)img.Height;
                        int cellHeight = e.CellBounds.Height;
                        int imgHeight = cellHeight;
                        int imgWidth = (int)(imageAspect * imgHeight);
                        if (imgWidth > e.CellBounds.Width)
                        {
                            imgWidth = e.CellBounds.Width;
                            imgHeight = (int)(imgWidth / imageAspect);
                        }

                        int imgLeft = e.CellBounds.Left + (e.CellBounds.Width - imgWidth) / 2;
                        int imgTop = e.CellBounds.Top + (e.CellBounds.Height - imgHeight) / 2;

                        e.Graphics.DrawImage(img, new Rectangle(imgLeft, imgTop + 5, imgWidth, imgHeight - 10));
                    }
                }

                e.Handled = true;
            }
        }

        private Image ByteArrayToImage(byte[] byteArray)
        {
            using (var ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }

        private byte[] CarPartsImageToByteArray(Image image)
        {
            using (var ms = new MemoryStream())
            {
                using (var clonedImage = new Bitmap(image))
                {
                    ImageFormat format = image.RawFormat;

                    if (ImageFormat.Jpeg.Equals(format))
                        format = ImageFormat.Jpeg;
                    else if (ImageFormat.Png.Equals(format))
                        format = ImageFormat.Png;
                    else if (ImageFormat.Bmp.Equals(format))
                        format = ImageFormat.Bmp;
                    else if (ImageFormat.Gif.Equals(format))
                        format = ImageFormat.Gif;
                    else if (ImageFormat.Tiff.Equals(format))
                        format = ImageFormat.Tiff;
                    else
                        format = ImageFormat.Png;

                    clonedImage.Save(ms, format);
                }
                return ms.ToArray();
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            try
            {
                using (var dbContext = new ApplicationDBContext())
                {
                    var carPartId = Guid.Parse(hiddenCarPartId); // Retrieve the car ID

                    var existingCarPart = dbContext.carParts.Find(carPartId);
                    if (existingCarPart != null)
                    {
                        // Update car part details
                        existingCarPart.CarModel = txtCarModel.Text;
                        existingCarPart.PartName = txtPartName.Text;
                        existingCarPart.Manufacture = txtManufacture.Text;
                        existingCarPart.Color = txtColor.Text;
                        existingCarPart.Price = double.Parse(txtPrice.Text);
                        existingCarPart.Quantity = int.Parse(txtQty.Text);
                        existingCarPart.PartCategory = comboCategory.Text;
                        existingCarPart.Condition = comboCondition.Text;
                        existingCarPart.Description = txtDescription.Text;
                        existingCarPart.UpdateDate = DateTime.Now;
                        existingCarPart.Image = CarPartsImageToByteArray(pictureBox.Image);

                        dbContext.SaveChanges();
                        NotificationUtil.ShowNotification(NotificationType.EDIT, "Car Part details updated successfully.");
                    }
                    else
                    {
                        NotificationUtil.ShowNotification(NotificationType.INFO, "Car Part not found.");
                    }
                    LoadCarPartsData();
                    ClearForm();
                    isExpanding = false;
                    TimerAdd.Start();
                    TLPanelTop.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                NotificationUtil.ShowNotification(NotificationType.ERROR, "An error occurred while modifying car part data: " + ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            ClearForm();
            LoadCarPartsData();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();
            tableCarPartView.Visible = false;
            pictureBoxLoading.Visible = true;

            try
            {
                await Task.Run(() =>
                {
                    Thread.Sleep(1000);
                    Invoke(new Action(() =>
                    {
                        LoadCarPartsData(searchTerm);
                    }));
                });
            }
            catch (Exception ex)
            {
                NotificationUtil.ShowNotification(NotificationType.ERROR, "An error occurred: " + ex.Message);
            }
            finally
            {
                pictureBoxLoading.Visible = false;
                tableCarPartView.Visible = true;
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            List<string> columnsToInclude = new List<string> { "CarModel", "PartName", "Color", "PartCategory", "Quantity", "Price" };
            string reportTopic = "Car Part Details Report";
            exportPdfUtil.ExportGridDataToPdf(tableCarPartView, "Car_Part_Details_Report", columnsToInclude, reportTopic);
        }
    }
}
