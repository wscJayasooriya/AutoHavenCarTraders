namespace CarTraders
{
    partial class Form_Checkout
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
            panelMain = new Panel();
            panelCheckout = new Panel();
            panelCustomerInformation = new Panel();
            panelPaymentInformation = new Panel();
            panelMain.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.Controls.Add(panelPaymentInformation);
            panelMain.Controls.Add(panelCustomerInformation);
            panelMain.Controls.Add(panelCheckout);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1545, 1181);
            panelMain.TabIndex = 0;
            // 
            // panelCheckout
            // 
            panelCheckout.Dock = DockStyle.Right;
            panelCheckout.Location = new Point(1022, 0);
            panelCheckout.Name = "panelCheckout";
            panelCheckout.Size = new Size(523, 1181);
            panelCheckout.TabIndex = 0;
            // 
            // panelCustomerInformation
            // 
            panelCustomerInformation.BackColor = Color.FromArgb(192, 255, 192);
            panelCustomerInformation.Dock = DockStyle.Top;
            panelCustomerInformation.Location = new Point(0, 0);
            panelCustomerInformation.Name = "panelCustomerInformation";
            panelCustomerInformation.Size = new Size(1022, 610);
            panelCustomerInformation.TabIndex = 1;
            // 
            // panelPaymentInformation
            // 
            panelPaymentInformation.BackColor = Color.FromArgb(192, 255, 255);
            panelPaymentInformation.Dock = DockStyle.Fill;
            panelPaymentInformation.Location = new Point(0, 610);
            panelPaymentInformation.Name = "panelPaymentInformation";
            panelPaymentInformation.Size = new Size(1022, 571);
            panelPaymentInformation.TabIndex = 2;
            // 
            // Form_Checkout
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1545, 1181);
            Controls.Add(panelMain);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_Checkout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_Checkout";
            panelMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMain;
        private Panel panelCustomerInformation;
        private Panel panelCheckout;
        private Panel panelPaymentInformation;
    }
}