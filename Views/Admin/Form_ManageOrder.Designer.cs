namespace CarTraders.Views
{
    partial class Form_ManageOrder
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ManageOrder));
            btnCompleteOrder = new Button();
            btnPendingOrder = new Button();
            loadPanel = new Panel();
            dataGridView = new DataGridView();
            pendingOrderCount = new Label();
            completeOrderCount = new Label();
            TLPanelTop = new TableLayoutPanel();
            btnRefresh = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            txtSearch = new TextBox();
            btnSearch = new Button();
            loadPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            TLPanelTop.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnCompleteOrder
            // 
            btnCompleteOrder.BackColor = Color.FromArgb(23, 32, 42);
            btnCompleteOrder.Cursor = Cursors.Hand;
            btnCompleteOrder.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCompleteOrder.ForeColor = Color.White;
            btnCompleteOrder.Location = new Point(342, 110);
            btnCompleteOrder.Name = "btnCompleteOrder";
            btnCompleteOrder.Size = new Size(342, 70);
            btnCompleteOrder.TabIndex = 7;
            btnCompleteOrder.Text = "Complete Orders";
            btnCompleteOrder.UseVisualStyleBackColor = false;
            btnCompleteOrder.Click += btnCompleteOrder_Click;
            // 
            // btnPendingOrder
            // 
            btnPendingOrder.BackColor = Color.FromArgb(23, 32, 42);
            btnPendingOrder.Cursor = Cursors.Hand;
            btnPendingOrder.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPendingOrder.ForeColor = Color.White;
            btnPendingOrder.Location = new Point(21, 110);
            btnPendingOrder.Name = "btnPendingOrder";
            btnPendingOrder.Size = new Size(298, 70);
            btnPendingOrder.TabIndex = 6;
            btnPendingOrder.Text = "Pending Orders";
            btnPendingOrder.UseVisualStyleBackColor = false;
            btnPendingOrder.Click += btnPendingOrder_Click;
            // 
            // loadPanel
            // 
            loadPanel.Controls.Add(dataGridView);
            loadPanel.Location = new Point(19, 189);
            loadPanel.Name = "loadPanel";
            loadPanel.Size = new Size(1539, 618);
            loadPanel.TabIndex = 8;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.BackgroundColor = Color.White;
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(52, 73, 94);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(52, 73, 94);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.Location = new Point(18, 34);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 62;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(1501, 569);
            dataGridView.TabIndex = 0;
            // 
            // pendingOrderCount
            // 
            pendingOrderCount.AutoSize = true;
            pendingOrderCount.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pendingOrderCount.Location = new Point(264, 130);
            pendingOrderCount.Name = "pendingOrderCount";
            pendingOrderCount.Size = new Size(42, 32);
            pendingOrderCount.TabIndex = 10;
            pendingOrderCount.Text = "20";
            // 
            // completeOrderCount
            // 
            completeOrderCount.AutoSize = true;
            completeOrderCount.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            completeOrderCount.Location = new Point(619, 130);
            completeOrderCount.Name = "completeOrderCount";
            completeOrderCount.Size = new Size(42, 32);
            completeOrderCount.TabIndex = 11;
            completeOrderCount.Text = "20";
            // 
            // TLPanelTop
            // 
            TLPanelTop.ColumnCount = 2;
            TLPanelTop.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            TLPanelTop.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            TLPanelTop.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            TLPanelTop.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            TLPanelTop.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            TLPanelTop.Controls.Add(btnRefresh, 0, 0);
            TLPanelTop.Controls.Add(panel1, 4, 0);
            TLPanelTop.Dock = DockStyle.Top;
            TLPanelTop.Location = new Point(0, 0);
            TLPanelTop.Name = "TLPanelTop";
            TLPanelTop.Padding = new Padding(2);
            TLPanelTop.RowCount = 1;
            TLPanelTop.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TLPanelTop.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TLPanelTop.Size = new Size(1575, 90);
            TLPanelTop.TabIndex = 12;
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
            btnRefresh.Location = new Point(5, 5);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(114, 80);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "Refresh";
            btnRefresh.TextImageRelation = TextImageRelation.ImageAboveText;
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(52, 73, 94);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnSearch);
            panel1.Location = new Point(125, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1445, 80);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(txtSearch);
            panel2.Location = new Point(956, 13);
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
            btnSearch.Location = new Point(1375, 13);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(55, 55);
            btnSearch.TabIndex = 2;
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // Form_ManageOrder
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1575, 830);
            Controls.Add(TLPanelTop);
            Controls.Add(completeOrderCount);
            Controls.Add(pendingOrderCount);
            Controls.Add(loadPanel);
            Controls.Add(btnCompleteOrder);
            Controls.Add(btnPendingOrder);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_ManageOrder";
            Text = "Form_ManageOrder";
            Load += Form_ManageOrder_Load;
            loadPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            TLPanelTop.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCompleteOrder;
        private Button btnPendingOrder;
        private Panel loadPanel;
        private DataGridView dataGridView;
        private Label pendingOrderCount;
        private Label completeOrderCount;
        private TableLayoutPanel TLPanelTop;
        private Button btnRefresh;
        private Panel panel1;
        private Panel panel2;
        private TextBox txtSearch;
        private Button btnSearch;
    }
}