

using CarTraders.Data;
using CarTraders.Helpers;
using System.Security.Cryptography;
using System.Text;
using static CarTraders.Helpers.NotificationUtil;

namespace CarTraders
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Signup signup = new Signup();
            signup.Show();
            this.Hide();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                NotificationUtil.ShowNotification(NotificationType.INFO, "Please enter both username and password.");
                return;
            }

            try
            {
                using (var dbContext = new ApplicationDBContext())
                {
                    var user = dbContext.users.SingleOrDefault(u => u.Username == username);

                    if (user != null)
                    {
                        string hashedPassword = HashPassword(password);
                        if (user.Password == hashedPassword)
                        {
                            Thread.Sleep(500);
                            Dashboard dashboard = new Dashboard(username);
                            dashboard.Show();
                            this.Hide();
                        }
                        else
                        {
                            NotificationUtil.ShowNotification(NotificationType.ERROR, "Invalid credentials. Please try again.");
                        }
                    }
                    else
                    {
                        NotificationUtil.ShowNotification(NotificationType.ERROR, "Invalid credentials. Please try again.");
                    }
                }
            }
            catch (Exception ex)
            {
                NotificationUtil.ShowNotification(NotificationType.ERROR, "An error occurred while logging in: " + ex.Message);
            }
        }
        private string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void lblForgot_Click(object sender, EventArgs e)
        {
            Form_Forgotten_Password form_Forgotten = new Form_Forgotten_Password();
            form_Forgotten.Show();
            this.Hide();
        }
    }
}
