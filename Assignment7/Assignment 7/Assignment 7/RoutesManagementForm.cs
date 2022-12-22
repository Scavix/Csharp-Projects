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
    public partial class RoutesManagementForm : Form
    {
        public RoutesManager rm { get; set; }
        public CitiesManager cm { get; set; }
        private FileManager fileManager { get; set; }
        private AddEditRouteForm aerf { get; set; }
        /// <summary>
        /// Basic constructor to init all variables
        /// </summary>
        public RoutesManagementForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            fileManager = new();
            List<Route> routeList = new();
            if (!fileManager.ReadRoutesData(routeList))
            {
                MessageBox.Show("Problem in reading route data", "Error");
            }
            rm = new(routeList);
            cm = new();
            InitializeGUI();
        }
        /// <summary>
        /// Method to initialize GUI, to prepare listview
        /// </summary>
        public void InitializeGUI()
        {
            for (int i = 0; i < rm.GetRouteList().Count; i++)
            {
                if (!cm.GetCitiesList().Contains(rm.GetRoute(i).from))
                {
                    cm.AddCity(rm.GetRoute(i).from);
                }
                if (!cm.GetCitiesList().Contains(rm.GetRoute(i).to))
                {
                    cm.AddCity(rm.GetRoute(i).to);
                }
            }
            ColumnHeader header0 = new()
            {
                Text = "From",
                TextAlign = HorizontalAlignment.Center,
                Width = 130
            };
            routesListView.Columns.Add(header0);
            ColumnHeader header1 = new()
            {
                Text = "To",
                TextAlign = HorizontalAlignment.Center,
                Width = 150
            };
            routesListView.Columns.Add(header1);
            ColumnHeader header2 = new()
            {
                Text = "Price €",
                TextAlign = HorizontalAlignment.Center,
                Width = 100
            };
            routesListView.Columns.Add(header2);
            ColumnHeader header3 = new()
            {
                Text = "Minutes",
                TextAlign = HorizontalAlignment.Center,
                Width = 100
            };
            routesListView.Columns.Add(header3);
            ColumnHeader header4 = new()
            {
                Text = "Transportation",
                TextAlign = HorizontalAlignment.Center,
                Width = 180
            };
            routesListView.Columns.Add(header4);
            routesListView.View = View.Details;
            UpdateGUI();
        }
        /// <summary>
        /// Methods to update the ListView.
        /// </summary>
        private void UpdateGUI()
        {
            cm.ClearCities();
            for (int i = 0; i < rm.GetRouteList().Count; i++)
            {
                if (!cm.GetCitiesList().Contains(rm.GetRoute(i).from))
                {
                    cm.AddCity(rm.GetRoute(i).from);
                }
                if (!cm.GetCitiesList().Contains(rm.GetRoute(i).to))
                {
                    cm.AddCity(rm.GetRoute(i).to);
                }
            }
            routesListView.Items.Clear();
            for (int i = 0; i < rm.GetRouteList().Count; i++)
            {
                ListViewItem lvi = new(rm.GetRoute(i).from);
                lvi.SubItems.Add(rm.GetRoute(i).to);
                lvi.SubItems.Add(rm.GetRoute(i).price.ToString());
                lvi.SubItems.Add(rm.GetRoute(i).minutes.ToString());
                lvi.SubItems.Add(rm.GetRoute(i).transportationType.ToString());
                routesListView.Items.Add(lvi);
            }
        }
        /// <summary>
        /// Methods triggered by the add button click
        /// It opens the route form
        /// </summary>
        private void addButton_Click(object sender, EventArgs e)
        {
            aerf = new(cm.GetCitiesList(), "Add new Route");
            DialogResult dg = aerf.ShowDialog();
            if (dg == DialogResult.OK || dg == DialogResult.Continue)
            {
                string from = aerf.from;
                string to = aerf.to;
                double price = aerf.price;
                TransportationTypes transportationType = aerf.transportationType;
                int minutes = aerf.minutes;
                cm.ClearCities();
                for (int i = 0; i < aerf.cm.GetCitiesList().Count; i++)
                {
                    cm.AddCity(aerf.cm.GetCity(i));
                }
                if (dg == DialogResult.OK)
                {
                    rm.AddRoute(new Route(from, to, price, transportationType, minutes));
                }
                List<int> indexesToRemove = new ();
                for (int i = 0; i < rm.GetRouteList().Count; i++)
                {
                    if ((!cm.GetCitiesList().Contains(rm.GetRoute(i).from)) || (!cm.GetCitiesList().Contains(rm.GetRoute(i).to)))
                    {
                        indexesToRemove.Add(i);
                    }
                }
                for(int i = 0; i < indexesToRemove.Count; i++)
                {
                    rm.RemoveRoute(indexesToRemove[indexesToRemove.Count - i - 1]);
                }
                UpdateGUI();
            }
        }
        /// <summary>
        /// Methods triggered by the edit button click
        /// It opens the route form
        /// </summary>
        private void editButton_Click(object sender, EventArgs e)
        {
            if (routesListView.Items.Count < 1)
            {
                return;
            }
            if (routesListView.SelectedIndices.Count != 1)
            {
                return;
            }
            aerf = new(cm.GetCitiesList(), "Edit Route", rm.GetRoute(routesListView.SelectedIndices[0]));
            DialogResult dg = aerf.ShowDialog();
            if (dg == DialogResult.OK)
            {
                string from = aerf.from;
                string to = aerf.to;
                double price = aerf.price;
                TransportationTypes transportationType = aerf.transportationType;
                int minutes = aerf.minutes;
                rm.ChangeRoute(new Route(from, to, price, transportationType, minutes), routesListView.SelectedIndices[0]);
                UpdateGUI();
            }
        }
        /// <summary>
        /// Methods triggered by the delete button click
        /// It deletes the current selected route
        /// </summary>
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (routesListView.Items.Count < 1)
            {
                return;
            }
            if (routesListView.SelectedIndices.Count != 1)
            {
                return;
            }
            rm.RemoveRoute(routesListView.SelectedIndices[0]);
            UpdateGUI();
        }
        /// <summary>
        /// Methods triggered by a click on the view button
        /// It opens the details in a messageBox
        /// </summary>
        private void viewButton_Click(object sender, EventArgs e)
        {
            if (routesListView.Items.Count < 1)
            {
                return;
            }
            if (routesListView.SelectedIndices.Count != 1)
            {
                return;
            }
            Route r = rm.GetRoute(routesListView.SelectedIndices[0]);
            string s = string.Empty;
            s += "Route" + "\n\n";
            s += "From> " + r.from + "\n";
            s += "To> " + r.to + "\n";
            s += "Price> " + r.price.ToString() + "\n";
            s += "Trasportaion Type> " + r.transportationType.ToString();
            MessageBox.Show(s, "Detailed view");
        }
        /// <summary>
        /// Method triggered by the button click save data
        /// </summary>
        private void saveButton_Click(object sender, EventArgs e)
        {
            fileManager = new();
            if (fileManager.WriteRoutesDataToFile(rm.GetRouteList()))
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
