namespace CarTraders
{
    partial class Form_CarParts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_CarParts));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            txtDescription = new TextBox();
            labelDescription = new Label();
            labelCondition = new Label();
            txtQty = new TextBox();
            labelQty = new Label();
            labelColor = new Label();
            TimerAdd = new System.Windows.Forms.Timer(components);
            panelAddTop = new Panel();
            btnModify = new Button();
            labelHead = new Label();
            btnCancel = new Button();
            btnCarSave = new Button();
            fileSystemWatcher1 = new FileSystemWatcher();
            txtColor = new TextBox();
            txtPartName = new TextBox();
            PnlGrid = new Panel();
            pictureBoxLoading = new PictureBox();
            tableCarPartView = new DataGridView();
            panel1 = new Panel();
            panel2 = new Panel();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnAdd = new Button();
            labelPartName = new Label();
            comboCategory = new ComboBox();
            labelCategory = new Label();
            txtPrice = new TextBox();
            labelPrice = new Label();
            txtManufacture = new TextBox();
            labelManufacture = new Label();
            txtCarModel = new TextBox();
            labelCarModel = new Label();
            buttonChooseImage = new Button();
            pictureBox = new PictureBox();
            panelFull = new Panel();
            panelAddPage = new Panel();
            panelBody = new Panel();
            comboCondition = new ComboBox();
            TLPanelTop = new TableLayoutPanel();
            btnExport = new Button();
            btnRefresh = new Button();
            panelAddTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            PnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLoading).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tableCarPartView).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            panelFull.SuspendLayout();
            panelAddPage.SuspendLayout();
            panelBody.SuspendLayout();
            TLPanelTop.SuspendLayout();
            SuspendLayout();
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescription.Location = new Point(27, 695);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(252, 114);
            txtDescription.TabIndex = 32;
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDescription.ForeColor = Color.White;
            labelDescription.Location = new Point(23, 660);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(112, 28);
            labelDescription.TabIndex = 31;
            labelDescription.Text = "Description";
            // 
            // labelCondition
            // 
            labelCondition.AutoSize = true;
            labelCondition.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCondition.ForeColor = Color.White;
            labelCondition.Location = new Point(323, 582);
            labelCondition.Name = "labelCondition";
            labelCondition.Size = new Size(99, 28);
            labelCondition.TabIndex = 26;
            labelCondition.Text = "Condition";
            // 
            // txtQty
            // 
            txtQty.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQty.Location = new Point(323, 542);
            txtQty.Name = "txtQty";
            txtQty.Size = new Size(252, 37);
            txtQty.TabIndex = 25;
            // 
            // labelQty
            // 
            labelQty.AutoSize = true;
            labelQty.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelQty.ForeColor = Color.White;
            labelQty.Location = new Point(325, 511);
            labelQty.Name = "labelQty";
            labelQty.Size = new Size(88, 28);
            labelQty.TabIndex = 24;
            labelQty.Text = "Quantity";
            // 
            // labelColor
            // 
            labelColor.AutoSize = true;
            labelColor.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelColor.ForeColor = Color.White;
            labelColor.Location = new Point(325, 438);
            labelColor.Name = "labelColor";
            labelColor.Size = new Size(60, 28);
            labelColor.TabIndex = 22;
            labelColor.Text = "Color";
            // 
            // TimerAdd
            // 
            TimerAdd.Tick += TimerAdd_Tick;
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
            btnModify.TabIndex = 7;
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
            labelHead.Location = new Point(338, 22);
            labelHead.Name = "labelHead";
            labelHead.Size = new Size(263, 38);
            labelHead.TabIndex = 5;
            labelHead.Text = "Add New Car Parts";
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
            // txtColor
            // 
            txtColor.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtColor.Location = new Point(323, 469);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(252, 37);
            txtColor.TabIndex = 23;
            // 
            // txtPartName
            // 
            txtPartName.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPartName.Location = new Point(323, 395);
            txtPartName.Name = "txtPartName";
            txtPartName.Size = new Size(252, 37);
            txtPartName.TabIndex = 21;
            // 
            // PnlGrid
            // 
            PnlGrid.BackColor = Color.White;
            PnlGrid.Controls.Add(pictureBoxLoading);
            PnlGrid.Controls.Add(tableCarPartView);
            PnlGrid.Dock = DockStyle.Fill;
            PnlGrid.Location = new Point(0, 90);
            PnlGrid.Name = "PnlGrid";
            PnlGrid.Size = new Size(941, 740);
            PnlGrid.TabIndex = 6;
            // 
            // pictureBoxLoading
            // 
            pictureBoxLoading.BackColor = Color.Transparent;
            pictureBoxLoading.Image = (Image)resources.GetObject("pictureBoxLoading.Image");
            pictureBoxLoading.Location = new Point(586, 448);
            pictureBoxLoading.Name = "pictureBoxLoading";
            pictureBoxLoading.Size = new Size(325, 280);
            pictureBoxLoading.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLoading.TabIndex = 3;
            pictureBoxLoading.TabStop = false;
            pictureBoxLoading.Visible = false;
            // 
            // tableCarPartView
            // 
            tableCarPartView.AllowUserToAddRows = false;
            tableCarPartView.AllowUserToDeleteRows = false;
            tableCarPartView.AllowUserToResizeColumns = false;
            tableCarPartView.AllowUserToResizeRows = false;
            tableCarPartView.BackgroundColor = Color.White;
            tableCarPartView.BorderStyle = BorderStyle.None;
            tableCarPartView.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            tableCarPartView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(52, 73, 94);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            tableCarPartView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            tableCarPartView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableCarPartView.EnableHeadersVisualStyles = false;
            tableCarPartView.Location = new Point(29, 25);
            tableCarPartView.Margin = new Padding(15);
            tableCarPartView.MultiSelect = false;
            tableCarPartView.Name = "tableCarPartView";
            tableCarPartView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            tableCarPartView.RowHeadersVisible = false;
            tableCarPartView.RowHeadersWidth = 62;
            tableCarPartView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tableCarPartView.Size = new Size(882, 400);
            tableCarPartView.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(52, 73, 94);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnSearch);
            panel1.Location = new Point(365, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1205, 80);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(txtSearch);
            panel2.Location = new Point(712, 13);
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
            btnSearch.Location = new Point(1131, 13);
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
            // labelPartName
            // 
            labelPartName.AutoSize = true;
            labelPartName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPartName.ForeColor = Color.White;
            labelPartName.Location = new Point(325, 364);
            labelPartName.Name = "labelPartName";
            labelPartName.Size = new Size(103, 28);
            labelPartName.TabIndex = 20;
            labelPartName.Text = "Part Name";
            // 
            // comboCategory
            // 
            comboCategory.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboCategory.FormattingEnabled = true;
            comboCategory.Items.AddRange(new object[] { "Engine", "Transmission", "Suspension", "Electrical", "Body", "Interior", "Exhaust", "Brakes", "Tires", "FuelSystem", "CoolingSystem", "Lighting", "Other" });
            comboCategory.Location = new Point(27, 616);
            comboCategory.Name = "comboCategory";
            comboCategory.Size = new Size(252, 38);
            comboCategory.TabIndex = 12;
            comboCategory.Text = "- Choose One -";
            // 
            // labelCategory
            // 
            labelCategory.AutoSize = true;
            labelCategory.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCategory.ForeColor = Color.White;
            labelCategory.Location = new Point(29, 584);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(131, 28);
            labelCategory.TabIndex = 8;
            labelCategory.Text = "Part Category";
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrice.Location = new Point(27, 542);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(252, 37);
            txtPrice.TabIndex = 7;
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPrice.ForeColor = Color.White;
            labelPrice.Location = new Point(29, 511);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(54, 28);
            labelPrice.TabIndex = 6;
            labelPrice.Text = "Price";
            // 
            // txtManufacture
            // 
            txtManufacture.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtManufacture.Location = new Point(27, 469);
            txtManufacture.Name = "txtManufacture";
            txtManufacture.Size = new Size(252, 37);
            txtManufacture.TabIndex = 5;
            // 
            // labelManufacture
            // 
            labelManufacture.AutoSize = true;
            labelManufacture.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelManufacture.ForeColor = Color.White;
            labelManufacture.Location = new Point(29, 438);
            labelManufacture.Name = "labelManufacture";
            labelManufacture.Size = new Size(122, 28);
            labelManufacture.TabIndex = 4;
            labelManufacture.Text = "Manufacture";
            // 
            // txtCarModel
            // 
            txtCarModel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCarModel.Location = new Point(27, 395);
            txtCarModel.Name = "txtCarModel";
            txtCarModel.Size = new Size(252, 37);
            txtCarModel.TabIndex = 3;
            // 
            // labelCarModel
            // 
            labelCarModel.AutoSize = true;
            labelCarModel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCarModel.ForeColor = Color.White;
            labelCarModel.Location = new Point(29, 364);
            labelCarModel.Name = "labelCarModel";
            labelCarModel.Size = new Size(103, 28);
            labelCarModel.TabIndex = 2;
            labelCarModel.Text = "Car Model";
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
            // panelFull
            // 
            panelFull.BackColor = Color.FromArgb(52, 73, 94);
            panelFull.Controls.Add(panelAddPage);
            panelFull.Controls.Add(panelAddTop);
            panelFull.Dock = DockStyle.Right;
            panelFull.Location = new Point(941, 90);
            panelFull.Name = "panelFull";
            panelFull.Size = new Size(634, 740);
            panelFull.TabIndex = 5;
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
            panelBody.Controls.Add(comboCondition);
            panelBody.Controls.Add(txtDescription);
            panelBody.Controls.Add(labelDescription);
            panelBody.Controls.Add(labelCondition);
            panelBody.Controls.Add(txtQty);
            panelBody.Controls.Add(labelQty);
            panelBody.Controls.Add(txtColor);
            panelBody.Controls.Add(labelColor);
            panelBody.Controls.Add(txtPartName);
            panelBody.Controls.Add(labelPartName);
            panelBody.Controls.Add(comboCategory);
            panelBody.Controls.Add(labelCategory);
            panelBody.Controls.Add(txtPrice);
            panelBody.Controls.Add(labelPrice);
            panelBody.Controls.Add(txtManufacture);
            panelBody.Controls.Add(labelManufacture);
            panelBody.Controls.Add(txtCarModel);
            panelBody.Controls.Add(labelCarModel);
            panelBody.Controls.Add(buttonChooseImage);
            panelBody.Controls.Add(pictureBox);
            panelBody.Location = new Point(4, 3);
            panelBody.Name = "panelBody";
            panelBody.Size = new Size(600, 981);
            panelBody.TabIndex = 0;
            panelBody.Visible = false;
            // 
            // comboCondition
            // 
            comboCondition.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboCondition.FormattingEnabled = true;
            comboCondition.Items.AddRange(new object[] { "Brand New", "Used", "Refurbished" });
            comboCondition.Location = new Point(323, 616);
            comboCondition.Name = "comboCondition";
            comboCondition.Size = new Size(252, 38);
            comboCondition.TabIndex = 33;
            comboCondition.Text = "- Choose One -";
            // 
            // TLPanelTop
            // 
            TLPanelTop.ColumnCount = 4;
            TLPanelTop.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            TLPanelTop.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            TLPanelTop.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            TLPanelTop.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            TLPanelTop.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            TLPanelTop.Controls.Add(btnExport, 0, 0);
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
            TLPanelTop.TabIndex = 4;
            // 
            // btnExport
            // 
            btnExport.BackColor = Color.FromArgb(52, 73, 94);
            btnExport.Cursor = Cursors.Hand;
            btnExport.Dock = DockStyle.Fill;
            btnExport.FlatAppearance.BorderSize = 0;
            btnExport.FlatStyle = FlatStyle.Flat;
            btnExport.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExport.ForeColor = Color.White;
            btnExport.Image = (Image)resources.GetObject("btnExport.Image");
            btnExport.Location = new Point(125, 5);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(114, 80);
            btnExport.TabIndex = 6;
            btnExport.Text = "Export";
            btnExport.TextImageRelation = TextImageRelation.ImageAboveText;
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += btnExport_Click;
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
            btnRefresh.Location = new Point(245, 5);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(114, 80);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "Refresh";
            btnRefresh.TextImageRelation = TextImageRelation.ImageAboveText;
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // Form_CarParts
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1575, 830);
            Controls.Add(PnlGrid);
            Controls.Add(panelFull);
            Controls.Add(TLPanelTop);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_CarParts";
            Text = "Form_CarParts";
            Load += Form_CarParts_Load;
            panelAddTop.ResumeLayout(false);
            panelAddTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            PnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLoading).EndInit();
            ((System.ComponentModel.ISupportInitialize)tableCarPartView).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            panelFull.ResumeLayout(false);
            panelAddPage.ResumeLayout(false);
            panelBody.ResumeLayout(false);
            panelBody.PerformLayout();
            TLPanelTop.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtDescription;
        private Label labelDescription;
        private DateTimePicker dateRegistration;
        private Label labelRegisterDate;
        private Label labelCondition;
        private TextBox txtQty;
        private Label labelQty;
        private Label labelColor;
        private System.Windows.Forms.Timer TimerAdd;
        private Panel panelAddTop;
        private Label labelHead;
        private Button btnCancel;
        private Button btnCarSave;
        private FileSystemWatcher fileSystemWatcher1;
        private Panel PnlGrid;
        private Panel panelFull;
        private Panel panelAddPage;
        private Panel panelBody;
        private TextBox txtColor;
        private TextBox txtPartName;
        private Label labelPartName;
        private ComboBox comboCategory;
        private Label labelCategory;
        private TextBox txtPrice;
        private Label labelPrice;
        private TextBox txtManufacture;
        private Label labelManufacture;
        private TextBox txtCarModel;
        private Label labelCarModel;
        private Button buttonChooseImage;
        private PictureBox pictureBox;
        private TableLayoutPanel TLPanelTop;
        private Button btnAdd;
        private Panel panel1;
        private Panel panel2;
        private TextBox txtSearch;
        private Button btnSearch;
        private ComboBox comboCondition;
        private Button btnModify;
        private DataGridView tableCarPartView;
        private Button btnRefresh;
        private PictureBox pictureBoxLoading;
        private Button btnExport;
    }
}