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
    public partial class AddEditUserForm : Form
    {
        public string firstName { get; set; } = String.Empty;
        public string lastName { get; set; } = String.Empty;
        public string officePhone { get; set; } = String.Empty;
        public string cellPhone { get; set; } = String.Empty;
        public string officeEmail { get; set; } = String.Empty;
        public string personalEmail { get; set; } = String.Empty;
        public string street { get; set; } = String.Empty;
        public string city { get; set; } = String.Empty;
        public string zip { get; set; } = String.Empty;
        public UserTypes userType { get; set; } = new();
        public Countries country { get; set; }
        /// <summary>
        /// Constructor for adding a users
        /// </summary>
        /// <param name="title"></param>
        public AddEditUserForm(string title)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeGUI();
            Text = title;
        }
        /// <summary>
        /// Constructor for editing a customer
        /// </summary>
        /// <param name="title"></param>
        /// /// <param name="u"></param>
        public AddEditUserForm(string title, User u)
        {
            InitializeComponent();
            InitializeGUI();
            Text = title;
            firstNameTextBox.Text = u.Contact.FirstName;
            lastNameTextBox.Text = u.Contact.LastName;
            officePhoneTextBox.Text = u.Contact.Phone.OfficePhone;
            cellPhoneTextBox.Text = u.Contact.Phone.CellPhone;
            officeEmailTextBox.Text = u.Contact.Email.OfficeMail;
            personalEmailTextBox.Text = u.Contact.Email.PersonalMail;
            streetTextBox.Text = u.Contact.Address.Street;
            cityTextBox.Text = u.Contact.Address.City;
            zipTextBox.Text = u.Contact.Address.Zip;
            countryComboBox.SelectedItem = u.Contact.Address.Country.ToString();
            adminRadioButton.Checked = (u.UserType == UserTypes.Administrator) ? true : false;
            userRadioButton.Checked = !adminRadioButton.Checked;
        }
        /// <summary>
        /// Methods to init the GUI
        /// </summary>
        private void InitializeGUI()
        {
            countryComboBox.Items.AddRange(Enum.GetNames(typeof(Countries)));
            countryComboBox.SelectedIndex = 0;
            userRadioButton.Checked = true;
        }
        /// <summary>
        /// Methods to read first name from textBox
        /// </summary>
        private bool ReadFirstName()
        {
            if (!string.IsNullOrEmpty(firstNameTextBox.Text.Trim()))
            {
                firstName = firstNameTextBox.Text.Trim();
            }
            else
            {
                MessageBox.Show("Invalid name");
                return false;
            }
            return true;
        }
        /// <summary>
        /// Methods to read last name from textBox
        /// </summary>
        private bool ReadLastName()
        {
            if (!string.IsNullOrEmpty(lastNameTextBox.Text.Trim()))
            {
                lastName = lastNameTextBox.Text.Trim();
            }
            else
            {
                MessageBox.Show("Invalid name");
                return false;
            }
            return true;
        }
        /// <summary>
        /// Methods to read both first and last name
        /// </summary>
        private bool ReadNames()
        {
            return ReadFirstName() && ReadLastName();
        }
        /// <summary>
        /// Methods to read office phone from textBox
        /// </summary>
        private bool ReadOfficePhone()
        {
            if (!string.IsNullOrEmpty(officePhoneTextBox.Text.Trim()))
            {
                officePhone = officePhoneTextBox.Text.Trim();
            }
            else
            {
                MessageBox.Show("Invalid phone");
                return false;
            }
            return true;
        }
        /// <summary>
        /// Methods to read cell phone from textBox
        /// </summary>
        private bool ReadCellPhone()
        {
            if (!string.IsNullOrEmpty(cellPhoneTextBox.Text.Trim()))
            {
                cellPhone = cellPhoneTextBox.Text.Trim();
            }
            else
            {
                MessageBox.Show("Invalid phone");
                return false;
            }
            return true;
        }
        /// <summary>
        /// Methods to read both phones
        /// </summary>
        private bool ReadPhones()
        {
            return ReadCellPhone() && ReadOfficePhone();
        }
        /// <summary>
        /// Methods to read office email from textBox
        /// </summary>
        private bool ReadOfficeEmail()
        {
            if (!string.IsNullOrEmpty(officeEmailTextBox.Text.Trim()))
            {
                officeEmail = officeEmailTextBox.Text.Trim();
            }
            else
            {
                MessageBox.Show("Invalid email");
                return false;
            }
            return true;
        }
        /// <summary>
        /// Methods to read personal email from textBox
        /// </summary>
        private bool ReadPersonalEmail()
        {
            if (!string.IsNullOrEmpty(personalEmailTextBox.Text.Trim()))
            {
                personalEmail = personalEmailTextBox.Text.Trim();
            }
            else
            {
                MessageBox.Show("Invalid email");
                return false;
            }
            return true;
        }
        /// <summary>
        /// Methods to both emails
        /// </summary>
        private bool ReadEmails()
        {
            return ReadPersonalEmail() && ReadOfficeEmail();
        }
        /// <summary>
        /// Methods to read street name from textBox
        /// </summary>
        private bool ReadStreet()
        {
            if (!string.IsNullOrEmpty(streetTextBox.Text.Trim()))
            {
                street = streetTextBox.Text.Trim();
            }
            else
            {
                MessageBox.Show("Invalid street");
                return false;
            }
            return true;
        }
        /// <summary>
        /// Methods to read city name from textBox
        /// </summary>
        private bool ReadCity()
        {
            if (!string.IsNullOrEmpty(cityTextBox.Text.Trim()))
            {
                city = cityTextBox.Text.Trim();
            }
            else
            {
                MessageBox.Show("Invalid city");
                return false;
            }
            return true;
        }
        /// <summary>
        /// Methods to read zip number from textBox
        /// </summary>
        private bool ReadZip()
        {
            if (!string.IsNullOrEmpty(zipTextBox.Text.Trim()))
            {
                zip = zipTextBox.Text.Trim();
            }
            else
            {
                MessageBox.Show("Invalid zip");
                return false;
            }
            return true;
        }
        /// <summary>
        /// Methods to read country name from textBox
        /// </summary>
        private bool ReadCountry()
        {
            if (!string.IsNullOrEmpty(countryComboBox.Text.Trim()))
            {
                country = (Countries)Enum.Parse(typeof(Countries), countryComboBox.Text);
            }
            else
            {
                MessageBox.Show("Invalid country");
                return false;
            }
            return true;
        }
        /// <summary>
        /// Methods to read admin or user from radio button
        /// </summary>
        private bool ReadAdminOrUser()
        {
            userType = (adminRadioButton.Checked) ? UserTypes.Administrator : UserTypes.User;
            return true;
        }
        /// <summary>
        /// Methods to read all address infos
        /// </summary>
        private bool ReadAddress()
        {
            return ReadStreet() && ReadCity() && ReadZip() && ReadCountry();
        }
        /// <summary>
        /// Methods triggered by the ok button that reads evetything
        /// </summary>
        private void okButton_Click(object sender, EventArgs e)
        {
            if (ReadNames() && ReadEmails() && ReadPhones() && ReadAddress() && ReadAdminOrUser())
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                return;
            }
        }
    }
}
