using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_7
{
    public partial class AddEditRouteForm : Form
    {
        public CitiesManager cm { get; set; } = new();
        public string from { get; set; } = String.Empty;
        public string to { get; set; } = String.Empty;
        public double price { get; set; } = 0;
        public int minutes { get; set; } = 0;
        public TransportationTypes transportationType { get; set; } = new();
        /// <summary>
        /// Constructor for adding a route
        /// </summary>
        /// <param name="cities"></param>
        /// <param name="title"></param>
        public AddEditRouteForm(List<string> cities, string title)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            cm = new(cities);
            InitializeGUI();
            Text = title;
        }
        /// <summary>
        /// Constructor for editing a route
        /// </summary>
        /// <param name="cities"></param>
        /// <param name="title"></param>
        /// <param name="r"></param>
        public AddEditRouteForm(List<string> cities, string title, Route r)
        {
            InitializeComponent();
            Text = title;
            cm = new(cities);
            InitializeGUI();
            fromComboBox.SelectedItem = r.from;
            toComboBox.SelectedItem = r.to;
            priceTextBox.Text = r.price.ToString();
            minutesTextBox.Text = r.minutes.ToString();
            trasportationComboBox.SelectedItem = r.transportationType.ToString();
        }
        /// <summary>
        /// Methods to init the GUI
        /// </summary>
        private void InitializeGUI()
        {
            trasportationComboBox.Items.Clear();
            trasportationComboBox.Items.AddRange(Enum.GetNames(typeof(TransportationTypes)));
            trasportationComboBox.SelectedIndex = 0;
            fromComboBox.Items.Clear();
            for (int i = 0; i < cm.GetCitiesList().Count; i++)
            {
                fromComboBox.Items.Add(cm.GetCity(i));
            }
            toComboBox.Items.Clear();
            for (int i = 0; i < cm.GetCitiesList().Count; i++)
            {
                toComboBox.Items.Add(cm.GetCity(i));
            }
            if (cm.GetCitiesList().Count > 0)
            {
                fromComboBox.SelectedIndex = 0;
            }
            if (cm.GetCitiesList().Count > 1)
            {
                toComboBox.SelectedIndex = 1;
            }
        }
        /// <summary>
        /// Methods to read from city name from textBox
        /// </summary>
        private bool ReadFrom()
        {
            if (!string.IsNullOrEmpty(fromComboBox.Text.Trim()))
            {
                from = fromComboBox.Text.Trim();
            }
            else
            {
                MessageBox.Show("Invalid depature city");
                return false;
            }
            return true;
        }
        /// <summary>
        /// Methods to read to city name from textBox
        /// </summary>
        private bool ReadTo()
        {
            if (!string.IsNullOrEmpty(toComboBox.Text.Trim()))
            {
                to = toComboBox.Text.Trim();
            }
            else
            {
                MessageBox.Show("Invalid arrival city");
                return false;
            }
            return true;
        }
        /// <summary>
        /// Methods to read price from textBox
        /// </summary>
        private bool ReadPrice()
        {
            double val;
            if (!string.IsNullOrEmpty(priceTextBox.Text.Trim()))
            {
                if (double.TryParse(priceTextBox.Text.Trim(), out val))
                {
                    price = val;
                }
                else
                {
                    MessageBox.Show("Invalid price");
                    price = 0;
                    return false;
                }
            }
            else
            {
                price = 0;
                MessageBox.Show("Invalid price");
                return false;
            }
            if (price < 0)
            {
                MessageBox.Show("Invalid price");
                price = 0;
                return false;
            }
            return true;
        }
        /// <summary>
        /// Methods to read transportation type name from textBox
        /// </summary>
        private bool ReadTransportation()
        {
            if (!string.IsNullOrEmpty(trasportationComboBox.Text.Trim()))
            {
                transportationType = (TransportationTypes)Enum.Parse(typeof(TransportationTypes), trasportationComboBox.Text.Trim());
            }
            else
            {
                MessageBox.Show("Invalid transportation type");
                return false;
            }
            return true;
        }
        /// <summary>
        /// Methods to read minutes from textBox
        /// </summary>
        private bool ReadMinutes()
        {
            int val;
            if (!string.IsNullOrEmpty(minutesTextBox.Text.Trim()))
            {
                if (int.TryParse(minutesTextBox.Text.Trim(), out val))
                {
                    minutes = val;
                }
                else
                {
                    MessageBox.Show("Invalid mintues");
                    minutes = 0;
                    return false;
                }
            }
            else
            {
                minutes = 0;
                MessageBox.Show("Invalid minutes");
                return false;
            }
            if (price < 0)
            {
                MessageBox.Show("Invalid minutes");
                minutes = 0;
                return false;
            }
            return true;
        }
        /// <summary>
        /// Methods triggered by the ok button that reads evetything
        /// </summary>
        private void addButton_Click(object sender, EventArgs e)
        {
            if (ReadFrom() && ReadTo() && ReadPrice() && ReadTransportation() && ReadMinutes())
            {
                if (from == to)
                {
                    MessageBox.Show("You cannot pick the same city", "Error");
                    return;
                }
                else
                {
                    this.DialogResult = DialogResult.OK;
                }
            }
            else
            {
                return;
            }
        }
        /// <summary>
        /// Methods triggered by the cities button
        /// Opens a new menu to interact with cities
        /// </summary>
        private void citiesButton_Click(object sender, EventArgs e)
        {
            AddRemoveCities adr = new(cm.GetCitiesList());
            DialogResult dr = adr.ShowDialog();
            if(dr == DialogResult.OK)
            {
                cm = new(adr.cm.GetCitiesList());
                InitializeGUI();
            }
        }
    }
}
