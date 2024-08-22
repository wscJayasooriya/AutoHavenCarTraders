using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarTraders
{
    public partial class customTextbox : UserControl
    {
        public customTextbox()
        {
            InitializeComponent();
        }

        bool isFocused = false;

        private void labelTimer_Tick(object sender, EventArgs e)
        {
            int y = label1.Location.Y;
            if (isFocused == false)
            {
                y -= 2;
                label1.Location = new Point(label1.Location.X, y);
                if (y <= 3)
                {
                    isFocused = true;
                    labelTimer.Stop();
                    label1.Font = new Font("Segoi UI", 8);
                    y = 0;
                    label1.ForeColor = Color.Silver;
                }
            }
            else
            {
                y += 2;
                label1.Location = new Point(label1.Location.X, y);
                if (y >= 35)
                {
                    isFocused = true;
                    labelTimer.Stop();
                    label1.Font = new Font("Segoi UI", 10);
                    y = 35;
                    label1.ForeColor = Color.Black;
                }
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                labelTimer.Start();
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                labelTimer.Start();
            }
        }
    }
}
