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

namespace CarTraders
{
    public partial class Signup : Form
    {
        private ValidatorUtil validatorUtil;
        public Signup()
        {
            validatorUtil = new ValidatorUtil();
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
                MessageBox.Show("Password must be at least 8 characters long and include uppercase, lowercase, numbers, and symbols.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.BackColor = Color.FromArgb(205, 97, 85);
                txtReEnterPassword.BackColor = Color.FromArgb(205, 97, 85);
                return;
            }
            if (password != rePassword)
            {
                MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (var dbContext = new ApplicationDBContext())
                {
                    var setImage = await dbContext.defaultImage.FirstOrDefaultAsync();

                    if (setImage == null)
                    {
                        MessageBox.Show("Default image not found. Please contact support.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }


                    var user = new Users
                    {
                        FirstName = "Not Set",
                        LastName = "Not Set",
                        ContactNo = "Not Set",
                        City = "Not Set",
                        Nic = "Not Set",
                        Address = "Not Set",
                        UserRole = "Customer_Role",
                        Email = email,
                        Username = username,
                        Password = HashPassword(password),
                        Status = 1,
                        CreateDate = DateTime.Now,
                        Image = setImage.Image,
                        Department = "Not Set"
                    };

                    dbContext.users.Add(user);
                    dbContext.SaveChanges();
                    MessageBox.Show("Registration successfully. Please Login Now!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form_Login form_Login = new Form_Login();
                    form_Login.Show();
                    this.Hide();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving customer data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private byte[] UserImageToByteArray(Image image)
        {
            using (var ms = new MemoryStream())
            {
                using (var clonedImage = new Bitmap(image))
                {
                    ImageFormat format = image.RawFormat;

                    if (ImageFormat.Jpeg.Equals(format))
                        format = ImageFormat.Jpeg;
                    else if (ImageFormat.Png.Equals(format))
                        format = ImageFormat.Png;
                    else if (ImageFormat.Bmp.Equals(format))
                        format = ImageFormat.Bmp;
                    else if (ImageFormat.Gif.Equals(format))
                        format = ImageFormat.Gif;
                    else if (ImageFormat.Tiff.Equals(format))
                        format = ImageFormat.Tiff;
                    else
                        format = ImageFormat.Png;

                    clonedImage.Save(ms, format);
                }
                return ms.ToArray();
            }
        }
    }
}
