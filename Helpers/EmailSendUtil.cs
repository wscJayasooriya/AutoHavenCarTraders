using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using static CarTraders.Helpers.NotificationUtil;

namespace CarTraders.Helpers
{
    public class EmailSendUtil
    {
        public async Task SendOtpEmailAsync(string email, int otp)
        {
            try
            {
                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress("cartraders.abc@gmail.com");
                    mail.To.Add(email);
                    mail.Subject = "Your OTP Code";
                    mail.Body = $"Your OTP code is {otp}. It will expire in 5 minutes.";
                    mail.IsBodyHtml = false;

                    using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                    {
                        smtp.Credentials = new System.Net.NetworkCredential("cartraders.abc@gmail.com", "vsfw pevw zlxp rsxz");
                        smtp.EnableSsl = true;
                        await smtp.SendMailAsync(mail);
                    }
                }
            }
            catch (Exception ex)
            {
                NotificationUtil.ShowNotification(NotificationType.ERROR, "Failed to send OTP email: " + ex.Message);
            }
        }

        public int GenerateOtp()
        {
            Random random = new Random();
            return random.Next(100000, 999999);
        }

        public async Task SendOtpEmailOrderAction(string email, string subject, string body)
        {
            try
            {
                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress("cartraders.abc@gmail.com");
                    mail.To.Add(email);
                    mail.Subject = subject;
                    mail.Body = body;
                    mail.IsBodyHtml = true;

                    using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                    {
                        smtp.Credentials = new System.Net.NetworkCredential("cartraders.abc@gmail.com", "vsfw pevw zlxp rsxz");
                        smtp.EnableSsl = true;
                        await smtp.SendMailAsync(mail);
                    }
                }
            }
            catch (Exception ex)
            {
                NotificationUtil.ShowNotification(NotificationType.ERROR, "Failed to send OTP email: " + ex.Message);
            }
        }
    }
}
