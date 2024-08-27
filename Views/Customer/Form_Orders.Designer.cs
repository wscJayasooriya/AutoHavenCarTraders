namespace CarTraders
{
    partial class Form_Orders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Orders));
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            textBox1 = new TextBox();
            container = new SplitContainer();
            loadPanel = new Panel();
            cartPanel = new Panel();
            btnPartClear = new Button();
            btnPartPlaceOrder = new Button();
            carPartPanel = new Panel();
            btnCar = new Button();
            btnCarParts = new Button();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)container).BeginInit();
            container.Panel1.SuspendLayout();
            container.Panel2.SuspendLayout();
            container.SuspendLayout();
            cartPanel.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(panel1, 4, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(2);
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1575, 90);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(52, 73, 94);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(5, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1565, 80);
            panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1010, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(55, 55);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(textBox1);
            panel2.Location = new Point(588, 13);
            panel2.Name = "panel2";
            panel2.Size = new Size(433, 55);
            panel2.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(7, 9);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(423, 40);
            textBox1.TabIndex = 6;
            // 
            // container
            // 
            container.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            container.Location = new Point(0, 157);
            container.Name = "container";
            // 
            // container.Panel1
            // 
            container.Panel1.Controls.Add(loadPanel);
            // 
            // container.Panel2
            // 
            container.Panel2.Controls.Add(cartPanel);
            container.Size = new Size(1563, 661);
            container.SplitterDistance = 1139;
            container.TabIndex = 2;
            // 
            // loadPanel
            // 
            loadPanel.Dock = DockStyle.Fill;
            loadPanel.Location = new Point(0, 0);
            loadPanel.Name = "loadPanel";
            loadPanel.Padding = new Padding(2);
            loadPanel.Size = new Size(1139, 661);
            loadPanel.TabIndex = 1;
            // 
            // cartPanel
            // 
            cartPanel.Controls.Add(btnPartClear);
            cartPanel.Controls.Add(btnPartPlaceOrder);
            cartPanel.Controls.Add(carPartPanel);
            cartPanel.Dock = DockStyle.Fill;
            cartPanel.Location = new Point(0, 0);
            cartPanel.Name = "cartPanel";
            cartPanel.Padding = new Padding(5);
            cartPanel.Size = new Size(420, 661);
            cartPanel.TabIndex = 0;
            // 
            // btnPartClear
            // 
            btnPartClear.BackColor = Color.FromArgb(77, 86, 86);
            btnPartClear.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPartClear.ForeColor = Color.White;
            btnPartClear.Location = new Point(5, 589);
            btnPartClear.Name = "btnPartClear";
            btnPartClear.Size = new Size(409, 61);
            btnPartClear.TabIndex = 2;
            btnPartClear.Text = "Clear";
            btnPartClear.UseVisualStyleBackColor = false;
            btnPartClear.Visible = false;
            // 
            // btnPartPlaceOrder
            // 
            btnPartPlaceOrder.BackColor = Color.FromArgb(52, 73, 94);
            btnPartPlaceOrder.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPartPlaceOrder.ForeColor = Color.White;
            btnPartPlaceOrder.Location = new Point(5, 522);
            btnPartPlaceOrder.Name = "btnPartPlaceOrder";
            btnPartPlaceOrder.Size = new Size(409, 68);
            btnPartPlaceOrder.TabIndex = 1;
            btnPartPlaceOrder.Text = "Place Order";
            btnPartPlaceOrder.UseVisualStyleBackColor = false;
            btnPartPlaceOrder.Visible = false;
            btnPartPlaceOrder.Click += btnPartPlaceOrder_Click;
            // 
            // carPartPanel
            // 
            carPartPanel.Location = new Point(5, 4);
            carPartPanel.Name = "carPartPanel";
            carPartPanel.Size = new Size(409, 511);
            carPartPanel.TabIndex = 0;
            // 
            // btnCar
            // 
            btnCar.BackColor = Color.FromArgb(23, 32, 42);
            btnCar.Cursor = Cursors.Hand;
            btnCar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCar.ForeColor = Color.White;
            btnCar.Location = new Point(3, 92);
            btnCar.Name = "btnCar";
            btnCar.Size = new Size(182, 60);
            btnCar.TabIndex = 3;
            btnCar.Text = "Cars";
            btnCar.UseVisualStyleBackColor = false;
            btnCar.Click += btnCar_Click;
            // 
            // btnCarParts
            // 
            btnCarParts.BackColor = Color.FromArgb(23, 32, 42);
            btnCarParts.Cursor = Cursors.Hand;
            btnCarParts.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCarParts.ForeColor = Color.White;
            btnCarParts.Location = new Point(202, 92);
            btnCarParts.Name = "btnCarParts";
            btnCarParts.Size = new Size(182, 60);
            btnCarParts.TabIndex = 4;
            btnCarParts.Text = "Car Parts";
            btnCarParts.UseVisualStyleBackColor = false;
            btnCarParts.Click += btnCarParts_Click;
            // 
            // Form_Orders
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1575, 830);
            Controls.Add(btnCarParts);
            Controls.Add(btnCar);
            Controls.Add(container);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_Orders";
            Text = "Form_Orders";
            Load += Form_Orders_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            container.Panel1.ResumeLayout(false);
            container.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)container).EndInit();
            container.ResumeLayout(false);
            cartPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private TextBox textBox1;
        private SplitContainer container;
        private Panel loadPanel;
        private Panel cartPanel;
        private Button btnCar;
        private Button btnCarParts;
        private Panel carPartPanel;
        private Button btnPartClear;
        private Button btnPartPlaceOrder;
    }
}