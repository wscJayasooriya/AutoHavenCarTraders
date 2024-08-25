using CarTraders.Data;
using CarTraders.Views;
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
    public partial class Dashboard : Form
    {
        private Form activeForm = null;
        Form_Dashboard _Dashboard;
        Form_Cars _Cars;
        Form_CarParts _CarParts;
        Form_Customers _Customers;
        Form_Orders _Orders;
        Form_ReportCustomer _CustomerReport;
        Form_Users _Users;
        Form_ManageOrder _ManageOrder;
        public string currentUser;
        public string userRole;

        public Dashboard(String username)
        {
            InitializeComponent();
            OpenChildForm(new Form_Dashboard());
            currentUser = username;
            using (var dbContext = new ApplicationDBContext())
            {
                var user = dbContext.users.FirstOrDefault(u => u.Username == currentUser && u.Status == 1);
                userRole = user.UserRole;
            }
        }

        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebarPanel.Width -= 10;
                if (sidebarPanel.Width <= 80)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();

                    panelDashboard.Width = sidebarPanel.Width;
                    panelCars.Width = sidebarPanel.Width;
                    panelCarParts.Width = sidebarPanel.Width;
                    panelCustomers.Width = sidebarPanel.Width;
                    panelOrders.Width = sidebarPanel.Width;
                    reportContainer.Width = sidebarPanel.Width;
                    panelLogout.Width = sidebarPanel.Width;
                }
            }
            else
            {
                sidebarPanel.Width += 10;
                if (sidebarPanel.Width >= 300)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();

                    panelDashboard.Width = sidebarPanel.Width;
                    panelCars.Width = sidebarPanel.Width;
                    panelCarParts.Width = sidebarPanel.Width;
                    panelCustomers.Width = sidebarPanel.Width;
                    panelOrders.Width = sidebarPanel.Width;
                    reportContainer.Width = sidebarPanel.Width;
                    panelLogout.Width = sidebarPanel.Width;
                }
            }
        }

        private void btnHam_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }


        bool reportExpand = false;
        private void reportTransition_Tick(object sender, EventArgs e)
        {
            if (reportExpand == false)
            {
                reportContainer.Height += 40;
                if (reportContainer.Height >= 240)
                {
                    reportTransition.Stop();
                    reportExpand = true;
                }
            }
            else
            {
                reportContainer.Height -= 40;
                if (reportContainer.Height <= 80)
                {
                    reportTransition.Stop();
                    reportExpand = false;
                }
            }
        }

        private void reportNav_Click(object sender, EventArgs e)
        {
            labelHead.Text = reportNav.Text.Trim();
            labelNav.Text = reportNav.Text.Trim();
            dashboardNav.BackColor = Color.FromArgb(52, 73, 94);
            carNav.BackColor = Color.FromArgb(52, 73, 94);
            carPartsNav.BackColor = Color.FromArgb(52, 73, 94);
            customerNav.BackColor = Color.FromArgb(52, 73, 94);
            orderNav.BackColor = Color.FromArgb(52, 73, 94);
            reportNav.BackColor = Color.FromArgb(97, 106, 107);
            manageUserNave.BackColor = Color.FromArgb(52, 73, 94);
            logoutNav.BackColor = Color.FromArgb(52, 73, 94);
            reportTransition.Start();
        }

        private void dashboardNav_Click(object sender, EventArgs e)
        {
            labelHead.Text = dashboardNav.Text.Trim();
            labelNav.Text = dashboardNav.Text.Trim();
            dashboardNav.BackColor = Color.FromArgb(97, 106, 107);
            carNav.BackColor = Color.FromArgb(52, 73, 94);
            carPartsNav.BackColor = Color.FromArgb(52, 73, 94);
            customerNav.BackColor = Color.FromArgb(52, 73, 94);
            orderNav.BackColor = Color.FromArgb(52, 73, 94);
            reportNav.BackColor = Color.FromArgb(52, 73, 94);
            manageUserNave.BackColor = Color.FromArgb(52, 73, 94);
            logoutNav.BackColor = Color.FromArgb(52, 73, 94);
            OpenChildForm(new Form_Dashboard());
        }

        private void customerReportNav_Click(object sender, EventArgs e)
        {
            labelHead.Text = customerReportNav.Text.Trim();
            labelNav.Text = customerReportNav.Text.Trim();
            OpenChildForm(new Form_ReportCustomer());
        }

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(childForm);
            mainPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void carNav_Click(object sender, EventArgs e)
        {
            labelHead.Text = carNav.Text.Trim();
            labelNav.Text = carNav.Text.Trim();
            dashboardNav.BackColor = Color.FromArgb(52, 73, 94);
            carNav.BackColor = Color.FromArgb(97, 106, 107);
            carPartsNav.BackColor = Color.FromArgb(52, 73, 94);
            customerNav.BackColor = Color.FromArgb(52, 73, 94);
            orderNav.BackColor = Color.FromArgb(52, 73, 94);
            reportNav.BackColor = Color.FromArgb(52, 73, 94);
            manageUserNave.BackColor = Color.FromArgb(52, 73, 94);
            logoutNav.BackColor = Color.FromArgb(52, 73, 94);
            OpenChildForm(new Form_Cars());
        }

        private void carPartsNav_Click(object sender, EventArgs e)
        {
            labelHead.Text = carPartsNav.Text.Trim();
            labelNav.Text = carPartsNav.Text.Trim();
            dashboardNav.BackColor = Color.FromArgb(52, 73, 94);
            carNav.BackColor = Color.FromArgb(52, 73, 94);
            carPartsNav.BackColor = Color.FromArgb(97, 106, 107);
            customerNav.BackColor = Color.FromArgb(52, 73, 94);
            orderNav.BackColor = Color.FromArgb(52, 73, 94);
            reportNav.BackColor = Color.FromArgb(52, 73, 94);
            manageUserNave.BackColor = Color.FromArgb(52, 73, 94);
            logoutNav.BackColor = Color.FromArgb(52, 73, 94);
            OpenChildForm(new Form_CarParts());
        }

        private void customerNav_Click(object sender, EventArgs e)
        {
            labelHead.Text = customerNav.Text.Trim();
            labelNav.Text = customerNav.Text.Trim();
            dashboardNav.BackColor = Color.FromArgb(52, 73, 94);
            carNav.BackColor = Color.FromArgb(52, 73, 94);
            carPartsNav.BackColor = Color.FromArgb(52, 73, 94);
            customerNav.BackColor = Color.FromArgb(97, 106, 107);
            orderNav.BackColor = Color.FromArgb(52, 73, 94);
            reportNav.BackColor = Color.FromArgb(52, 73, 94);
            manageUserNave.BackColor = Color.FromArgb(52, 73, 94);
            logoutNav.BackColor = Color.FromArgb(52, 73, 94);
            OpenChildForm(new Form_Customers());
        }

        private void orderNav_Click(object sender, EventArgs e)
        {

            if (userRole == "Customer_Role")
            {
                labelHead.Text = orderNav.Text.Trim();
                labelNav.Text = orderNav.Text.Trim();
                dashboardNav.BackColor = Color.FromArgb(52, 73, 94);
                carNav.BackColor = Color.FromArgb(52, 73, 94);
                carPartsNav.BackColor = Color.FromArgb(52, 73, 94);
                customerNav.BackColor = Color.FromArgb(52, 73, 94);
                orderNav.BackColor = Color.FromArgb(97, 106, 107);
                reportNav.BackColor = Color.FromArgb(52, 73, 94);
                manageUserNave.BackColor = Color.FromArgb(52, 73, 94);
                logoutNav.BackColor = Color.FromArgb(52, 73, 94);
                OpenChildForm(new Form_Orders(currentUser));
            }
            else
            {
                labelHead.Text = orderNav.Text.Trim();
                labelNav.Text = orderNav.Text.Trim();
                dashboardNav.BackColor = Color.FromArgb(52, 73, 94);
                carNav.BackColor = Color.FromArgb(52, 73, 94);
                carPartsNav.BackColor = Color.FromArgb(52, 73, 94);
                customerNav.BackColor = Color.FromArgb(52, 73, 94);
                orderNav.BackColor = Color.FromArgb(97, 106, 107);
                reportNav.BackColor = Color.FromArgb(52, 73, 94);
                manageUserNave.BackColor = Color.FromArgb(52, 73, 94);
                logoutNav.BackColor = Color.FromArgb(52, 73, 94);
                OpenChildForm(new Form_ManageOrder(currentUser));
            }

        }

        private void btnAppMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnAppClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnAppMin_MouseEnter(object sender, EventArgs e)
        {
            btnAppMin.BackColor = Color.Blue;
        }

        private void btnAppMin_MouseLeave(object sender, EventArgs e)
        {
            btnAppMin.BackColor = panel1.BackColor;
        }

        private void btnAppClose_MouseEnter(object sender, EventArgs e)
        {
            btnAppClose.BackColor = Color.Red;
        }

        private void btnAppClose_MouseLeave(object sender, EventArgs e)
        {
            btnAppClose.BackColor = panel1.BackColor;
        }

        private void manageUserNave_Click(object sender, EventArgs e)
        {
            labelHead.Text = manageUserNave.Text.Trim();
            labelNav.Text = manageUserNave.Text.Trim();
            dashboardNav.BackColor = Color.FromArgb(52, 73, 94);
            carNav.BackColor = Color.FromArgb(52, 73, 94);
            carPartsNav.BackColor = Color.FromArgb(52, 73, 94);
            customerNav.BackColor = Color.FromArgb(52, 73, 94);
            orderNav.BackColor = Color.FromArgb(52, 73, 94);
            reportNav.BackColor = Color.FromArgb(52, 73, 94);
            manageUserNave.BackColor = Color.FromArgb(97, 106, 107);
            logoutNav.BackColor = Color.FromArgb(52, 73, 94);
            OpenChildForm(new Form_Users());
        }
    }
}
