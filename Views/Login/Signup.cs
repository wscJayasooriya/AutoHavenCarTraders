using CarTraders.Data;
using CarTraders.Helpers;
using CarTraders.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CarTraders.Helpers.NotificationUtil;

namespace CarTraders
{
    public partial class Signup : Form
    {
        private ValidatorUtil validatorUtil;
        private CodeGenerateUtil generateUtil;

        public Signup()
        {
            validatorUtil = new ValidatorUtil();
            generateUtil = new CodeGenerateUtil();
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Form_Login login = new Form_Login();
            login.Show();
            this.Hide();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            txtUsername.Text = txtEmail.Text;
        }

        private async void BtnRegister_Click(object sender, EventArgs e)
        {
            var email = txtEmail.Text;
            var username = txtUsername.Text;
            var password = txtPassword.Text;
            var rePassword = txtReEnterPassword.Text;

            if (!validatorUtil.ValidatePassword(password))
            {
                NotificationUtil.ShowNotification(NotificationType.INFO, "Password must be at least 8 characters long and include uppercase, lowercase, numbers, and symbols.");
                txtPassword.BackColor = Color.FromArgb(205, 97, 85);
                txtReEnterPassword.BackColor = Color.FromArgb(205, 97, 85);
                return;
            }
            if (password != rePassword)
            {
                NotificationUtil.ShowNotification(NotificationType.INFO, "Passwords do not match.");
                return;
            }

            try
            {
                using (var dbContext = new ApplicationDBContext())
                {
                    var setImage = await dbContext.defaultImage.FirstOrDefaultAsync();

                    if (setImage == null)
                    {
                        NotificationUtil.ShowNotification(NotificationType.ERROR, "Default image not found. Please contact support.");
                        return;
                    }
                    var userRole = "Customer_Role";
                    var userCode = generateUtil.GetNextUserCode(userRole);

                    var user = new Users
                    {
                        FirstName = "",
                        LastName = "",
                        ContactNo = "",
                        City = "",
                        Nic = "",
                        Address = "",
                        UserRole = userRole,
                        UserCode = userCode,
                        Email = email,
                        Username = username,
                        Password = HashPassword(password),
                        Status = 1,
                        CreateDate = DateTime.Now,
                        Image = setImage.Image,
                        Department = "",
                        IsDeleted = 0,
                        DeletedBy = ""
                    };

                    dbContext.users.Add(user);
                    dbContext.SaveChanges();
                    NotificationUtil.ShowNotification(NotificationType.SUCCESS, "Registration successfully. Please Login Now!");
                    Form_Login form_Login = new Form_Login();
                    form_Login.Show();
                    this.Hide();

                }

            }
            catch (Exception ex)
            {
                NotificationUtil.ShowNotification(NotificationType.ERROR, "An error occurred while saving customer data: " + ex.Message);
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
    }
}
