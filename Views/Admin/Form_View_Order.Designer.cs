﻿namespace CarTraders.Views
{
    partial class Form_View_Order
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
            panel1 = new Panel();
            labelStatus = new Label();
            txtChangeAmount = new TextBox();
            labelChangeAmount = new Label();
            txtPaidAmount = new TextBox();
            labelPaidAmount = new Label();
            btnPayment = new Button();
            btnReject = new Button();
            button2 = new Button();
            button1 = new Button();
            txtGrossAmount = new TextBox();
            label4 = new Label();
            panelOrderMain = new Panel();
            label10 = new Label();
            label5 = new Label();
            label6 = new Label();
            label9 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtInvoiceDate = new TextBox();
            label3 = new Label();
            txtCustomer = new TextBox();
            label2 = new Label();
            txtInvoiceNo = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            panelOrderMain.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(244, 246, 246);
            panel1.Controls.Add(labelStatus);
            panel1.Controls.Add(txtChangeAmount);
            panel1.Controls.Add(labelChangeAmount);
            panel1.Controls.Add(txtPaidAmount);
            panel1.Controls.Add(labelPaidAmount);
            panel1.Controls.Add(btnPayment);
            panel1.Controls.Add(btnReject);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(txtGrossAmount);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(panelOrderMain);
            panel1.Controls.Add(txtInvoiceDate);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtCustomer);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtInvoiceNo);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(762, 868);
            panel1.TabIndex = 0;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.BackColor = Color.FromArgb(0, 192, 0);
            labelStatus.FlatStyle = FlatStyle.Flat;
            labelStatus.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelStatus.ForeColor = Color.White;
            labelStatus.Location = new Point(37, 15);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(47, 23);
            labelStatus.TabIndex = 17;
            labelStatus.Text = "Paid";
            // 
            // txtChangeAmount
            // 
            txtChangeAmount.Enabled = false;
            txtChangeAmount.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtChangeAmount.ForeColor = Color.FromArgb(52, 73, 94);
            txtChangeAmount.Location = new Point(464, 702);
            txtChangeAmount.Name = "txtChangeAmount";
            txtChangeAmount.Size = new Size(280, 34);
            txtChangeAmount.TabIndex = 16;
            txtChangeAmount.Visible = false;
            // 
            // labelChangeAmount
            // 
            labelChangeAmount.AutoSize = true;
            labelChangeAmount.Font = new Font("Times New Roman", 10F);
            labelChangeAmount.Location = new Point(464, 670);
            labelChangeAmount.Name = "labelChangeAmount";
            labelChangeAmount.Size = new Size(133, 22);
            labelChangeAmount.TabIndex = 15;
            labelChangeAmount.Text = "Change Amount";
            labelChangeAmount.Visible = false;
            // 
            // txtPaidAmount
            // 
            txtPaidAmount.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPaidAmount.ForeColor = Color.FromArgb(52, 73, 94);
            txtPaidAmount.Location = new Point(464, 619);
            txtPaidAmount.Name = "txtPaidAmount";
            txtPaidAmount.Size = new Size(280, 34);
            txtPaidAmount.TabIndex = 14;
            txtPaidAmount.Visible = false;
            txtPaidAmount.TextChanged += txtPaidAmount_TextChanged;
            // 
            // labelPaidAmount
            // 
            labelPaidAmount.AutoSize = true;
            labelPaidAmount.Font = new Font("Times New Roman", 10F);
            labelPaidAmount.Location = new Point(464, 587);
            labelPaidAmount.Name = "labelPaidAmount";
            labelPaidAmount.Size = new Size(111, 22);
            labelPaidAmount.TabIndex = 13;
            labelPaidAmount.Text = "Paid Amount";
            labelPaidAmount.Visible = false;
            // 
            // btnPayment
            // 
            btnPayment.BackColor = Color.FromArgb(52, 73, 94);
            btnPayment.Cursor = Cursors.Hand;
            btnPayment.FlatStyle = FlatStyle.Flat;
            btnPayment.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPayment.ForeColor = Color.White;
            btnPayment.Location = new Point(37, 773);
            btnPayment.Name = "btnPayment";
            btnPayment.Size = new Size(194, 60);
            btnPayment.TabIndex = 12;
            btnPayment.Text = "Payment Order";
            btnPayment.UseVisualStyleBackColor = false;
            btnPayment.Visible = false;
            btnPayment.Click += btnPayment_Click;
            // 
            // btnReject
            // 
            btnReject.BackColor = Color.Red;
            btnReject.FlatStyle = FlatStyle.Flat;
            btnReject.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReject.ForeColor = Color.White;
            btnReject.Location = new Point(432, 773);
            btnReject.Name = "btnReject";
            btnReject.Size = new Size(112, 60);
            btnReject.TabIndex = 11;
            btnReject.Text = "Reject";
            btnReject.UseVisualStyleBackColor = false;
            btnReject.Click += btnReject_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(52, 73, 94);
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(550, 773);
            button2.Name = "button2";
            button2.Size = new Size(194, 60);
            button2.TabIndex = 10;
            button2.Text = "Approve Order";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(718, 4);
            button1.Name = "button1";
            button1.Size = new Size(41, 40);
            button1.TabIndex = 9;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtGrossAmount
            // 
            txtGrossAmount.Enabled = false;
            txtGrossAmount.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtGrossAmount.ForeColor = Color.FromArgb(52, 73, 94);
            txtGrossAmount.Location = new Point(37, 619);
            txtGrossAmount.Name = "txtGrossAmount";
            txtGrossAmount.Size = new Size(280, 34);
            txtGrossAmount.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10F);
            label4.Location = new Point(37, 587);
            label4.Name = "label4";
            label4.Size = new Size(122, 22);
            label4.TabIndex = 7;
            label4.Text = "Gross Amount";
            // 
            // panelOrderMain
            // 
            panelOrderMain.Controls.Add(label10);
            panelOrderMain.Controls.Add(label5);
            panelOrderMain.Controls.Add(label6);
            panelOrderMain.Controls.Add(label9);
            panelOrderMain.Controls.Add(label7);
            panelOrderMain.Controls.Add(label8);
            panelOrderMain.Location = new Point(37, 285);
            panelOrderMain.Name = "panelOrderMain";
            panelOrderMain.Size = new Size(707, 267);
            panelOrderMain.TabIndex = 6;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 10F, FontStyle.Bold);
            label10.Location = new Point(215, 0);
            label10.Name = "label10";
            label10.Size = new Size(103, 23);
            label10.TabIndex = 15;
            label10.Text = "Item Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 10F, FontStyle.Bold);
            label5.Location = new Point(5, 0);
            label5.Name = "label5";
            label5.Size = new Size(62, 23);
            label5.TabIndex = 10;
            label5.Text = "Image";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 10F, FontStyle.Bold);
            label6.Location = new Point(110, 0);
            label6.Name = "label6";
            label6.Size = new Size(98, 23);
            label6.TabIndex = 11;
            label6.Text = "Item Code";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 10F, FontStyle.Bold);
            label9.Location = new Point(580, 0);
            label9.Name = "label9";
            label9.Size = new Size(123, 23);
            label9.TabIndex = 14;
            label9.Text = "Total Amount";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 10F, FontStyle.Bold);
            label7.Location = new Point(405, 0);
            label7.Name = "label7";
            label7.Size = new Size(85, 23);
            label7.TabIndex = 12;
            label7.Text = "Quantity";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 10F, FontStyle.Bold);
            label8.Location = new Point(500, 0);
            label8.Name = "label8";
            label8.Size = new Size(54, 23);
            label8.TabIndex = 13;
            label8.Text = "Price";
            // 
            // txtInvoiceDate
            // 
            txtInvoiceDate.Enabled = false;
            txtInvoiceDate.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtInvoiceDate.ForeColor = Color.FromArgb(52, 73, 94);
            txtInvoiceDate.Location = new Point(464, 102);
            txtInvoiceDate.Name = "txtInvoiceDate";
            txtInvoiceDate.Size = new Size(280, 34);
            txtInvoiceDate.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10F);
            label3.Location = new Point(464, 70);
            label3.Name = "label3";
            label3.Size = new Size(101, 22);
            label3.TabIndex = 4;
            label3.Text = "Invice Date";
            // 
            // txtCustomer
            // 
            txtCustomer.Enabled = false;
            txtCustomer.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCustomer.ForeColor = Color.FromArgb(52, 73, 94);
            txtCustomer.Location = new Point(37, 182);
            txtCustomer.Name = "txtCustomer";
            txtCustomer.Size = new Size(280, 34);
            txtCustomer.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10F);
            label2.Location = new Point(37, 149);
            label2.Name = "label2";
            label2.Size = new Size(85, 22);
            label2.TabIndex = 2;
            label2.Text = "Customer";
            // 
            // txtInvoiceNo
            // 
            txtInvoiceNo.Enabled = false;
            txtInvoiceNo.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtInvoiceNo.ForeColor = Color.FromArgb(52, 73, 94);
            txtInvoiceNo.Location = new Point(37, 103);
            txtInvoiceNo.Name = "txtInvoiceNo";
            txtInvoiceNo.Size = new Size(280, 34);
            txtInvoiceNo.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10F);
            label1.Location = new Point(37, 70);
            label1.Name = "label1";
            label1.Size = new Size(88, 22);
            label1.TabIndex = 0;
            label1.Text = "Invice No";
            // 
            // Form_View_Order
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(171, 235, 198);
            ClientSize = new Size(786, 896);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_View_Order";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_View_Order";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelOrderMain.ResumeLayout(false);
            panelOrderMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtInvoiceDate;
        private Label label3;
        private TextBox txtCustomer;
        private Label label2;
        private TextBox txtInvoiceNo;
        private Label label1;
        private TextBox txtGrossAmount;
        private Label label4;
        private Panel panelOrderMain;
        private Button button1;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label10;
        private Button button2;
        private Button btnReject;
        private Button btnPayment;
        private Label labelStatus;
        private TextBox txtChangeAmount;
        private Label labelChangeAmount;
        private TextBox txtPaidAmount;
        private Label labelPaidAmount;
    }
}