namespace CarTraders
{
    partial class Form_Users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Users));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            labelUsername = new Label();
            txtContactNo = new TextBox();
            labelContact = new Label();
            txtNic = new TextBox();
            labelNic = new Label();
            txtFirstName = new TextBox();
            label2 = new Label();
            buttonChooseImage = new Button();
            pictureBox = new PictureBox();
            btnRefresh = new Button();
            panelFull = new Panel();
            panelAddPage = new Panel();
            panelBody = new Panel();
            txtRePassword = new TextBox();
            labelRePassword = new Label();
            txtPassword = new TextBox();
            labelPassowrd = new Label();
            txtUsername = new TextBox();
            txtDepartment = new TextBox();
            labelDepartment = new Label();
            txtCity = new TextBox();
            labelCity = new Label();
            txtEmail = new TextBox();
            labelEmail = new Label();
            txtLastName = new TextBox();
            labelLastName = new Label();
            panelAddTop = new Panel();
            btnModify = new Button();
            labelHead = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            TLPanelTop = new TableLayoutPanel();
            btnAdd = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            txtSearch = new TextBox();
            btnSearch = new Button();
            tableUserView = new DataGridView();
            TimerAdd = new System.Windows.Forms.Timer(components);
            fileSystemWatcher1 = new FileSystemWatcher();
            PnlGrid = new Panel();
            pictureBoxLoading = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            panelFull.SuspendLayout();
            panelAddPage.SuspendLayout();
            panelBody.SuspendLayout();
            panelAddTop.SuspendLayout();
            TLPanelTop.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tableUserView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            PnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLoading).BeginInit();
            SuspendLayout();
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelUsername.ForeColor = Color.White;
            labelUsername.Location = new Point(325, 435);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(99, 28);
            labelUsername.TabIndex = 33;
            labelUsername.Text = "Username";
            // 
            // txtContactNo
            // 
            txtContactNo.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContactNo.Location = new Point(27, 614);
            txtContactNo.Name = "txtContactNo";
            txtContactNo.Size = new Size(252, 37);
            txtContactNo.TabIndex = 7;
            // 
            // labelContact
            // 
            labelContact.AutoSize = true;
            labelContact.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelContact.ForeColor = Color.White;
            labelContact.Location = new Point(29, 582);
            labelContact.Name = "labelContact";
            labelContact.Size = new Size(112, 28);
            labelContact.TabIndex = 6;
            labelContact.Text = "Contact No";
            // 
            // txtNic
            // 
            txtNic.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNic.Location = new Point(27, 692);
            txtNic.Name = "txtNic";
            txtNic.Size = new Size(252, 37);
            txtNic.TabIndex = 5;
            // 
            // labelNic
            // 
            labelNic.AutoSize = true;
            labelNic.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNic.ForeColor = Color.White;
            labelNic.Location = new Point(29, 657);
            labelNic.Name = "labelNic";
            labelNic.Size = new Size(44, 28);
            labelNic.TabIndex = 4;
            labelNic.Text = "NIC";
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstName.Location = new Point(27, 395);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(252, 37);
            txtFirstName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(29, 364);
            label2.Name = "label2";
            label2.Size = new Size(106, 28);
            label2.TabIndex = 2;
            label2.Text = "First Name";
            // 
            // buttonChooseImage
            // 
            buttonChooseImage.Cursor = Cursors.Hand;
            buttonChooseImage.Location = new Point(27, 294);
            buttonChooseImage.Name = "buttonChooseImage";
            buttonChooseImage.Size = new Size(256, 43);
            buttonChooseImage.TabIndex = 1;
            buttonChooseImage.Text = "Choose Image";
            buttonChooseImage.UseVisualStyleBackColor = true;
            buttonChooseImage.Click += buttonChooseImage_Click;
            // 
            // pictureBox
            // 
            pictureBox.BackColor = Color.Transparent;
            pictureBox.BorderStyle = BorderStyle.FixedSingle;
            pictureBox.Image = (Image)resources.GetObject("pictureBox.Image");
            pictureBox.Location = new Point(27, 20);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(256, 256);
            pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(52, 73, 94);
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.Dock = DockStyle.Fill;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Image = (Image)resources.GetObject("btnRefresh.Image");
            btnRefresh.Location = new Point(125, 5);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(114, 80);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "Refresh";
            btnRefresh.TextImageRelation = TextImageRelation.ImageAboveText;
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // panelFull
            // 
            panelFull.BackColor = Color.FromArgb(52, 73, 94);
            panelFull.Controls.Add(panelAddPage);
            panelFull.Controls.Add(panelAddTop);
            panelFull.Dock = DockStyle.Right;
            panelFull.Location = new Point(941, 90);
            panelFull.Name = "panelFull";
            panelFull.Size = new Size(634, 740);
            panelFull.TabIndex = 8;
            // 
            // panelAddPage
            // 
            panelAddPage.AutoScroll = true;
            panelAddPage.Controls.Add(panelBody);
            panelAddPage.Dock = DockStyle.Fill;
            panelAddPage.Location = new Point(0, 85);
            panelAddPage.Margin = new Padding(0);
            panelAddPage.Name = "panelAddPage";
            panelAddPage.Padding = new Padding(10, 5, 10, 5);
            panelAddPage.Size = new Size(634, 655);
            panelAddPage.TabIndex = 1;
            // 
            // panelBody
            // 
            panelBody.AutoScroll = true;
            panelBody.Controls.Add(txtRePassword);
            panelBody.Controls.Add(labelRePassword);
            panelBody.Controls.Add(txtPassword);
            panelBody.Controls.Add(labelPassowrd);
            panelBody.Controls.Add(txtUsername);
            panelBody.Controls.Add(labelUsername);
            panelBody.Controls.Add(txtDepartment);
            panelBody.Controls.Add(labelDepartment);
            panelBody.Controls.Add(txtCity);
            panelBody.Controls.Add(labelCity);
            panelBody.Controls.Add(txtEmail);
            panelBody.Controls.Add(labelEmail);
            panelBody.Controls.Add(txtLastName);
            panelBody.Controls.Add(labelLastName);
            panelBody.Controls.Add(txtContactNo);
            panelBody.Controls.Add(labelContact);
            panelBody.Controls.Add(txtNic);
            panelBody.Controls.Add(labelNic);
            panelBody.Controls.Add(txtFirstName);
            panelBody.Controls.Add(label2);
            panelBody.Controls.Add(buttonChooseImage);
            panelBody.Controls.Add(pictureBox);
            panelBody.Location = new Point(4, 3);
            panelBody.Name = "panelBody";
            panelBody.Size = new Size(600, 981);
            panelBody.TabIndex = 0;
            panelBody.Visible = false;
            // 
            // txtRePassword
            // 
            txtRePassword.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRePassword.Location = new Point(323, 539);
            txtRePassword.Name = "txtRePassword";
            txtRePassword.Size = new Size(252, 37);
            txtRePassword.TabIndex = 38;
            txtRePassword.UseSystemPasswordChar = true;
            // 
            // labelRePassword
            // 
            labelRePassword.AutoSize = true;
            labelRePassword.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelRePassword.ForeColor = Color.White;
            labelRePassword.Location = new Point(325, 508);
            labelRePassword.Name = "labelRePassword";
            labelRePassword.Size = new Size(172, 28);
            labelRePassword.TabIndex = 37;
            labelRePassword.Text = "Re-Enter Password";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(27, 539);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(252, 37);
            txtPassword.TabIndex = 36;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // labelPassowrd
            // 
            labelPassowrd.AutoSize = true;
            labelPassowrd.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPassowrd.ForeColor = Color.White;
            labelPassowrd.Location = new Point(29, 508);
            labelPassowrd.Name = "labelPassowrd";
            labelPassowrd.Size = new Size(93, 28);
            labelPassowrd.TabIndex = 35;
            labelPassowrd.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.Enabled = false;
            txtUsername.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(323, 466);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(252, 37);
            txtUsername.TabIndex = 34;
            // 
            // txtDepartment
            // 
            txtDepartment.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDepartment.Location = new Point(323, 692);
            txtDepartment.Multiline = true;
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(252, 37);
            txtDepartment.TabIndex = 32;
            // 
            // labelDepartment
            // 
            labelDepartment.AutoSize = true;
            labelDepartment.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDepartment.ForeColor = Color.White;
            labelDepartment.Location = new Point(325, 657);
            labelDepartment.Name = "labelDepartment";
            labelDepartment.Size = new Size(117, 28);
            labelDepartment.TabIndex = 31;
            labelDepartment.Text = "Department";
            // 
            // txtCity
            // 
            txtCity.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCity.Location = new Point(323, 614);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(252, 37);
            txtCity.TabIndex = 25;
            // 
            // labelCity
            // 
            labelCity.AutoSize = true;
            labelCity.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCity.ForeColor = Color.White;
            labelCity.Location = new Point(325, 582);
            labelCity.Name = "labelCity";
            labelCity.Size = new Size(46, 28);
            labelCity.TabIndex = 24;
            labelCity.Text = "City";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(27, 466);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(252, 37);
            txtEmail.TabIndex = 23;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelEmail.ForeColor = Color.White;
            labelEmail.Location = new Point(29, 435);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(59, 28);
            labelEmail.TabIndex = 22;
            labelEmail.Text = "Email";
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.Location = new Point(323, 395);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(252, 37);
            txtLastName.TabIndex = 21;
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelLastName.ForeColor = Color.White;
            labelLastName.Location = new Point(325, 364);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(103, 28);
            labelLastName.TabIndex = 20;
            labelLastName.Text = "Last Name";
            // 
            // panelAddTop
            // 
            panelAddTop.Controls.Add(btnModify);
            panelAddTop.Controls.Add(labelHead);
            panelAddTop.Controls.Add(btnCancel);
            panelAddTop.Controls.Add(btnSave);
            panelAddTop.Dock = DockStyle.Top;
            panelAddTop.Location = new Point(0, 0);
            panelAddTop.Name = "panelAddTop";
            panelAddTop.Size = new Size(634, 85);
            panelAddTop.TabIndex = 0;
            // 
            // btnModify
            // 
            btnModify.BackColor = Color.FromArgb(52, 73, 94);
            btnModify.Cursor = Cursors.Hand;
            btnModify.Dock = DockStyle.Left;
            btnModify.FlatAppearance.BorderSize = 0;
            btnModify.FlatStyle = FlatStyle.Flat;
            btnModify.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnModify.ForeColor = Color.White;
            btnModify.Image = (Image)resources.GetObject("btnModify.Image");
            btnModify.Location = new Point(170, 0);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(85, 85);
            btnModify.TabIndex = 8;
            btnModify.Text = "Edit";
            btnModify.TextImageRelation = TextImageRelation.ImageAboveText;
            btnModify.UseVisualStyleBackColor = false;
            btnModify.Visible = false;
            btnModify.Click += btnModify_Click;
            // 
            // labelHead
            // 
            labelHead.AutoSize = true;
            labelHead.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHead.ForeColor = Color.White;
            labelHead.Location = new Point(329, 20);
            labelHead.Name = "labelHead";
            labelHead.Size = new Size(204, 38);
            labelHead.TabIndex = 5;
            labelHead.Text = "Add New User";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(52, 73, 94);
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.Dock = DockStyle.Left;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Image = (Image)resources.GetObject("btnCancel.Image");
            btnCancel.Location = new Point(85, 0);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(85, 85);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(52, 73, 94);
            btnSave.Cursor = Cursors.Hand;
            btnSave.Dock = DockStyle.Left;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.Location = new Point(0, 0);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(85, 85);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.TextImageRelation = TextImageRelation.ImageAboveText;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // TLPanelTop
            // 
            TLPanelTop.ColumnCount = 3;
            TLPanelTop.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            TLPanelTop.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            TLPanelTop.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            TLPanelTop.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            TLPanelTop.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            TLPanelTop.Controls.Add(btnRefresh, 1, 0);
            TLPanelTop.Controls.Add(btnAdd, 0, 0);
            TLPanelTop.Controls.Add(panel1, 4, 0);
            TLPanelTop.Dock = DockStyle.Top;
            TLPanelTop.Enabled = false;
            TLPanelTop.Location = new Point(0, 0);
            TLPanelTop.Name = "TLPanelTop";
            TLPanelTop.Padding = new Padding(2);
            TLPanelTop.RowCount = 1;
            TLPanelTop.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TLPanelTop.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TLPanelTop.Size = new Size(1575, 90);
            TLPanelTop.TabIndex = 7;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(52, 73, 94);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.Dock = DockStyle.Fill;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.Location = new Point(5, 5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(114, 80);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add New";
            btnAdd.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(52, 73, 94);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnSearch);
            panel1.Location = new Point(245, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1325, 80);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(txtSearch);
            panel2.Location = new Point(826, 13);
            panel2.Name = "panel2";
            panel2.Size = new Size(416, 55);
            panel2.TabIndex = 9;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(7, 9);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(406, 40);
            txtSearch.TabIndex = 6;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(52, 73, 94);
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.Location = new Point(1245, 13);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(55, 55);
            btnSearch.TabIndex = 2;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // tableUserView
            // 
            tableUserView.AllowUserToAddRows = false;
            tableUserView.AllowUserToDeleteRows = false;
            tableUserView.AllowUserToResizeColumns = false;
            tableUserView.AllowUserToResizeRows = false;
            tableUserView.BackgroundColor = Color.White;
            tableUserView.BorderStyle = BorderStyle.None;
            tableUserView.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            tableUserView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(52, 73, 94);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            tableUserView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            tableUserView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableUserView.EnableHeadersVisualStyles = false;
            tableUserView.Location = new Point(24, 119);
            tableUserView.Margin = new Padding(15);
            tableUserView.MultiSelect = false;
            tableUserView.Name = "tableUserView";
            tableUserView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            tableUserView.RowHeadersVisible = false;
            tableUserView.RowHeadersWidth = 62;
            tableUserView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tableUserView.Size = new Size(882, 404);
            tableUserView.TabIndex = 1;
            // 
            // TimerAdd
            // 
            TimerAdd.Tick += TimerAdd_Tick;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // PnlGrid
            // 
            PnlGrid.BackColor = Color.White;
            PnlGrid.Controls.Add(pictureBoxLoading);
            PnlGrid.Controls.Add(tableUserView);
            PnlGrid.Dock = DockStyle.Fill;
            PnlGrid.Location = new Point(0, 0);
            PnlGrid.Name = "PnlGrid";
            PnlGrid.Size = new Size(1575, 830);
            PnlGrid.TabIndex = 9;
            // 
            // pictureBoxLoading
            // 
            pictureBoxLoading.BackColor = Color.Transparent;
            pictureBoxLoading.Image = (Image)resources.GetObject("pictureBoxLoading.Image");
            pictureBoxLoading.Location = new Point(571, 542);
            pictureBoxLoading.Name = "pictureBoxLoading";
            pictureBoxLoading.Size = new Size(325, 280);
            pictureBoxLoading.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLoading.TabIndex = 2;
            pictureBoxLoading.TabStop = false;
            pictureBoxLoading.Visible = false;
            // 
            // Form_Users
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1575, 830);
            Controls.Add(panelFull);
            Controls.Add(TLPanelTop);
            Controls.Add(PnlGrid);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_Users";
            Text = "Form_Users";
            Load += Form_Users_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            panelFull.ResumeLayout(false);
            panelAddPage.ResumeLayout(false);
            panelBody.ResumeLayout(false);
            panelBody.PerformLayout();
            panelAddTop.ResumeLayout(false);
            panelAddTop.PerformLayout();
            TLPanelTop.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tableUserView).EndInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            PnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLoading).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label labelUsername;
        private TextBox txtContactNo;
        private Label labelContact;
        private TextBox txtNic;
        private Label labelNic;
        private TextBox txtFirstName;
        private Label label2;
        private Button buttonChooseImage;
        private PictureBox pictureBox;
        private Button btnRefresh;
        private Panel panelFull;
        private Panel panelAddPage;
        private Panel panelBody;
        private TextBox txtRePassword;
        private Label labelRePassword;
        private TextBox txtPassword;
        private Label labelPassowrd;
        private TextBox txtUsername;
        private TextBox txtDepartment;
        private Label labelDepartment;
        private TextBox txtCity;
        private Label labelCity;
        private TextBox txtEmail;
        private Label labelEmail;
        private TextBox txtLastName;
        private Label labelLastName;
        private Panel panelAddTop;
        private Button btnModify;
        private Label labelHead;
        private Button btnCancel;
        private Button btnSave;
        private TableLayoutPanel TLPanelTop;
        private Button btnAdd;
        private Panel panel1;
        private Panel panel2;
        private TextBox txtSearch;
        private Button btnSearch;
        private DataGridView tableUserView;
        private System.Windows.Forms.Timer TimerAdd;
        private FileSystemWatcher fileSystemWatcher1;
        private Panel PnlGrid;
        private PictureBox pictureBoxLoading;
    }
}