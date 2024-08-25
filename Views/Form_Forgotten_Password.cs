using CarTraders.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarTraders
{
    public partial class Form_Forgotten_Password : Form
    {
        public Form_Forgotten_Password()
        {
            InitializeComponent();
        }

        private async void btnSendOtp_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Please enter your email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                using (var dbContext = new ApplicationDBContext())
                {
                    var user = dbContext.users.SingleOrDefault(u => u.Email == email);

                    if (user != null)
                    {
                        int otp = GenerateOtp();
                        user.VerificationCode = otp;
                        user.OtpExpireTime = DateTime.Now.AddMinutes(5);
                        dbContext.SaveChanges();
                        await SendOtpEmailAsync(email, otp);
                        MessageBox.Show("An OTP has been sent to your email address.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Form_OTP form_OTP = new Form_OTP(email);
                        form_OTP.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("The entered email address does not exist in our records.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while checking the email: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task SendOtpEmailAsync(string email, int otp)
        {
            try
            {
                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress("jayasooriya114@gmail.com");
                    mail.To.Add(email);
                    mail.Subject = "Your OTP Code";
                    mail.Body = $"Your OTP code is {otp}. It will expire in 5 minutes.";
                    mail.IsBodyHtml = false;

                    using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                    {
                        smtp.Credentials = new System.Net.NetworkCredential("jayasooriya114@gmail.com", "ikip woac rjgz pjso");
                        smtp.EnableSsl = true;
                        await smtp.SendMailAsync(mail);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to send OTP email: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GenerateOtp()
        {
            Random random = new Random();
            return random.Next(100000, 999999);
        }
    }
}
