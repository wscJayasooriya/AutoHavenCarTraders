namespace CarTraders
{
    partial class Form_Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            lblForgot = new Label();
            btnRegister = new Button();
            txtPassword = new TextBox();
            panel4 = new Panel();
            pictureBox3 = new PictureBox();
            txtUserName = new TextBox();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            BtnLogin = new Button();
            panel2 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(452, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(668, 874);
            panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblForgot);
            groupBox1.Controls.Add(btnRegister);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(panel4);
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(txtUserName);
            groupBox1.Controls.Add(panel3);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(BtnLogin);
            groupBox1.Font = new Font("Century Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(52, 73, 94);
            groupBox1.Location = new Point(42, 109);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(607, 571);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "LOGIN";
            // 
            // lblForgot
            // 
            lblForgot.AutoSize = true;
            lblForgot.BorderStyle = BorderStyle.Fixed3D;
            lblForgot.Cursor = Cursors.Hand;
            lblForgot.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblForgot.Location = new Point(316, 279);
            lblForgot.Name = "lblForgot";
            lblForgot.Size = new Size(217, 25);
            lblForgot.TabIndex = 13;
            lblForgot.Text = "Forgotten Password?";
            lblForgot.Click += lblForgot_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.LimeGreen;
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Century Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(60, 467);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(464, 72);
            btnRegister.TabIndex = 7;
            btnRegister.Text = "Create Account";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Times New Roman", 12F);
            txtPassword.ForeColor = Color.DodgerBlue;
            txtPassword.Location = new Point(126, 226);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(394, 28);
            txtPassword.TabIndex = 12;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(52, 73, 94);
            panel4.Location = new Point(60, 257);
            panel4.Name = "panel4";
            panel4.Size = new Size(464, 5);
            panel4.TabIndex = 11;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(60, 210);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(45, 45);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // txtUserName
            // 
            txtUserName.BorderStyle = BorderStyle.None;
            txtUserName.Font = new Font("Times New Roman", 12F);
            txtUserName.ForeColor = Color.DodgerBlue;
            txtUserName.Location = new Point(126, 145);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(394, 28);
            txtUserName.TabIndex = 9;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(52, 73, 94);
            panel3.Location = new Point(60, 177);
            panel3.Name = "panel3";
            panel3.Size = new Size(464, 5);
            panel3.TabIndex = 8;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(60, 130);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(45, 45);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(164, 419);
            label4.Name = "label4";
            label4.Size = new Size(263, 23);
            label4.TabIndex = 5;
            label4.Text = "Don't Have An Account ?";
            // 
            // BtnLogin
            // 
            BtnLogin.BackColor = Color.FromArgb(52, 73, 94);
            BtnLogin.Cursor = Cursors.Hand;
            BtnLogin.FlatAppearance.BorderSize = 0;
            BtnLogin.FlatStyle = FlatStyle.Flat;
            BtnLogin.Font = new Font("Century Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnLogin.ForeColor = Color.White;
            BtnLogin.Location = new Point(141, 334);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(300, 58);
            BtnLogin.TabIndex = 4;
            BtnLogin.Text = "Login";
            BtnLogin.UseVisualStyleBackColor = false;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(52, 73, 94);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(5, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(449, 874);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(8, 432);
            label1.Name = "label1";
            label1.Size = new Size(433, 62);
            label1.TabIndex = 1;
            label1.Text = "Car Sale System";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(16, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(415, 406);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Form_Login
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(1125, 884);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.DodgerBlue;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Form_Login";
            Padding = new Padding(5);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_Login";
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Label label1;
        private Label label4;
        private Button BtnLogin;
        private PictureBox pictureBox2;
        private Panel panel3;
        private TextBox txtPassword;
        private Panel panel4;
        private PictureBox pictureBox3;
        private TextBox txtUserName;
        private Button btnRegister;
        private Label lblForgot;
    }
}
