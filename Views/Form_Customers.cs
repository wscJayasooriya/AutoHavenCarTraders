using CarTraders.Data;
using CarTraders.Helpers;
using CarTraders.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarTraders
{
    public partial class Form_Customers : Form
    {
        private ValidatorUtil validatorUtil;
        private CodeGenerateUtil generateUtil;
        private bool isExpanding = true;
        private string hiddenUserId;

        private Point labelContactOriginalLocation;
        private Point txtContactOriginalLocation;
        private Point labelCityOriginalLocation;
        private Point txtCityOriginalLocation;
        private Point labelNicOriginalLocation;
        private Point txtNicOriginalLocation;
        private Point labelAddressOriginalLocation;
        private Point txtAddressOriginalLocation;
        public Form_Customers()
        {
            InitializeComponent();
            validatorUtil = new ValidatorUtil();
            generateUtil = new CodeGenerateUtil();
            pictureBoxLoading.Location = new Point((this.Width - pictureBoxLoading.Width) / 2, (this.Height - pictureBoxLoading.Height) / 2);
        }

        private void Form_Customers_Load(object sender, EventArgs e)
        {
            panelFull.Width = 0;

            labelContactOriginalLocation = labelContact.Location;
            txtContactOriginalLocation = txtContactNo.Location;
            labelCityOriginalLocation = labelCity.Location;
            txtCityOriginalLocation = txtCity.Location;
            labelNicOriginalLocation = labelNic.Location;
            txtNicOriginalLocation = txtNic.Location;
            labelAddressOriginalLocation = labelAddress.Location;
            txtAddressOriginalLocation = txtAddress.Location;

            tableCustomerView.Width = 1600;
            tableCustomerView.Height = 650;
            if (tableCustomerView.Parent is Panel parentPanel)
            {

                parentPanel.HorizontalScroll.Enabled = true;
                parentPanel.HorizontalScroll.Visible = true;
                parentPanel.VerticalScroll.Enabled = false;
                parentPanel.VerticalScroll.Visible = false;
            }

            tableCustomerView.CellClick += TableCustomerView_CellClick;

            LoadUserData();
        }

        private void TableCustomerView_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            // Remove Button 
            if (e.ColumnIndex == tableCustomerView.Columns["Remove"].Index && e.RowIndex >= 0)
            {
                var result = MessageBox.Show("Are you sure you want to remove this customer?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result != DialogResult.Yes) return;

                if (Guid.TryParse(tableCustomerView.Rows[e.RowIndex].Cells["Id"].Value.ToString(), out Guid userGuid))
                {
                    using (var dbContext = new ApplicationDBContext())
                    {
                        var user = dbContext.users.SingleOrDefault(c => c.Id == userGuid);

                        if (user == null)
                        {
                            MessageBox.Show("User not found in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        MessageBox.Show("User successfully deleted in the database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dbContext.users.Remove(user);
                        dbContext.SaveChanges();

                        LoadUserData();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid User ID format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Edit Button
            if (e.RowIndex >= 0 && e.ColumnIndex == tableCustomerView.Columns["Edit"].Index)
            {
                txtPassword.Visible = false;
                txtRePassword.Visible = false;
                labelPassowrd.Visible = false;
                labelRePassword.Visible = false;
                labelContact.Location = labelPassowrd.Location;
                txtContactNo.Location = txtPassword.Location;
                labelCity.Location = labelRePassword.Location;
                txtCity.Location = txtRePassword.Location;
                labelNic.Location = labelContactOriginalLocation;
                txtNic.Location = txtContactOriginalLocation;
                labelAddress.Location = labelCityOriginalLocation;
                txtAddress.Location = txtCityOriginalLocation;
                // Get the selected car's data from the DataGridView row
                DataGridViewRow selectedRow = tableCustomerView.Rows[e.RowIndex];

                // Assuming you have textboxes, combo boxes, etc., in the panel to fill with data
                txtFirstName.Text = selectedRow.Cells["FirstName"].Value.ToString();
                txtLastName.Text = selectedRow.Cells["LastName"].Value.ToString();
                txtEmail.Text = selectedRow.Cells["Email"].Value.ToString();
                txtUsername.Text = selectedRow.Cells["Username"].Value.ToString();
                txtContactNo.Text = selectedRow.Cells["ContactNo"].Value.ToString();
                txtCity.Text = selectedRow.Cells["City"].Value.ToString();
                txtNic.Text = selectedRow.Cells["Nic"].Value.ToString();
                txtAddress.Text = selectedRow.Cells["Address"].Value.ToString();

                // Display the image if needed
                if (selectedRow.Cells["Image"].Value != null)
                {
                    pictureBox.Image = (Image)selectedRow.Cells["Image"].Value;

                }


                // Optionally, store the car's ID in a hidden field or a variable for future reference
                hiddenUserId = selectedRow.Cells["Id"].Value.ToString();

                // Open or make visible the panel for editing
                isExpanding = true;
                TimerAdd.Start();
                TLPanelTop.Enabled = false;

                // Optionally change the button text to "Update" instead of "Add"
                btnCarSave.Visible = false;
                btnModify.Visible = true;
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                labelHead.Text = "Edit Customer Details";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            labelHead.Text = "Add New Customer";
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

        private void buttonChooseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox.ImageLocation = openFileDialog.FileName;
            }
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

        private void btnCarSave_Click(object sender, EventArgs e)
        {
            var firstName = txtFirstName.Text;
            var lastName = txtLastName.Text;
            var email = txtEmail.Text;
            var username = txtUsername.Text;
            var password = txtPassword.Text;
            var rePassword = txtRePassword.Text;
            var address = txtAddress.Text;
            var contactNo = txtContactNo.Text;
            var city = txtCity.Text;
            var nic = txtNic.Text;

            if (!validatorUtil.ValidatePassword(password))
            {
                MessageBox.Show("Password must be at least 8 characters long and include uppercase, lowercase, numbers, and symbols.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.BackColor = Color.FromArgb(205, 97, 85);
                txtRePassword.BackColor = Color.FromArgb(205, 97, 85);
                return;
            }
            if (password != rePassword)
            {
                MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (var dbContext = new ApplicationDBContext())
                {
                    var userRole = "Customer_Role";
                    var userCode = generateUtil.GetNextUserCode(userRole);
                    var user = new Users
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        UserRole = userRole,
                        Email = email,
                        Username = username,
                        UserCode = userCode,
                        ContactNo = contactNo,
                        City = city,
                        Nic = nic,
                        Address = address,
                        Password = HashPassword(password),
                        Status = 1,
                        CreateDate = DateTime.Now,
                        Image = UserImageToByteArray(pictureBox.Image)
                    };

                    dbContext.users.Add(user);
                    dbContext.SaveChanges();
                    MessageBox.Show("Customer Saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadUserData();
                    ClearForm();
                    isExpanding = false;
                    TimerAdd.Start();
                    TLPanelTop.Enabled = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving customer data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                // Convert byte array to a string
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private byte[] UserImageToByteArray(Image image)
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

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            txtUsername.Text = txtEmail.Text;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            try
            {
                using (var dbContext = new ApplicationDBContext())
                {
                    var userId = Guid.Parse(hiddenUserId); // Retrieve the user ID

                    var existingUser = dbContext.users.Find(userId);
                    if (existingUser != null)
                    {
                        // Update user details
                        existingUser.FirstName = txtFirstName.Text;
                        existingUser.LastName = txtLastName.Text;
                        existingUser.UserRole = "Customer_Role";
                        existingUser.Email = txtEmail.Text;
                        existingUser.Username = txtUsername.Text;
                        existingUser.ContactNo = txtContactNo.Text;
                        existingUser.City = txtCity.Text;
                        existingUser.Nic = txtNic.Text;
                        existingUser.Address = txtAddress.Text;
                        existingUser.Status = 1;
                        existingUser.UpdateDate = DateTime.Now;
                        existingUser.Image = UserImageToByteArray(pictureBox.Image);

                        dbContext.SaveChanges();
                        MessageBox.Show("Customer details updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Customer not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    LoadUserData();
                    ClearForm();
                    isExpanding = false;
                    TimerAdd.Start();
                    TLPanelTop.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while modifying customer data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadUserData(string searchTerm = "")
        {
            try
            {
                using (var dbContext = new ApplicationDBContext())
                {
                    var usersQuery = dbContext.users
                   .Where(u => u.UserRole == "Customer_Role" && u.Status == 1);

                    if (!string.IsNullOrEmpty(searchTerm))
                    {
                        usersQuery = usersQuery.Where(u =>
                            u.FirstName.Contains(searchTerm) ||
                            u.LastName.Contains(searchTerm) ||
                            u.Email.Contains(searchTerm) ||
                            u.Username.Contains(searchTerm) ||
                            u.ContactNo.Contains(searchTerm) ||
                            u.City.Contains(searchTerm) ||
                            u.Nic.Contains(searchTerm) ||
                            u.Address.Contains(searchTerm));
                    }

                    var users = usersQuery.ToList();
                    var setImage = dbContext.defaultImage.FirstOrDefault();

                    DataTable customerTable = new DataTable();

                    customerTable.Columns.Add("Id", typeof(string));
                    customerTable.Columns.Add("Image", typeof(Image));
                    customerTable.Columns.Add("FirstName", typeof(string));
                    customerTable.Columns.Add("LastName", typeof(string));
                    customerTable.Columns.Add("UserRole", typeof(string));
                    customerTable.Columns.Add("Email", typeof(string));
                    customerTable.Columns.Add("Username", typeof(string));
                    customerTable.Columns.Add("ContactNo", typeof(string));
                    customerTable.Columns.Add("City", typeof(string));
                    customerTable.Columns.Add("Nic", typeof(string));
                    customerTable.Columns.Add("Address", typeof(string));
                    customerTable.Columns.Add("Password", typeof(string));
                    customerTable.Columns.Add("Department", typeof(string));
                    customerTable.Columns.Add("CreateDate", typeof(DateTime));
                    customerTable.Columns.Add("Status", typeof(int));
                    customerTable.Columns.Add("UpdateDate", typeof(DateTime));

                    foreach (var user in users)
                    {
                        DataRow row = customerTable.NewRow();
                        row["Id"] = user.Id;
                        row["FirstName"] = user.FirstName;
                        row["LastName"] = user.LastName;
                        row["UserRole"] = user.UserRole;
                        row["Email"] = user.Email;
                        row["Username"] = user.Username;
                        row["ContactNo"] = user.ContactNo;
                        row["City"] = user.City;
                        row["Nic"] = user.Nic;
                        row["Address"] = user.Address;
                        row["Password"] = user.Password;
                        row["Department"] = user.Department;
                        row["CreateDate"] = user.CreateDate;
                        row["Status"] = user.Status;
                        row["UpdateDate"] = user.UpdateDate;

                        Image imageValue = null;
                        if (user.Image != null && user.Image.Length > 0)
                        {
                            imageValue = ByteArrayToImage(user.Image);
                        }
                        else
                        {
                            imageValue = ByteArrayToImage(setImage.Image);
                        }
                        row["Image"] = imageValue;

                        customerTable.Rows.Add(row);
                    }
                    // Bind the DataTable to the DataGridView
                    tableCustomerView.DataSource = customerTable;

                    if (!tableCustomerView.Columns.Contains("Edit"))
                    {
                        DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
                        editButtonColumn.Name = "Edit";
                        editButtonColumn.HeaderText = "Edit";
                        editButtonColumn.Text = "Edit";
                        editButtonColumn.UseColumnTextForButtonValue = true;
                        tableCustomerView.Columns.Add(editButtonColumn);
                    }

                    if (!tableCustomerView.Columns.Contains("Remove"))
                    {
                        DataGridViewButtonColumn removeButtonColumn = new DataGridViewButtonColumn();
                        removeButtonColumn.Name = "Remove";
                        removeButtonColumn.HeaderText = "Remove";
                        removeButtonColumn.Text = "Remove";
                        removeButtonColumn.UseColumnTextForButtonValue = true;
                        tableCustomerView.Columns.Add(removeButtonColumn);
                    }
                    ConfigureDataGridView();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading customer data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigureDataGridView()
        {
            tableCustomerView.AutoGenerateColumns = true;
            Padding cellPadding = new Padding(10, 5, 10, 5); // Left, Top, Right, Bottom
            tableCustomerView.RowTemplate.DefaultCellStyle.Padding = cellPadding;

            tableCustomerView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            tableCustomerView.ColumnHeadersHeight = 50;

            tableCustomerView.Columns["FirstName"].Width = 200;
            tableCustomerView.Columns["FirstName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            tableCustomerView.Columns["FirstName"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tableCustomerView.Columns["FirstName"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tableCustomerView.Columns["LastName"].Width = 200;
            tableCustomerView.Columns["LastName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            tableCustomerView.Columns["LastName"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tableCustomerView.Columns["LastName"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tableCustomerView.Columns["Email"].Width = 250;
            tableCustomerView.Columns["Email"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            tableCustomerView.Columns["Email"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tableCustomerView.Columns["Email"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tableCustomerView.Columns["ContactNo"].Width = 200;
            tableCustomerView.Columns["ContactNo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            tableCustomerView.Columns["ContactNo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tableCustomerView.Columns["ContactNo"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tableCustomerView.Columns["City"].Width = 200;
            tableCustomerView.Columns["City"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            tableCustomerView.Columns["City"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tableCustomerView.Columns["City"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tableCustomerView.Columns["Nic"].Width = 200;
            tableCustomerView.Columns["Nic"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            tableCustomerView.Columns["Nic"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tableCustomerView.Columns["Nic"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            tableCustomerView.Columns["Id"].Visible = false;
            tableCustomerView.Columns["Image"].Visible = false;
            tableCustomerView.Columns["UserRole"].Visible = false;
            tableCustomerView.Columns["Username"].Visible = false;
            tableCustomerView.Columns["Address"].Visible = false;
            tableCustomerView.Columns["Password"].Visible = false;
            tableCustomerView.Columns["CreateDate"].Visible = false;
            tableCustomerView.Columns["Status"].Visible = false;
            tableCustomerView.Columns["UpdateDate"].Visible = false;
            tableCustomerView.Columns["Department"].Visible = false;

            tableCustomerView.Columns["FirstName"].HeaderText = "First Name";
            tableCustomerView.Columns["LastName"].HeaderText = "Last Name";
            tableCustomerView.Columns["Email"].HeaderText = "Email";
            tableCustomerView.Columns["ContactNo"].HeaderText = "Contact No";
            tableCustomerView.Columns["City"].HeaderText = "City";
            tableCustomerView.Columns["Nic"].HeaderText = "Nic";

            tableCustomerView.RowTemplate.Height = 75;
            tableCustomerView.CellFormatting += (sender, e) =>
            {
                if (e.ColumnIndex == tableCustomerView.Columns["Edit"].Index && e.RowIndex >= 0)
                {
                    DataGridViewButtonCell? buttonCell = tableCustomerView.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewButtonCell;
                    if (buttonCell != null)
                    {
                        tableCustomerView.Rows[e.RowIndex].Height = 70;
                        tableCustomerView.Columns[e.ColumnIndex].Width = 100;
                        tableCustomerView.Cursor = Cursors.Hand;
                    }
                }
                if (e.ColumnIndex == tableCustomerView.Columns["Remove"].Index && e.RowIndex >= 0)
                {
                    DataGridViewButtonCell? buttonCell = tableCustomerView.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewButtonCell;
                    if (buttonCell != null)
                    {
                        tableCustomerView.Rows[e.RowIndex].Height = 70;
                        tableCustomerView.Columns[e.ColumnIndex].Width = 100;
                        tableCustomerView.Cursor = Cursors.Hand;
                    }
                }
            };
        }

        private Image ByteArrayToImage(byte[] byteArray)
        {
            using (var ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }

        private void ClearForm()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            txtRePassword.Clear();
            txtContactNo.Clear();
            txtCity.Clear();
            txtNic.Clear();
            txtAddress.Clear();
            pictureBox.Image = null; // Optionally, clear the picture box
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            ClearForm();
            LoadUserData();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();
            tableCustomerView.Visible = false;
            pictureBoxLoading.Visible = true;

            try
            {
                await Task.Run(() =>
                {
                    Thread.Sleep(1000);
                    Invoke(new Action(() =>
                    {
                        LoadUserData(searchTerm);
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
                tableCustomerView.Visible = true;
            }
        }
    }
}
