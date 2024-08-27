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

namespace CarTraders.Views.Customer
{
    public partial class Form_Customer_Dashboard : Form
    {
        public string currentUser;
        private int completeOrderCount = 0;
        private int currentCarCount = 0;
        private int currentCarPartCount = 0;
        private int currentPendingOrderCount = 0;
        private int activeOrderCount = 0;
        private int activeCarCount = 0;
        private int activeCarPartCount = 0;
        private int pendingOrderCount = 0;
        public Form_Customer_Dashboard(string username)
        {
            InitializeComponent();
            currentUser = username;
        }

        private void CountTimer_Tick(object sender, EventArgs e)
        {
            bool allCountsUpdated = true;
            if (completeOrderCount < activeOrderCount)
            {
                completeOrderCount++;
                labelCompleteOrders.Visible = true;
                labelCompleteOrders.Text = completeOrderCount.ToString();
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
            if (currentPendingOrderCount < pendingOrderCount)
            {
                currentPendingOrderCount++;
                labelPendingOrderCount.Visible = true;
                labelPendingOrderCount.Text = currentPendingOrderCount.ToString();
                allCountsUpdated = false;
            }

            // Stop the timer if all counts are updated
            if (allCountsUpdated)
            {
                CountTimer.Stop();
            }

        }

        private void Form_Customer_Dashboard_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            using (var context = new ApplicationDBContext())
            {
                var user = context.users.FirstOrDefault(u => u.Username == currentUser);

                activeOrderCount = context.orderDetails.Count(o => o.CustomerCode == user.UserCode && o.Is_active == 1 && o.IsApproved == 1);
                activeCarCount = context.cars.Count(c => c.Status == 1 && c.IsDeleted == 0);
                activeCarPartCount = context.carParts.Count(c => c.Status == 1 && c.Quantity > 0 && c.IsDeleted == 0);
                pendingOrderCount = context.orderDetails.Count(o => o.CustomerCode == user.UserCode && o.Is_active == 1 && o.IsApproved == 0);
            }
            CountTimer.Start();
        }
    }
}
