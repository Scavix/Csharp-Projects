using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Assignment_7
{
    public partial class AddRemoveCities : Form
    {
        public CitiesManager cm { get; set; } = new();
        private string city { get; set; } = string.Empty;
        public AddRemoveCities(List<string> cities)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeGUI();
            cm = new(cities);
            UpdateGUI();
        }
        /// <summary>
        /// Methods to init the GUI
        /// </summary>
        private void InitializeGUI()
        {
            ColumnHeader header = new()
            {
                Text = "City",
                TextAlign = HorizontalAlignment.Center
            };
            citiesListView.Columns.Add(header);
            citiesListView.View = View.Details;
            citiesListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            UpdateGUI();
        }
        /// <summary>
        /// Methods to update the ListView.
        /// </summary>
        private void UpdateGUI()
        {
            citiesListView.Items.Clear();
            if (cm.GetCitiesList().Count>0) { 
                for (int i = 0; i < cm.GetCitiesList().Count; i++)
                {
                    ListViewItem lvi = new(cm.GetCity(i));
                    citiesListView.Items.Add(lvi);
                }
            }
        }
        /// <summary>
        /// Methods to read from city name from textBox
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
        /// Methods triggered by the add button click
        /// </summary>
        private void addButton_Click(object sender, EventArgs e)
        {
            if (ReadCity())
            {
                cm.AddCity(city);
                cityTextBox.Clear();
                UpdateGUI();
            }
        }
        /// <summary>
        /// Methods triggered by the delete button click
        /// It deletes the current selected city
        /// </summary>
        private void removeButton_Click(object sender, EventArgs e)
        {
            if (citiesListView.Items.Count < 1)
            {
                return;
            }
            if (citiesListView.SelectedIndices.Count != 1)
            {
                return;
            }
            cm.RemoveCity(citiesListView.SelectedIndices[0]);
            UpdateGUI();
        }
    }
}
