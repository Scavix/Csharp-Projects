using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5
{
    public partial class ContactForm : Form
    {
        public string firstName { get; set; } = String.Empty;
        public string lastName { get; set; } = String.Empty;
        public string homePhone { get; set; } = String.Empty;
        public string cellPhone { get; set; } = String.Empty;
        public string businessEmail { get; set; } = String.Empty;
        public string privateEmail { get; set; } = String.Empty;
        public string street { get; set; } = String.Empty;
        public string city { get; set; } = String.Empty;
        public string zip { get; set; } = String.Empty;
        public Countries country { get; set; }
        /// <summary>
        /// Constructor for adding a customer
        /// </summary>
        public ContactForm(string title)
        {
            InitializeComponent();
            InitializeGUI();
            Text = title;
        }
        /// <summary>
        /// Constructor for editing a customer
        /// </summary>
        public ContactForm(string title, Customer c)
        {
            InitializeComponent();
            InitializeGUI();
            Text = title;
            firstNameTextBox.Text = c.contact.firstName;
            lastNameTextBox.Text = c.contact.lastName;
            homePhoneTextBox.Text = c.contact.phone.Home;
            cellPhoneTextBox.Text = c.contact.phone.Cell;
            businessEmailTextBox.Text = c.contact.email.Work;
            privateEmailTextBox.Text = c.contact.email.Personal;
            streetTextBox.Text = c.contact.address.Street;
            cityTextBox.Text = c.contact.address.City;
            zipTextBox.Text = c.contact.address.Zip;
            countryComboBox.SelectedItem = c.contact.address.Country.ToString();
        }
        /// <summary>
        /// Methods to init the GUI
        /// </summary>
        private void InitializeGUI()
        {
            countryComboBox.Items.AddRange(Enum.GetNames(typeof(Countries)));
            countryComboBox.SelectedIndex = 0;
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
        /// Methods to read hoem phone from textBox
        /// </summary>
        private bool ReadHomePhone()
        {
            if (!string.IsNullOrEmpty(homePhoneTextBox.Text.Trim()))
            {
                homePhone = homePhoneTextBox.Text.Trim();
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
            return ReadCellPhone() && ReadHomePhone();
        }
        /// <summary>
        /// Methods to read vusiness email from textBox
        /// </summary>
        private bool ReadBusinessEmail()
        {
            if (!string.IsNullOrEmpty(businessEmailTextBox.Text.Trim()))
            {
                businessEmail = businessEmailTextBox.Text.Trim();
            }
            else
            {
                MessageBox.Show("Invalid email");
                return false;
            }
            return true;
        }
        /// <summary>
        /// Methods to read private email from textBox
        /// </summary>
        private bool ReadPrivateEmail()
        {
            if (!string.IsNullOrEmpty(privateEmailTextBox.Text.Trim()))
            {
                privateEmail = privateEmailTextBox.Text.Trim();
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
            return ReadPrivateEmail() && ReadBusinessEmail();
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
                country = (Countries) Enum.Parse(typeof(Countries), countryComboBox.Text);
            }
            else
            {
                MessageBox.Show("Invalid country");
                return false;
            }
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
            if (ReadNames()&&ReadEmails()&&ReadPhones()&&ReadAddress())
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
