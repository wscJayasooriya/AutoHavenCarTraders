namespace CarTraders
{
    partial class Form_Cars
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Cars));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            panel2 = new Panel();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnAdd = new Button();
            TLPanelTop = new TableLayoutPanel();
            btnRefresh = new Button();
            panelFull = new Panel();
            panelAddPage = new Panel();
            panelBody = new Panel();
            txtSpecification = new TextBox();
            labelSpec = new Label();
            txtPrice = new TextBox();
            labelPrice = new Label();
            dateRegistration = new DateTimePicker();
            labelRegisterDate = new Label();
            txtOwnerContact = new TextBox();
            labelOwnerContact = new Label();
            txtNic = new TextBox();
            labelOwnerNic = new Label();
            txtOwnerName = new TextBox();
            labelOwnerName = new Label();
            txtOwners = new TextBox();
            labelOwners = new Label();
            comboCondition = new ComboBox();
            label9 = new Label();
            comboFuel = new ComboBox();
            label8 = new Label();
            txtMileage = new TextBox();
            label7 = new Label();
            comboTransmission = new ComboBox();
            comboEngine = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            txtColor = new TextBox();
            label4 = new Label();
            txtManufacture = new TextBox();
            label3 = new Label();
            txtCarModel = new TextBox();
            label2 = new Label();
            buttonChooseImage = new Button();
            pictureBox = new PictureBox();
            panelAddTop = new Panel();
            btnModify = new Button();
            labelHead = new Label();
            btnCancel = new Button();
            btnCarSave = new Button();
            fileSystemWatcher1 = new FileSystemWatcher();
            TimerAdd = new System.Windows.Forms.Timer(components);
            PnlGrid = new Panel();
            pictureBoxLoading = new PictureBox();
            tableCarView = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            TLPanelTop.SuspendLayout();
            panelFull.SuspendLayout();
            panelAddPage.SuspendLayout();
            panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            panelAddTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            PnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLoading).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tableCarView).BeginInit();
            SuspendLayout();
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
            panel2.Location = new Point(829, 13);
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
            btnSearch.Location = new Point(1248, 13);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(55, 55);
            btnSearch.TabIndex = 2;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
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
            TLPanelTop.Location = new Point(0, 0);
            TLPanelTop.Name = "TLPanelTop";
            TLPanelTop.Padding = new Padding(2);
            TLPanelTop.RowCount = 1;
            TLPanelTop.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TLPanelTop.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TLPanelTop.Size = new Size(1575, 90);
            TLPanelTop.TabIndex = 1;
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
            panelFull.TabIndex = 2;
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
            panelBody.Controls.Add(txtSpecification);
            panelBody.Controls.Add(labelSpec);
            panelBody.Controls.Add(txtPrice);
            panelBody.Controls.Add(labelPrice);
            panelBody.Controls.Add(dateRegistration);
            panelBody.Controls.Add(labelRegisterDate);
            panelBody.Controls.Add(txtOwnerContact);
            panelBody.Controls.Add(labelOwnerContact);
            panelBody.Controls.Add(txtNic);
            panelBody.Controls.Add(labelOwnerNic);
            panelBody.Controls.Add(txtOwnerName);
            panelBody.Controls.Add(labelOwnerName);
            panelBody.Controls.Add(txtOwners);
            panelBody.Controls.Add(labelOwners);
            panelBody.Controls.Add(comboCondition);
            panelBody.Controls.Add(label9);
            panelBody.Controls.Add(comboFuel);
            panelBody.Controls.Add(label8);
            panelBody.Controls.Add(txtMileage);
            panelBody.Controls.Add(label7);
            panelBody.Controls.Add(comboTransmission);
            panelBody.Controls.Add(comboEngine);
            panelBody.Controls.Add(label6);
            panelBody.Controls.Add(label5);
            panelBody.Controls.Add(txtColor);
            panelBody.Controls.Add(label4);
            panelBody.Controls.Add(txtManufacture);
            panelBody.Controls.Add(label3);
            panelBody.Controls.Add(txtCarModel);
            panelBody.Controls.Add(label2);
            panelBody.Controls.Add(buttonChooseImage);
            panelBody.Controls.Add(pictureBox);
            panelBody.Location = new Point(4, 3);
            panelBody.Name = "panelBody";
            panelBody.Size = new Size(600, 981);
            panelBody.TabIndex = 0;
            panelBody.Visible = false;
            // 
            // txtSpecification
            // 
            txtSpecification.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSpecification.Location = new Point(323, 840);
            txtSpecification.Multiline = true;
            txtSpecification.Name = "txtSpecification";
            txtSpecification.Size = new Size(252, 114);
            txtSpecification.TabIndex = 32;
            // 
            // labelSpec
            // 
            labelSpec.AutoSize = true;
            labelSpec.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSpec.ForeColor = Color.White;
            labelSpec.Location = new Point(319, 805);
            labelSpec.Name = "labelSpec";
            labelSpec.Size = new Size(124, 28);
            labelSpec.TabIndex = 31;
            labelSpec.Text = "Specification";
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrice.Location = new Point(323, 765);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(252, 37);
            txtPrice.TabIndex = 30;
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPrice.ForeColor = Color.White;
            labelPrice.Location = new Point(321, 734);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(54, 28);
            labelPrice.TabIndex = 29;
            labelPrice.Text = "Price";
            // 
            // dateRegistration
            // 
            dateRegistration.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateRegistration.Format = DateTimePickerFormat.Short;
            dateRegistration.Location = new Point(323, 693);
            dateRegistration.Name = "dateRegistration";
            dateRegistration.Size = new Size(249, 37);
            dateRegistration.TabIndex = 3;
            // 
            // labelRegisterDate
            // 
            labelRegisterDate.AutoSize = true;
            labelRegisterDate.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelRegisterDate.ForeColor = Color.White;
            labelRegisterDate.Location = new Point(325, 657);
            labelRegisterDate.Name = "labelRegisterDate";
            labelRegisterDate.Size = new Size(163, 28);
            labelRegisterDate.TabIndex = 28;
            labelRegisterDate.Text = "Registration Date";
            // 
            // txtOwnerContact
            // 
            txtOwnerContact.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtOwnerContact.Location = new Point(323, 616);
            txtOwnerContact.Name = "txtOwnerContact";
            txtOwnerContact.Size = new Size(252, 37);
            txtOwnerContact.TabIndex = 27;
            // 
            // labelOwnerContact
            // 
            labelOwnerContact.AutoSize = true;
            labelOwnerContact.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelOwnerContact.ForeColor = Color.White;
            labelOwnerContact.Location = new Point(323, 582);
            labelOwnerContact.Name = "labelOwnerContact";
            labelOwnerContact.Size = new Size(142, 28);
            labelOwnerContact.TabIndex = 26;
            labelOwnerContact.Text = "Owner Contact";
            // 
            // txtNic
            // 
            txtNic.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNic.Location = new Point(323, 542);
            txtNic.Name = "txtNic";
            txtNic.Size = new Size(252, 37);
            txtNic.TabIndex = 25;
            // 
            // labelOwnerNic
            // 
            labelOwnerNic.AutoSize = true;
            labelOwnerNic.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelOwnerNic.ForeColor = Color.White;
            labelOwnerNic.Location = new Point(325, 511);
            labelOwnerNic.Name = "labelOwnerNic";
            labelOwnerNic.Size = new Size(106, 28);
            labelOwnerNic.TabIndex = 24;
            labelOwnerNic.Text = "Owner NIC";
            // 
            // txtOwnerName
            // 
            txtOwnerName.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtOwnerName.Location = new Point(323, 469);
            txtOwnerName.Name = "txtOwnerName";
            txtOwnerName.Size = new Size(252, 37);
            txtOwnerName.TabIndex = 23;
            // 
            // labelOwnerName
            // 
            labelOwnerName.AutoSize = true;
            labelOwnerName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelOwnerName.ForeColor = Color.White;
            labelOwnerName.Location = new Point(325, 438);
            labelOwnerName.Name = "labelOwnerName";
            labelOwnerName.Size = new Size(126, 28);
            labelOwnerName.TabIndex = 22;
            labelOwnerName.Text = "Owner Name";
            // 
            // txtOwners
            // 
            txtOwners.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtOwners.Location = new Point(323, 395);
            txtOwners.Name = "txtOwners";
            txtOwners.Size = new Size(252, 37);
            txtOwners.TabIndex = 21;
            // 
            // labelOwners
            // 
            labelOwners.AutoSize = true;
            labelOwners.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelOwners.ForeColor = Color.White;
            labelOwners.Location = new Point(325, 364);
            labelOwners.Name = "labelOwners";
            labelOwners.Size = new Size(132, 28);
            labelOwners.TabIndex = 20;
            labelOwners.Text = "No of Owners";
            // 
            // comboCondition
            // 
            comboCondition.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboCondition.FormattingEnabled = true;
            comboCondition.Items.AddRange(new object[] { "Brand New", "Used" });
            comboCondition.Location = new Point(27, 916);
            comboCondition.Name = "comboCondition";
            comboCondition.Size = new Size(252, 38);
            comboCondition.TabIndex = 19;
            comboCondition.Text = "- Choose One -";
            comboCondition.SelectedIndexChanged += comboCondition_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(29, 881);
            label9.Name = "label9";
            label9.Size = new Size(99, 28);
            label9.TabIndex = 18;
            label9.Text = "Condition";
            // 
            // comboFuel
            // 
            comboFuel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboFuel.FormattingEnabled = true;
            comboFuel.Items.AddRange(new object[] { "Petrol", "Diesel", "Electric" });
            comboFuel.Location = new Point(27, 840);
            comboFuel.Name = "comboFuel";
            comboFuel.Size = new Size(252, 38);
            comboFuel.TabIndex = 17;
            comboFuel.Text = "- Choose One -";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(29, 805);
            label8.Name = "label8";
            label8.Size = new Size(94, 28);
            label8.TabIndex = 16;
            label8.Text = "Fuel Type";
            // 
            // txtMileage
            // 
            txtMileage.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMileage.Location = new Point(27, 765);
            txtMileage.Name = "txtMileage";
            txtMileage.Size = new Size(252, 37);
            txtMileage.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(31, 734);
            label7.Name = "label7";
            label7.Size = new Size(82, 28);
            label7.TabIndex = 14;
            label7.Text = "Mileage";
            // 
            // comboTransmission
            // 
            comboTransmission.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboTransmission.FormattingEnabled = true;
            comboTransmission.Items.AddRange(new object[] { "Automatic", "Manual" });
            comboTransmission.Location = new Point(27, 693);
            comboTransmission.Name = "comboTransmission";
            comboTransmission.Size = new Size(252, 38);
            comboTransmission.TabIndex = 13;
            comboTransmission.Text = "- Choose One -";
            // 
            // comboEngine
            // 
            comboEngine.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboEngine.FormattingEnabled = true;
            comboEngine.Items.AddRange(new object[] { "Inline-4 (I4)", "Inline-6 (I6)", "V6", "V8", "V10", "V12", "Flat-4 (Boxer)", "Flat-6 (Boxer)", "Hybrid", "Electric", "Diesel", "Turbocharged", "Supercharged", "Rotary (Wankel)", "Hydrogen Fuel Cell", "Plug-in Hybrid" });
            comboEngine.Location = new Point(27, 616);
            comboEngine.Name = "comboEngine";
            comboEngine.Size = new Size(252, 38);
            comboEngine.TabIndex = 12;
            comboEngine.Text = "- Choose One -";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(29, 658);
            label6.Name = "label6";
            label6.Size = new Size(122, 28);
            label6.TabIndex = 10;
            label6.Text = "Transmission";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(29, 584);
            label5.Name = "label5";
            label5.Size = new Size(117, 28);
            label5.TabIndex = 8;
            label5.Text = "Engine Type";
            // 
            // txtColor
            // 
            txtColor.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtColor.Location = new Point(27, 542);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(252, 37);
            txtColor.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(29, 511);
            label4.Name = "label4";
            label4.Size = new Size(60, 28);
            label4.TabIndex = 6;
            label4.Text = "Color";
            // 
            // txtManufacture
            // 
            txtManufacture.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtManufacture.Location = new Point(27, 469);
            txtManufacture.Name = "txtManufacture";
            txtManufacture.Size = new Size(252, 37);
            txtManufacture.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(29, 438);
            label3.Name = "label3";
            label3.Size = new Size(163, 28);
            label3.TabIndex = 4;
            label3.Text = "Manufacture Year";
            // 
            // txtCarModel
            // 
            txtCarModel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCarModel.Location = new Point(27, 395);
            txtCarModel.Name = "txtCarModel";
            txtCarModel.Size = new Size(252, 37);
            txtCarModel.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(29, 364);
            label2.Name = "label2";
            label2.Size = new Size(103, 28);
            label2.TabIndex = 2;
            label2.Text = "Car Model";
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
            // panelAddTop
            // 
            panelAddTop.Controls.Add(btnModify);
            panelAddTop.Controls.Add(labelHead);
            panelAddTop.Controls.Add(btnCancel);
            panelAddTop.Controls.Add(btnCarSave);
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
            btnModify.TabIndex = 6;
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
            labelHead.Location = new Point(390, 20);
            labelHead.Name = "labelHead";
            labelHead.Size = new Size(189, 38);
            labelHead.TabIndex = 5;
            labelHead.Text = "Add New Car";
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
            btnCancel.Text = "Close";
            btnCancel.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnCarSave
            // 
            btnCarSave.BackColor = Color.FromArgb(52, 73, 94);
            btnCarSave.Cursor = Cursors.Hand;
            btnCarSave.Dock = DockStyle.Left;
            btnCarSave.FlatAppearance.BorderSize = 0;
            btnCarSave.FlatStyle = FlatStyle.Flat;
            btnCarSave.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCarSave.ForeColor = Color.White;
            btnCarSave.Image = (Image)resources.GetObject("btnCarSave.Image");
            btnCarSave.Location = new Point(0, 0);
            btnCarSave.Name = "btnCarSave";
            btnCarSave.Size = new Size(85, 85);
            btnCarSave.TabIndex = 3;
            btnCarSave.Text = "Save";
            btnCarSave.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCarSave.UseVisualStyleBackColor = false;
            btnCarSave.Click += btnCarSave_Click;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // TimerAdd
            // 
            TimerAdd.Tick += TimerAdd_Tick;
            // 
            // PnlGrid
            // 
            PnlGrid.BackColor = Color.White;
            PnlGrid.Controls.Add(pictureBoxLoading);
            PnlGrid.Controls.Add(tableCarView);
            PnlGrid.Dock = DockStyle.Fill;
            PnlGrid.Location = new Point(0, 90);
            PnlGrid.Margin = new Padding(5);
            PnlGrid.Name = "PnlGrid";
            PnlGrid.Size = new Size(941, 740);
            PnlGrid.TabIndex = 3;
            // 
            // pictureBoxLoading
            // 
            pictureBoxLoading.BackColor = Color.Transparent;
            pictureBoxLoading.Image = (Image)resources.GetObject("pictureBoxLoading.Image");
            pictureBoxLoading.Location = new Point(581, 448);
            pictureBoxLoading.Name = "pictureBoxLoading";
            pictureBoxLoading.Size = new Size(325, 280);
            pictureBoxLoading.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLoading.TabIndex = 3;
            pictureBoxLoading.TabStop = false;
            pictureBoxLoading.Visible = false;
            // 
            // tableCarView
            // 
            tableCarView.AllowUserToAddRows = false;
            tableCarView.AllowUserToDeleteRows = false;
            tableCarView.AllowUserToResizeColumns = false;
            tableCarView.AllowUserToResizeRows = false;
            tableCarView.BackgroundColor = Color.White;
            tableCarView.BorderStyle = BorderStyle.None;
            tableCarView.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            tableCarView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(52, 73, 94);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            tableCarView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            tableCarView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableCarView.EnableHeadersVisualStyles = false;
            tableCarView.Location = new Point(24, 33);
            tableCarView.Margin = new Padding(15);
            tableCarView.MultiSelect = false;
            tableCarView.Name = "tableCarView";
            tableCarView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            tableCarView.RowHeadersVisible = false;
            tableCarView.RowHeadersWidth = 62;
            tableCarView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tableCarView.Size = new Size(882, 400);
            tableCarView.TabIndex = 0;
            // 
            // Form_Cars
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1575, 830);
            Controls.Add(PnlGrid);
            Controls.Add(panelFull);
            Controls.Add(TLPanelTop);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_Cars";
            Text = "Form_Cars";
            Load += Form_Cars_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            TLPanelTop.ResumeLayout(false);
            panelFull.ResumeLayout(false);
            panelAddPage.ResumeLayout(false);
            panelBody.ResumeLayout(false);
            panelBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            panelAddTop.ResumeLayout(false);
            panelAddTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            PnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLoading).EndInit();
            ((System.ComponentModel.ISupportInitialize)tableCarView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox txtSearch;
        private Button btnAdd;
        private TableLayoutPanel TLPanelTop;
        private Button btnSearch;
        private Panel panelFull;
        private Panel panelAddTop;
        private Button btnCancel;
        private Button btnCarSave;
        private Label labelHead;
        private Panel panelAddPage;
        private Panel panelBody;
        private Label label2;
        private Button buttonChooseImage;
        private PictureBox pictureBox;
        private Label label6;
        private Label label5;
        private TextBox txtColor;
        private Label label4;
        private TextBox txtManufacture;
        private Label label3;
        private TextBox txtCarModel;
        private ComboBox comboEngine;
        private ComboBox comboTransmission;
        private TextBox txtNic;
        private Label labelOwnerNic;
        private TextBox txtOwnerName;
        private Label labelOwnerName;
        private TextBox txtOwners;
        private Label labelOwners;
        private ComboBox comboCondition;
        private Label label9;
        private ComboBox comboFuel;
        private Label label8;
        private TextBox txtMileage;
        private Label label7;
        private TextBox txtSpecification;
        private Label labelSpec;
        private TextBox txtPrice;
        private Label labelPrice;
        private DateTimePicker dateRegistration;
        private Label labelRegisterDate;
        private TextBox txtOwnerContact;
        private Label labelOwnerContact;
        private FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Timer TimerAdd;
        private Panel PnlGrid;
        private DataGridView tableCarView;
        private Button btnModify;
        private Button btnRefresh;
        private PictureBox pictureBoxLoading;
    }
}