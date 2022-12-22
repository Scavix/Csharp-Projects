using System.Diagnostics.Metrics;
using System.Net;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Assignment6
{
    public partial class MainForm : Form
    {
        /// Icons source
        /// https://icons8.com/icons/set/question
        /// https://icons8.com/icons/set/file
        /// https://icons8.com/icons/set/exit
        /// https://icons8.com/icons/set/download
        /// https://icons8.com/icons/set/upload
        /// https://icons8.com/icons/set/todo
        private Task currentTask = new();
        private TaskManager tm = new();
        private int seconds = 0;
        private string fileName = Application.StartupPath + "\\Tasks.txt";
        /// <summary>
        /// Constructor
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }
        /// <summary>
        /// Methods to init the GUI
        /// </summary>
        private void InitializeGUI()
        {
            deleteButton.Enabled = false;
            changeButton.Enabled = false;
            ToolTip tt = new();
            tt.SetToolTip(dateTimePicker, "Click to open calendar for date, write time in here");
            tt.SetToolTip(priorityComboBox, "Select priority");
            tt.SetToolTip(toDoTextBox, "Write your sins here");
            tt.SetToolTip(addButton, "Click to add Task");
            tt.SetToolTip(deleteButton, "Click to remove Task");
            tt.SetToolTip(changeButton, "Click to edit Task");
            ColumnHeader header1 = new()
            {
                Text = "Date",
                TextAlign = HorizontalAlignment.Center,
                Width = 110
            };
            listView.Columns.Add(header1);
            ColumnHeader header2 = new()
            {
                Text = "Hour",
                TextAlign = HorizontalAlignment.Center,
                Width = 110
            };
            listView.Columns.Add(header2);
            ColumnHeader header3 = new()
            {
                Text = "Priority",
                TextAlign = HorizontalAlignment.Center,
                Width = 140
            };
            listView.Columns.Add(header3);
            ColumnHeader header4 = new()
            {
                Text = "Description",
                TextAlign = HorizontalAlignment.Center,
                Width = 309
            };
            listView.Columns.Add(header4);
            listView.View = View.Details;
            priorityComboBox.Items.AddRange(Enum.GetNames(typeof(PriorityType)));
            priorityComboBox.SelectedIndex = 0;
            UpdateTimer();
        }
        /// <summary>
        /// Methods to update the ListView.
        /// </summary>
        private void UpdateGUI()
        {
            listView.Items.Clear();
            ListViewItem lvi;
            for (int i = 0; i < tm.getTaskList().Count; i++)
            {
                lvi = new(tm.getTaskAt(i).dateTime.Date.ToString());
                lvi.SubItems.Add(tm.getTaskAt(i).dateTime.Hour.ToString());
                lvi.SubItems.Add(tm.getTaskAt(i).priority.ToString());
                lvi.SubItems.Add(tm.getTaskAt(i).description);
                listView.Items.Add(lvi);
            }
        }
        /// <summary>
        /// Method triggered for updating the label of timer
        /// </summary>
        private void UpdateTimer()
        {
            decimal d = seconds / 60;
            timerLabel.Text = "";
            timerLabel.Text += (Math.Floor(d) > 9) ? Math.Floor(d) : "0" + Math.Floor(d);
            timerLabel.Text += ":";
            timerLabel.Text += (seconds % 60 > 9) ? seconds % 60 : "0" + seconds % 60;
        }
        /// <summary>
        /// Methods to read description from textBox
        /// </summary>
        private bool ReadDescription()
        {
            if (!string.IsNullOrEmpty(toDoTextBox.Text.Trim()))
            {
                currentTask.description = toDoTextBox.Text.Trim();
            }
            else
            {
                MessageBox.Show("Invalid description");
                return false;
            }
            return true;
        }
        /// <summary>
        /// Methods to read priority type from comboBox
        /// </summary>
        private bool ReadPriority()
        {
            if (!string.IsNullOrEmpty(priorityComboBox.Text.Trim()))
            {
                currentTask.priority = (PriorityType)Enum.Parse(typeof(PriorityType), priorityComboBox.Text);
            }
            else
            {
                MessageBox.Show("Invalid priority");
                return false;
            }
            return true;
        }
        /// <summary>
        /// Methods to read datetime from picker
        /// </summary>
        private bool ReadDateTime()
        {
            if (!string.IsNullOrEmpty(dateTimePicker.Text.Trim()))
            {
                string date = dateTimePicker.Text.Split(" ")[0];
                string time = dateTimePicker.Text.Split(" ")[1];
                currentTask.dateTime = new DateTime(int.Parse(date.Split("/")[2]), int.Parse(date.Split("/")[1]), int.Parse(date.Split("/")[0]), int.Parse(time.Split(":")[0]), int.Parse(time.Split(":")[1]), int.Parse(time.Split(":")[2]));
            }
            else
            {
                MessageBox.Show("Invalid datetime");
                return false;
            }
            return true;
        }
        /// <summary>
        /// Methods triggered by the about tootltip click
        /// </summary>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox ab = new();
            ab.ShowDialog();
        }
        /// <summary>
        /// Method triggered by the add button click
        /// </summary>
        private void addButton_Click(object sender, EventArgs e)
        {
            if (ReadDateTime()&&ReadDescription()&&ReadPriority())
            {
                tm.AddTask(currentTask);
                currentTask = new Task();
                UpdateGUI();
                if (tm.getTaskList().Count>0)
                {
                    deleteButton.Enabled = true;
                    changeButton.Enabled = true;
                }
                else
                {
                    deleteButton.Enabled = false;
                    changeButton.Enabled = false;
                }
            }
        }
        /// <summary>
        /// Method triggered by the delete button click
        /// </summary>
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (tm.getTaskList().Count<1)
            {
                return;
            }
            if (listView.SelectedIndices.Count!=1)
            {
                return;
            }
            tm.RemoveTask(listView.SelectedIndices[0]);
            UpdateGUI();
            if (tm.getTaskList().Count > 0)
            {
                deleteButton.Enabled = true;
                changeButton.Enabled = true;
            }
            else
            {
                deleteButton.Enabled = false;
                changeButton.Enabled = false;
            }
        }
        /// <summary>
        /// Method triggered by the change button click
        /// </summary>
        private void changeButton_Click(object sender, EventArgs e)
        {
            if (tm.getTaskList().Count < 1)
            {
                return;
            }
            if (listView.SelectedIndices.Count != 1)
            {
                return;
            }
            EditForm ef = new EditForm(tm.getTaskAt(listView.SelectedIndices[0]).description, tm.getTaskAt(listView.SelectedIndices[0]).priority, tm.getTaskAt(listView.SelectedIndices[0]).dateTime);
            DialogResult dg = ef.ShowDialog();
            if (dg == DialogResult.OK)
            {
                tm.ChangeTask(new Task(ef.description,ef.priority,ef.dateTime), listView.SelectedIndices[0]);
                UpdateGUI();
            }
        }
        /// <summary>
        /// Method triggered by the tooltip menu Exit click
        /// </summary>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExitForm ef = new();
            DialogResult dr = ef.ShowDialog();
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        /// <summary>
        /// Method triggered by the timer event every second
        /// </summary>
        private void timer_Tick(object sender, EventArgs e)
        {
            seconds++;
            UpdateTimer();
        }
        /// <summary>
        /// Method triggered by the tooltip menu open data file click
        /// </summary>
        private void openDataFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tm.ReadDataFromFile(fileName))
            {
                UpdateGUI();
            }
            else
            {
                MessageBox.Show("Error while reading data from file " + fileName, "Error");
            }
        }
        /// <summary>
        /// Method triggered by the tooltip menu save data file click
        /// </summary>
        private void saveDataFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tm.WriteDataFromFile(fileName))
            {
                MessageBox.Show("Data saved to file: " + fileName, "Success");
            }
            else
            {
                MessageBox.Show("Error while saving data to file " + fileName, "Error");
            }
        }
    }
}