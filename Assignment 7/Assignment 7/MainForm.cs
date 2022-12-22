namespace Assignment_7
{
    public partial class MainForm : Form
    {
        private LoginForm loginForm { get; set; }
        private AdminForm adminForm { get; set; }
        private UserForm userForm { get; set; }
        // Invisible form used for its logic
        public MainForm()
        {
            InitializeComponent();
            DialogResult dialogResult;
            // Loop over form for consistency
            do
            {
                loginForm = new();
                this.StartPosition = FormStartPosition.CenterScreen;
                dialogResult = loginForm.ShowDialog();
                //login form
                if (dialogResult == DialogResult.OK)
                {
                    // if login as admin open admin form
                    if (loginForm.admin)
                    {
                        adminForm = new();
                        adminForm.ShowDialog();
                    }
                    // if login as use open user form
                    else
                    {
                        userForm = new();
                        userForm.ShowDialog();
                    }
                }
                else
                {
                    if (System.Windows.Forms.Application.MessageLoop)
                    {
                        System.Windows.Forms.Application.Exit();
                    }
                    else
                    {
                        System.Environment.Exit(1);
                    }
                }
            } while (dialogResult != DialogResult.Cancel);
        }
    }
}