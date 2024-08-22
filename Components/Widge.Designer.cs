namespace CarTraders.Components
{
    partial class Widge
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Widge));
            panelCard = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            labelName = new Label();
            panelCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelCard
            // 
            panelCard.Controls.Add(pictureBox1);
            panelCard.Controls.Add(label1);
            panelCard.Controls.Add(labelName);
            panelCard.Dock = DockStyle.Fill;
            panelCard.Location = new Point(0, 0);
            panelCard.Name = "panelCard";
            panelCard.Size = new Size(501, 226);
            panelCard.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(21, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(175, 158);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(277, 118);
            label1.Name = "label1";
            label1.Size = new Size(106, 25);
            label1.TabIndex = 1;
            label1.Text = "Selling Price";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(274, 56);
            labelName.Name = "labelName";
            labelName.Size = new Size(90, 25);
            labelName.TabIndex = 0;
            labelName.Text = "Car Name";
            // 
            // Widge
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panelCard);
            Name = "Widge";
            Size = new Size(501, 226);
            panelCard.ResumeLayout(false);
            panelCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelCard;
        private PictureBox pictureBox1;
        private Label label1;
        private Label labelName;
    }
}
