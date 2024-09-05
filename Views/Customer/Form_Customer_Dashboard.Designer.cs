namespace CarTraders.Views.Customer
{
    partial class Form_Customer_Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Customer_Dashboard));
            panelMain = new Panel();
            panel5 = new Panel();
            label5 = new Label();
            label3 = new Label();
            lableUsername = new Label();
            panel4 = new Panel();
            labelPendingOrderCount = new Label();
            label8 = new Label();
            pictureBox4 = new PictureBox();
            panel3 = new Panel();
            labelCarPartCount = new Label();
            label6 = new Label();
            pictureBox3 = new PictureBox();
            panel2 = new Panel();
            labelCarCount = new Label();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            labelCompleteOrders = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            CountTimer = new System.Windows.Forms.Timer(components);
            panelMain.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.Controls.Add(panel5);
            panelMain.Controls.Add(panel4);
            panelMain.Controls.Add(panel3);
            panelMain.Controls.Add(panel2);
            panelMain.Controls.Add(panel1);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1575, 830);
            panelMain.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ActiveBorder;
            panel5.Controls.Add(label5);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(lableUsername);
            panel5.Location = new Point(181, 311);
            panel5.Name = "panel5";
            panel5.Size = new Size(1274, 455);
            panel5.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(124, 295);
            label5.Name = "label5";
            label5.Size = new Size(1026, 96);
            label5.TabIndex = 14;
            label5.Text = "ABC Car and Car Part Traders";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(420, 177);
            label3.Name = "label3";
            label3.Size = new Size(445, 96);
            label3.TabIndex = 13;
            label3.Text = "Welcome to";
            // 
            // lableUsername
            // 
            lableUsername.AutoSize = true;
            lableUsername.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lableUsername.Location = new Point(293, 63);
            lableUsername.Name = "lableUsername";
            lableUsername.Size = new Size(0, 96);
            lableUsername.TabIndex = 12;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(250, 229, 211);
            panel4.Controls.Add(labelPendingOrderCount);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(pictureBox4);
            panel4.Location = new Point(806, 60);
            panel4.Name = "panel4";
            panel4.Size = new Size(350, 135);
            panel4.TabIndex = 6;
            // 
            // labelPendingOrderCount
            // 
            labelPendingOrderCount.AutoSize = true;
            labelPendingOrderCount.Font = new Font("Sitka Small", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPendingOrderCount.Location = new Point(159, 62);
            labelPendingOrderCount.Name = "labelPendingOrderCount";
            labelPendingOrderCount.Size = new Size(87, 63);
            labelPendingOrderCount.TabIndex = 3;
            labelPendingOrderCount.Text = "00";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(133, 24);
            label8.Name = "label8";
            label8.Size = new Size(213, 38);
            label8.TabIndex = 2;
            label8.Text = "Pending Orders";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(10, 10);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(115, 115);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(212, 239, 223);
            panel3.Controls.Add(labelCarPartCount);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(pictureBox3);
            panel3.Location = new Point(416, 60);
            panel3.Name = "panel3";
            panel3.Size = new Size(350, 135);
            panel3.TabIndex = 7;
            // 
            // labelCarPartCount
            // 
            labelCarPartCount.AutoSize = true;
            labelCarPartCount.Font = new Font("Sitka Small", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCarPartCount.Location = new Point(159, 62);
            labelCarPartCount.Name = "labelCarPartCount";
            labelCarPartCount.Size = new Size(87, 63);
            labelCarPartCount.TabIndex = 3;
            labelCarPartCount.Text = "00";
            labelCarPartCount.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(165, 24);
            label6.Name = "label6";
            label6.Size = new Size(130, 38);
            label6.TabIndex = 2;
            label6.Text = "Car Parts";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(10, 10);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(115, 115);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(212, 230, 241);
            panel2.Controls.Add(labelCarCount);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(26, 60);
            panel2.Name = "panel2";
            panel2.Size = new Size(350, 135);
            panel2.TabIndex = 8;
            // 
            // labelCarCount
            // 
            labelCarCount.AutoSize = true;
            labelCarCount.Font = new Font("Sitka Small", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCarCount.Location = new Point(159, 62);
            labelCarCount.Name = "labelCarCount";
            labelCarCount.Size = new Size(87, 63);
            labelCarCount.TabIndex = 3;
            labelCarCount.Text = "00";
            labelCarCount.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(165, 24);
            label4.Name = "label4";
            label4.Size = new Size(71, 38);
            label4.TabIndex = 2;
            label4.Text = "Cars";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(10, 10);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(115, 115);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(235, 222, 240);
            panel1.Controls.Add(labelCompleteOrders);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(1199, 60);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 135);
            panel1.TabIndex = 5;
            // 
            // labelCompleteOrders
            // 
            labelCompleteOrders.AutoSize = true;
            labelCompleteOrders.Font = new Font("Sitka Small", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCompleteOrders.Location = new Point(159, 62);
            labelCompleteOrders.Name = "labelCompleteOrders";
            labelCompleteOrders.Size = new Size(87, 63);
            labelCompleteOrders.TabIndex = 3;
            labelCompleteOrders.Text = "00";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(115, 20);
            label1.Name = "label1";
            label1.Size = new Size(233, 38);
            label1.TabIndex = 2;
            label1.Text = "Complete Orders";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(10, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(115, 115);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // CountTimer
            // 
            CountTimer.Tick += CountTimer_Tick;
            // 
            // Form_Customer_Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            ClientSize = new Size(1575, 830);
            Controls.Add(panelMain);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_Customer_Dashboard";
            Text = "Form_Customer_Dashboard";
            Load += Form_Customer_Dashboard_Load;
            panelMain.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMain;
        private Panel panel4;
        private Label labelPendingOrderCount;
        private Label label8;
        private PictureBox pictureBox4;
        private Panel panel3;
        private Label labelCarPartCount;
        private Label label6;
        private PictureBox pictureBox3;
        private Panel panel2;
        private Label labelCarCount;
        private Label label4;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Label labelCompleteOrders;
        private Label label1;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer CountTimer;
        private Panel panel5;
        private Label label5;
        private Label label3;
        private Label lableUsername;
    }
}