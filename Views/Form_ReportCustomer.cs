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
    public partial class Form_ReportCustomer : Form
    {
        public Form_ReportCustomer()
        {
            InitializeComponent();
        }

        private void Form_ReportCustomer_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }
}
