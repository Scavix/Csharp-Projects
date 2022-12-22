using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_7
{
    /// Icon source
    /// https://icons8.com/icons/set/exit--static--white
    /// https://icons8.com/icons/set/globe--static--white
    /// https://icons8.com/icons/set/info--static--white
    public partial class LoginForm : Form
    {
        private LoginManager loginManager;
        string username { get; set; } = string.Empty;
        string password { get; set; } = string.Empty;
        private string userId { get; set; } = string.Empty;
        private AboutBoxForm aboutBoxForm { get; set; } = new();
        public bool admin { get; set; } = false;
        /// <summary>
        /// Basic constructor
        /// </summary>
        public LoginForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            leavePictureBox.BorderStyle = BorderStyle.None;
            globePictureBox.BorderStyle = BorderStyle.None;
            aboutPictureBox.BorderStyle = BorderStyle.None;
            loginManager = new();
        }
        /// <summary>
        /// Methods to read username from textBox
        /// </summary>
        private bool ReadUsername()
        {
            if (!string.IsNullOrEmpty(usernameTextBox.Text.Trim()))
            {
                username = usernameTextBox.Text.Trim();
            }
            else
            {
                MessageBox.Show("Invalid username");
                return false;
            }
            return true;
        }
        /// <summary>
        /// Methods to read password from textBox
        /// </summary>
        private bool ReadPassword()
        {
            if (!string.IsNullOrEmpty(passwordTextBox.Text.Trim()))
            {
                password = passwordTextBox.Text.Trim();
            }
            else
            {
                MessageBox.Show("Invalid password");
                return false;
            }
            return true;
        }
        /// <summary>
        /// Methods triggered by the login button
        /// Reads username and password and uses login manager to retrieve data
        /// </summary>
        private void loginButton_Click(object sender, EventArgs e)
        {
            if (ReadUsername() && ReadPassword())
            {
                if (loginManager.Login(username,password))
                {
                    userId = loginManager.GetUserId(username,password);
                    admin = loginManager.IsAdmin(username,password);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Wrong credentials","Error");
                }
            }

        }
        /// <summary>
        /// Methods triggered by the about button
        /// Shows about details
        /// </summary>
        private void aboutButton_Click(object sender, EventArgs e)
        {
            aboutBoxForm = new();
            aboutBoxForm.ShowDialog();
        }
    }
}
