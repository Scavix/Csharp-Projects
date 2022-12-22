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
    public partial class UsersManagementForm : Form
    {
        UsersLoginInfosManager ulim;
        private AddEditUserForm aeuf { get; set; }
        private FileManager fileManager { get; set; } = new();
        /// <summary>
        /// Basic constructor that read from file
        /// </summary>
        public UsersManagementForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            fileManager = new();
            List<UserLoginInfo> userLoginInfoList = new();
            if (!fileManager.ReadUserLoginInfoData(userLoginInfoList))
            {
                MessageBox.Show("Problem in reading user data","Error");
            }
            ulim = new(userLoginInfoList);
            InitializeGUI();
        }
        /// <summary>
        /// Method to initialize GUI, to prepare listview
        /// </summary>
        public void InitializeGUI()
        {
            ColumnHeader header0 = new()
            {
                Text = "First Name",
                TextAlign = HorizontalAlignment.Center,
                Width = 120
            };
            usersListView.Columns.Add(header0);
            ColumnHeader header1 = new()
            {
                Text = "Last Name",
                TextAlign = HorizontalAlignment.Center,
                Width = 120
            };
            usersListView.Columns.Add(header1);
            ColumnHeader header2 = new()
            {
                Text = "Type",
                TextAlign = HorizontalAlignment.Center,
                Width = 100
            };
            usersListView.Columns.Add(header2);
            ColumnHeader header3 = new()
            {
                Text = "Office Phone",
                TextAlign = HorizontalAlignment.Center,
                Width = 120
            };
            usersListView.Columns.Add(header3);
            ColumnHeader header4 = new()
            {
                Text = "Office Email",
                TextAlign = HorizontalAlignment.Center,
                Width = 150
            };
            usersListView.Columns.Add(header4);
            ColumnHeader header5 = new()
            {
                Text = "City",
                TextAlign = HorizontalAlignment.Center,
                Width = 120
            };
            usersListView.Columns.Add(header5);
            ColumnHeader header6 = new()
            {
                Text = "Country",
                TextAlign = HorizontalAlignment.Center,
                Width = 158
            };
            usersListView.Columns.Add(header6);
            usersListView.View = View.Details;
            UpdateGUI();
        }
        /// <summary>
        /// Methods to update the ListView.
        /// </summary>
        private void UpdateGUI()
        {
            usersListView.Items.Clear();
            for (int i = 0; i < ulim.GetUserList().Count; i++)
            {
                ListViewItem lvi = new(ulim.GetUser(i).Contact.FirstName);
                lvi.SubItems.Add(ulim.GetUser(i).Contact.LastName);
                lvi.SubItems.Add(ulim.GetUser(i).UserType.ToString());
                lvi.SubItems.Add(ulim.GetUser(i).Contact.Phone.OfficePhone);
                lvi.SubItems.Add(ulim.GetUser(i).Contact.Email.OfficeMail);
                lvi.SubItems.Add(ulim.GetUser(i).Contact.Address.City);
                lvi.SubItems.Add(ulim.GetUser(i).Contact.Address.Country.ToString());
                usersListView.Items.Add(lvi);
            }
        }
        /// <summary>
        /// Methods triggered by the add button click
        /// It opens the user form
        /// </summary>
        private void addButton_Click(object sender, EventArgs e)
        {
            aeuf = new("Add new User");
            DialogResult dg = aeuf.ShowDialog();
            if (dg == DialogResult.OK)
            {
                string firstName = aeuf.firstName;
                string lastName = aeuf.lastName;
                Phone phone = new(aeuf.cellPhone, aeuf.officePhone);
                Email email = new(aeuf.personalEmail, aeuf.officePhone);
                Address address = new(aeuf.street, aeuf.city, aeuf.zip, aeuf.country);
                UserTypes userType = aeuf.userType;
                ulim.AddUser(new User("----",new Contact(firstName, lastName, address, phone, email),userType));
                UpdateGUI();
            }
        }
        /// <summary>
        /// Methods triggered by the edit button click
        /// It opens the user form
        /// </summary>
        private void editButton_Click(object sender, EventArgs e)
        {
            if (usersListView.Items.Count < 1)
            {
                return;
            }
            if (usersListView.SelectedIndices.Count != 1)
            {
                return;
            }
            aeuf = new("Edit customer", ulim.GetUser(usersListView.SelectedIndices[0]));
            DialogResult dg = aeuf.ShowDialog();
            if (dg == DialogResult.OK)
            {
                string firstName = aeuf.firstName;
                string lastName = aeuf.lastName;
                Phone phone = new(aeuf.cellPhone, aeuf.officePhone);
                Email email = new(aeuf.personalEmail, aeuf.officePhone);
                Address address = new(aeuf.street, aeuf.city, aeuf.zip, aeuf.country);
                UserTypes userType = aeuf.userType;
                ulim.ChangeUser(new User("----", new Contact(firstName, lastName, address, phone, email), userType), usersListView.SelectedIndices[0]);
                UpdateGUI();
            }
        }
        /// <summary>
        /// Methods triggered by the delete button click
        /// It deletes the current selected user
        /// </summary>
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (usersListView.Items.Count < 1)
            {
                return;
            }
            if (usersListView.SelectedIndices.Count != 1)
            {
                return;
            }
            ulim.RemoveUser(usersListView.SelectedIndices[0]);
            UpdateGUI();
        }
        /// <summary>
        /// Methods triggered by a click on the view button
        /// It opens the details in a messageBox
        /// </summary>
        private void viewButton_Click(object sender, EventArgs e)
        {
            if (usersListView.Items.Count < 1)
            {
                return;
            }
            if (usersListView.SelectedIndices.Count != 1)
            {
                return;
            }
            User u = ulim.GetUser(usersListView.SelectedIndices[0]);
            string s = string.Empty;
            s += "User Id: " + u.UserId + "\n\n";
            s += u.Contact.FirstName + " " + u.Contact.LastName + "\n\n";
            s += "Address:\n"+u.Contact.Address.Street + "\n";
            s += u.Contact.Address.City + ", " +u.Contact.Address.Zip + "\n";
            s += u.Contact.Address.Country.ToString() + "\n\n";
            s += "Emails\n Personal " + u.Contact.Email.PersonalMail + "\n Office " + u.Contact.Email.OfficeMail + "\n\n";
            s += "Phone numbers\n Cell " + u.Contact.Phone.CellPhone + "\n Office " + u.Contact.Phone.OfficePhone;
            MessageBox.Show(s,"Detailed view");
        }
        /// <summary>
        /// Method triggered by the button click save data
        /// </summary>
        private void saveButton_Click(object sender, EventArgs e)
        {
            fileManager = new();
            if (fileManager.WriteUserLoginInfoDataToFile(ulim.GetUserLoginInfoList()))
            {
                MessageBox.Show("Data saved to file", "Success");
            }
            else
            {
                MessageBox.Show("Error while saving data to file", "Error");
            }
        }
    }
}
