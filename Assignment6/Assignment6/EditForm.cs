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

namespace Assignment6
{
    public partial class EditForm : Form
    {
        public string description { get; set; }
        public PriorityType priority { get; set; }
        public DateTime dateTime { get; set; }
        /// <summary>
        /// Main Constructor
        /// </summary>
        public EditForm(string d, PriorityType pt, DateTime dt)
        {
            InitializeComponent();
            description = d;
            priority = pt;
            dateTime = dt;
            InitializeGUI();
        }
        /// <summary>
        /// Methods to init the GUI
        /// </summary>
        private void InitializeGUI()
        {
            System.Windows.Forms.ToolTip tt = new();
            tt.SetToolTip(dateTimePickerEdit, "Click to open calendar for date, write time in here");
            priorityComboBoxEdit.Items.AddRange(Enum.GetNames(typeof(PriorityType)));
            priorityComboBoxEdit.SelectedIndex = 0;
            priorityComboBoxEdit.Text = priority.ToString();
            descriptionTextBoxEdit.Text = description;
            dateTimePickerEdit.Text = dateTime.ToString();
        }
        /// <summary>
        /// Methods to read description from textBox
        /// </summary>
        private bool ReadDescription()
        {
            if (!string.IsNullOrEmpty(descriptionTextBoxEdit.Text.Trim()))
            {
                description = descriptionTextBoxEdit.Text.Trim();
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
            if (!string.IsNullOrEmpty(priorityComboBoxEdit.Text.Trim()))
            {
                priority = (PriorityType)Enum.Parse(typeof(PriorityType), priorityComboBoxEdit.Text);
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
            if (!string.IsNullOrEmpty(dateTimePickerEdit.Text.Trim()))
            {
                string date = dateTimePickerEdit.Text.Split(" ")[0];
                string time = dateTimePickerEdit.Text.Split(" ")[1];
                dateTime = new DateTime(int.Parse(date.Split("/")[2]), int.Parse(date.Split("/")[1]), int.Parse(date.Split("/")[0]), int.Parse(time.Split(":")[0]), int.Parse(time.Split(":")[1]), int.Parse(time.Split(":")[2]));
            }
            else
            {
                MessageBox.Show("Invalid datetime");
                return false;
            }
            return true;
        }
        private void okButton_Click(object sender, EventArgs e)
        {
            if (ReadDateTime() && ReadDescription() && ReadPriority())
            {
                this.DialogResult= DialogResult.OK;
            }
        }
    }
}
