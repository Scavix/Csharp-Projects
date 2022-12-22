namespace Assignment3
{
    public partial class MainForm : Form
    {
        //private variables storing classes instances for calculation
        private BMICalculator bmiCalc = new BMICalculator();
        private SavingCalculator savingCalc = new SavingCalculator();
        private BMRCalculator bmrCalc = new BMRCalculator();
        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }
        /// <summary>
        /// Method that initialises values.
        /// </summary>
        private void InitializeGUI()
        {
            Text += "Francesco";
            radioM.Checked = true;
            bmiCalc.Unit = UnitTypes.Metric;
            lblBMIValue.Text = " ";
            lblCategoryValue.Text = " ";
            txtH.Text = "";
            txtH2.Text = "";
            txtName.Text = "Undefined";
            txtW.Text = "";
            lblOutputBMI.Text = " ";
            lblOutputW.Text = " ";
            txtH2.Visible = false;
            lblAmountValue.Text = " ";
            lblEarnedValue.Text = " ";
            txtDeposit.Text = "0";
            txtPeriod.Text = "0";
            txtBalance.Text = "0";
            txtInterest.Text = "10";
            txtFees.Text = "0";
            radioMale.Checked = true;
            radioLightly.Checked = true;
            txtAge.Text = "1";
            bmrCalc.Gender = Genders.Male;
            bmrCalc.ActivityLevel = ActivityLevels.Lightly;
        }
        /// <summary>
        /// Actions triggered by the calculate bmi button click!
        /// Reads name, weight and height from GUI, if error happens
        /// Shows messageboxes, if no problems, makes calculation and update GUI
        /// </summary>
        private void btnCalculateBMI_Click(object sender, EventArgs e)
        {
            if (ReadName() && ReadWeight() && ReadHeight())
            {
                boxResults.Text = "Results for " + bmiCalc.Name;
                lblBMIValue.Text = bmiCalc.GetBMI().ToString();
                lblCategoryValue.Text = bmiCalc.GetCategory();
                lblOutputBMI.Text = bmiCalc.GetBMIInfo();
                lblOutputW.Text = bmiCalc.GetCategoryInfo();
            }
        }
        /// <summary>
        /// Method that reads initial balance from GUI, if value is not valid, shows message and use unknown as defailt.
        /// </summary>
        private bool ReadName()
        {
            txtName.Text.Trim();
            if (!string.IsNullOrEmpty(txtName.Text))
            {
                bmiCalc.Name = txtName.Text;
            }
            else
            {
                bmiCalc.Name = "Unknown";
                MessageBox.Show("Invalid name");
                return false;
            }
            return true;
        }
        /// <summary>
        /// Method that reads weight from GUI, if value is not valid, shows message and use 0 as defailt.
        /// </summary>
        private bool ReadWeight()
        {
            bmiCalc.Weight = 0;
            txtW.Text.Trim();
            double val;
            if (!string.IsNullOrEmpty(txtW.Text))
            {
                if (double.TryParse(txtW.Text, out val))
                {
                    bmiCalc.Weight = val;
                }
                else
                {
                    MessageBox.Show("Invalid weight");
                    bmiCalc.Weight = 0;
                    return false;
                }
            }
            else
            {
                bmiCalc.Weight = 0;
                MessageBox.Show("Invalid weight");
                return false;
            }
            if (bmiCalc.Weight < 0)
            {
                MessageBox.Show("Invalid weight");
                bmiCalc.Weight = 0;
                return false;
            }
            return true;
        }
        /// <summary>
        /// Method that reads heights from GUI, if value is not valid, shows message and use 0 as defailt
        /// Based on the unit, rads meters directly but it converts ft to inches.
        /// </summary>
        private bool ReadHeight()
        {
            bmiCalc.Height = 0;
            txtH.Text.Trim();
            txtH2.Text.Trim();
            double val;
            if (radioI.Checked)
            {
                if (!string.IsNullOrEmpty(txtH2.Text))
                {
                    if (double.TryParse(txtH2.Text, out val))
                    {
                        bmiCalc.Height = val;
                    }
                    else
                    {
                        bmiCalc.Height = 0;
                        MessageBox.Show("Invalid Height");
                        return false;
                    }
                }
            }
            if (!string.IsNullOrEmpty(txtH.Text))
            {
                if (double.TryParse(txtH.Text, out val))
                {
                    bmiCalc.Height += radioI.Checked ? val * 12 : val;
                    if (bmiCalc.Height < 0)
                    {
                        MessageBox.Show("Invalid Height");
                        return false;
                    }
                }
                else
                {
                    bmiCalc.Height = 0;
                    MessageBox.Show("Invalid Height");
                    return false;
                }
                return true;
            }
            bmiCalc.Height = 0;
            MessageBox.Show("Invalid Height");
            return false;
        }
        /// <summary>
        /// Radio button triggered method! update backend variables and txtbox visibility.
        /// </summary>
        private void rbtnMetric_CheckedChanged(object sender, EventArgs e)
        {
            txtH2.Visible = radioI.Checked;
            bmiCalc.Unit = UnitTypes.Metric;
            lblH.Text = "Height (cm)";
            lblW.Text = "Weight (kg)";
        }
        /// <summary>
        /// Radio button triggered method! update backend variables and txtbox visibility.
        /// </summary>
        private void rbtnImperial_CheckedChanged(object sender, EventArgs e)
        {
            txtH2.Visible = radioI.Checked;
            bmiCalc.Unit = UnitTypes.Imperial;
            lblH.Text = "Height (ft)";
            lblW.Text = "Weight (lbs)";
        }
        /// <summary>
        /// Actions triggered by the calculate saving button click!
        /// Reads period, deposit, interest rate, fees and initial balance from GUI,
        /// If error happens shows messageboxes, 
        /// If no problems, makes calculation and update GUI
        /// </summary>
        private void btnCalculateSaving_Click(object sender, EventArgs e)
        {
            if (ReadPeriod() && ReadDeposit() && ReadInterest() && ReadFees() && ReadInitialBalance())
            {
                lblBalanceValue.Text = savingCalc.GetBalance().ToString();
                lblAmountValue.Text = savingCalc.GetAmountPaid().ToString();
                lblEarnedValue.Text = savingCalc.GetEarned().ToString();
                lblFeesTotalValue.Text = Math.Round(savingCalc.TotalFees, 2).ToString();
            }
        }
        /// <summary>
        /// Method that reads period in years from GUI, if value is not valid, shows message and use 0 as default.
        /// </summary>
        private bool ReadPeriod()
        {
            txtPeriod.Text.Trim();
            int val;
            if (!string.IsNullOrEmpty(txtPeriod.Text))
            {
                if (int.TryParse(txtPeriod.Text, out val))
                {
                    savingCalc.NumberOfYears = val;
                }
                else
                {
                    MessageBox.Show("Invalid period");
                    savingCalc.NumberOfYears = 0;
                    return false;
                }
            }
            else
            {
                savingCalc.NumberOfYears = 0;
                MessageBox.Show("Invalid period");
                return false;
            }
            if (savingCalc.NumberOfYears < 0)
            {
                savingCalc.NumberOfYears = 0;
                MessageBox.Show("Invalid period");
                return false;
            }
            return true;
        }
        /// <summary>
        /// Method that reads monthly deposit from GUI, if value is not valid, shows message and use 0 as default.
        /// </summary>
        private bool ReadDeposit()
        {
            txtDeposit.Text.Trim();
            int val;
            if (!string.IsNullOrEmpty(txtDeposit.Text))
            {
                if (int.TryParse(txtDeposit.Text, out val))
                {
                    savingCalc.MonthlyDeposit = val;
                }
                else
                {
                    MessageBox.Show("Invalid deposit");
                    savingCalc.MonthlyDeposit = 0;
                    return false;
                }
            }
            else
            {
                savingCalc.MonthlyDeposit = 0;
                MessageBox.Show("Invalid deposit");
                return false;
            }
            if (savingCalc.MonthlyDeposit < 0)
            {
                savingCalc.MonthlyDeposit = 0;
                MessageBox.Show("Invalid deposit");
                return false;
            }
            return true;
        }
        /// <summary>
        /// Method that reads interest rate from GUI, if value is not valid, shows message and use 10 as default.
        /// </summary>
        private bool ReadInterest()
        {
            txtInterest.Text.Trim();
            double val;
            if (!string.IsNullOrEmpty(txtInterest.Text))
            {
                if (double.TryParse(txtInterest.Text, out val))
                {
                    savingCalc.InterestRate = val;
                }
                else
                {
                    MessageBox.Show("Invalid interest rate");
                    savingCalc.InterestRate = 10;
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Invalid interest rate");
                savingCalc.InterestRate = 10;
                return false;
            }
            if (savingCalc.InterestRate < 0)
            {
                MessageBox.Show("Invalid interest rate");
                savingCalc.InterestRate = 10;
                return false;
            }
            return true;
        }
        /// <summary>
        /// Method that reads fees from GUI, if value is not valid, shows message and use 0 as defailt.
        /// </summary>
        private bool ReadFees()
        {
            txtFees.Text.Trim();
            double val;
            if (!string.IsNullOrEmpty(txtFees.Text))
            {
                if (double.TryParse(txtFees.Text, out val))
                {
                    savingCalc.Fees = val;
                }
                else
                {
                    MessageBox.Show("Invalid fees");
                    savingCalc.Fees = 0;
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Invalid fees");
                savingCalc.Fees = 0;
                return false;
            }
            if (savingCalc.Fees < 0)
            {
                MessageBox.Show("Invalid fees");
                savingCalc.Fees = 0;
                return false;
            }
            return true;
        }
        /// <summary>
        /// Method that reads initial balance from GUI, if value is not valid, shows message and use 0 as default.
        /// </summary>
        private bool ReadInitialBalance()
        {
            txtBalance.Text.Trim();
            double val;
            if (!string.IsNullOrEmpty(txtBalance.Text))
            {
                if (double.TryParse(txtBalance.Text, out val))
                {
                    savingCalc.Balance = val;
                }
                else
                {
                    MessageBox.Show("Invalid balance");
                    savingCalc.Balance = 0;
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Invalid balance");
                savingCalc.Balance = 0;
                return false;
            }
            if (savingCalc.Balance < 0)
            {
                MessageBox.Show("Invalid balance");
                savingCalc.Balance = 0;
                return false;
            }
            return true;
        }
        /// <summary>
        /// Actions triggered by the calculate BMR button click!
        /// Reads name, weight, height, age from GUI,
        /// If error happens shows messageboxes, 
        /// If no problems, makes calculation and update GUI
        /// To notice! it delegates most reading logic to the already existing button method
        /// That is going to read name, weight and height!
        /// </summary>
        private void btnCalculateBMR_Click(object sender, EventArgs e)
        {
            if (ReadAge())
            {
                btnCalculateBMI_Click(sender, e);
                bmrCalc.Name = bmiCalc.Name;
                bmrCalc.Weight = bmiCalc.Weight;
                bmrCalc.Height = bmiCalc.Height;
                bmrCalc.Unit = bmiCalc.Unit;
                CreateBMRText();
            }
        }
        /// <summary>
        /// Method that reads age from GUI, if value is not valid, shows message and use 1 as default.
        /// </summary>
        private bool ReadAge()
        {
            bmrCalc.Age = 0;
            txtAge.Text.Trim();
            int val;
            if (!string.IsNullOrEmpty(txtAge.Text))
            {
                if (int.TryParse(txtAge.Text, out val))
                {
                    bmrCalc.Age = val;
                }
                else
                {
                    MessageBox.Show("Invalid age");
                    bmrCalc.Age = 1;
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Invalid age");
                bmrCalc.Age = 1;
                return false;
            }
            if (bmrCalc.Age <= 0)
            {
                MessageBox.Show("Invalid age");
                bmrCalc.Age = 1;
                return false;
            }
            return true;
        }
        /// <summary>
        /// Method that update radiobutton values backend
        /// </summary>
        private void radioFemale_CheckedChanged(object sender, EventArgs e)
        {
            bmrCalc.Gender = Genders.Female;
        }
        /// <summary>
        /// Method that update radiobutton values backend
        /// </summary>
        private void radioMale_CheckedChanged(object sender, EventArgs e)
        {
            bmrCalc.Gender = Genders.Male;
        }
        /// <summary>
        /// Method that update radiobutton values backend
        /// </summary>
        private void radioSedentary_CheckedChanged(object sender, EventArgs e)
        {
            bmrCalc.ActivityLevel = ActivityLevels.Sedentary;
        }
        /// <summary>
        /// Method that update radiobutton values backend
        /// </summary>
        private void radioLightly_CheckedChanged(object sender, EventArgs e)
        {
            bmrCalc.ActivityLevel = ActivityLevels.Lightly;
        }
        /// <summary>
        /// Method that update radiobutton values backend
        /// </summary>
        private void radioModerate_CheckedChanged(object sender, EventArgs e)
        {
            bmrCalc.ActivityLevel = ActivityLevels.Moderately;
        }
        /// <summary>
        /// Method that update radiobutton values backend
        /// </summary>
        private void radioVery_CheckedChanged(object sender, EventArgs e)
        {
            bmrCalc.ActivityLevel = ActivityLevels.Very;
        }
        /// <summary>
        /// Method that update radiobutton values backend
        /// </summary>
        private void radioExtra_CheckedChanged(object sender, EventArgs e)
        {
            bmrCalc.ActivityLevel = ActivityLevels.Extra;
        }
        /// <summary>
        /// Method that create BMR texts based on units and add it to listbox to show
        /// </summary>
        public void CreateBMRText() {
            string format = "{0,3:d} {1}";
            listBoxBMR.Items.Clear();
            listBoxBMR.Items.Add(string.Format(format,"BMR results for ",bmrCalc.Name));
            listBoxBMR.Items.Add("");
            listBoxBMR.Items.Add(string.Format("{0} {1, 35:f2}", "Your BMR (calories per day)", bmrCalc.GetBMR().ToString()));
            listBoxBMR.Items.Add(string.Format("{0} {1, 30:f2}", "Calories to mantain your weight", Math.Round(bmrCalc.MaintainWeightBMRs(), 2).ToString()));
            listBoxBMR.Items.Add(string.Format("{0} {1, 15:f2}", "Calories to lose 0.5 kg or 2.2 lbs per week", Math.Round(bmrCalc.LoseOrGainWeight(-0.5), 2).ToString()));
            listBoxBMR.Items.Add(string.Format("{0} {1, 18:f2}", "Calories to lose 1 kg or 2.2 lbs per week", Math.Round(bmrCalc.LoseOrGainWeight(-1), 2).ToString()));
            listBoxBMR.Items.Add(string.Format("{0} {1, 15:f2}", "Calories to gain 0.5 kg or 2.2 lbs per week", Math.Round(bmrCalc.LoseOrGainWeight(0.5), 2).ToString()));
            listBoxBMR.Items.Add(string.Format("{0} {1, 18:f2}", "Calories to gain 1 kg or 2.2 lbs per week", Math.Round(bmrCalc.LoseOrGainWeight(1), 2).ToString()));
            listBoxBMR.Items.Add("");
            listBoxBMR.Items.Add("Losing more than 1000 calories per day is to be avoided");
        }
    }
}