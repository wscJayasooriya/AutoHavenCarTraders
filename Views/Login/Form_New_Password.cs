using CarTraders.Data;
using CarTraders.Helpers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CarTraders.Helpers.NotificationUtil;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CarTraders
{
    public partial class Form_New_Password : Form
    {
        private ValidatorUtil validatorUtil;
        private string email;
        public Form_New_Password(string userEmail)
        {
            InitializeComponent();
            validatorUtil = new ValidatorUtil();
            txtEmail.Text = userEmail;
            email = userEmail;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var password = txtPassword.Text;
            var confPassword = txtConfirmPassword.Text;
            if (!validatorUtil.ValidatePassword(password))
            {
                NotificationUtil.ShowNotification(NotificationType.ERROR, "Password must be at least 8 characters long and include uppercase, lowercase, numbers, and symbols.");
                txtPassword.BackColor = Color.FromArgb(205, 97, 85);
                txtConfirmPassword.BackColor = Color.FromArgb(205, 97, 85);
                return;
            }
            if (password != confPassword)
            {
                NotificationUtil.ShowNotification(NotificationType.ERROR, "Passwords do not match.");
                return;
            }
            try
            {
                using (var dbContext = new ApplicationDBContext())
                {
                    var user = dbContext.users.SingleOrDefault(u => u.Email == email);

                    if (user != null)
                    {
                        user.UpdateDate = DateTime.Now;
                        user.Password = HashPassword(password);
                        dbContext.SaveChanges();

                        NotificationUtil.ShowNotification(NotificationType.SUCCESS, "Your Password Change Successfully. Please Login Again.");
                        Form_Login form_Login = new Form_Login();
                        form_Login.Show();
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

        private string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                // Convert byte array to a string
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Form_Login form_Login = new Form_Login();
            form_Login.Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
