using CarTraders.Data;
using CarTraders.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CarTraders.Helpers.NotificationUtil;

namespace CarTraders
{
    public partial class Form_OTP : Form
    {
        private string userEmail;
        EmailSendUtil emailSendUtil;
        private int countdown = 300;
        public Form_OTP(string email)
        {
            InitializeComponent();
            emailSendUtil = new EmailSendUtil();
            labelEmail.Visible = true;
            labelEmail.Text = email;
            userEmail = email;

            countdownTimer.Tick += CountdownTimer_Tick;

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

        private void CountdownTimer_Tick(object? sender, EventArgs e)
        {
            countdown--;
            labelCountdown.Text = TimeSpan.FromSeconds(countdown).ToString(@"mm\:ss");
            if (countdown <= 0)
            {
                countdownTimer.Stop();
                btnResend.Visible = true;
                labelCountdown.Visible = false;
                labelResendOTP.Visible = false;
            }
        }

        private void Form_OTP_Load(object? sender, EventArgs e)
        {
            StartOtpCountdown();

            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 100; // Delay in milliseconds
            timer.Tick += (s, args) =>
            {
                timer.Stop();
                txtOtp1.Focus();
            };
            timer.Start();
        }

        private void StartOtpCountdown()
        {
            countdown = 300;
            btnResend.Visible = false;
            countdownTimer.Start();
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
                            NotificationUtil.ShowNotification(NotificationType.SUCCESS, "Verification successful!");
                            Form_New_Password _New_Password = new Form_New_Password(userEmail);
                            _New_Password.Show();
                            this.Hide();
                        }
                        else
                        {
                            NotificationUtil.ShowNotification(NotificationType.INFO, "Verification code has expired.");
                        }
                    }
                    else
                    {
                        NotificationUtil.ShowNotification(NotificationType.ERROR, "Incorrect verification code.");
                    }
                }
                else
                {
                    NotificationUtil.ShowNotification(NotificationType.INFO, "User not found.");
                }
            }
        }

        private async void btnResend_Click(object sender, EventArgs e)
        {

            try
            {
                using (var dbContext = new ApplicationDBContext())
                {
                    var user = dbContext.users.SingleOrDefault(u => u.Email == userEmail);

                    if (user != null)
                    {
                        int otp = emailSendUtil.GenerateOtp();
                        user.VerificationCode = otp;
                        user.OtpExpireTime = DateTime.Now.AddMinutes(5);
                        dbContext.SaveChanges();
                        await emailSendUtil.SendOtpEmailAsync(userEmail, otp);
                        NotificationUtil.ShowNotification(NotificationType.SUCCESS, "An OTP has been sent to your email address.");
                        Form_OTP form_OTP = new Form_OTP(userEmail);
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
            StartOtpCountdown();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
