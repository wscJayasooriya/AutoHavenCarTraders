using CarTraders.Data;
using CarTraders.Helpers;
using CarTraders.Migrations;
using CarTraders.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CarTraders.Helpers.NotificationUtil;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace CarTraders
{
    public partial class Form_Orders : Form
    {
        public class CarPartDetails
        {
            public int Quantity { get; set; }
            public string PartName { get; set; }
            public string Value { get; set; }
            public string CarModel { get; set; }
            public decimal Price { get; set; }
            public Image PartImage { get; set; }
        }

        private Dictionary<Guid, CarPartDetails> cartItems = new Dictionary<Guid, CarPartDetails>();
        private List<CarParts> carParts = new List<CarParts>();
        private CodeGenerateUtil generateUtil;
        public string currentUser;
        public Form_Orders(string username)
        {
            InitializeComponent();
            loadPanel.AutoScroll = true;
            loadPanel.VerticalScroll.Enabled = false;
            loadPanel.VerticalScroll.Visible = false;
            loadPanel.HorizontalScroll.Visible = false;
            generateUtil = new CodeGenerateUtil();
            currentUser = username;


            btnPartClear.Click += BtnPartClear_Click;
        }

        private void Form_Orders_Load(object sender, EventArgs e)
        {
            btnCar_Click(sender, e);
        }

        private void btnCar_Click(object sender, EventArgs e)
        {
            carPartPanel.Controls.Clear();
            btnCar.BackColor = Color.FromArgb(33, 97, 140);
            btnCarParts.BackColor = Color.FromArgb(23, 32, 42);

            btnPartClear.Visible = false;
            btnPartPlaceOrder.Visible = false;
            carPartPanel.AutoScroll = false;
            using (var dbContext = new ApplicationDBContext())
            {

                var cars = dbContext.cars
                    .Where(c => c.Status == 1 && c.IsDeleted == 0)
                    .ToList();

                loadPanel.Controls.Clear();
                int yPos = 10;
                int xPos = 10;
                int cardWidth = 250;
                int cardHeight = 350;
                int padding = 15;
                foreach (var car in cars)
                {
                    // Create a Panel to act as the card
                    Panel card = new Panel();
                    card.Size = new Size(cardWidth, cardHeight);
                    card.Location = new Point(xPos, yPos);
                    card.BackColor = Color.FromArgb(236, 240, 241);


                    // Create PictureBox for the car image
                    PictureBox pictureBox = new PictureBox();
                    try
                    {
                        pictureBox.Image = ByteArrayToImage(car.Image);
                    }
                    catch (Exception ex)
                    {
                        NotificationUtil.ShowNotification(NotificationType.ERROR, "Image Load Error: " + $"Error loading image for {car.CarModel}: {ex.Message}");
                        pictureBox.Image = null;
                    }
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox.Size = new Size(cardWidth - 20, 160);
                    pictureBox.Location = new Point(10, 10);

                    // Create Label for the car model
                    Label labelCarModel = new Label();
                    labelCarModel.Text = car.CarModel;
                    labelCarModel.Location = new Point(10, 180);
                    labelCarModel.AutoSize = true;
                    labelCarModel.Font = new Font("Arial", 10, FontStyle.Bold);
                    labelCarModel.ForeColor = Color.Black;

                    // Create Label for the car price
                    Label labelPrice = new Label();
                    labelPrice.Text = "RS " + car.Price.ToString() + ".00";
                    // Assuming Price is a decimal type
                    labelPrice.Location = new Point(10, 210);
                    labelPrice.AutoSize = true;
                    labelPrice.Font = new Font("Arial", 10, FontStyle.Bold);
                    labelPrice.ForeColor = Color.Green;

                    // Create "View Details" Button
                    Button btnViewDetails = new Button();
                    btnViewDetails.Text = "View";
                    btnViewDetails.Size = new Size(100, 30);
                    btnViewDetails.Location = new Point(10, 250);
                    btnViewDetails.FlatStyle = FlatStyle.Flat;
                    btnViewDetails.BackColor = Color.FromArgb(52, 152, 219);
                    btnViewDetails.ForeColor = Color.White;
                    btnViewDetails.Font = new Font("Arial", 9, FontStyle.Bold);
                    btnViewDetails.Click += (s, args) =>
                    {
                        DisplayCarDetails(car);
                    };



                    // Create "Add to Cart" Button
                    Button btnAddToCart = new Button();
                    btnAddToCart.Text = "Buy";
                    btnAddToCart.Size = new Size(100, 30);
                    btnAddToCart.Location = new Point(140, 250);
                    btnAddToCart.FlatStyle = FlatStyle.Flat;
                    btnAddToCart.BackColor = Color.DarkOrange;
                    btnAddToCart.ForeColor = Color.White;
                    btnAddToCart.Font = new Font("Arial", 9, FontStyle.Bold);
                    btnAddToCart.Click += (s, args) =>
                    {
                        DisplayCarInCartPanel(car);
                    };
                    btnAddToCart.Visible = car.Status != 0;

                    Label labelStatus = new Label();
                    labelStatus.Text = car.Status == 0 ? "Sold Out" : "Available";
                    labelStatus.Location = new Point(10, 300);
                    labelStatus.AutoSize = true;
                    labelStatus.Font = new Font("Arial", 9, FontStyle.Bold);
                    labelStatus.ForeColor = car.Status == 0 ? Color.Red : Color.Green;

                    // Add controls to the card Panel
                    card.Controls.Add(pictureBox);
                    card.Controls.Add(labelCarModel);
                    card.Controls.Add(labelPrice);
                    card.Controls.Add(btnViewDetails);
                    card.Controls.Add(btnAddToCart);
                    card.Controls.Add(labelStatus);

                    // Add the card to loadPanel
                    loadPanel.Controls.Add(card);

                    // Update xPos for the next card, wrap to next line if necessary
                    xPos += cardWidth + padding;
                    if (xPos + cardWidth > loadPanel.Width)
                    {
                        xPos = 10;
                        yPos += cardHeight + padding;
                    }
                }
            }
        }

        private void DisplayCarDetails(Car car)
        {
            // Create a new form to display the car part details
            Form detailsForm = new Form();
            detailsForm.Size = new Size(550, 750);
            detailsForm.StartPosition = FormStartPosition.CenterParent;
            detailsForm.FormBorderStyle = FormBorderStyle.None;
            detailsForm.BackColor = Color.FromArgb(214, 234, 248);

            // Create a Panel to hold the details
            Panel detailsPanel = new Panel();
            detailsPanel.Size = new Size(500, 700);
            detailsPanel.Location = new Point(20, 20);
            detailsPanel.BorderStyle = BorderStyle.FixedSingle;

            // Create PictureBox for the car part image
            PictureBox pictureBox = new PictureBox();
            try
            {
                pictureBox.Image = ByteArrayToImage(car.Image);
            }
            catch (Exception ex)
            {
                NotificationUtil.ShowNotification(NotificationType.ERROR, "Image Load Error: " + $"Error loading image for {car.CarModel}: {ex.Message}");
                pictureBox.Image = null;
            }
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.Size = new Size(320, 200);
            pictureBox.Location = new Point(20, 20);

            // Initial Y position for labels
            int labelYPosition = 240;

            // Helper method to create and position labels dynamically
            Label CreateLabel(string text)
            {
                Label label = new Label();

                if (text.Contains("Specification"))
                {
                    label.Height = 40;
                }
                label.Text = text;
                label.Location = new Point(20, labelYPosition);
                label.AutoSize = true;
                label.Font = new Font("Arial", 11, FontStyle.Regular);
                label.ForeColor = Color.Black;

                // Update Y position for the next label
                labelYPosition += label.Height + 15;

                return label;
            }

            // Create and position labels
            Label labelCarModel = CreateLabel("Car Model: " + car.CarModel);
            Label labelManufactureYear = CreateLabel("Manufacture Year: " + car.ManufactureYear);
            Label labelColor = CreateLabel("Color: " + car.Color);
            Label labelEngine = CreateLabel("Color: " + car.EngineType);
            Label labelTransmission = CreateLabel("Color: " + car.Transmission);
            Label labelFuel = CreateLabel("Color: " + car.FuelType);
            Label labelCondition = CreateLabel("Condition: " + car.Condition);
            Label labelSpecification = CreateLabel("Specification: " + car.Specification);
            Label labelPrice = CreateLabel("Price: RS " + car.Price.ToString() + ".00");
            labelPrice.ForeColor = Color.Green;

            // Create a Close button
            Button closeButton = new Button();
            closeButton.Text = "Close";
            closeButton.Size = new Size(100, 40);
            closeButton.BackColor = Color.Red;
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.ForeColor = Color.White;
            closeButton.Location = new Point(350, labelYPosition + 20); // Position below the last label
            closeButton.Click += (sender, e) => { detailsForm.Close(); };

            // Add all controls to the panel
            detailsPanel.Controls.Add(pictureBox);
            detailsPanel.Controls.Add(labelCarModel);
            detailsPanel.Controls.Add(labelManufactureYear);
            detailsPanel.Controls.Add(labelColor);
            detailsPanel.Controls.Add(labelCondition);
            detailsPanel.Controls.Add(labelEngine);
            detailsPanel.Controls.Add(labelFuel);
            detailsPanel.Controls.Add(labelTransmission);
            detailsPanel.Controls.Add(labelSpecification);
            detailsPanel.Controls.Add(labelPrice);
            detailsPanel.Controls.Add(closeButton);

            // Add the panel to the form
            detailsForm.Controls.Add(detailsPanel);

            // Show the details form
            detailsForm.ShowDialog();
        }

        private void btnCarParts_Click(object sender, EventArgs e)
        {
            carPartPanel.Controls.Clear();
            btnCar.BackColor = Color.FromArgb(23, 32, 42);
            btnCarParts.BackColor = Color.FromArgb(33, 97, 140);
            btnPartClear.Visible = false;
            btnPartPlaceOrder.Visible = false;
            carPartPanel.AutoScroll = false;

            using (var dbContext = new ApplicationDBContext())
            {
                var carPartQuery = dbContext.carParts
                    .Where(cp => cp.Status == 1 && cp.Quantity > 0 && cp.IsDeleted == 0);
                var carPartsList = carPartQuery.ToList();
                carParts = carPartsList;

                loadPanel.Controls.Clear();
                int yPos = 10;
                int xPos = 10;
                int cardWidth = 250;
                int cardHeight = 350;
                int padding = 15;
                foreach (var part in carParts)
                {
                    Panel card = new Panel();
                    card.Size = new Size(cardWidth, cardHeight);
                    card.Location = new Point(xPos, yPos);
                    card.BackColor = Color.FromArgb(236, 240, 241);

                    PictureBox pictureBox = new PictureBox();
                    try
                    {
                        pictureBox.Image = ByteArrayToImage(part.Image);
                    }
                    catch (Exception ex)
                    {
                        NotificationUtil.ShowNotification(NotificationType.ERROR, "Image Load Error: " + $"Error loading image for {part.CarModel}: {ex.Message}");
                        pictureBox.Image = null;
                    }
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox.Size = new Size(cardWidth - 20, 160);
                    pictureBox.Location = new Point(10, 10);

                    // Create Label for the car part name
                    Label labelCarPartName = new Label();
                    labelCarPartName.Text = part.PartName;
                    labelCarPartName.Location = new Point(10, 180);
                    labelCarPartName.AutoSize = true;
                    labelCarPartName.Font = new Font("Arial", 10, FontStyle.Bold);
                    labelCarPartName.ForeColor = Color.Black;

                    // Create Label for the car part model
                    Label labelCarModel = new Label();
                    labelCarModel.Text = part.CarModel;
                    labelCarModel.Location = new Point(10, 210);
                    labelCarModel.AutoSize = true;
                    labelCarModel.Font = new Font("Arial", 8, FontStyle.Regular);
                    labelCarModel.ForeColor = Color.Black;

                    // Create Label for the car part price
                    Label labelPrice = new Label();
                    labelPrice.Text = "RS " + part.Price.ToString() + ".00";
                    // Assuming Price is a decimal type
                    labelPrice.Location = new Point(10, 240);
                    labelPrice.AutoSize = true;
                    labelPrice.Font = new Font("Arial", 10, FontStyle.Bold);
                    labelPrice.ForeColor = Color.Green;

                    // Create Label for the car part model
                    Label labelQty = new Label();
                    labelQty.Text = "Only " + part.Quantity.ToString() + " Left";
                    labelQty.Location = new Point(10, 270);
                    labelQty.AutoSize = true;
                    labelQty.Font = new Font("Arial", 8, FontStyle.Regular);
                    labelQty.ForeColor = Color.Black;

                    // Create "View Details" Button
                    Button btnViewDetails = new Button();
                    btnViewDetails.Text = "View";
                    btnViewDetails.Size = new Size(100, 30);
                    btnViewDetails.Location = new Point(10, 300);
                    btnViewDetails.BackColor = Color.FromArgb(52, 152, 219);
                    btnViewDetails.ForeColor = Color.White;
                    btnViewDetails.FlatStyle = FlatStyle.Flat;
                    btnViewDetails.Font = new Font("Arial", 9, FontStyle.Bold);
                    btnViewDetails.Click += (s, args) =>
                    {
                        DisplayCarPartDetails(part);
                    };

                    Button btnAddToCart = new Button();
                    btnAddToCart.Text = "Add Cart";
                    btnAddToCart.Size = new Size(100, 30);
                    btnAddToCart.Location = new Point(140, 300);
                    btnAddToCart.BackColor = Color.DarkOrange;
                    btnAddToCart.ForeColor = Color.White;
                    btnAddToCart.FlatStyle = FlatStyle.Flat;
                    btnAddToCart.Font = new Font("Arial", 9, FontStyle.Bold);
                    btnAddToCart.Click += (s, args) =>
                    {
                        DisplayCarPartInCartPanel(part);
                        btnAddToCart.Enabled = false;
                    };
                    btnPartClear.Click += (sender, e) =>
                    {
                        // Clear the cart panel
                        carPartPanel.Controls.Clear();

                        // Re-enable the Add to Cart button
                        btnAddToCart.Enabled = true;

                        // Hide the Clear and Place Order buttons
                        btnPartClear.Visible = false;
                        btnPartPlaceOrder.Visible = false;
                        carPartPanel.AutoScroll = false;
                    };

                    // Add controls to the card Panel
                    card.Controls.Add(pictureBox);
                    card.Controls.Add(labelCarPartName);
                    card.Controls.Add(labelCarModel);
                    card.Controls.Add(labelPrice);
                    card.Controls.Add(labelQty);
                    card.Controls.Add(btnViewDetails);
                    card.Controls.Add(btnAddToCart);

                    // Add the card to loadPanel
                    loadPanel.Controls.Add(card);

                    // Update xPos for the next card, wrap to next line if necessary
                    xPos += cardWidth + padding;
                    if (xPos + cardWidth > loadPanel.Width)
                    {
                        xPos = 10;
                        yPos += cardHeight + padding;
                    }
                }
            }
        }


        private void DisplayCarPartDetails(CarParts part)
        {
            // Create a new form to display the car part details
            Form detailsForm = new Form();
            detailsForm.Size = new Size(550, 700);
            detailsForm.StartPosition = FormStartPosition.CenterParent;
            detailsForm.FormBorderStyle = FormBorderStyle.None;
            detailsForm.BackColor = Color.FromArgb(214, 234, 248);

            // Create a Panel to hold the details
            Panel detailsPanel = new Panel();
            detailsPanel.Size = new Size(500, 650);
            detailsPanel.Location = new Point(20, 20);
            detailsPanel.BorderStyle = BorderStyle.FixedSingle;

            // Create PictureBox for the car part image
            PictureBox pictureBox = new PictureBox();
            try
            {
                pictureBox.Image = ByteArrayToImage(part.Image);
            }
            catch (Exception ex)
            {
                NotificationUtil.ShowNotification(NotificationType.ERROR, "Image Load Error: " + $"Error loading image for {part.CarModel}: {ex.Message}");
                pictureBox.Image = null;
            }
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.Size = new Size(320, 200);
            pictureBox.Location = new Point(20, 20);

            // Initial Y position for labels
            int labelYPosition = 240;

            // Helper method to create and position labels dynamically
            Label CreateLabel(string text)
            {
                Label label = new Label();

                if (text.Contains("Description"))
                {
                    label.Height = 40;
                }
                label.Text = text;
                label.Location = new Point(20, labelYPosition);
                label.AutoSize = true;
                label.Font = new Font("Arial", 11, FontStyle.Regular);
                label.ForeColor = Color.Black;

                // Update Y position for the next label
                labelYPosition += label.Height + 15;

                return label;
            }

            // Create and position labels
            Label labelPartName = CreateLabel("Part Name: " + part.PartName);
            Label labelCarModel = CreateLabel("Car Model: " + part.CarModel);
            Label labelManufacture = CreateLabel("Manufacture: " + part.Manufacture);
            Label labelColor = CreateLabel("Color: " + part.Color);
            Label labelCondition = CreateLabel("Condition: " + part.Condition);
            Label labelCategory = CreateLabel("Category: " + part.PartCategory);
            Label labelDescription = CreateLabel("Description: " + part.Description);
            Label labelPrice = CreateLabel("Price: LKR " + part.Price.ToString() + ".00");
            labelPrice.ForeColor = Color.Green;

            // Create a Close button
            Button closeButton = new Button();
            closeButton.Text = "Close";
            closeButton.Size = new Size(100, 40);
            closeButton.BackColor = Color.Red;
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.ForeColor = Color.White;
            closeButton.Location = new Point(350, labelYPosition + 20); // Position below the last label
            closeButton.Click += (sender, e) => { detailsForm.Close(); };

            // Add all controls to the panel
            detailsPanel.Controls.Add(pictureBox);
            detailsPanel.Controls.Add(labelPartName);
            detailsPanel.Controls.Add(labelCarModel);
            detailsPanel.Controls.Add(labelManufacture);
            detailsPanel.Controls.Add(labelColor);
            detailsPanel.Controls.Add(labelCondition);
            detailsPanel.Controls.Add(labelCategory);
            detailsPanel.Controls.Add(labelDescription);
            detailsPanel.Controls.Add(labelPrice);
            detailsPanel.Controls.Add(closeButton);

            // Add the panel to the form
            detailsForm.Controls.Add(detailsPanel);

            // Show the details form
            detailsForm.ShowDialog();
        }


        private void DisplayCarInCartPanel(Car car)
        {
            if (!cartItems.ContainsKey(car.Id))
            {
                cartItems.Add(car.Id, new CarPartDetails
                {
                    Quantity = 1,
                    CarModel = car.CarModel,
                    Price = (decimal)car.Price,
                    PartImage = ByteArrayToImage(car.Image),
                    Value = "car"  // Ensure this Value field is set correctly to identify it as a car
                });
            }


            btnPartPlaceOrder.Text = "Inquire Car";
            // Clear existing controls from the cartPanel
            carPartPanel.Controls.Clear();
            cartPanel.BorderStyle = BorderStyle.FixedSingle;
            // Create a PictureBox for the car image
            PictureBox pictureBox = new PictureBox();
            try
            {
                pictureBox.Image = ByteArrayToImage(car.Image);
            }
            catch (Exception ex)
            {
                NotificationUtil.ShowNotification(NotificationType.ERROR, "Image Load Error: " + $"Error loading image for {car.CarModel}: {ex.Message}");
                pictureBox.Image = null;
            }
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.Size = new Size(carPartPanel.Width - 20, 200);
            pictureBox.Location = new Point(10, 10);

            // Create Label for the car model
            Label labelCarModel = new Label();
            labelCarModel.Text = car.CarModel;
            labelCarModel.Location = new Point(10, 220);
            labelCarModel.AutoSize = true;
            labelCarModel.Font = new Font("Arial", 12, FontStyle.Bold);
            labelCarModel.ForeColor = Color.Black;

            // Create Label for the car manufacture
            Label labelManufacture = new Label();
            labelManufacture.Text = "Manufacture Year : " + car.ManufactureYear;
            labelManufacture.Location = new Point(10, 260);
            labelManufacture.AutoSize = true;
            labelManufacture.Font = new Font("Arial", 10, FontStyle.Regular);
            labelManufacture.ForeColor = Color.Black;

            // Create Label for the car color
            Label labelColor = new Label();
            labelColor.Text = "Color : " + car.Color;
            labelColor.Location = new Point(10, 300);
            labelColor.AutoSize = true;
            labelColor.Font = new Font("Arial", 10, FontStyle.Regular);
            labelColor.ForeColor = Color.Black;

            // Create Label for the car fuel type
            Label labelFuel = new Label();
            labelFuel.Text = "Fuel Type : " + car.FuelType;
            labelFuel.Location = new Point(10, 340);
            labelFuel.AutoSize = true;
            labelFuel.Font = new Font("Arial", 10, FontStyle.Regular);
            labelFuel.ForeColor = Color.Black;

            // Create Label for the car transmission
            Label labelTrans = new Label();
            labelTrans.Text = "Transmission : " + car.Transmission;
            labelTrans.Location = new Point(10, 380);
            labelTrans.AutoSize = true;
            labelTrans.Font = new Font("Arial", 10, FontStyle.Regular);
            labelTrans.ForeColor = Color.Black;

            // Create Label for the car price
            Label labelPrice = new Label();
            labelPrice.Text = "LKR " + car.Price.ToString() + ".00";
            labelPrice.Location = new Point(10, 420);
            labelPrice.AutoSize = true;
            labelPrice.Font = new Font("Arial", 14, FontStyle.Bold);
            labelPrice.ForeColor = Color.Green;

            // Add controls to the cartPartPanel
            carPartPanel.Controls.Add(pictureBox);
            carPartPanel.Controls.Add(labelCarModel);
            carPartPanel.Controls.Add(labelManufacture);
            carPartPanel.Controls.Add(labelColor);
            carPartPanel.Controls.Add(labelFuel);
            carPartPanel.Controls.Add(labelTrans);
            carPartPanel.Controls.Add(labelPrice);



            btnPartPlaceOrder.Visible = true;
            btnPartClear.Visible = true;

            btnPartClear.Click += BtnPartClear_Click;

        }

        private Image ByteArrayToImage(byte[] image)
        {
            using (var ms = new MemoryStream(image))
            {
                return Image.FromStream(ms);
            }
        }

        private void DisplayCarPartInCartPanel(CarParts part)
        {
            btnPartPlaceOrder.Text = "Place Order";
            cartPanel.BorderStyle = BorderStyle.FixedSingle;

            // Check if the item is already in the cart
            if (cartItems.ContainsKey(part.Id))
            {
                cartItems[part.Id].Quantity++;
            }
            else
            {
                cartItems.Add(part.Id, new CarPartDetails
                {
                    Quantity = 1,
                    PartName = part.PartName,
                    Price = (decimal)part.Price,
                    PartImage = ByteArrayToImage(part.Image),
                    Value = "part"
                });
            }

            // Clear the cart panel to refresh the display
            carPartPanel.Controls.Clear();

            // Calculate the total height for the cartPanel scroll
            int yPos = 10;
            foreach (var item in cartItems)
            {
                CarPartDetails cartPart = item.Value;

                // Create a new panel for the item
                Panel itemPanel = new Panel
                {
                    Size = new Size(carPartPanel.Width - 20, 150),
                    BorderStyle = BorderStyle.FixedSingle,
                    Location = new Point(10, yPos)
                };

                // Create PictureBox for the car part image
                PictureBox pictureBox = new PictureBox();

                pictureBox.Image = cartPart.PartImage;
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Size = new Size(100, 100);
                pictureBox.Location = new Point(10, 10);

                // Create Label for the car part name
                Label labelPartName = new Label
                {
                    Text = cartPart.PartName,
                    Location = new Point(120, 10),
                    AutoSize = true,
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    ForeColor = Color.Black
                };

                // Create Label for the car price
                Label labelPrice = new Label
                {
                    Text = "RS " + cartPart.Price.ToString() + ".00",
                    Location = new Point(120, 40),
                    AutoSize = true,
                    Font = new Font("Arial", 10, FontStyle.Regular),
                    ForeColor = Color.Black
                };

                // Create the "Decrease" button
                Button btnDecrease = new Button
                {
                    Text = "-",
                    Location = new Point(120, 70),
                    Size = new Size(40, 40),
                    Font = new Font("Arial", 12, FontStyle.Bold),
                    BackColor = Color.FromArgb(52, 73, 94),
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat
                };

                // Create a TextBox for the quantity, placed between the buttons
                Button txtQuantity = new Button
                {
                    Text = cartPart.Quantity.ToString(),
                    Location = new Point(180, 70), // Positioned between btnDecrease and btnIncrease
                    Size = new Size(40, 40),
                    Font = new Font("Arial", 10, FontStyle.Regular),
                    Enabled = false

                };

                // Create the "Increase" button
                Button btnIncrease = new Button
                {
                    Text = "+",
                    Location = new Point(240, 70),
                    Size = new Size(40, 40),
                    Font = new Font("Arial", 12, FontStyle.Bold),
                    BackColor = Color.FromArgb(52, 73, 94),
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat
                };

                btnIncrease.Click += (s, args) =>
                {
                    int currentQuantity;
                    if (int.TryParse(txtQuantity.Text, out currentQuantity))
                    {
                        if (currentQuantity < part.Quantity) // Assuming 99 is the max quantity
                        {
                            currentQuantity++;
                            txtQuantity.Text = currentQuantity.ToString();
                            cartItems[item.Key].Quantity = currentQuantity;
                        }
                    }
                };
                btnDecrease.Click += (s, args) =>
                {
                    int currentQuantity;
                    if (int.TryParse(txtQuantity.Text, out currentQuantity))
                    {
                        if (currentQuantity > 1) // Ensure quantity doesn't go below 1
                        {
                            currentQuantity--;
                            txtQuantity.Text = currentQuantity.ToString();
                            cartItems[item.Key].Quantity = currentQuantity;
                        }
                    }
                };

                // Add controls to the item panel
                itemPanel.Controls.Add(pictureBox);
                itemPanel.Controls.Add(labelPartName);
                itemPanel.Controls.Add(labelPrice);
                itemPanel.Controls.Add(txtQuantity);
                itemPanel.Controls.Add(btnIncrease);
                itemPanel.Controls.Add(btnDecrease);

                // Add the item panel to the cartPanel
                carPartPanel.Controls.Add(itemPanel);

                // Update yPos for the next item
                yPos += itemPanel.Height + 10;

                // Disable the Add Cart button if quantity reaches the available stock
                if (cartPart.Quantity >= cartPart.Quantity)
                {
                    Button btnAddToCart = new Button
                    {
                        Text = "Add Cart",
                        Size = new Size(100, 30),
                        Location = new Point(140, 300),
                        BackColor = Color.DarkOrange,
                        ForeColor = Color.White,
                        FlatStyle = FlatStyle.Flat,
                        Font = new Font("Arial", 9, FontStyle.Bold),
                        Enabled = false // Disable button
                    };
                }
            }

            // Adjust cartPanel size and enable horizontal scrolling
            carPartPanel.AutoScroll = true;
            carPartPanel.AutoScrollMinSize = new Size(carPartPanel.Width, yPos + 10);
            carPartPanel.HorizontalScroll.Enabled = true;
            carPartPanel.HorizontalScroll.Visible = true;

            btnPartClear.Click += BtnPartClear_Click;

            // Set the visibility of buttons
            btnPartClear.Visible = true;
            btnPartPlaceOrder.Visible = true;
        }

        private void BtnPartClear_Click(object? sender, EventArgs e)
        {
            carPartPanel.Controls.Clear();
            cartItems.Clear();
            btnPartClear.Visible = false;
            btnPartPlaceOrder.Visible = false;
            carPartPanel.AutoScroll = false;
        }

        private void btnPartPlaceOrder_Click(object sender, EventArgs e)
        {
            Form_Checkout form_Checkout = new Form_Checkout(currentUser, cartItems);
            form_Checkout.Show();
        }

    }


}
