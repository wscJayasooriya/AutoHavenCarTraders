namespace CarTraders
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            panel1 = new Panel();
            btnAppClose = new Button();
            btnAppMin = new Button();
            btnHam = new Button();
            labelMain = new Label();
            sidebarPanel = new Panel();
            panelViewCustomerOrders = new Panel();
            viewOrdersNav = new Button();
            panel4 = new Panel();
            manageUserNave = new Button();
            reportContainer = new FlowLayoutPanel();
            panel8 = new Panel();
            reportNav = new Button();
            panel9 = new Panel();
            customerReportNav = new Button();
            panelViewOrder = new Panel();
            panelLogout = new Panel();
            panel2 = new Panel();
            button2 = new Button();
            button1 = new Button();
            logoutNav = new Button();
            panelDashboard = new Panel();
            dashboardNav = new Button();
            panelCars = new Panel();
            carNav = new Button();
            panelOrders = new Panel();
            orderNav = new Button();
            panelCarParts = new Panel();
            carPartsNav = new Button();
            panelCustomers = new Panel();
            customerNav = new Button();
            panel3 = new Panel();
            labelNav = new Label();
            labelHead = new Label();
            sidebarTransition = new System.Windows.Forms.Timer(components);
            reportTransition = new System.Windows.Forms.Timer(components);
            mainPanel = new Panel();
            panel1.SuspendLayout();
            sidebarPanel.SuspendLayout();
            panelViewCustomerOrders.SuspendLayout();
            panel4.SuspendLayout();
            reportContainer.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panelLogout.SuspendLayout();
            panel2.SuspendLayout();
            panelDashboard.SuspendLayout();
            panelCars.SuspendLayout();
            panelOrders.SuspendLayout();
            panelCarParts.SuspendLayout();
            panelCustomers.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(btnAppClose);
            panel1.Controls.Add(btnAppMin);
            panel1.Controls.Add(btnHam);
            panel1.Controls.Add(labelMain);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1875, 75);
            panel1.TabIndex = 0;
            // 
            // btnAppClose
            // 
            btnAppClose.BackColor = Color.Transparent;
            btnAppClose.BackgroundImageLayout = ImageLayout.Stretch;
            btnAppClose.FlatStyle = FlatStyle.Flat;
            btnAppClose.ForeColor = Color.DodgerBlue;
            btnAppClose.Image = (Image)resources.GetObject("btnAppClose.Image");
            btnAppClose.Location = new Point(1805, 12);
            btnAppClose.Name = "btnAppClose";
            btnAppClose.Size = new Size(59, 51);
            btnAppClose.TabIndex = 8;
            btnAppClose.UseVisualStyleBackColor = false;
            btnAppClose.Click += btnAppClose_Click;
            btnAppClose.MouseEnter += btnAppClose_MouseEnter;
            btnAppClose.MouseLeave += btnAppClose_MouseLeave;
            // 
            // btnAppMin
            // 
            btnAppMin.BackColor = Color.Transparent;
            btnAppMin.BackgroundImageLayout = ImageLayout.Stretch;
            btnAppMin.FlatStyle = FlatStyle.Flat;
            btnAppMin.ForeColor = Color.DodgerBlue;
            btnAppMin.Image = (Image)resources.GetObject("btnAppMin.Image");
            btnAppMin.Location = new Point(1740, 12);
            btnAppMin.Name = "btnAppMin";
            btnAppMin.Size = new Size(59, 51);
            btnAppMin.TabIndex = 7;
            btnAppMin.UseVisualStyleBackColor = false;
            btnAppMin.Click += btnAppMin_Click;
            btnAppMin.MouseEnter += btnAppMin_MouseEnter;
            btnAppMin.MouseLeave += btnAppMin_MouseLeave;
            // 
            // btnHam
            // 
            btnHam.BackColor = Color.Transparent;
            btnHam.BackgroundImageLayout = ImageLayout.Stretch;
            btnHam.Cursor = Cursors.Hand;
            btnHam.FlatAppearance.BorderSize = 0;
            btnHam.FlatStyle = FlatStyle.Flat;
            btnHam.Image = (Image)resources.GetObject("btnHam.Image");
            btnHam.Location = new Point(12, 18);
            btnHam.Name = "btnHam";
            btnHam.Size = new Size(50, 42);
            btnHam.TabIndex = 4;
            btnHam.UseVisualStyleBackColor = false;
            btnHam.Click += btnHam_Click;
            // 
            // labelMain
            // 
            labelMain.AutoSize = true;
            labelMain.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMain.ForeColor = Color.White;
            labelMain.Location = new Point(68, 22);
            labelMain.Name = "labelMain";
            labelMain.Size = new Size(233, 30);
            labelMain.TabIndex = 3;
            labelMain.Text = "Admin Dashboard";
            // 
            // sidebarPanel
            // 
            sidebarPanel.BackColor = Color.FromArgb(52, 73, 94);
            sidebarPanel.Controls.Add(panelViewCustomerOrders);
            sidebarPanel.Controls.Add(panel4);
            sidebarPanel.Controls.Add(reportContainer);
            sidebarPanel.Controls.Add(panelLogout);
            sidebarPanel.Controls.Add(panelDashboard);
            sidebarPanel.Controls.Add(panelCars);
            sidebarPanel.Controls.Add(panelOrders);
            sidebarPanel.Controls.Add(panelCarParts);
            sidebarPanel.Controls.Add(panelCustomers);
            sidebarPanel.Dock = DockStyle.Left;
            sidebarPanel.Location = new Point(0, 75);
            sidebarPanel.Name = "sidebarPanel";
            sidebarPanel.Size = new Size(300, 899);
            sidebarPanel.TabIndex = 1;
            // 
            // panelViewCustomerOrders
            // 
            panelViewCustomerOrders.Controls.Add(viewOrdersNav);
            panelViewCustomerOrders.Location = new Point(3, 6);
            panelViewCustomerOrders.Name = "panelViewCustomerOrders";
            panelViewCustomerOrders.Padding = new Padding(0, 30, 0, 0);
            panelViewCustomerOrders.Size = new Size(297, 80);
            panelViewCustomerOrders.TabIndex = 6;
            panelViewCustomerOrders.Visible = false;
            // 
            // viewOrdersNav
            // 
            viewOrdersNav.BackColor = Color.FromArgb(52, 73, 94);
            viewOrdersNav.Cursor = Cursors.Hand;
            viewOrdersNav.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            viewOrdersNav.ForeColor = Color.White;
            viewOrdersNav.Image = (Image)resources.GetObject("viewOrdersNav.Image");
            viewOrdersNav.ImageAlign = ContentAlignment.MiddleLeft;
            viewOrdersNav.Location = new Point(-5, -17);
            viewOrdersNav.Name = "viewOrdersNav";
            viewOrdersNav.Padding = new Padding(25, 0, 0, 0);
            viewOrdersNav.Size = new Size(354, 121);
            viewOrdersNav.TabIndex = 3;
            viewOrdersNav.Text = "         View Orders";
            viewOrdersNav.TextAlign = ContentAlignment.MiddleLeft;
            viewOrdersNav.UseVisualStyleBackColor = false;
            viewOrdersNav.Visible = false;
            viewOrdersNav.Click += viewOrdersNav_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(manageUserNave);
            panel4.Location = new Point(1, 727);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(0, 30, 0, 0);
            panel4.Size = new Size(297, 80);
            panel4.TabIndex = 5;
            // 
            // manageUserNave
            // 
            manageUserNave.BackColor = Color.FromArgb(52, 73, 94);
            manageUserNave.Cursor = Cursors.Hand;
            manageUserNave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            manageUserNave.ForeColor = Color.White;
            manageUserNave.Image = (Image)resources.GetObject("manageUserNave.Image");
            manageUserNave.ImageAlign = ContentAlignment.MiddleLeft;
            manageUserNave.Location = new Point(-6, -10);
            manageUserNave.Name = "manageUserNave";
            manageUserNave.Padding = new Padding(25, 0, 0, 0);
            manageUserNave.Size = new Size(354, 121);
            manageUserNave.TabIndex = 3;
            manageUserNave.Text = "         Manage Users";
            manageUserNave.TextAlign = ContentAlignment.MiddleLeft;
            manageUserNave.UseVisualStyleBackColor = false;
            manageUserNave.Click += manageUserNave_Click;
            // 
            // reportContainer
            // 
            reportContainer.BackColor = Color.FromArgb(55, 64, 93);
            reportContainer.Controls.Add(panel8);
            reportContainer.Controls.Add(panel9);
            reportContainer.Controls.Add(panelViewOrder);
            reportContainer.Location = new Point(2, 491);
            reportContainer.Margin = new Padding(0);
            reportContainer.Name = "reportContainer";
            reportContainer.Size = new Size(297, 80);
            reportContainer.TabIndex = 5;
            // 
            // panel8
            // 
            panel8.Controls.Add(reportNav);
            panel8.Location = new Point(0, 0);
            panel8.Margin = new Padding(0);
            panel8.Name = "panel8";
            panel8.Padding = new Padding(0, 30, 0, 0);
            panel8.Size = new Size(297, 80);
            panel8.TabIndex = 4;
            // 
            // reportNav
            // 
            reportNav.BackColor = Color.FromArgb(52, 73, 94);
            reportNav.Cursor = Cursors.Hand;
            reportNav.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            reportNav.ForeColor = Color.White;
            reportNav.Image = (Image)resources.GetObject("reportNav.Image");
            reportNav.ImageAlign = ContentAlignment.MiddleLeft;
            reportNav.Location = new Point(-5, -17);
            reportNav.Name = "reportNav";
            reportNav.Padding = new Padding(25, 0, 0, 0);
            reportNav.Size = new Size(354, 121);
            reportNav.TabIndex = 3;
            reportNav.Text = "         Reports";
            reportNav.TextAlign = ContentAlignment.MiddleLeft;
            reportNav.UseVisualStyleBackColor = false;
            reportNav.Click += reportNav_Click;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(55, 64, 93);
            panel9.Controls.Add(customerReportNav);
            panel9.Location = new Point(0, 80);
            panel9.Margin = new Padding(0);
            panel9.Name = "panel9";
            panel9.Padding = new Padding(0, 30, 0, 0);
            panel9.Size = new Size(297, 80);
            panel9.TabIndex = 4;
            // 
            // customerReportNav
            // 
            customerReportNav.BackColor = Color.FromArgb(55, 64, 93);
            customerReportNav.Cursor = Cursors.Hand;
            customerReportNav.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customerReportNav.ForeColor = Color.White;
            customerReportNav.Image = (Image)resources.GetObject("customerReportNav.Image");
            customerReportNav.ImageAlign = ContentAlignment.MiddleLeft;
            customerReportNav.Location = new Point(-5, -17);
            customerReportNav.Name = "customerReportNav";
            customerReportNav.Padding = new Padding(25, 0, 0, 0);
            customerReportNav.Size = new Size(354, 121);
            customerReportNav.TabIndex = 3;
            customerReportNav.Text = "         Item Wise Sales Report";
            customerReportNav.TextAlign = ContentAlignment.MiddleLeft;
            customerReportNav.UseVisualStyleBackColor = false;
            customerReportNav.Click += customerReportNav_Click;
            // 
            // panelViewOrder
            // 
            panelViewOrder.BackColor = Color.FromArgb(55, 64, 93);
            panelViewOrder.Location = new Point(0, 160);
            panelViewOrder.Margin = new Padding(0);
            panelViewOrder.Name = "panelViewOrder";
            panelViewOrder.Padding = new Padding(0, 30, 0, 0);
            panelViewOrder.Size = new Size(297, 80);
            panelViewOrder.TabIndex = 4;
            panelViewOrder.Visible = false;
            // 
            // panelLogout
            // 
            panelLogout.Controls.Add(panel2);
            panelLogout.Controls.Add(logoutNav);
            panelLogout.Location = new Point(3, 816);
            panelLogout.Name = "panelLogout";
            panelLogout.Padding = new Padding(0, 30, 0, 0);
            panelLogout.Size = new Size(297, 80);
            panelLogout.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(8, 8);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(0, 30, 0, 0);
            panel2.Size = new Size(297, 80);
            panel2.TabIndex = 5;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(52, 73, 94);
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(-13, -25);
            button2.Name = "button2";
            button2.Padding = new Padding(25, 0, 0, 0);
            button2.Size = new Size(354, 121);
            button2.TabIndex = 4;
            button2.Text = "         Logout";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(52, 73, 94);
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(-5, -17);
            button1.Name = "button1";
            button1.Padding = new Padding(25, 0, 0, 0);
            button1.Size = new Size(354, 121);
            button1.TabIndex = 3;
            button1.Text = "         Logout";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            // 
            // logoutNav
            // 
            logoutNav.BackColor = Color.FromArgb(52, 73, 94);
            logoutNav.Cursor = Cursors.Hand;
            logoutNav.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logoutNav.ForeColor = Color.White;
            logoutNav.Image = (Image)resources.GetObject("logoutNav.Image");
            logoutNav.ImageAlign = ContentAlignment.MiddleLeft;
            logoutNav.Location = new Point(-5, -17);
            logoutNav.Name = "logoutNav";
            logoutNav.Padding = new Padding(25, 0, 0, 0);
            logoutNav.Size = new Size(354, 121);
            logoutNav.TabIndex = 3;
            logoutNav.Text = "         Logout";
            logoutNav.TextAlign = ContentAlignment.MiddleLeft;
            logoutNav.UseVisualStyleBackColor = false;
            logoutNav.Click += logoutNav_Click;
            // 
            // panelDashboard
            // 
            panelDashboard.Controls.Add(dashboardNav);
            panelDashboard.Location = new Point(0, 67);
            panelDashboard.Name = "panelDashboard";
            panelDashboard.Padding = new Padding(0, 30, 0, 0);
            panelDashboard.Size = new Size(297, 80);
            panelDashboard.TabIndex = 4;
            // 
            // dashboardNav
            // 
            dashboardNav.BackColor = Color.FromArgb(52, 73, 94);
            dashboardNav.Cursor = Cursors.Hand;
            dashboardNav.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dashboardNav.ForeColor = Color.White;
            dashboardNav.Image = (Image)resources.GetObject("dashboardNav.Image");
            dashboardNav.ImageAlign = ContentAlignment.MiddleLeft;
            dashboardNav.Location = new Point(-5, -17);
            dashboardNav.Name = "dashboardNav";
            dashboardNav.Padding = new Padding(25, 0, 0, 0);
            dashboardNav.Size = new Size(354, 121);
            dashboardNav.TabIndex = 3;
            dashboardNav.Text = "         Dashboard";
            dashboardNav.TextAlign = ContentAlignment.MiddleLeft;
            dashboardNav.UseVisualStyleBackColor = false;
            dashboardNav.Click += dashboardNav_Click;
            // 
            // panelCars
            // 
            panelCars.Controls.Add(carNav);
            panelCars.Location = new Point(0, 151);
            panelCars.Name = "panelCars";
            panelCars.Padding = new Padding(0, 30, 0, 0);
            panelCars.Size = new Size(297, 80);
            panelCars.TabIndex = 4;
            // 
            // carNav
            // 
            carNav.BackColor = Color.FromArgb(52, 73, 94);
            carNav.Cursor = Cursors.Hand;
            carNav.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            carNav.ForeColor = Color.White;
            carNav.Image = (Image)resources.GetObject("carNav.Image");
            carNav.ImageAlign = ContentAlignment.MiddleLeft;
            carNav.Location = new Point(-5, -17);
            carNav.Name = "carNav";
            carNav.Padding = new Padding(25, 0, 0, 0);
            carNav.Size = new Size(354, 121);
            carNav.TabIndex = 3;
            carNav.Text = "         Cars";
            carNav.TextAlign = ContentAlignment.MiddleLeft;
            carNav.UseVisualStyleBackColor = false;
            carNav.Click += carNav_Click;
            // 
            // panelOrders
            // 
            panelOrders.Controls.Add(orderNav);
            panelOrders.Location = new Point(2, 406);
            panelOrders.Name = "panelOrders";
            panelOrders.Padding = new Padding(0, 30, 0, 0);
            panelOrders.Size = new Size(297, 80);
            panelOrders.TabIndex = 4;
            // 
            // orderNav
            // 
            orderNav.BackColor = Color.FromArgb(52, 73, 94);
            orderNav.Cursor = Cursors.Hand;
            orderNav.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            orderNav.ForeColor = Color.White;
            orderNav.Image = (Image)resources.GetObject("orderNav.Image");
            orderNav.ImageAlign = ContentAlignment.MiddleLeft;
            orderNav.Location = new Point(-5, -17);
            orderNav.Name = "orderNav";
            orderNav.Padding = new Padding(25, 0, 0, 0);
            orderNav.Size = new Size(354, 121);
            orderNav.TabIndex = 3;
            orderNav.Text = "         Orders";
            orderNav.TextAlign = ContentAlignment.MiddleLeft;
            orderNav.UseVisualStyleBackColor = false;
            orderNav.Click += orderNav_Click;
            // 
            // panelCarParts
            // 
            panelCarParts.Controls.Add(carPartsNav);
            panelCarParts.Location = new Point(1, 235);
            panelCarParts.Name = "panelCarParts";
            panelCarParts.Padding = new Padding(0, 30, 0, 0);
            panelCarParts.Size = new Size(297, 80);
            panelCarParts.TabIndex = 4;
            // 
            // carPartsNav
            // 
            carPartsNav.BackColor = Color.FromArgb(52, 73, 94);
            carPartsNav.Cursor = Cursors.Hand;
            carPartsNav.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            carPartsNav.ForeColor = Color.White;
            carPartsNav.Image = (Image)resources.GetObject("carPartsNav.Image");
            carPartsNav.ImageAlign = ContentAlignment.MiddleLeft;
            carPartsNav.Location = new Point(-5, -17);
            carPartsNav.Name = "carPartsNav";
            carPartsNav.Padding = new Padding(25, 0, 0, 0);
            carPartsNav.Size = new Size(354, 121);
            carPartsNav.TabIndex = 3;
            carPartsNav.Text = "         Car Parts";
            carPartsNav.TextAlign = ContentAlignment.MiddleLeft;
            carPartsNav.UseVisualStyleBackColor = false;
            carPartsNav.Click += carPartsNav_Click;
            // 
            // panelCustomers
            // 
            panelCustomers.Controls.Add(customerNav);
            panelCustomers.Location = new Point(2, 320);
            panelCustomers.Name = "panelCustomers";
            panelCustomers.Padding = new Padding(0, 30, 0, 0);
            panelCustomers.Size = new Size(297, 80);
            panelCustomers.TabIndex = 4;
            // 
            // customerNav
            // 
            customerNav.BackColor = Color.FromArgb(52, 73, 94);
            customerNav.Cursor = Cursors.Hand;
            customerNav.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customerNav.ForeColor = Color.White;
            customerNav.Image = (Image)resources.GetObject("customerNav.Image");
            customerNav.ImageAlign = ContentAlignment.MiddleLeft;
            customerNav.Location = new Point(-5, -17);
            customerNav.Name = "customerNav";
            customerNav.Padding = new Padding(25, 0, 0, 0);
            customerNav.Size = new Size(354, 121);
            customerNav.TabIndex = 3;
            customerNav.Text = "         Customers";
            customerNav.TextAlign = ContentAlignment.MiddleLeft;
            customerNav.UseVisualStyleBackColor = false;
            customerNav.Click += customerNav_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(labelNav);
            panel3.Controls.Add(labelHead);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(300, 75);
            panel3.Name = "panel3";
            panel3.Size = new Size(1575, 69);
            panel3.TabIndex = 2;
            // 
            // labelNav
            // 
            labelNav.AutoSize = true;
            labelNav.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNav.Location = new Point(1305, 20);
            labelNav.Name = "labelNav";
            labelNav.Size = new Size(138, 32);
            labelNav.TabIndex = 2;
            labelNav.Text = "Dashboard";
            // 
            // labelHead
            // 
            labelHead.AutoSize = true;
            labelHead.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHead.Location = new Point(6, 20);
            labelHead.Name = "labelHead";
            labelHead.Size = new Size(82, 32);
            labelHead.TabIndex = 0;
            labelHead.Text = "Home";
            // 
            // sidebarTransition
            // 
            sidebarTransition.Interval = 10;
            sidebarTransition.Tick += sidebarTransition_Tick;
            // 
            // reportTransition
            // 
            reportTransition.Tick += reportTransition_Tick;
            // 
            // mainPanel
            // 
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(300, 144);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1575, 830);
            mainPanel.TabIndex = 4;
            // 
            // Dashboard
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1875, 974);
            Controls.Add(mainPanel);
            Controls.Add(panel3);
            Controls.Add(sidebarPanel);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Name = "Dashboard";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            sidebarPanel.ResumeLayout(false);
            panelViewCustomerOrders.ResumeLayout(false);
            panel4.ResumeLayout(false);
            reportContainer.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panelLogout.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panelDashboard.ResumeLayout(false);
            panelCars.ResumeLayout(false);
            panelOrders.ResumeLayout(false);
            panelCarParts.ResumeLayout(false);
            panelCustomers.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel sidebarPanel;
        private Panel panel3;
        private Label labelMain;
        private Button btnHam;
        private Label labelHead;
        private Label label3;
        private System.Windows.Forms.Timer sidebarTransition;
        private Button carPartsNav;
        private Button dashboardNav;
        private Panel panelDashboard;
        private Panel panelCars;
        private Button carNav;
        private Panel panelCarParts;
        private Panel panelCustomers;
        private Button customerNav;
        private Panel panelOrders;
        private Button orderNav;
        private Panel panel8;
        private Button reportNav;
        private FlowLayoutPanel reportContainer;
        private Panel panel9;
        private Button customerReportNav;
        private Panel panelViewOrder;
        private System.Windows.Forms.Timer reportTransition;
        private Panel panelLogout;
        private Button logoutNav;
        private Panel mainPanel;
        private Button btnAppClose;
        private Button btnAppMin;
        private Panel panel4;
        private Button manageUserNave;
        private Panel panel2;
        private Button button2;
        private Button button1;
        private Label labelNav;
        private Panel panelViewCustomerOrders;
        private Button viewOrdersNav;
    }
}