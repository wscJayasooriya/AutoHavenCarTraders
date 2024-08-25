using CarTraders.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarTraders.Views
{
    public partial class Form_View_Order : Form
    {
        public Form_View_Order(string orderCode)
        {
            InitializeComponent();
            panelOrderMain.AutoScroll = true;

            using (var dbContext = new ApplicationDBContext())
            {
                var orderDetails = dbContext.orderDetails.FirstOrDefault(o => o.OrderCode == orderCode);
                var itemDetails = dbContext.orderItemDetails.Where(i => i.OrderCode == orderCode).ToList();

                if (orderDetails == null)
                {
                    MessageBox.Show("Order details not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                txtInvoiceNo.Text = orderDetails.OrderCode;
                txtInvoiceDate.Text = orderDetails.OrderDate.ToString();
                txtCustomer.Text = orderDetails.CustomerCode;
                txtGrossAmount.Text = orderDetails.GrossAmount.ToString() + ".00";

                int yPos = 30;
                // Adding item details labels
                foreach (var item in itemDetails)
                {
                    Panel panelLine = new Panel
                    {
                        Size = new Size(panelOrderMain.Width - 20, 100), // Set the size of the panel
                        Location = new Point(5, yPos), // Set the location
                        BorderStyle = BorderStyle.FixedSingle
                    };
                    PictureBox pictureBox = new PictureBox
                    {
                        Size = new Size(90, 90), // Set size of picture box
                        Location = new Point(5, 5), // Set location to top-left corner of the panel
                        BorderStyle = BorderStyle.FixedSingle,
                        SizeMode = PictureBoxSizeMode.StretchImage
                    };
                    dynamic carPart;
                    if (item.ItemCode.StartsWith("CP"))
                    {
                        carPart = dbContext.carParts.FirstOrDefault(c => c.CarPartCode == item.ItemCode);
                    }
                    else
                    {
                        carPart = dbContext.cars.FirstOrDefault(c => c.CarCode == item.ItemCode);
                    }

                    if (carPart != null && carPart.Image != null)
                    {
                        using (var ms = new MemoryStream(carPart.Image))
                        {
                            pictureBox.Image = Image.FromStream(ms);
                        }
                    }

                    // Add controls to panelLine here, similar to below:
                    Label labelItemCode = new Label { Text = item.ItemCode, Location = new Point(110, 40), Size = new Size(100, 20) };
                    Label labelItemName = new Label { Text = item.ItemName, Location = new Point(215, 40), Size = new Size(200, 20) };
                    Label labelQty = new Label { Text = item.Quantity.ToString(), Location = new Point(415, 40), Size = new Size(50, 20) };
                    Label labelPrice = new Label { Text = item.Price.ToString("F2"), Location = new Point(480, 40), Size = new Size(100, 20) };
                    Label labelTotal = new Label { Text = item.TotalAmount.ToString("F2"), Location = new Point(580, 40), Size = new Size(100, 20) };

                    panelLine.Controls.Add(pictureBox);
                    panelLine.Controls.Add(labelItemCode);
                    panelLine.Controls.Add(labelItemName);
                    panelLine.Controls.Add(labelQty);
                    panelLine.Controls.Add(labelPrice);
                    panelLine.Controls.Add(labelTotal);

                    panelOrderMain.Controls.Add(panelLine);

                    yPos += 110;
                }


            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
