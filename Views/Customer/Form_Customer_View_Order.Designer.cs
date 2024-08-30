namespace CarTraders.Views
{
    partial class Form_Customer_View_Order
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
            dataGridView = new DataGridView();
            TLPanelTop = new TableLayoutPanel();
            panel1 = new Panel();
            loadPanel = new Panel();
            btnCompleteOrder = new Button();
            btnPendingOrder = new Button();
            pendingOrderCount = new Label();
            completeOrderCount = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            TLPanelTop.SuspendLayout();
            loadPanel.SuspendLayout();
            SuspendLayout();
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
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.Location = new Point(0, 0);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 62;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(1539, 660);
            dataGridView.TabIndex = 0;
            // 
            // TLPanelTop
            // 
            TLPanelTop.ColumnCount = 1;
            TLPanelTop.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            TLPanelTop.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            TLPanelTop.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            TLPanelTop.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            TLPanelTop.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            TLPanelTop.Controls.Add(panel1, 4, 0);
            TLPanelTop.Dock = DockStyle.Top;
            TLPanelTop.Location = new Point(0, 0);
            TLPanelTop.Name = "TLPanelTop";
            TLPanelTop.Padding = new Padding(2);
            TLPanelTop.RowCount = 1;
            TLPanelTop.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TLPanelTop.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TLPanelTop.Size = new Size(1575, 65);
            TLPanelTop.TabIndex = 15;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(52, 73, 94);
            panel1.Location = new Point(5, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1565, 55);
            panel1.TabIndex = 4;
            // 
            // loadPanel
            // 
            loadPanel.Controls.Add(dataGridView);
            loadPanel.Location = new Point(19, 159);
            loadPanel.Name = "loadPanel";
            loadPanel.Size = new Size(1539, 660);
            loadPanel.TabIndex = 14;
            // 
            // btnCompleteOrder
            // 
            btnCompleteOrder.BackColor = Color.FromArgb(23, 32, 42);
            btnCompleteOrder.Cursor = Cursors.Hand;
            btnCompleteOrder.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCompleteOrder.ForeColor = Color.White;
            btnCompleteOrder.Location = new Point(354, 85);
            btnCompleteOrder.Name = "btnCompleteOrder";
            btnCompleteOrder.Size = new Size(325, 60);
            btnCompleteOrder.TabIndex = 13;
            btnCompleteOrder.Text = "Complete  Orders";
            btnCompleteOrder.UseVisualStyleBackColor = false;
            btnCompleteOrder.Click += btnCompleteOrder_Click;
            // 
            // btnPendingOrder
            // 
            btnPendingOrder.BackColor = Color.FromArgb(23, 32, 42);
            btnPendingOrder.Cursor = Cursors.Hand;
            btnPendingOrder.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPendingOrder.ForeColor = Color.White;
            btnPendingOrder.Location = new Point(19, 85);
            btnPendingOrder.Name = "btnPendingOrder";
            btnPendingOrder.Size = new Size(315, 60);
            btnPendingOrder.TabIndex = 12;
            btnPendingOrder.Text = "Pending Orders";
            btnPendingOrder.UseVisualStyleBackColor = false;
            btnPendingOrder.Click += btnPendingOrder_Click;
            // 
            // pendingOrderCount
            // 
            pendingOrderCount.AutoSize = true;
            pendingOrderCount.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            pendingOrderCount.Location = new Point(276, 98);
            pendingOrderCount.Name = "pendingOrderCount";
            pendingOrderCount.Size = new Size(42, 32);
            pendingOrderCount.TabIndex = 16;
            pendingOrderCount.Text = "20";
            // 
            // completeOrderCount
            // 
            completeOrderCount.AutoSize = true;
            completeOrderCount.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            completeOrderCount.Location = new Point(619, 98);
            completeOrderCount.Name = "completeOrderCount";
            completeOrderCount.Size = new Size(42, 32);
            completeOrderCount.TabIndex = 17;
            completeOrderCount.Text = "20";
            // 
            // Form_Customer_View_Order
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1575, 830);
            Controls.Add(completeOrderCount);
            Controls.Add(pendingOrderCount);
            Controls.Add(TLPanelTop);
            Controls.Add(loadPanel);
            Controls.Add(btnCompleteOrder);
            Controls.Add(btnPendingOrder);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_Customer_View_Order";
            Text = "Form_Customer_View_Order";
            Load += Form_Customer_View_Order_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            TLPanelTop.ResumeLayout(false);
            loadPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView;
        private TableLayoutPanel TLPanelTop;
        private Panel panel1;
        private Panel loadPanel;
        private Button btnCompleteOrder;
        private Button btnPendingOrder;
        private Label pendingOrderCount;
        private Label completeOrderCount;
    }
}