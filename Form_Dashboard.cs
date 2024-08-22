using CarTraders.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarTraders
{
    public partial class Form_Dashboard : Form
    {
        private int currentCustomerCount = 0;
        private int currentCarCount = 0;
        private int currentCarPartCount = 0;
        private int activeCustomerCount = 0;
        private int activeCarCount = 0;
        private int activeCarPartCount = 0;
        private int pendingOrderCount = 0;

        public Form_Dashboard()
        {
            InitializeComponent();
            CountTimer.Tick += CountTimer_Tick;
        }

        private void Form_Dashboard_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            using (var context = new ApplicationDBContext())
            {
                activeCustomerCount = context.users.Count(u => u.UserRole == "Customer_Role" && u.Status == 1);
                activeCarCount = context.cars.Count(c => c.Status == 1);
                activeCarPartCount = context.carParts.Count(c => c.Status == 1 && c.Quantity > 0);

                // Car Latest Details
                var latestCar = context.cars
                                     .Where(c => c.Status == 1)
                                     .OrderByDescending(c => c.CreateDate)
                                     .FirstOrDefault();
                if (latestCar != null)
                {
                    if (latestCar.Image != null)
                    {
                        using (MemoryStream ms = new MemoryStream(latestCar.Image))
                        {
                            pictureBoxCarDetails.Image = Image.FromStream(ms);
                        }
                    }

                    labelCarColor.Text = latestCar.Color;
                    labelCarModel.Text = latestCar.CarModel;
                    labelPrice.Text = "Rs " + latestCar.Price.ToString() + ".00";
                    labelFuleType.Text = latestCar.FuelType;
                    labelTransmission.Text = latestCar.Transmission;

                    TimeSpan timeGap = DateTime.Now - latestCar.CreateDate;
                    string timeGapText = "";
                    if (timeGap.Days > 0)
                    {
                        timeGapText = $"{timeGap.Days} day{(timeGap.Days > 1 ? "s" : "")}";
                    }
                    else if (timeGap.Hours > 0)
                    {
                        timeGapText = $"{timeGap.Hours} hour{(timeGap.Hours > 1 ? "s" : "")}";
                    }
                    else if (timeGap.Minutes > 0)
                    {
                        timeGapText = $"{timeGap.Minutes} minute{(timeGap.Minutes > 1 ? "s" : "")}";
                    }
                    else
                    {
                        timeGapText = "Just now";
                    }
                    labelTimeGap.Text = timeGapText;
                }

                // Car Part Latest Details
                var latestCarPart = context.carParts
                                     .Where(c => c.Status == 1)
                                     .OrderByDescending(c => c.CreateDate)
                                     .FirstOrDefault();
                if (latestCarPart != null)
                {
                    if (latestCarPart.Image != null)
                    {
                        using (MemoryStream ms = new MemoryStream(latestCarPart.Image))
                        {
                            pictureBoxPartDetails.Image = Image.FromStream(ms);
                        }
                    }

                    labelPartModel.Text = latestCarPart.CarModel;
                    labelPartName.Text = latestCarPart.PartName;
                    labelPartPrice.Text = "Rs " + latestCarPart.Price.ToString() + ".00";
                    labelQty.Text = latestCarPart.Quantity.ToString();
                    labelPartColor.Text = latestCarPart.Color;

                    TimeSpan timeGap = DateTime.Now - latestCarPart.CreateDate;
                    string timeGapText = "";
                    if (timeGap.Days > 0)
                    {
                        timeGapText = $"{timeGap.Days} day{(timeGap.Days > 1 ? "s" : "")}";
                    }
                    else if (timeGap.Hours > 0)
                    {
                        timeGapText = $"{timeGap.Hours} hour{(timeGap.Hours > 1 ? "s" : "")}";
                    }
                    else if (timeGap.Minutes > 0)
                    {
                        timeGapText = $"{timeGap.Minutes} minute{(timeGap.Minutes > 1 ? "s" : "")}";
                    }
                    else
                    {
                        timeGapText = "Just now";
                    }
                    labelTimeGap2.Text = timeGapText;
                }

                // Customer Latest Details
                var latestCustomer = context.users
                                     .Where(c => c.Status == 1 && c.UserRole == "Customer_Role")
                                     .OrderByDescending(c => c.CreateDate)
                                     .FirstOrDefault();
                if (latestCustomer != null)
                {
                    if (latestCustomer.Image != null)
                    {
                        using (MemoryStream ms = new MemoryStream(latestCustomer.Image))
                        {
                            pictureBoxCustomer.Image = Image.FromStream(ms);
                        }
                    }

                    labelFirstName.Text = latestCustomer.FirstName;
                    labelLastName.Text = latestCustomer.LastName;
                    labelEmail.Text = latestCustomer.Email;
                    labelContact.Text = latestCustomer.ContactNo;
                    labelCity.Text = latestCustomer.City;

                    TimeSpan timeGap = DateTime.Now - latestCustomer.CreateDate;
                    string timeGapText = "";
                    if (timeGap.Days > 0)
                    {
                        timeGapText = $"{timeGap.Days} day{(timeGap.Days > 1 ? "s" : "")}";
                    }
                    else if (timeGap.Hours > 0)
                    {
                        timeGapText = $"{timeGap.Hours} hour{(timeGap.Hours > 1 ? "s" : "")}";
                    }
                    else if (timeGap.Minutes > 0)
                    {
                        timeGapText = $"{timeGap.Minutes} minute{(timeGap.Minutes > 1 ? "s" : "")}";
                    }
                    else
                    {
                        timeGapText = "Just now";
                    }
                    labelTimeGap3.Text = timeGapText;
                }
            }
            CountTimer.Start();
        }

        private void CountTimer_Tick(object sender, EventArgs e)
        {
            bool allCountsUpdated = true;
            if (currentCustomerCount < activeCustomerCount)
            {
                currentCustomerCount++;
                labelCustomerCount.Visible = true;
                labelCustomerCount.Text = currentCustomerCount.ToString();
                allCountsUpdated = false;
            }

            // Increment Car Count
            if (currentCarCount < activeCarCount)
            {
                currentCarCount++;
                labelCarCount.Visible = true;
                labelCarCount.Text = currentCarCount.ToString();
                allCountsUpdated = false;
            }

            // Increment Car Part Count
            if (currentCarPartCount < activeCarPartCount)
            {
                currentCarPartCount++;
                labelCarPartCount.Visible = true;
                labelCarPartCount.Text = currentCarPartCount.ToString();
                allCountsUpdated = false;
            }

            // Stop the timer if all counts are updated
            if (allCountsUpdated)
            {
                CountTimer.Stop();
            }

        }
    }
}
