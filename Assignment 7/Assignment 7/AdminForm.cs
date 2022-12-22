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
    public partial class AdminForm : Form
    {
        private UsersManagementForm usersManagementForm { get; set; }
        private RoutesManagementForm routesManagementForm { get; set; }
        public AdminForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void usersButton_Click(object sender, EventArgs e)
        {
            usersManagementForm = new();
            DialogResult dialogResult = usersManagementForm.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
            }
        }
        private void routesButton_Click(object sender, EventArgs e)
        {
            routesManagementForm = new();
            DialogResult dialogResult = routesManagementForm.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
            }
        }
        /// <summary>
        /// Method triggered by the leave button to return to the login form
        /// </summary>
        private void leaveButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
