using CarTraders.Data;
using CarTraders.Helpers;
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
using static CarTraders.Helpers.NotificationUtil;

namespace CarTraders
{
    public partial class Form_Forgotten_Password : Form
    {
        EmailSendUtil emailSendUtil;
        public Form_Forgotten_Password()
        {
            InitializeComponent();
            emailSendUtil = new EmailSendUtil();
        }

        private async void btnSendOtp_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                NotificationUtil.ShowNotification(NotificationType.ERROR, "Please enter your email address.");
                return;
            }
            try
            {
                using (var dbContext = new ApplicationDBContext())
                {
                    var user = dbContext.users.SingleOrDefault(u => u.Email == email);

                    if (user != null)
                    {
                        int otp = emailSendUtil.GenerateOtp();
                        user.VerificationCode = otp;
                        user.OtpExpireTime = DateTime.Now.AddMinutes(5);
                        dbContext.SaveChanges();
                        await emailSendUtil.SendOtpEmailAsync(email, otp);
                        NotificationUtil.ShowNotification(NotificationType.SUCCESS, "An OTP has been sent to your email address.");
                        Form_OTP form_OTP = new Form_OTP(email);
                        form_OTP.Show();
                        this.Hide();
                    }
                    else
                    {
                        NotificationUtil.ShowNotification(NotificationType.ERROR, "The entered email address does not exist in our records.");
                    }
                }
            }
            catch (Exception ex)
            {
                NotificationUtil.ShowNotification(NotificationType.ERROR, "An error occurred while checking the email: " + ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
