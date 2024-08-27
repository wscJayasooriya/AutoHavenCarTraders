using CarTraders.Data;
using CarTraders.Helpers;
using CarTraders.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarTraders
{

    public partial class Form_Cars : Form
    {
        private bool isExpanding = true;
        private Point labelPriceOriginalLocation;
        private Point txtPriceOriginalLocation;
        private Point labelSpecOriginalLocation;
        private Point txtSpecificationOriginalLocation;
        private string hiddenCarId;
        public string currentUser;

        private CodeGenerateUtil generateUtil;


        public Form_Cars(string username)
        {
            InitializeComponent();
            generateUtil = new CodeGenerateUtil();
            pictureBoxLoading.Location = new Point((this.Width - pictureBoxLoading.Width) / 2, (this.Height - pictureBoxLoading.Height) / 2);
            currentUser = username;
        }

        private void Form_Cars_Load(object sender, EventArgs e)
        {
            panelFull.Width = 0;
            comboCondition.SelectedIndexChanged += comboCondition_SelectedIndexChanged;
            // Store the original locations of the controls
            labelPriceOriginalLocation = labelPrice.Location;
            txtPriceOriginalLocation = txtPrice.Location;
            labelSpecOriginalLocation = labelSpec.Location;
            txtSpecificationOriginalLocation = txtSpecification.Location;

            tableCarView.Width = 1600;
            tableCarView.Height = 650;
            if (tableCarView.Parent is Panel parentPanel)
            {

                parentPanel.HorizontalScroll.Enabled = true;
                parentPanel.HorizontalScroll.Visible = true;
                parentPanel.VerticalScroll.Enabled = false;
                parentPanel.VerticalScroll.Visible = false;
            }

            tableCarView.CellClick += TableCarView_CellClick;

            LoadCarData();
        }

        private void LoadCarData(string searchTerm = "")
        {
            try
            {
                using (var dbContext = new ApplicationDBContext())
                {

                    var carQuery = dbContext.cars
                    .Where(u => u.Status == 1 && u.IsDeleted == 0);

                    if (!string.IsNullOrEmpty(searchTerm))
                    {
                        carQuery = carQuery.Where(u =>
                            u.CarModel.Contains(searchTerm) ||
                            u.ManufactureYear.Contains(searchTerm) ||
                            u.Color.Contains(searchTerm) ||
                            u.EngineType.Contains(searchTerm) ||
                            u.Transmission.Contains(searchTerm) ||
                            u.Mileage.Contains(searchTerm) ||
                            u.FuelType.Contains(searchTerm) ||
                            u.Condition.Contains(searchTerm));
                    }

                    var cars = carQuery.ToList();
                    var setImage = dbContext.defaultImage.FirstOrDefault();

                    // Create a DataTable to hold the car data
                    DataTable carTable = new DataTable();

                    // Add columns to the DataTable
                    carTable.Columns.Add("Id", typeof(string));
                    carTable.Columns.Add("Image", typeof(Image));
                    carTable.Columns.Add("CarModel", typeof(string));
                    carTable.Columns.Add("ManufactureYear", typeof(string));
                    carTable.Columns.Add("EngineType", typeof(string));
                    carTable.Columns.Add("FuelType", typeof(string));
                    carTable.Columns.Add("Condition", typeof(string));
                    carTable.Columns.Add("Color", typeof(string));
                    carTable.Columns.Add("Price", typeof(double));
                    carTable.Columns.Add("Transmission", typeof(string));
                    carTable.Columns.Add("Mileage", typeof(string));
                    carTable.Columns.Add("NoOfOwners", typeof(int));
                    carTable.Columns.Add("OwnerName", typeof(string));
                    carTable.Columns.Add("OwnerNic", typeof(string));
                    carTable.Columns.Add("OwnerContact", typeof(string));
                    carTable.Columns.Add("RegistrationDate", typeof(DateTime));
                    carTable.Columns.Add("Specification", typeof(string));
                    // Image column

                    foreach (var car in cars)
                    {
                        DataRow row = carTable.NewRow();
                        row["CarModel"] = car.CarModel;
                        row["Color"] = car.Color;
                        row["ManufactureYear"] = car.ManufactureYear;
                        row["EngineType"] = car.EngineType;
                        row["FuelType"] = car.FuelType;
                        row["Condition"] = car.Condition;
                        row["Price"] = car.Price;
                        row["Id"] = car.Id;
                        row["Transmission"] = car.Transmission;
                        row["Mileage"] = car.Mileage;
                        row["NoOfOwners"] = car.NoOfOwners;
                        row["OwnerName"] = car.OwnerName;
                        row["OwnerNic"] = car.OwnerNic;
                        row["OwnerContact"] = car.OwnerContact;
                        row["RegistrationDate"] = car.RegistrationDate;
                        row["Specification"] = car.Specification;

                        Image imageValue = null;
                        if (car.Image != null && car.Image.Length > 0)
                        {
                            imageValue = ByteArrayToImage(car.Image);
                        }
                        else
                        {
                            imageValue = ByteArrayToImage(setImage.Image);
                        }
                        row["Image"] = imageValue;

                        carTable.Rows.Add(row);
                    }

                    // Bind the DataTable to the DataGridView
                    tableCarView.DataSource = carTable;

                    if (!tableCarView.Columns.Contains("Edit"))
                    {
                        DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
                        editButtonColumn.Name = "Edit";
                        editButtonColumn.HeaderText = "Edit";
                        editButtonColumn.Text = "Edit";
                        editButtonColumn.UseColumnTextForButtonValue = true;
                        tableCarView.Columns.Add(editButtonColumn);
                    }

                    if (!tableCarView.Columns.Contains("Remove"))
                    {
                        DataGridViewButtonColumn removeButtonColumn = new DataGridViewButtonColumn();
                        removeButtonColumn.Name = "Remove";
                        removeButtonColumn.HeaderText = "Remove";
                        removeButtonColumn.Text = "Remove";
                        removeButtonColumn.UseColumnTextForButtonValue = true;
                        tableCarView.Columns.Add(removeButtonColumn);
                    }

                    // Configure the DataGridView (Optional)
                    ConfigureDataGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading car data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigureDataGridView()
        {
            tableCarView.AutoGenerateColumns = true;
            Padding cellPadding = new Padding(10, 5, 10, 5); // Left, Top, Right, Bottom
            tableCarView.RowTemplate.DefaultCellStyle.Padding = cellPadding;

            tableCarView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            tableCarView.ColumnHeadersHeight = 50;

            tableCarView.Columns["Image"].Width = 150;
            tableCarView.Columns["Image"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            tableCarView.Columns["Image"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tableCarView.Columns["Image"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tableCarView.Columns["CarModel"].Width = 300;
            tableCarView.Columns["CarModel"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            tableCarView.Columns["CarModel"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tableCarView.Columns["CarModel"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tableCarView.Columns["ManufactureYear"].Width = 150;
            tableCarView.Columns["ManufactureYear"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            tableCarView.Columns["ManufactureYear"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tableCarView.Columns["ManufactureYear"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tableCarView.Columns["EngineType"].Width = 150;
            tableCarView.Columns["EngineType"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            tableCarView.Columns["EngineType"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tableCarView.Columns["EngineType"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tableCarView.Columns["FuelType"].Width = 150;
            tableCarView.Columns["FuelType"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            tableCarView.Columns["FuelType"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tableCarView.Columns["FuelType"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tableCarView.Columns["Condition"].Width = 150;
            tableCarView.Columns["Condition"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            tableCarView.Columns["Condition"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tableCarView.Columns["Condition"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tableCarView.Columns["Color"].Width = 150;
            tableCarView.Columns["Color"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            tableCarView.Columns["Color"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tableCarView.Columns["Color"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tableCarView.Columns["Price"].Width = 100;
            tableCarView.Columns["Price"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            tableCarView.Columns["Price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tableCarView.Columns["Price"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;



            tableCarView.Columns["Id"].Visible = false;
            tableCarView.Columns["Transmission"].Visible = false;
            tableCarView.Columns["Mileage"].Visible = false;
            tableCarView.Columns["NoOfOwners"].Visible = false;
            tableCarView.Columns["OwnerName"].Visible = false;
            tableCarView.Columns["OwnerNic"].Visible = false;
            tableCarView.Columns["OwnerContact"].Visible = false;
            tableCarView.Columns["RegistrationDate"].Visible = false;
            tableCarView.Columns["Specification"].Visible = false;

            tableCarView.Columns["Image"].HeaderText = "Car Image";
            tableCarView.Columns["CarModel"].HeaderText = "Car Model";
            tableCarView.Columns["ManufactureYear"].HeaderText = "Manufacture Year";
            tableCarView.Columns["EngineType"].HeaderText = "Engine Type";
            tableCarView.Columns["FuelType"].HeaderText = "Fuel Type";
            tableCarView.Columns["Condition"].HeaderText = "Condition";
            tableCarView.Columns["Color"].HeaderText = "Color";
            tableCarView.Columns["Price"].HeaderText = "Selling Price";

            tableCarView.RowTemplate.Height = 75;

            tableCarView.CellFormatting += (sender, e) =>
            {
                if (e.ColumnIndex == tableCarView.Columns["Edit"].Index && e.RowIndex >= 0)
                {
                    DataGridViewButtonCell? buttonCell = tableCarView.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewButtonCell;
                    if (buttonCell != null)
                    {
                        tableCarView.Rows[e.RowIndex].Height = 70;
                        tableCarView.Columns[e.ColumnIndex].Width = 100;
                        tableCarView.Cursor = Cursors.Hand;
                    }
                }
                if (e.ColumnIndex == tableCarView.Columns["Remove"].Index && e.RowIndex >= 0)
                {
                    DataGridViewButtonCell? buttonCell = tableCarView.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewButtonCell;
                    if (buttonCell != null)
                    {
                        tableCarView.Rows[e.RowIndex].Height = 70;
                        tableCarView.Columns[e.ColumnIndex].Width = 100;
                        tableCarView.Cursor = Cursors.Hand;
                    }
                }
            };


            tableCarView.CellPainting += new DataGridViewCellPaintingEventHandler(tableCarView_CellPainting);

        }
        private void tableCarView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == tableCarView.Columns["Image"].Index && e.RowIndex >= 0)
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

        private void TableCarView_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            // Remove Button 
            if (e.ColumnIndex == tableCarView.Columns["Remove"].Index && e.RowIndex >= 0)
            {
                var result = MessageBox.Show("Are you sure you want to remove this car?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result != DialogResult.Yes) return;

                if (Guid.TryParse(tableCarView.Rows[e.RowIndex].Cells["Id"].Value.ToString(), out Guid carGuid))
                {
                    using (var dbContext = new ApplicationDBContext())
                    {
                        var car = dbContext.cars.SingleOrDefault(c => c.Id == carGuid);
                        var user = dbContext.users.SingleOrDefault(u => u.Username == currentUser);

                        if (car == null)
                        {
                            MessageBox.Show("Car not found in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        MessageBox.Show("Car successfully deleted in the database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        car.IsDeleted = 1;
                        car.DeletedDate = DateTime.Now;
                        car.DeletedBy = user.UserCode;
                        dbContext.cars.Update(car);
                        dbContext.SaveChanges();

                        LoadCarData();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid car ID format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Edit Button
            if (e.RowIndex >= 0 && e.ColumnIndex == tableCarView.Columns["Edit"].Index)
            {
                // Get the selected car's data from the DataGridView row
                DataGridViewRow selectedRow = tableCarView.Rows[e.RowIndex];

                // Assuming you have textboxes, combo boxes, etc., in the panel to fill with data
                txtCarModel.Text = selectedRow.Cells["CarModel"].Value.ToString();
                txtManufacture.Text = selectedRow.Cells["ManufactureYear"].Value.ToString();
                comboEngine.Text = selectedRow.Cells["EngineType"].Value.ToString();
                comboTransmission.Text = selectedRow.Cells["Transmission"].Value.ToString();
                comboFuel.Text = selectedRow.Cells["FuelType"].Value.ToString();
                comboCondition.Text = selectedRow.Cells["Condition"].Value.ToString();
                txtColor.Text = selectedRow.Cells["Color"].Value.ToString();
                txtPrice.Text = selectedRow.Cells["Price"].Value.ToString();
                txtMileage.Text = selectedRow.Cells["Mileage"].Value.ToString();
                txtOwners.Text = selectedRow.Cells["NoOfOwners"].Value.ToString();
                txtOwnerName.Text = selectedRow.Cells["OwnerName"].Value.ToString();
                txtNic.Text = selectedRow.Cells["OwnerNic"].Value.ToString();
                txtOwnerContact.Text = selectedRow.Cells["OwnerContact"].Value.ToString();
                txtSpecification.Text = selectedRow.Cells["Specification"].Value.ToString();
                dateRegistration.Text = selectedRow.Cells["RegistrationDate"].Value.ToString();

                // Display the image if needed
                if (selectedRow.Cells["Image"].Value != null)
                {
                    pictureBox.Image = (Image)selectedRow.Cells["Image"].Value;

                }


                // Optionally, store the car's ID in a hidden field or a variable for future reference
                hiddenCarId = selectedRow.Cells["Id"].Value.ToString();

                // Open or make visible the panel for editing
                isExpanding = true;
                TimerAdd.Start();
                TLPanelTop.Enabled = false;

                // Optionally change the button text to "Update" instead of "Add"
                btnCarSave.Visible = false;
                btnModify.Visible = true;
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                labelHead.Text = "Edit Car Details";
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            labelHead.Text = "Add New Car";
            isExpanding = true;
            TimerAdd.Start();
            TLPanelTop.Enabled = false;
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearForm();
            isExpanding = false;
            TimerAdd.Start();
            TLPanelTop.Enabled = true;
        }

        private void comboCondition_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboCondition.SelectedItem != null && comboCondition.SelectedItem.ToString() == "Brand New")
            {
                // Hide the controls
                txtOwners.Visible = false;
                txtOwnerName.Visible = false;
                txtOwnerContact.Visible = false;
                txtNic.Visible = false;
                dateRegistration.Visible = false;
                labelOwners.Visible = false;
                labelOwnerName.Visible = false;
                labelOwnerNic.Visible = false;
                labelOwnerContact.Visible = false;
                labelRegisterDate.Visible = false;
                labelPrice.Location = labelOwners.Location;
                txtPrice.Location = txtOwners.Location;
                labelSpec.Location = labelOwnerName.Location;
                txtSpecification.Location = txtOwnerName.Location;
            }
            else if (comboCondition.SelectedItem != null && comboCondition.SelectedItem.ToString() == "Used")
            {
                // Show the controls
                txtOwners.Visible = true;
                txtOwnerName.Visible = true;
                txtOwnerContact.Visible = true;
                txtNic.Visible = true;
                dateRegistration.Visible = true;
                labelOwners.Visible = true;
                labelOwnerName.Visible = true;
                labelOwnerNic.Visible = true;
                labelOwnerContact.Visible = true;
                labelRegisterDate.Visible = true;
                // Reset the Price and Specification controls to their original locations
                labelPrice.Location = labelPriceOriginalLocation;
                txtPrice.Location = txtPriceOriginalLocation;
                labelSpec.Location = labelSpecOriginalLocation;
                txtSpecification.Location = txtSpecificationOriginalLocation;
            }
            else
            {
                // Show the controls
                txtOwners.Visible = true;
                txtOwnerName.Visible = true;
                txtOwnerContact.Visible = true;
                txtNic.Visible = true;
                dateRegistration.Visible = true;
                labelOwners.Visible = true;
                labelOwnerName.Visible = true;
                labelOwnerNic.Visible = true;
                labelOwnerContact.Visible = true;
                labelRegisterDate.Visible = true;
            }
        }

        private void btnCarSave_Click(object sender, EventArgs e)
        {
            var carModel = txtCarModel.Text;
            var color = txtColor.Text;
            var manufactureYear = txtManufacture.Text;
            var engineType = comboEngine.Text;
            var transmission = comboTransmission.Text;
            var mileage = txtMileage.Text;
            var fuelType = comboFuel.Text;
            var condition = comboCondition.Text;
            var price = txtPrice.Text;
            var specification = txtSpecification.Text;
            string noOfOwners = null;
            string ownerName = null;
            string ownerNic = null;
            string ownerContact = null;
            DateTime registrationDateTime;
            if (condition != "Brand New")
            {
                registrationDateTime = DateTime.MinValue;
                noOfOwners = null;
                ownerName = null;
                ownerNic = null;
                ownerContact = null;
            }
            else
            {
                noOfOwners = txtOwners.Text;
                ownerName = txtOwnerName.Text;
                ownerNic = txtNic.Text;
                ownerContact = txtOwnerContact.Text;
                if (!DateTime.TryParse(dateRegistration.Text, out registrationDateTime))
                {
                    MessageBox.Show("Invalid registration date. Please enter a valid date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }


            try
            {
                using (var dbContext = new ApplicationDBContext())
                {
                    var carCode = generateUtil.GetNextCarCode();

                    if (string.IsNullOrWhiteSpace(carCode))
                    {
                        throw new Exception("Car code generation failed or returned an empty value.");
                    }
                    var car = new Car
                    {
                        CarModel = carModel,
                        Color = color,
                        ManufactureYear = manufactureYear,
                        EngineType = engineType,
                        Transmission = transmission,
                        Mileage = mileage,
                        FuelType = fuelType,
                        Condition = condition,
                        NoOfOwners = string.IsNullOrWhiteSpace(noOfOwners) ? 0 : int.Parse(noOfOwners),
                        OwnerName = ownerName ?? "Unknown",
                        OwnerNic = ownerNic ?? string.Empty,
                        OwnerContact = ownerContact ?? string.Empty,
                        RegistrationDate = registrationDateTime,
                        Price = double.Parse(price),
                        CarCode = carCode,
                        CreateDate = DateTime.Now,
                        Status = 1,
                        Specification = specification,
                        Image = CarImageToByteArray(pictureBox.Image)
                    };


                    dbContext.cars.Add(car);
                    dbContext.SaveChanges();
                    MessageBox.Show("Car Saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadCarData();
                    ClearForm();
                    isExpanding = false;
                    TimerAdd.Start();
                    TLPanelTop.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving car data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            txtCarModel.Clear();
            txtManufacture.Clear();
            txtColor.Clear();
            comboEngine.SelectedIndex = -1;
            comboEngine.Text = "- Choose One -";
            comboTransmission.SelectedIndex = -1;
            comboTransmission.Text = "- Choose One -";
            comboFuel.SelectedIndex = -1;
            comboFuel.Text = "- Choose One -";
            comboCondition.SelectedIndex = -1;
            comboCondition.Text = "- Choose One -";
            txtMileage.Clear();
            txtOwners.Clear();
            txtOwnerName.Clear();
            txtNic.Clear();
            txtOwnerContact.Clear();
            dateRegistration.Value = DateTime.Now;
            txtPrice.Clear();
            txtSpecification.Clear();
            pictureBox.Image = null; // Optionally, clear the picture box
        }

        private byte[] CarImageToByteArray(Image image)
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
        private Image ByteArrayToImage(byte[] byteArray)
        {
            using (var ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }

        private void PnlGrid_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            try
            {
                using (var dbContext = new ApplicationDBContext())
                {

                    // Update existing car
                    var carId = Guid.Parse(hiddenCarId); // Retrieve the car ID

                    var existingCar = dbContext.cars.Find(carId); // Adjust this to match your primary key

                    if (existingCar != null)
                    {
                        // Update car details
                        existingCar.CarModel = txtCarModel.Text;
                        existingCar.ManufactureYear = txtManufacture.Text;
                        existingCar.EngineType = comboCondition.Text;
                        existingCar.FuelType = comboFuel.Text;
                        existingCar.Condition = comboCondition.Text;
                        existingCar.Transmission = comboTransmission.Text;
                        existingCar.Mileage = txtMileage.Text;
                        existingCar.Color = txtColor.Text;
                        existingCar.NoOfOwners = int.Parse(txtOwners.Text);
                        existingCar.OwnerName = txtOwnerName.Text;
                        existingCar.OwnerNic = txtNic.Text;
                        existingCar.OwnerContact = txtOwnerContact.Text;
                        existingCar.Specification = txtSpecification.Text;
                        DateTime registrationDateTime;
                        if (!DateTime.TryParse(dateRegistration.Text, out registrationDateTime))
                        {
                            MessageBox.Show("Invalid registration date. Please enter a valid date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        existingCar.RegistrationDate = registrationDateTime;
                        existingCar.Price = double.Parse(txtPrice.Text);
                        existingCar.Image = CarImageToByteArray(pictureBox.Image);
                        existingCar.UpdateDate = DateTime.Now;

                        dbContext.SaveChanges();
                        MessageBox.Show("Car details updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Car not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    LoadCarData();
                    ClearForm();
                    isExpanding = false;
                    TimerAdd.Start();
                    TLPanelTop.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving car data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();
            tableCarView.Visible = false;
            pictureBoxLoading.Visible = true;

            try
            {
                await Task.Run(() =>
                {
                    Thread.Sleep(1000);
                    Invoke(new Action(() =>
                    {
                        LoadCarData(searchTerm);
                    }));
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            finally
            {
                pictureBoxLoading.Visible = false;
                tableCarView.Visible = true;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            ClearForm();
            LoadCarData();
        }
    }
}
