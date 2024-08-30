namespace CarTraders
{
    partial class Form_Checkout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Checkout));
            panelMain = new Panel();
            panelCustomerInformation = new Panel();
            groupBox1 = new GroupBox();
            panelCustomer = new Panel();
            pictureBoxLoading = new PictureBox();
            textCity = new TextBox();
            label6 = new Label();
            textAddress = new TextBox();
            label5 = new Label();
            textNIC = new TextBox();
            label4 = new Label();
            textContact = new TextBox();
            label3 = new Label();
            textEmail = new TextBox();
            label2 = new Label();
            textName = new TextBox();
            label1 = new Label();
            panelCheckout = new Panel();
            orderDetailsBox = new GroupBox();
            orderPanel = new Panel();
            dataView = new DataGridView();
            button2 = new Button();
            button1 = new Button();
            panelMain.SuspendLayout();
            panelCustomerInformation.SuspendLayout();
            groupBox1.SuspendLayout();
            panelCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLoading).BeginInit();
            panelCheckout.SuspendLayout();
            orderDetailsBox.SuspendLayout();
            orderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataView).BeginInit();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.Controls.Add(panelCustomerInformation);
            panelMain.Controls.Add(panelCheckout);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1545, 921);
            panelMain.TabIndex = 0;
            // 
            // panelCustomerInformation
            // 
            panelCustomerInformation.BackColor = Color.White;
            panelCustomerInformation.Controls.Add(groupBox1);
            panelCustomerInformation.Dock = DockStyle.Fill;
            panelCustomerInformation.Location = new Point(0, 0);
            panelCustomerInformation.Name = "panelCustomerInformation";
            panelCustomerInformation.Size = new Size(942, 921);
            panelCustomerInformation.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(panelCustomer);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(52, 73, 94);
            groupBox1.Location = new Point(16, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(906, 744);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Customer Details";
            // 
            // panelCustomer
            // 
            panelCustomer.Controls.Add(pictureBoxLoading);
            panelCustomer.Controls.Add(textCity);
            panelCustomer.Controls.Add(label6);
            panelCustomer.Controls.Add(textAddress);
            panelCustomer.Controls.Add(label5);
            panelCustomer.Controls.Add(textNIC);
            panelCustomer.Controls.Add(label4);
            panelCustomer.Controls.Add(textContact);
            panelCustomer.Controls.Add(label3);
            panelCustomer.Controls.Add(textEmail);
            panelCustomer.Controls.Add(label2);
            panelCustomer.Controls.Add(textName);
            panelCustomer.Controls.Add(label1);
            panelCustomer.Location = new Point(22, 61);
            panelCustomer.Name = "panelCustomer";
            panelCustomer.Size = new Size(867, 656);
            panelCustomer.TabIndex = 0;
            // 
            // pictureBoxLoading
            // 
            pictureBoxLoading.BackColor = Color.Transparent;
            pictureBoxLoading.BorderStyle = BorderStyle.Fixed3D;
            pictureBoxLoading.Image = (Image)resources.GetObject("pictureBoxLoading.Image");
            pictureBoxLoading.Location = new Point(271, 276);
            pictureBoxLoading.Name = "pictureBoxLoading";
            pictureBoxLoading.Size = new Size(685, 524);
            pictureBoxLoading.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLoading.TabIndex = 4;
            pictureBoxLoading.TabStop = false;
            pictureBoxLoading.Visible = false;
            // 
            // textCity
            // 
            textCity.BorderStyle = BorderStyle.None;
            textCity.Enabled = false;
            textCity.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            textCity.ForeColor = SystemColors.WindowFrame;
            textCity.Location = new Point(35, 585);
            textCity.Multiline = true;
            textCity.Name = "textCity";
            textCity.Size = new Size(589, 31);
            textCity.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9F);
            label6.Location = new Point(35, 546);
            label6.Name = "label6";
            label6.Size = new Size(123, 21);
            label6.TabIndex = 10;
            label6.Text = "Customer City";
            // 
            // textAddress
            // 
            textAddress.BorderStyle = BorderStyle.None;
            textAddress.Enabled = false;
            textAddress.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            textAddress.ForeColor = SystemColors.WindowFrame;
            textAddress.Location = new Point(35, 489);
            textAddress.Multiline = true;
            textAddress.Name = "textAddress";
            textAddress.Size = new Size(589, 31);
            textAddress.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9F);
            label5.Location = new Point(35, 450);
            label5.Name = "label5";
            label5.Size = new Size(156, 21);
            label5.TabIndex = 8;
            label5.Text = "Customer Address";
            // 
            // textNIC
            // 
            textNIC.BorderStyle = BorderStyle.None;
            textNIC.Enabled = false;
            textNIC.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            textNIC.ForeColor = SystemColors.WindowFrame;
            textNIC.Location = new Point(35, 392);
            textNIC.Multiline = true;
            textNIC.Name = "textNIC";
            textNIC.Size = new Size(589, 31);
            textNIC.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9F);
            label4.Location = new Point(35, 353);
            label4.Name = "label4";
            label4.Size = new Size(122, 21);
            label4.TabIndex = 6;
            label4.Text = "Customer NIC";
            // 
            // textContact
            // 
            textContact.BorderStyle = BorderStyle.None;
            textContact.Enabled = false;
            textContact.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            textContact.ForeColor = SystemColors.WindowFrame;
            textContact.Location = new Point(35, 297);
            textContact.Multiline = true;
            textContact.Name = "textContact";
            textContact.Size = new Size(589, 31);
            textContact.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9F);
            label3.Location = new Point(35, 258);
            label3.Name = "label3";
            label3.Size = new Size(182, 21);
            label3.TabIndex = 4;
            label3.Text = "Customer Contact No";
            // 
            // textEmail
            // 
            textEmail.BorderStyle = BorderStyle.None;
            textEmail.Enabled = false;
            textEmail.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            textEmail.ForeColor = SystemColors.WindowFrame;
            textEmail.Location = new Point(35, 198);
            textEmail.Multiline = true;
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(589, 31);
            textEmail.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9F);
            label2.Location = new Point(35, 159);
            label2.Name = "label2";
            label2.Size = new Size(136, 21);
            label2.TabIndex = 2;
            label2.Text = "Customer Email";
            // 
            // textName
            // 
            textName.BorderStyle = BorderStyle.None;
            textName.Enabled = false;
            textName.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            textName.ForeColor = SystemColors.WindowFrame;
            textName.Location = new Point(35, 103);
            textName.Multiline = true;
            textName.Name = "textName";
            textName.Size = new Size(589, 31);
            textName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9F);
            label1.Location = new Point(35, 64);
            label1.Name = "label1";
            label1.Size = new Size(139, 21);
            label1.TabIndex = 0;
            label1.Text = "Customer Name";
            // 
            // panelCheckout
            // 
            panelCheckout.Controls.Add(orderDetailsBox);
            panelCheckout.Dock = DockStyle.Right;
            panelCheckout.Location = new Point(942, 0);
            panelCheckout.Name = "panelCheckout";
            panelCheckout.Size = new Size(603, 921);
            panelCheckout.TabIndex = 0;
            // 
            // orderDetailsBox
            // 
            orderDetailsBox.Controls.Add(orderPanel);
            orderDetailsBox.Controls.Add(button2);
            orderDetailsBox.Controls.Add(button1);
            orderDetailsBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            orderDetailsBox.ForeColor = Color.FromArgb(52, 73, 94);
            orderDetailsBox.Location = new Point(13, 36);
            orderDetailsBox.Name = "orderDetailsBox";
            orderDetailsBox.Size = new Size(579, 873);
            orderDetailsBox.TabIndex = 0;
            orderDetailsBox.TabStop = false;
            orderDetailsBox.Text = "Order Details";
            // 
            // orderPanel
            // 
            orderPanel.AutoScroll = true;
            orderPanel.AutoScrollMinSize = new Size(0, 580);
            orderPanel.BorderStyle = BorderStyle.FixedSingle;
            orderPanel.Controls.Add(dataView);
            orderPanel.Location = new Point(20, 55);
            orderPanel.Name = "orderPanel";
            orderPanel.Size = new Size(545, 585);
            orderPanel.TabIndex = 2;
            // 
            // dataView
            // 
            dataView.AllowUserToAddRows = false;
            dataView.AllowUserToDeleteRows = false;
            dataView.AllowUserToResizeColumns = false;
            dataView.AllowUserToResizeRows = false;
            dataView.BackgroundColor = Color.White;
            dataView.BorderStyle = BorderStyle.None;
            dataView.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dataView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataView.EnableHeadersVisualStyles = false;
            dataView.Location = new Point(9, 25);
            dataView.MultiSelect = false;
            dataView.Name = "dataView";
            dataView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataView.RowHeadersVisible = false;
            dataView.RowHeadersWidth = 62;
            dataView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataView.Size = new Size(527, 548);
            dataView.TabIndex = 0;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkRed;
            button2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(20, 762);
            button2.Name = "button2";
            button2.Size = new Size(545, 85);
            button2.TabIndex = 1;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(52, 73, 94);
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(20, 656);
            button1.Name = "button1";
            button1.Size = new Size(545, 94);
            button1.TabIndex = 0;
            button1.Text = "Checkout";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form_Checkout
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1545, 921);
            Controls.Add(panelMain);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_Checkout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_Checkout";
            Load += Form_Checkout_Load;
            panelMain.ResumeLayout(false);
            panelCustomerInformation.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            panelCustomer.ResumeLayout(false);
            panelCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLoading).EndInit();
            panelCheckout.ResumeLayout(false);
            orderDetailsBox.ResumeLayout(false);
            orderPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMain;
        private Panel panelCustomerInformation;
        private Panel panelCheckout;
        private Panel panelPaymentInformation;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private GroupBox orderDetailsBox;
        private Panel panelCustomer;
        private Label label1;
        private TextBox textNIC;
        private Label label4;
        private TextBox textContact;
        private Label label3;
        private TextBox textEmail;
        private Label label2;
        private TextBox textName;
        private TextBox textCity;
        private Label label6;
        private TextBox textAddress;
        private Label label5;
        private Button button1;
        private Panel orderPanel;
        private Button button2;
        private DataGridView dataView;
        private PictureBox pictureBoxLoading;
    }
}