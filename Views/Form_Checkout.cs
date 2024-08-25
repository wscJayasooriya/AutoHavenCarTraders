using CarTraders.Data;
using CarTraders.Helpers;
using CarTraders.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static CarTraders.Form_Orders;

namespace CarTraders
{
    public partial class Form_Checkout : Form
    {
        public string currentUser;
        public string userCode;
        private Dictionary<Guid, CarPartDetails> cartItems;
        private CodeGenerateUtil generateUtil;
        public Form_Checkout(string username, Dictionary<Guid, CarPartDetails> items)
        {
            InitializeComponent();
            currentUser = username;
            cartItems = items;
            generateUtil = new CodeGenerateUtil();
            this.Load += Form_Checkout_Load;
            pictureBoxLoading.Location = new Point((this.Width - pictureBoxLoading.Width) / 2, (this.Height - pictureBoxLoading.Height) / 2);
        }

        private void Form_Checkout_Load(object sender, EventArgs e)
        {
            LoadCartItems();
            using (var dbContext = new ApplicationDBContext())
            {
                var user = dbContext.users.FirstOrDefault(u => u.Username == currentUser);
                userCode = user.UserCode;
                if (user != null)
                {
                    // Populate form fields with user data
                    textEmail.Text = user.Email;
                    textName.Text = user.FirstName + " " + user.LastName;
                    textAddress.Text = user.Address;
                    textContact.Text = user.ContactNo;
                    textCity.Text = user.City;
                    textNIC.Text = user.Nic;
                    // Set other fields as needed
                }
                else
                {
                    MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadCartItems()
        {
            DataTable carPartsTable = new DataTable();
            carPartsTable.Columns.Add("Image", typeof(Image));
            carPartsTable.Columns.Add("Name", typeof(string));
            carPartsTable.Columns.Add("Quantity", typeof(int));
            carPartsTable.Columns.Add("Price", typeof(double));

            foreach (var item in cartItems)
            {
                var partDetails = item.Value;

                DataRow row = carPartsTable.NewRow();
                row["Image"] = partDetails.PartImage;
                row["Name"] = partDetails.PartName;
                row["Quantity"] = partDetails.Quantity;
                row["Price"] = partDetails.Price;

                carPartsTable.Rows.Add(row);


            }
            dataView.DataSource = carPartsTable;

            ConfigureDataGridView();
            SetupRowSelection();

        }

        private void ConfigureDataGridView()
        {
            dataView.RowTemplate.Height = 100;
            dataView.DefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Regular);
            dataView.Width = orderPanel.Width;
            dataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            if (dataView.Columns["Image"] != null)
            {
                ((DataGridViewImageColumn)dataView.Columns["Image"]).ImageLayout = DataGridViewImageCellLayout.Stretch;
            }

            dataView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataView.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);

            dataView.Columns["Image"].HeaderText = "Image";
            dataView.Columns["Name"].HeaderText = "Name";
            dataView.Columns["Quantity"].HeaderText = "Qty";
            dataView.Columns["Price"].HeaderText = "Price (Rs)";

            dataView.Columns["Image"].Width = 100;
            dataView.Columns["Name"].Width = 250;
            dataView.Columns["Quantity"].Width = 50;
            dataView.Columns["Price"].Width = 100;

            dataView.Columns["Image"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataView.Columns["Name"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataView.Columns["Price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataView.Columns["Quantity"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            orderPanel.AutoScroll = false;
        }

        private void SetupRowSelection()
        {
            dataView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataView.SelectionChanged += (sender, e) => dataView.ClearSelection();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (cartItems.Count == 0)
            {
                MessageBox.Show("Your cart is empty. Please add items to your cart before placing an order.", "Cart Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.Controls.Add(pictureBoxLoading);
            pictureBoxLoading.Dock = DockStyle.Fill;
            pictureBoxLoading.BringToFront();
            pictureBoxLoading.Visible = true;
            pictureBoxLoading.BackColor = Color.FromArgb(235, 222, 240);

            using (var dbContext = new ApplicationDBContext())
            {
                var orderCode = generateUtil.GenerateOrderCode();

                // Create a new OrderDetails object
                var orderDetail = new OrderDetails
                {
                    Id = Guid.NewGuid(),
                    OrderCode = orderCode,
                    CustomerCode = userCode,
                    OrderStatus = "Pending",
                    IsPayment = 0,
                    IsApproved = 0,
                    IsDelivered = 0,
                    Is_active = 1,
                    OrderDate = DateTime.Now,
                    DeliveredDate = DateTime.Now.AddDays(5),
                    ApprovedBy = "Not Approved"
                };

                double grossAmount = 0.0;

                foreach (var item in cartItems)
                {
                    var partDetails = item.Value;
                    var carPart = dbContext.carParts.First(cp => cp.Id == item.Key);

                    // Create a new OrderItemDetails object
                    var orderItemDetail = new OrderItemDetails
                    {
                        Id = Guid.NewGuid(),
                        OrderCode = orderCode,
                        ItemCode = carPart.CarPartCode,
                        ItemName = carPart.PartName,
                        Price = carPart.Price,
                        Quantity = partDetails.Quantity,
                        TotalAmount = carPart.Price * partDetails.Quantity,
                        OrderDate = DateTime.Now
                    };

                    // Calculate the gross amount for the order
                    grossAmount += orderItemDetail.TotalAmount;

                    // Add the OrderItemDetails object to the OrderDetails
                    orderDetail.ItemDetails.Add(orderItemDetail);

                    // Update car part stock
                    carPart.Quantity -= partDetails.Quantity;
                    dbContext.carParts.Update(carPart);
                }
                orderDetail.GrossAmount = grossAmount;

                dbContext.orderDetails.Add(orderDetail);

                // Save all the changes to the database
                dbContext.SaveChanges();
            }

            try
            {
                await Task.Delay(5000);
                Invoke(new Action(() =>
                {
                    cartItems.Clear();
                    orderPanel.Controls.Clear();
                    var result = MessageBox.Show("Order placed successfully!", "Order Placed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                        this.Hide();
                    }
                }));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            finally
            {
                pictureBoxLoading.Visible = false;
                pictureBoxLoading.Dock = DockStyle.None;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit this form?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
            }
        }


    }
}
