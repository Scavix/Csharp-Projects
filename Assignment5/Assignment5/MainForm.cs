namespace Assignment5
{
    public partial class MainForm : Form
    {
        // Customer Manager variable
        private CustomerManager cm = new();
        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }
        /// <summary>
        /// Method to inilialize GUI, to prepare listview
        /// </summary>
        private void InitializeGUI()
        {
            ColumnHeader header1 = new()
            {
                Text = "Id",
                TextAlign = HorizontalAlignment.Center,
                Width = 50
            };
            infoListView.Columns.Add(header1);
            ColumnHeader header2 = new()
            {
                Text = "Name",
                TextAlign = HorizontalAlignment.Center,
                Width = 128
            };
            infoListView.Columns.Add(header2);
            ColumnHeader header3 = new()
            {
                Text = "Office Phone",
                TextAlign = HorizontalAlignment.Center,
                Width = 180
            };
            infoListView.Columns.Add(header3);
            ColumnHeader header4 = new()
            {
                Text = "Office Email",
                TextAlign = HorizontalAlignment.Center,
                Width = 210
            };
            infoListView.Columns.Add(header4);
            infoListView.View = View.Details;
        }
        /// <summary>
        /// Methods to update the ListView.
        /// </summary>
        private void UpdateGUI()
        {
            infoListView.Items.Clear();
            for (int i = 0; i < cm.GetCustomerList().Count; i++)
            {
                ListViewItem lvi = new(cm.GetId(i).ToString());
                lvi.SubItems.Add(cm.GetCustomer(i).contact.lastName + ", " + cm.GetCustomer(i).contact.firstName);
                lvi.SubItems.Add(cm.GetCustomer(i).contact.phone.Home);
                lvi.SubItems.Add(cm.GetCustomer(i).contact.email.Work);
                infoListView.Items.Add(lvi);
            }
        }
        /// <summary>
        /// Methods triggered by the add button click
        /// It opens the customer form
        /// </summary>
        private void addButton_Click(object sender, EventArgs e)
        {
            ContactForm cf = new("Add new customer");
            DialogResult dg = cf.ShowDialog();
            if (dg == DialogResult.OK)
            {
                string firstName = cf.firstName;
                string lastName = cf.lastName;
                Phone phone = new(cf.homePhone,cf.cellPhone);
                Email email = new(cf.privateEmail,cf.businessEmail);
                Address address = new(cf.street,cf.city,cf.zip,cf.country);
                cm.AddCustomer(new Contact(firstName,lastName,address,phone,email));
                UpdateGUI();
            }
        }
        /// <summary>
        /// Methods triggered by the edit button click
        /// It opens the customer form
        /// </summary>
        private void editButton_Click(object sender, EventArgs e)
        {
            if (infoListView.Items.Count<1)
            {
                return;
            }
            if (infoListView.SelectedIndices.Count != 1)
            {
                return;
            }
            ContactForm cf = new("Edit customer", cm.GetCustomer(infoListView.SelectedIndices[0]));
            DialogResult dg = cf.ShowDialog();
            if (dg == DialogResult.OK)
            {
                string firstName = cf.firstName;
                string lastName = cf.lastName;
                Phone phone = new(cf.homePhone, cf.cellPhone);
                Email email = new(cf.privateEmail, cf.businessEmail);
                Address address = new(cf.street, cf.city, cf.zip, cf.country);
                cm.ChangeCustomer(new Contact(firstName, lastName, address, phone, email), infoListView.SelectedIndices[0]);
                UpdateGUI();
            }
        }
        /// <summary>
        /// Methods triggered by a double click on the listview
        /// It opens the details in the lateral tab
        /// </summary>
        private void infoListView_DoubleClick(object sender, EventArgs e)
        {
            Customer c = cm.GetCustomer(infoListView.SelectedIndices[0]);
            string s = string.Empty;
            s += c.contact.firstName + c.contact.lastName + "\n";
            s += c.contact.address.Street + "\n";
            s += c.contact.address.City + "\n";
            s += c.contact.address.Zip + "\n";
            s += c.contact.address.Country.ToString() + "\n\n";
            s += "Emails\n Private" + c.contact.email.Personal + "\n Office" + c.contact.email.Work + "\n\n";
            s += "Phone numbers\n Private" + c.contact.phone.Home + "\n Office" + c.contact.phone.Cell;
            contactTextBox.Text = s;
        }
        /// <summary>
        /// Methods triggered by the delete button click
        /// It deletes the current selected customer
        /// </summary>
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (infoListView.Items.Count < 1)
            {
                return;
            }
            if (infoListView.SelectedIndices.Count != 1)
            {
                return;
            }
            cm.RemoveCustomer(infoListView.SelectedIndices[0]);
            UpdateGUI();
            contactTextBox.Text = "";
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            contactTextBox.Text = "";
        }
    }
}