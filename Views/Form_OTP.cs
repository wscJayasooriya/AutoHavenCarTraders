using CarTraders.Data;
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
    public partial class Form_OTP : Form
    {
        private string userEmail;
        public Form_OTP(string email)
        {
            InitializeComponent();
            labelEmail.Visible = true;
            labelEmail.Text = email;
            userEmail = email;

            txtOtp1.KeyPress += new KeyPressEventHandler(OtpTextBox_KeyPress);
            txtOtp2.KeyPress += new KeyPressEventHandler(OtpTextBox_KeyPress);
            txtOtp3.KeyPress += new KeyPressEventHandler(OtpTextBox_KeyPress);
            txtOtp4.KeyPress += new KeyPressEventHandler(OtpTextBox_KeyPress);
            txtOtp5.KeyPress += new KeyPressEventHandler(OtpTextBox_KeyPress);
            txtOtp6.KeyPress += new KeyPressEventHandler(OtpTextBox_KeyPress);

            txtOtp1.TextChanged += new EventHandler(OtpTextBox_TextChanged);
            txtOtp2.TextChanged += new EventHandler(OtpTextBox_TextChanged);
            txtOtp3.TextChanged += new EventHandler(OtpTextBox_TextChanged);
            txtOtp4.TextChanged += new EventHandler(OtpTextBox_TextChanged);
            txtOtp5.TextChanged += new EventHandler(OtpTextBox_TextChanged);
            txtOtp6.TextChanged += new EventHandler(OtpTextBox_TextChanged);

            this.Load += new EventHandler(Form_OTP_Load);
        }

        private void Form_OTP_Load(object? sender, EventArgs e)
        {
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 100; // Delay in milliseconds
            timer.Tick += (s, args) =>
            {
                timer.Stop();
                txtOtp1.Focus();
            };
            timer.Start();
        }

        private void OtpTextBox_TextChanged(object? sender, EventArgs e)
        {
            TextBox currentTextBox = sender as TextBox;
            if (currentTextBox.Text.Length > 1)
            {
                currentTextBox.Text = currentTextBox.Text.Substring(0, 1);
                currentTextBox.Select(currentTextBox.Text.Length, 0);
            }
            if (currentTextBox.Text.Length == 1)
            {
                if (currentTextBox == txtOtp1)
                {
                    txtOtp2.Focus();
                }
                else if (currentTextBox == txtOtp2)
                {
                    txtOtp3.Focus();
                }
                else if (currentTextBox == txtOtp3)
                {
                    txtOtp4.Focus();
                }
                else if (currentTextBox == txtOtp4)
                {
                    txtOtp5.Focus();
                }
                else if (currentTextBox == txtOtp5)
                {
                    txtOtp6.Focus();
                }
            }
        }

        private void OtpTextBox_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            string enteredOtp = txtOtp1.Text + txtOtp2.Text + txtOtp3.Text + txtOtp4.Text + txtOtp5.Text + txtOtp6.Text;

            using (var context = new ApplicationDBContext())
            {
                var user = context.users.FirstOrDefault(u => u.Email == userEmail);
                if (user != null)
                {
                    if (user.VerificationCode == int.Parse(enteredOtp))
                    {
                        if (user.OtpExpireTime >= DateTime.Now)
                        {
                            MessageBox.Show("Verification successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Form_New_Password _New_Password = new Form_New_Password(userEmail);
                            _New_Password.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Verification code has expired.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Incorrect verification code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
