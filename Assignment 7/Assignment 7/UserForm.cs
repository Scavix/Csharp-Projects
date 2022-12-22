using System.Security.Cryptography.Xml;

namespace Assignment_7
{
    public partial class UserForm : Form
    {
        public string cityFrom { get; set; } = string.Empty;
        public string cityTo { get; set; } = string.Empty;
        public int timeMax { get; set; } = 0;
        public double priceMax { get; set; } = 0;
        public bool direct { get; set; } = true;
        public int adults { get; set; } = 0;
        public int children { get; set; } = 0;
        public List<TransportationTypes> TransportationTypesList { get; set; } = new();
        public RoutesManager rm { get; set; }
        public CitiesManager cm { get; set; }
        public SolutionsManager sm { get; set; }
        private FileManager fileManager { get; set; }
        /// <summary>
        /// Basic construtor that reads data from file
        /// </summary>
        public UserForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            fileManager = new();
            List<Route> routes = new();
            if (!fileManager.ReadRoutesData(routes))
            {
                MessageBox.Show("Problem in reading route data", "Error");
            }
            rm = new(routes);
            cm = new();
            sm = new();
            InitializeGUI();
        }
        /// <summary>
        /// Methods to init the GUI
        /// </summary>
        private void InitializeGUI()
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
            cityFromComboBox.Items.AddRange(cm.GetCitiesList().ToArray());
            cityFromComboBox.SelectedIndex = 0;
            cityToComboBox.Items.AddRange(cm.GetCitiesList().ToArray());
            cityToComboBox.SelectedIndex = (cm.GetCitiesList().Count > 0) ? 1 : 0;
            directCheckBox.Checked = true;
            adultsTextBox.Text = 1.ToString();
            childrenTextBox.Text = 0.ToString();
            transportationListBox.Items.AddRange(Enum.GetNames(typeof(TransportationTypes)));
            for (int i = 0; i < transportationListBox.Items.Count; i++)
            {
                transportationListBox.SetItemChecked(i, true);
            }
            priceMaxTextBox.Text = 0.ToString();
            timeMaxTextBox.Text = 0.ToString();
            ColumnHeader header0 = new()
            {
                Text = "From",
                TextAlign = HorizontalAlignment.Center,
                Width = 115
            };
            solutionListView.Columns.Add(header0);
            ColumnHeader header1_5 = new()
            {
                Text = "Changes",
                TextAlign = HorizontalAlignment.Center,
                Width = 200
            };
            solutionListView.Columns.Add(header1_5);
            ColumnHeader header1 = new()
            {
                Text = "To",
                TextAlign = HorizontalAlignment.Center,
                Width = 115
            };
            solutionListView.Columns.Add(header1);
            ColumnHeader header2 = new()
            {
                Text = "Price €",
                TextAlign = HorizontalAlignment.Center,
                Width = 100
            };
            solutionListView.Columns.Add(header2);
            ColumnHeader header3 = new()
            {
                Text = "Minutes",
                TextAlign = HorizontalAlignment.Center,
                Width = 100
            };
            solutionListView.Columns.Add(header3);
            ColumnHeader header4 = new()
            {
                Text = "Direct",
                TextAlign = HorizontalAlignment.Center,
                Width = 80
            };
            solutionListView.Columns.Add(header4);
            ColumnHeader header5 = new()
            {
                Text = "People",
                TextAlign = HorizontalAlignment.Center,
                Width = 80
            };
            solutionListView.Columns.Add(header5);
            ColumnHeader header6 = new()
            {
                Text = "Transportation(s)",
                TextAlign = HorizontalAlignment.Center,
                Width = 205
            };
            solutionListView.Columns.Add(header6);
            solutionListView.View = View.Details;
            UpdateGUI();
        }
        /// <summary>
        /// Methods to update the ListView.
        /// </summary>
        private void UpdateGUI()
        {
            solutionListView.Items.Clear();
            for (int i = 0; i < sm.GetSolutionsList().Count; i++)
            {
                ListViewItem lvi = new(sm.GetSolution(i).From);
                lvi.SubItems.Add(sm.GetSolution(i).Rm.GetRouteList().Count == 1
                                    ?
                                    "--"
                                        :   
                                   (sm.GetSolution(i).Rm.GetRouteList().Count == 2
                                        ?
                                        sm.GetSolution(i).Rm.GetRoute(0).to
                                            :
                                       (sm.GetSolution(i).Rm.GetRoute(0).to
                                            + ", " +
                                        sm.GetSolution(i).Rm.GetRoute(1).to)));
                lvi.SubItems.Add(sm.GetSolution(i).To);
                lvi.SubItems.Add(sm.GetSolution(i).TotalPrice.ToString());
                lvi.SubItems.Add(sm.GetSolution(i).TotalMinutes.ToString());
                lvi.SubItems.Add(sm.GetSolution(i).Rm.GetRouteList().Count == 1 ? "YES" : "NO");
                lvi.SubItems.Add((sm.preference.Adults + sm.preference.Children).ToString());
                string s = "";
                for (int j = 0; j < sm.GetSolution(i).Rm.GetRouteList().Count; j++)
                {
                    s += sm.GetSolution(i).Rm.GetRoute(j).transportationType.ToString() + ", ";
                }
                lvi.SubItems.Add(s[..^2]);
                solutionListView.Items.Add(lvi);
            }
        }
        /// <summary>
        /// Methods to read city name from comboBox
        /// </summary>
        private bool ReadCityFrom()
        {
            if (!string.IsNullOrEmpty(cityFromComboBox.Text.Trim()))
            {
                cityFrom = cityFromComboBox.Text.Trim();
            }
            else
            {
                MessageBox.Show("Invalid city");
                return false;
            }
            return true;
        }
        /// <summary>
        /// Methods to read city name to comboBox
        /// </summary>
        private bool ReadCityTo()
        {
            if (!string.IsNullOrEmpty(cityToComboBox.Text.Trim()))
            {
                cityTo = cityToComboBox.Text.Trim();
            }
            else
            {
                MessageBox.Show("Invalid city");
                return false;
            }
            return true;
        }
        /// <summary>
        /// Methods to read cities from and to
        /// </summary>
        private bool ReadCities()
        {
            if (ReadCityFrom() && ReadCityTo())
            {
                if (cityFrom != cityTo)
                {
                    return true;
                }
            }
            MessageBox.Show("Cannot pick the same place", "Error");
            return false;
        }
        /// <summary>
        /// Methods to read price min from textBox
        /// </summary>
        private bool ReadTimeMax()
        {
            int val;
            if (!string.IsNullOrEmpty(timeMaxTextBox.Text.Trim()))
            {
                if (int.TryParse(timeMaxTextBox.Text.Trim(), out val))
                {
                    timeMax = val;
                }
                else
                {
                    MessageBox.Show("Invalid time");
                    timeMax = 0;
                    return false;
                }
            }
            else
            {
                timeMax = 0;
                MessageBox.Show("Invalid time");
                return false;
            }
            if (timeMax < 0)
            {
                MessageBox.Show("Invalid time");
                timeMax = 0;
                return false;
            }
            return true;
        }
        /// <summary>
        /// Methods to read price max from textBox
        /// </summary>
        private bool ReadPriceMax()
        {
            double val;
            if (!string.IsNullOrEmpty(priceMaxTextBox.Text.Trim()))
            {
                if (double.TryParse(priceMaxTextBox.Text.Trim(), out val))
                {
                    priceMax = val;
                }
                else
                {
                    MessageBox.Show("Invalid price");
                    priceMax = 0;
                    return false;
                }
            }
            else
            {
                priceMax = 0;
                MessageBox.Show("Invalid price");
                return false;
            }
            if (priceMax < 0)
            {
                MessageBox.Show("Invalid price");
                priceMax = 0;
                return false;
            }
            return true;
        }
        private bool ReadPrices()
        {
            return ReadPriceMax() && ReadTimeMax();
        }
        /// <summary>
        /// Methods to read direct radio
        /// </summary>
        private bool ReadDirect()
        {
            direct = directCheckBox.Checked;
            return true;
        }
        /// <summary>
        /// Methods to read num of adults from textBox
        /// </summary>
        private bool ReadAdults()
        {
            int val;
            if (!string.IsNullOrEmpty(adultsTextBox.Text.Trim()))
            {
                if (int.TryParse(adultsTextBox.Text.Trim(), out val))
                {
                    adults = val;
                }
                else
                {
                    MessageBox.Show("Invalid adults");
                    adults = 1;
                    return false;
                }
            }
            else
            {
                adults = 1;
                MessageBox.Show("Invalid adults");
                return false;
            }
            if (adults < 1)
            {
                MessageBox.Show("Invalid adults");
                adults = 1;
                return false;
            }
            return true;
        }
        /// <summary>
        /// Methods to read num of children from textBox
        /// </summary>
        private bool ReadChildren()
        {
            int val;
            if (!string.IsNullOrEmpty(childrenTextBox.Text.Trim()))
            {
                if (int.TryParse(childrenTextBox.Text.Trim(), out val))
                {
                    children = val;
                }
                else
                {
                    MessageBox.Show("Invalid children");
                    children = 0;
                    return false;
                }
            }
            else
            {
                children = 0;
                MessageBox.Show("Invalid children");
                return false;
            }
            if (children < 0)
            {
                MessageBox.Show("Invalid children");
                children = 0;
                return false;
            }
            return true;
        }
        /// <summary>
        /// Methods to read num of people
        /// </summary>
        private bool ReadNoPeople()
        {
            return ReadAdults() && ReadChildren();
        }
        private bool ReadTransportations()
        {
            if (transportationListBox.CheckedItems.Count > 0)
            {
                TransportationTypesList = new();
                for (int i = 0; i < transportationListBox.CheckedItems.Count; i++)
                {
                    TransportationTypesList.Add((TransportationTypes)Enum.Parse(typeof(TransportationTypes), transportationListBox.CheckedItems[i].ToString()));
                }
            }
            else
            {
                MessageBox.Show("Invalid transportations");
                return false;
            }
            return true;
        }
        /// <summary>
        /// Where the magic happens
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchButton_Click(object sender, EventArgs e)
        {
            if (ReadCities() && ReadPrices() && ReadDirect() && ReadNoPeople() && ReadTransportations())
            {
                // Static method search routes take a list of routes and a preference to filter on the results
                sm = new(new(SearchManager.SearchRoutes(rm.GetRouteList(), cityFrom, cityTo)), new(timeMax, priceMax, direct, adults, children, TransportationTypesList));
                UpdateGUI();
            }
        }
        /// <summary>
        /// Method to buy a ticket, and print receipt to file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buyButton_Click(object sender, EventArgs e)
        {
            if (solutionListView.Items.Count < 1)
            {
                return;
            }
            if (solutionListView.SelectedIndices.Count != 1)
            {
                return;
            }
            fileManager = new();
            if (fileManager.WriteReceiptToFile(sm.GetSolution(solutionListView.SelectedIndices[0])))
            {
                MessageBox.Show("Data saved to file", "Success");
                detailsRichTextBox.Text = "[" + DateTime.Now.ToString() + "]";
                detailsRichTextBox.Text += "\nTICKET BOUGHT";
                detailsRichTextBox.Text += "\nFrom " + sm.GetSolution(solutionListView.SelectedIndices[0]).From;
                detailsRichTextBox.Text += "\nChange " + (sm.GetSolution(solutionListView.SelectedIndices[0]).Rm.GetRouteList().Count == 1
                                                          ?
                                                            "--"
                                                          :
                                                            (sm.GetSolution(solutionListView.SelectedIndices[0]).Rm.GetRouteList().Count == 2
                                                             ?
                                                                sm.GetSolution(solutionListView.SelectedIndices[0]).Rm.GetRouteList()[0].to
                                                             :
                                                               (sm.GetSolution(solutionListView.SelectedIndices[0]).Rm.GetRouteList()[0].to
                                                                + ", " +
                                                                sm.GetSolution(solutionListView.SelectedIndices[0]).Rm.GetRouteList()[1].to)));
                detailsRichTextBox.Text += "\nTo " + sm.GetSolution(solutionListView.SelectedIndices[0]).To;
                detailsRichTextBox.Text += "\nPrice per one " + sm.GetSolution(solutionListView.SelectedIndices[0]).Price + "€";
                detailsRichTextBox.Text += "\nTotal price " + sm.GetSolution(solutionListView.SelectedIndices[0]).TotalPrice + "€";
                detailsRichTextBox.Text += "\nMinutes " + sm.GetSolution(solutionListView.SelectedIndices[0]).TotalMinutes;
            }
            else
            {
                MessageBox.Show("Error while saving data to file", "Error");
                detailsRichTextBox.Text = "[" + DateTime.Now.ToString() + "]";
                detailsRichTextBox.Text += "\nERROR";
            }
        }
        /// <summary>
        /// Method triggered by the view button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void viewButton_Click(object sender, EventArgs e)
        {
            if (solutionListView.Items.Count < 1)
            {
                return;
            }
            if (solutionListView.SelectedIndices.Count != 1)
            {
                return;
            }
            string s = string.Empty;
            s += "From " + sm.GetSolution(solutionListView.SelectedIndices[0]).From;
            s += "\nChange " + (sm.GetSolution(solutionListView.SelectedIndices[0]).Rm.GetRouteList().Count == 1 ? "--" : (sm.GetSolution(solutionListView.SelectedIndices[0]).Rm.GetRouteList().Count == 2 ? sm.GetSolution(solutionListView.SelectedIndices[0]).Rm.GetRouteList()[0].to : (sm.GetSolution(solutionListView.SelectedIndices[0]).Rm.GetRouteList()[0].to + ", " + sm.GetSolution(solutionListView.SelectedIndices[0]).Rm.GetRouteList()[1].to + ", " + sm.GetSolution(solutionListView.SelectedIndices[0]).Rm.GetRouteList()[2].to)));
            s += "\nTo " + sm.GetSolution(solutionListView.SelectedIndices[0]).To;
            s += "\nPrice per one " + sm.GetSolution(solutionListView.SelectedIndices[0]).Price + "€";
            s += "\nTotal price " + sm.GetSolution(solutionListView.SelectedIndices[0]).TotalPrice + "€";
            s += "\nMinutes " + sm.GetSolution(solutionListView.SelectedIndices[0]).TotalMinutes;
            MessageBox.Show(s, "Detailed view");
        }
    }
}