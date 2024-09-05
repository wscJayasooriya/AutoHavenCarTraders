namespace CarTraders
{
    partial class Form_Forgotten_Password
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Forgotten_Password));
            panelMain = new Panel();
            btnSendOtp = new Button();
            label4 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnClose = new Button();
            panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.White;
            panelMain.Controls.Add(btnClose);
            panelMain.Controls.Add(btnSendOtp);
            panelMain.Controls.Add(label4);
            panelMain.Controls.Add(txtEmail);
            panelMain.Controls.Add(label3);
            panelMain.Controls.Add(label2);
            panelMain.Controls.Add(label1);
            panelMain.Controls.Add(pictureBox1);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1000, 505);
            panelMain.TabIndex = 0;
            // 
            // btnSendOtp
            // 
            btnSendOtp.BackColor = Color.FromArgb(52, 73, 94);
            btnSendOtp.Cursor = Cursors.Hand;
            btnSendOtp.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSendOtp.ForeColor = Color.White;
            btnSendOtp.Location = new Point(325, 439);
            btnSendOtp.Name = "btnSendOtp";
            btnSendOtp.Size = new Size(350, 54);
            btnSendOtp.TabIndex = 6;
            btnSendOtp.Text = "Send OTP";
            btnSendOtp.UseVisualStyleBackColor = false;
            btnSendOtp.Click += btnSendOtp_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(398, 335);
            label4.Name = "label4";
            label4.Size = new Size(203, 32);
            label4.TabIndex = 5;
            label4.Text = "Enter Your Email";
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.BackColor = Color.White;
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.ForeColor = SystemColors.Highlight;
            txtEmail.Location = new Point(177, 381);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(645, 39);
            txtEmail.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(251, 285);
            label3.Name = "label3";
            label3.Size = new Size(498, 32);
            label3.TabIndex = 3;
            label3.Text = "allowing you to securely reset your password.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(177, 240);
            label2.Name = "label2";
            label2.Size = new Size(645, 32);
            label2.TabIndex = 2;
            label2.Text = "Please enter your registered email. We'll send a secure OTP";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 26F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(265, 176);
            label1.Name = "label1";
            label1.Size = new Size(471, 64);
            label1.TabIndex = 1;
            label1.Text = "Reset Your Password";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(425, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Red;
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(959, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(41, 40);
            btnClose.TabIndex = 12;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // Form_Forgotten_Password
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 505);
            Controls.Add(panelMain);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_Forgotten_Password";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_Forgotten_Password";
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMain;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label4;
        private TextBox txtEmail;
        private Label label3;
        private Label label2;
        private Button btnSendOtp;
        private Button btnClose;
    }
}