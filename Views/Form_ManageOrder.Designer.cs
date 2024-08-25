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
            panel1 = new Panel();
            btnCompleteOrder = new Button();
            btnPendingOrder = new Button();
            loadPanel = new Panel();
            dataGridView = new DataGridView();
            loadPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(52, 73, 94);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1575, 65);
            panel1.TabIndex = 5;
            // 
            // btnCompleteOrder
            // 
            btnCompleteOrder.BackColor = Color.FromArgb(23, 32, 42);
            btnCompleteOrder.Cursor = Cursors.Hand;
            btnCompleteOrder.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCompleteOrder.ForeColor = Color.White;
            btnCompleteOrder.Location = new Point(357, 71);
            btnCompleteOrder.Name = "btnCompleteOrder";
            btnCompleteOrder.Size = new Size(330, 60);
            btnCompleteOrder.TabIndex = 7;
            btnCompleteOrder.Text = "Complete Orders";
            btnCompleteOrder.UseVisualStyleBackColor = false;
            // 
            // btnPendingOrder
            // 
            btnPendingOrder.BackColor = Color.FromArgb(23, 32, 42);
            btnPendingOrder.Cursor = Cursors.Hand;
            btnPendingOrder.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPendingOrder.ForeColor = Color.White;
            btnPendingOrder.Location = new Point(12, 71);
            btnPendingOrder.Name = "btnPendingOrder";
            btnPendingOrder.Size = new Size(330, 60);
            btnPendingOrder.TabIndex = 6;
            btnPendingOrder.Text = "Pending Orders";
            btnPendingOrder.UseVisualStyleBackColor = false;
            btnPendingOrder.Click += btnPendingOrder_Click;
            // 
            // loadPanel
            // 
            loadPanel.Controls.Add(dataGridView);
            loadPanel.Location = new Point(19, 147);
            loadPanel.Name = "loadPanel";
            loadPanel.Size = new Size(1539, 660);
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
            dataGridView.Size = new Size(1501, 467);
            dataGridView.TabIndex = 0;
            // 
            // Form_ManageOrder
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1575, 830);
            Controls.Add(loadPanel);
            Controls.Add(btnCompleteOrder);
            Controls.Add(btnPendingOrder);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_ManageOrder";
            Text = "Form_ManageOrder";
            loadPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnCompleteOrder;
        private Button btnPendingOrder;
        private Panel loadPanel;
        private DataGridView dataGridView;
    }
}