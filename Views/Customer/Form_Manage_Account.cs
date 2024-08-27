using CarTraders.Data;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarTraders.Views.Customer
{
    public partial class Form_Manage_Account : Form
    {
        public string currentUser;
        public Form_Manage_Account(string username)
        {
            InitializeComponent();
            currentUser = username;
            LoadData(username);
        }

        private void LoadData(string username)
        {

            try
            {
                using (var dbContext = new ApplicationDBContext())
                {
                    var setImage = dbContext.defaultImage.FirstOrDefault();

                    var existingUser = dbContext.users.FirstOrDefault(u => u.Username == currentUser);

                    txtFirstName.Text = existingUser.FirstName;
                    txtLastName.Text = existingUser.LastName;
                    txtEmail.Text = existingUser.Email;
                    txtUsername.Text = existingUser.Username;
                    txtContactNo.Text = existingUser.ContactNo;
                    txtNic.Text = existingUser.Nic;
                    txtCity.Text = existingUser.City;
                    txtAddress.Text = existingUser.Address;

                    Image imageValue = null;
                    if (existingUser.Image != null && existingUser.Image.Length > 0)
                    {
                        imageValue = ByteArrayToImage(existingUser.Image);
                    }
                    else
                    {
                        imageValue = ByteArrayToImage(setImage.Image);
                    }
                    pictureBox.Image = imageValue;
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading customer data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Image? ByteArrayToImage(byte[] image)
        {
            using (var ms = new MemoryStream(image))
            {
                return Image.FromStream(ms);
            }
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox.ImageLocation = openFileDialog.FileName;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (var dbContext = new ApplicationDBContext())
                {
                    var existingUser = dbContext.users.FirstOrDefault(u => u.Username == currentUser);
                    if (existingUser != null)
                    {
                        existingUser.FirstName = txtFirstName.Text;
                        existingUser.LastName = txtLastName.Text;
                        existingUser.Email = txtEmail.Text;
                        existingUser.Username = txtUsername.Text;
                        existingUser.ContactNo = txtContactNo.Text;
                        existingUser.Address = txtAddress.Text;
                        existingUser.City = txtCity.Text;
                        existingUser.Nic = txtNic.Text;
                        existingUser.UpdateDate = DateTime.Now;
                        existingUser.Image = UserImageToByteArray(pictureBox.Image);

                        dbContext.SaveChanges();
                        MessageBox.Show("User details updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData(txtUsername.Text);
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while modifying customer data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
