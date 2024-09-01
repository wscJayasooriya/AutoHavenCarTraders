using CarTraders.Data;
using CarTraders.Helpers;
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
    public partial class Form_View_Order : Form
    {
        public string currentUser;
        EmailSendUtil emailSendUtil;
        public Form_View_Order(string orderCode, string username, bool v)
        {
            InitializeComponent();
            emailSendUtil = new EmailSendUtil();
            panelOrderMain.AutoScroll = true;
            currentUser = username;

            if (!v)
            {
                button2.Visible = false;
                btnReject.Visible = false;
            }

            using (var dbContext = new ApplicationDBContext())
            {
                var orderDetails = dbContext.orderDetails.FirstOrDefault(o => o.OrderCode == orderCode);
                var user = dbContext.users.FirstOrDefault(u => u.Username == currentUser);
                var itemDetails = dbContext.orderItemDetails.Where(i => i.OrderCode == orderCode).ToList();

                if (orderDetails == null)
                {
                    NotificationUtil.ShowNotification(NotificationType.INFO, "Order details not found.");
                    return;
                }
                if (orderDetails.IsPayment == 1)
                {
                    labelStatus.Text = "Paid";
                    labelStatus.BackColor = Color.Green;
                }
                else
                {
                    labelStatus.Text = "Non-Paid";
                    labelStatus.BackColor = Color.Red;
                }

                if (orderDetails.IsApproved == 1 && orderDetails.IsPayment == 0 && user.UserRole == "User_Role")
                {
                    btnPayment.Visible = true;
                    labelPaidAmount.Visible = true;
                    txtPaidAmount.Visible = true;
                    labelChangeAmount.Visible = true;
                    txtChangeAmount.Visible = true;
                    btnPayment.Location = button2.Location;
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
                        Size = new Size(panelOrderMain.Width - 20, 100),
                        Location = new Point(5, yPos),
                        BorderStyle = BorderStyle.FixedSingle
                    };
                    PictureBox pictureBox = new PictureBox
                    {
                        Size = new Size(90, 90),
                        Location = new Point(5, 5),
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

        private void button2_Click(object sender, EventArgs e)
        {
            string invoiceNo = txtInvoiceNo.Text;
            string approvedBy;

            using (var dbContext = new ApplicationDBContext())
            {
                var orderDetails = dbContext.orderDetails.FirstOrDefault(o => o.OrderCode == invoiceNo);
                var customerDetails = dbContext.users.FirstOrDefault(c => c.UserCode == orderDetails.CustomerCode);
                var userDetail = dbContext.users.FirstOrDefault(u => u.Username == currentUser);
                approvedBy = userDetail.UserCode;

                if (orderDetails == null)
                {
                    NotificationUtil.ShowNotification(NotificationType.INFO, "Order not found.");
                    return;
                }

                // Update the order details
                orderDetails.IsApproved = 1;
                orderDetails.OrderStatus = "Approved";
                orderDetails.ApprovedDate = DateTime.Now;
                orderDetails.ApprovedBy = approvedBy;
                dbContext.SaveChanges();

                string htmlTemplate = @"
                    <!DOCTYPE html>
                    <html lang='en'>
                    <head>
                        <meta charset='UTF-8'>
                        <meta name='viewport' content='width=device-width, initial-scale=1.0'>
                        <title>Order Approval Notification</title>
                    </head>
                    <body style='font-family: Arial, sans-serif; line-height: 1.6;'>
                        <p>Dear {0},</p>

                        <p>We are pleased to inform you that your recent order, <strong>#{1}</strong>, has been approved and is now being processed.</p>

                        <p>We appreciate your business and look forward to serving you. You can track the status of your order by logging into your account on our website.</p>

                        <p>If you have any questions or need further assistance, please do not hesitate to contact our customer service team.</p>

                        <p>Thank you for choosing us!</p>

                        <p>Sincerely,<br>{2}<br>{3}</p>
                    </body>
                    </html>";
                string customerName = customerDetails.FirstName + " " + customerDetails.LastName;
                string orderNumber = orderDetails.OrderCode;
                string companyName = "ABC Car Traders";
                string customerServiceInfo = "cartraders.abc@gmail.com or call us at 011 2345 678";

                string formattedHtml = string.Format(htmlTemplate, customerName, orderNumber, companyName, customerServiceInfo);


                emailSendUtil.SendOtpEmailOrderAction(customerDetails.Email, "Your Order Has Been Approved", formattedHtml);

                NotificationUtil.ShowNotification(NotificationType.SUCCESS, "Order approved successfully.");
                this.Close();


            }
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            string invoiceNo = txtInvoiceNo.Text;
            string approvedBy;

            using (var dbContext = new ApplicationDBContext())
            {
                var orderDetails = dbContext.orderDetails.FirstOrDefault(o => o.OrderCode == invoiceNo);
                var customerDetails = dbContext.users.FirstOrDefault(c => c.UserCode == orderDetails.CustomerCode);
                var userDetail = dbContext.users.FirstOrDefault(u => u.Username == currentUser);
                approvedBy = userDetail.UserCode;

                if (orderDetails == null)
                {
                    NotificationUtil.ShowNotification(NotificationType.INFO, "Order not found.");
                    return;
                }

                // Update the order details
                orderDetails.IsApproved = -1;
                orderDetails.OrderStatus = "Rejected";
                orderDetails.ApprovedDate = DateTime.Now;
                orderDetails.ApprovedBy = approvedBy;
                dbContext.SaveChanges();



                string htmlTemplate = @"
                        <!DOCTYPE html>
                        <html lang='en'>
                        <head>
                            <meta charset='UTF-8'>
                            <meta name='viewport' content='width=device-width, initial-scale=1.0'>
                            <title>Order Rejection Notification</title>
                        </head>
                        <body style='font-family: Arial, sans-serif; line-height: 1.6;'>
                            <p>Dear {0},</p>
    
                            <p>We regret to inform you that your recent order, <strong>{1}</strong>, has been rejected.</p>
    
                            <p><strong>Reason for Rejection:</strong> {2}</p>
    
                            <p>Please feel free to place a new order on our website or contact our customer service team for assistance with any issues.</p>
    
                            <p>We apologize for any inconvenience this may cause.</p>
    
                            <p>Thank you for understanding.</p>
    
                            <p>Sincerely,<br>{3}<br>{4}</p>
                        </body>
                        </html>";
                string customerName = customerDetails.FirstName + " " + customerDetails.LastName;
                string orderNumber = orderDetails.OrderCode;
                string rejectionReason = "This Item is Out of Stock";
                string companyName = "ABC Car Traders";
                string customerServiceInfo = "support@yourcompany.com or call us at 011 2345 678";

                string formattedHtml = string.Format(htmlTemplate, customerName, orderNumber, rejectionReason, companyName, customerServiceInfo);


                emailSendUtil.SendOtpEmailOrderAction(customerDetails.Email, "Your Order Has Been Rejected", formattedHtml);
                NotificationUtil.ShowNotification(NotificationType.SUCCESS, "Order Rejected successfully.");
                this.Close();

            }
        }

        private void txtPaidAmount_TextChanged(object sender, EventArgs e)
        {
            CalculateChangeAmount();
        }

        private void CalculateChangeAmount()
        {
            if (decimal.TryParse(txtPaidAmount.Text, out decimal paidAmount) && decimal.TryParse(txtGrossAmount.Text, out decimal grossAmount))
            {
                // Calculate the change amount
                decimal changeAmount = paidAmount - grossAmount;

                // Set the change amount to txtChangeAmount textbox
                txtChangeAmount.Text = changeAmount.ToString("F2"); // Formatting to 2 decimal places
            }
            else
            {
                // Handle parsing error, maybe set default values or show an error message
                txtChangeAmount.Text = "Invalid input";
                NotificationUtil.ShowNotification(NotificationType.ERROR, "Please enter valid numeric values.");
            }
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            string invoiceNo = txtInvoiceNo.Text;

            using (var dbContext = new ApplicationDBContext())
            {
                var orderDetails = dbContext.orderDetails.FirstOrDefault(o => o.OrderCode == invoiceNo);

                if (orderDetails == null)
                {
                    NotificationUtil.ShowNotification(NotificationType.INFO, "Order not found.");
                    return;
                }

                if (decimal.TryParse(txtPaidAmount.Text, out decimal paidAmount) && decimal.TryParse(txtChangeAmount.Text, out decimal changeAmount))
                {
                    // Update the order details
                    orderDetails.IsPayment = 1;
                    orderDetails.PaidAmount = double.Parse(txtPaidAmount.Text);
                    orderDetails.ChangeAmount = double.Parse(txtChangeAmount.Text);
                    orderDetails.OrderStatus = "Paid";
                    dbContext.SaveChanges();

                    NotificationUtil.ShowNotification(NotificationType.SUCCESS, "Payment details updated successfully.");
                    this.Close();

                }
                else
                {
                    NotificationUtil.ShowNotification(NotificationType.ERROR, "Invalid amount entered.");
                }
            }
        }
    }
}
