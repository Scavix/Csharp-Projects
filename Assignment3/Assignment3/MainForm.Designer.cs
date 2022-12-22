namespace Assignment3
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.boxBMI = new System.Windows.Forms.GroupBox();
            this.txtH = new System.Windows.Forms.TextBox();
            this.txtW = new System.Windows.Forms.TextBox();
            this.txtH2 = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblW = new System.Windows.Forms.Label();
            this.lblH = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.boxUnit = new System.Windows.Forms.GroupBox();
            this.radioI = new System.Windows.Forms.RadioButton();
            this.radioM = new System.Windows.Forms.RadioButton();
            this.btnBMI = new System.Windows.Forms.Button();
            this.boxResults = new System.Windows.Forms.GroupBox();
            this.lblOutputW = new System.Windows.Forms.Label();
            this.lblOutputBMI = new System.Windows.Forms.Label();
            this.lblCategoryValue = new System.Windows.Forms.Label();
            this.lblBMIValue = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblBMI = new System.Windows.Forms.Label();
            this.groupplan = new System.Windows.Forms.GroupBox();
            this.lblInitialBalance = new System.Windows.Forms.Label();
            this.lblFees = new System.Windows.Forms.Label();
            this.lblGrowth = new System.Windows.Forms.Label();
            this.txtFees = new System.Windows.Forms.TextBox();
            this.txtInterest = new System.Windows.Forms.TextBox();
            this.txtPeriod = new System.Windows.Forms.TextBox();
            this.txtDeposit = new System.Windows.Forms.TextBox();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.lblDeposit = new System.Windows.Forms.Label();
            this.btnSaving = new System.Windows.Forms.Button();
            this.groupFuture = new System.Windows.Forms.GroupBox();
            this.lblFeesTotalValue = new System.Windows.Forms.Label();
            this.lblBalanceValue = new System.Windows.Forms.Label();
            this.lblFeesTotal = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblEarnedValue = new System.Windows.Forms.Label();
            this.lblAmountValue = new System.Windows.Forms.Label();
            this.lblEarned = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.boxBMR = new System.Windows.Forms.GroupBox();
            this.btnBMR = new System.Windows.Forms.Button();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.listBoxBMR = new System.Windows.Forms.ListBox();
            this.boxActivity = new System.Windows.Forms.GroupBox();
            this.radioExtra = new System.Windows.Forms.RadioButton();
            this.radioVery = new System.Windows.Forms.RadioButton();
            this.radioModerate = new System.Windows.Forms.RadioButton();
            this.radioLightly = new System.Windows.Forms.RadioButton();
            this.radioSedentary = new System.Windows.Forms.RadioButton();
            this.boxGender = new System.Windows.Forms.GroupBox();
            this.radioMale = new System.Windows.Forms.RadioButton();
            this.radioFemale = new System.Windows.Forms.RadioButton();
            this.boxBMI.SuspendLayout();
            this.boxUnit.SuspendLayout();
            this.boxResults.SuspendLayout();
            this.groupplan.SuspendLayout();
            this.groupFuture.SuspendLayout();
            this.boxBMR.SuspendLayout();
            this.boxActivity.SuspendLayout();
            this.boxGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // boxBMI
            // 
            this.boxBMI.Controls.Add(this.txtH);
            this.boxBMI.Controls.Add(this.txtW);
            this.boxBMI.Controls.Add(this.txtH2);
            this.boxBMI.Controls.Add(this.txtName);
            this.boxBMI.Controls.Add(this.lblW);
            this.boxBMI.Controls.Add(this.lblH);
            this.boxBMI.Controls.Add(this.lblName);
            this.boxBMI.Location = new System.Drawing.Point(12, 12);
            this.boxBMI.Name = "boxBMI";
            this.boxBMI.Size = new System.Drawing.Size(288, 135);
            this.boxBMI.TabIndex = 0;
            this.boxBMI.TabStop = false;
            this.boxBMI.Text = "BMI Calculator";
            // 
            // txtH
            // 
            this.txtH.Location = new System.Drawing.Point(131, 65);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(67, 23);
            this.txtH.TabIndex = 5;
            this.txtH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtW
            // 
            this.txtW.Location = new System.Drawing.Point(131, 101);
            this.txtW.Name = "txtW";
            this.txtW.Size = new System.Drawing.Size(147, 23);
            this.txtW.TabIndex = 5;
            this.txtW.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtH2
            // 
            this.txtH2.Location = new System.Drawing.Point(211, 65);
            this.txtH2.Name = "txtH2";
            this.txtH2.Size = new System.Drawing.Size(67, 23);
            this.txtH2.TabIndex = 4;
            this.txtH2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(131, 29);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(147, 23);
            this.txtName.TabIndex = 3;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblW
            // 
            this.lblW.AutoSize = true;
            this.lblW.Location = new System.Drawing.Point(21, 104);
            this.lblW.Name = "lblW";
            this.lblW.Size = new System.Drawing.Size(45, 15);
            this.lblW.TabIndex = 2;
            this.lblW.Text = "Weight";
            // 
            // lblH
            // 
            this.lblH.AutoSize = true;
            this.lblH.Location = new System.Drawing.Point(21, 68);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(43, 15);
            this.lblH.TabIndex = 1;
            this.lblH.Text = "Height";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(21, 32);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // boxUnit
            // 
            this.boxUnit.Controls.Add(this.radioI);
            this.boxUnit.Controls.Add(this.radioM);
            this.boxUnit.Location = new System.Drawing.Point(306, 12);
            this.boxUnit.Name = "boxUnit";
            this.boxUnit.Size = new System.Drawing.Size(160, 135);
            this.boxUnit.TabIndex = 1;
            this.boxUnit.TabStop = false;
            this.boxUnit.Text = "Unit";
            // 
            // radioI
            // 
            this.radioI.AutoSize = true;
            this.radioI.Location = new System.Drawing.Point(19, 66);
            this.radioI.Name = "radioI";
            this.radioI.Size = new System.Drawing.Size(108, 19);
            this.radioI.TabIndex = 1;
            this.radioI.TabStop = true;
            this.radioI.Text = "Imperial (ft, lbs)";
            this.radioI.UseVisualStyleBackColor = true;
            this.radioI.CheckedChanged += new System.EventHandler(this.rbtnImperial_CheckedChanged);
            // 
            // radioM
            // 
            this.radioM.AutoSize = true;
            this.radioM.Location = new System.Drawing.Point(19, 33);
            this.radioM.Name = "radioM";
            this.radioM.Size = new System.Drawing.Size(106, 19);
            this.radioM.TabIndex = 0;
            this.radioM.TabStop = true;
            this.radioM.Text = "Metric (kg, cm)";
            this.radioM.UseVisualStyleBackColor = true;
            this.radioM.CheckedChanged += new System.EventHandler(this.rbtnMetric_CheckedChanged);
            // 
            // btnBMI
            // 
            this.btnBMI.Location = new System.Drawing.Point(104, 153);
            this.btnBMI.Name = "btnBMI";
            this.btnBMI.Size = new System.Drawing.Size(296, 44);
            this.btnBMI.TabIndex = 3;
            this.btnBMI.Text = "Calculate BMI";
            this.btnBMI.UseVisualStyleBackColor = true;
            this.btnBMI.Click += new System.EventHandler(this.btnCalculateBMI_Click);
            // 
            // boxResults
            // 
            this.boxResults.Controls.Add(this.lblOutputW);
            this.boxResults.Controls.Add(this.lblOutputBMI);
            this.boxResults.Controls.Add(this.lblCategoryValue);
            this.boxResults.Controls.Add(this.lblBMIValue);
            this.boxResults.Controls.Add(this.lblCategory);
            this.boxResults.Controls.Add(this.lblBMI);
            this.boxResults.Location = new System.Drawing.Point(12, 203);
            this.boxResults.Name = "boxResults";
            this.boxResults.Size = new System.Drawing.Size(454, 176);
            this.boxResults.TabIndex = 4;
            this.boxResults.TabStop = false;
            this.boxResults.Text = "Results";
            // 
            // lblOutputW
            // 
            this.lblOutputW.AutoSize = true;
            this.lblOutputW.Location = new System.Drawing.Point(106, 144);
            this.lblOutputW.Name = "lblOutputW";
            this.lblOutputW.Size = new System.Drawing.Size(12, 15);
            this.lblOutputW.TabIndex = 8;
            this.lblOutputW.Text = "-";
            // 
            // lblOutputBMI
            // 
            this.lblOutputBMI.AutoSize = true;
            this.lblOutputBMI.ForeColor = System.Drawing.Color.Green;
            this.lblOutputBMI.Location = new System.Drawing.Point(158, 112);
            this.lblOutputBMI.Name = "lblOutputBMI";
            this.lblOutputBMI.Size = new System.Drawing.Size(12, 15);
            this.lblOutputBMI.TabIndex = 7;
            this.lblOutputBMI.Text = "-";
            // 
            // lblCategoryValue
            // 
            this.lblCategoryValue.AutoSize = true;
            this.lblCategoryValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCategoryValue.Location = new System.Drawing.Point(247, 70);
            this.lblCategoryValue.Name = "lblCategoryValue";
            this.lblCategoryValue.Size = new System.Drawing.Size(12, 17);
            this.lblCategoryValue.TabIndex = 8;
            this.lblCategoryValue.Text = " ";
            // 
            // lblBMIValue
            // 
            this.lblBMIValue.AutoSize = true;
            this.lblBMIValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBMIValue.Location = new System.Drawing.Point(247, 34);
            this.lblBMIValue.Name = "lblBMIValue";
            this.lblBMIValue.Size = new System.Drawing.Size(12, 17);
            this.lblBMIValue.TabIndex = 7;
            this.lblBMIValue.Text = " ";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(131, 70);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(94, 15);
            this.lblCategory.TabIndex = 6;
            this.lblCategory.Text = "Weight category";
            // 
            // lblBMI
            // 
            this.lblBMI.AutoSize = true;
            this.lblBMI.Location = new System.Drawing.Point(131, 34);
            this.lblBMI.Name = "lblBMI";
            this.lblBMI.Size = new System.Drawing.Size(28, 15);
            this.lblBMI.TabIndex = 5;
            this.lblBMI.Text = "BMI";
            // 
            // groupplan
            // 
            this.groupplan.Controls.Add(this.lblInitialBalance);
            this.groupplan.Controls.Add(this.lblFees);
            this.groupplan.Controls.Add(this.lblGrowth);
            this.groupplan.Controls.Add(this.txtFees);
            this.groupplan.Controls.Add(this.txtInterest);
            this.groupplan.Controls.Add(this.txtPeriod);
            this.groupplan.Controls.Add(this.txtDeposit);
            this.groupplan.Controls.Add(this.txtBalance);
            this.groupplan.Controls.Add(this.lblPeriod);
            this.groupplan.Controls.Add(this.lblDeposit);
            this.groupplan.Location = new System.Drawing.Point(472, 12);
            this.groupplan.Name = "groupplan";
            this.groupplan.Size = new System.Drawing.Size(239, 169);
            this.groupplan.TabIndex = 5;
            this.groupplan.TabStop = false;
            this.groupplan.Text = "Saving plan";
            // 
            // lblInitialBalance
            // 
            this.lblInitialBalance.AutoSize = true;
            this.lblInitialBalance.Location = new System.Drawing.Point(21, 23);
            this.lblInitialBalance.Name = "lblInitialBalance";
            this.lblInitialBalance.Size = new System.Drawing.Size(80, 15);
            this.lblInitialBalance.TabIndex = 11;
            this.lblInitialBalance.Text = "Initial balance";
            // 
            // lblFees
            // 
            this.lblFees.AutoSize = true;
            this.lblFees.Location = new System.Drawing.Point(21, 143);
            this.lblFees.Name = "lblFees";
            this.lblFees.Size = new System.Drawing.Size(56, 15);
            this.lblFees.TabIndex = 10;
            this.lblFees.Text = "Fees in %";
            // 
            // lblGrowth
            // 
            this.lblGrowth.AutoSize = true;
            this.lblGrowth.Location = new System.Drawing.Point(21, 113);
            this.lblGrowth.Name = "lblGrowth";
            this.lblGrowth.Size = new System.Drawing.Size(72, 15);
            this.lblGrowth.TabIndex = 9;
            this.lblGrowth.Text = "Growth in %";
            // 
            // txtFees
            // 
            this.txtFees.Location = new System.Drawing.Point(129, 140);
            this.txtFees.Name = "txtFees";
            this.txtFees.Size = new System.Drawing.Size(104, 23);
            this.txtFees.TabIndex = 8;
            this.txtFees.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtInterest
            // 
            this.txtInterest.Location = new System.Drawing.Point(129, 110);
            this.txtInterest.Name = "txtInterest";
            this.txtInterest.Size = new System.Drawing.Size(104, 23);
            this.txtInterest.TabIndex = 7;
            this.txtInterest.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPeriod
            // 
            this.txtPeriod.Location = new System.Drawing.Point(129, 80);
            this.txtPeriod.Name = "txtPeriod";
            this.txtPeriod.Size = new System.Drawing.Size(104, 23);
            this.txtPeriod.TabIndex = 6;
            this.txtPeriod.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDeposit
            // 
            this.txtDeposit.Location = new System.Drawing.Point(129, 50);
            this.txtDeposit.Name = "txtDeposit";
            this.txtDeposit.Size = new System.Drawing.Size(104, 23);
            this.txtDeposit.TabIndex = 5;
            this.txtDeposit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(129, 20);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(104, 23);
            this.txtBalance.TabIndex = 3;
            this.txtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Location = new System.Drawing.Point(21, 83);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(79, 15);
            this.lblPeriod.TabIndex = 1;
            this.lblPeriod.Text = "Period (years)";
            // 
            // lblDeposit
            // 
            this.lblDeposit.AutoSize = true;
            this.lblDeposit.Location = new System.Drawing.Point(21, 53);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(94, 15);
            this.lblDeposit.TabIndex = 0;
            this.lblDeposit.Text = "Monthly deposit";
            // 
            // btnSaving
            // 
            this.btnSaving.Location = new System.Drawing.Point(493, 187);
            this.btnSaving.Name = "btnSaving";
            this.btnSaving.Size = new System.Drawing.Size(175, 44);
            this.btnSaving.TabIndex = 6;
            this.btnSaving.Text = "Calculate saving";
            this.btnSaving.UseVisualStyleBackColor = true;
            this.btnSaving.Click += new System.EventHandler(this.btnCalculateSaving_Click);
            // 
            // groupFuture
            // 
            this.groupFuture.Controls.Add(this.lblFeesTotalValue);
            this.groupFuture.Controls.Add(this.lblBalanceValue);
            this.groupFuture.Controls.Add(this.lblFeesTotal);
            this.groupFuture.Controls.Add(this.lblBalance);
            this.groupFuture.Controls.Add(this.lblEarnedValue);
            this.groupFuture.Controls.Add(this.lblAmountValue);
            this.groupFuture.Controls.Add(this.lblEarned);
            this.groupFuture.Controls.Add(this.lblAmount);
            this.groupFuture.Location = new System.Drawing.Point(473, 237);
            this.groupFuture.Name = "groupFuture";
            this.groupFuture.Size = new System.Drawing.Size(238, 142);
            this.groupFuture.TabIndex = 7;
            this.groupFuture.TabStop = false;
            this.groupFuture.Text = "Future value";
            // 
            // lblFeesTotalValue
            // 
            this.lblFeesTotalValue.AutoSize = true;
            this.lblFeesTotalValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFeesTotalValue.Location = new System.Drawing.Point(147, 110);
            this.lblFeesTotalValue.Name = "lblFeesTotalValue";
            this.lblFeesTotalValue.Size = new System.Drawing.Size(12, 17);
            this.lblFeesTotalValue.TabIndex = 14;
            this.lblFeesTotalValue.Text = " ";
            // 
            // lblBalanceValue
            // 
            this.lblBalanceValue.AutoSize = true;
            this.lblBalanceValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBalanceValue.Location = new System.Drawing.Point(147, 81);
            this.lblBalanceValue.Name = "lblBalanceValue";
            this.lblBalanceValue.Size = new System.Drawing.Size(12, 17);
            this.lblBalanceValue.TabIndex = 13;
            this.lblBalanceValue.Text = " ";
            // 
            // lblFeesTotal
            // 
            this.lblFeesTotal.AutoSize = true;
            this.lblFeesTotal.Location = new System.Drawing.Point(33, 112);
            this.lblFeesTotal.Name = "lblFeesTotal";
            this.lblFeesTotal.Size = new System.Drawing.Size(56, 15);
            this.lblFeesTotal.TabIndex = 12;
            this.lblFeesTotal.Text = "Total fees";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(31, 83);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(76, 15);
            this.lblBalance.TabIndex = 11;
            this.lblBalance.Text = "Final balance";
            // 
            // lblEarnedValue
            // 
            this.lblEarnedValue.AutoSize = true;
            this.lblEarnedValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEarnedValue.Location = new System.Drawing.Point(147, 52);
            this.lblEarnedValue.Name = "lblEarnedValue";
            this.lblEarnedValue.Size = new System.Drawing.Size(12, 17);
            this.lblEarnedValue.TabIndex = 10;
            this.lblEarnedValue.Text = " ";
            // 
            // lblAmountValue
            // 
            this.lblAmountValue.AutoSize = true;
            this.lblAmountValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAmountValue.Location = new System.Drawing.Point(147, 23);
            this.lblAmountValue.Name = "lblAmountValue";
            this.lblAmountValue.Size = new System.Drawing.Size(12, 17);
            this.lblAmountValue.TabIndex = 9;
            this.lblAmountValue.Text = " ";
            // 
            // lblEarned
            // 
            this.lblEarned.AutoSize = true;
            this.lblEarned.Location = new System.Drawing.Point(32, 54);
            this.lblEarned.Name = "lblEarned";
            this.lblEarned.Size = new System.Drawing.Size(90, 15);
            this.lblEarned.TabIndex = 6;
            this.lblEarned.Text = "Amount earned";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(32, 25);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(77, 15);
            this.lblAmount.TabIndex = 5;
            this.lblAmount.Text = "Amount paid";
            // 
            // boxBMR
            // 
            this.boxBMR.Controls.Add(this.btnBMR);
            this.boxBMR.Controls.Add(this.txtAge);
            this.boxBMR.Controls.Add(this.lblAge);
            this.boxBMR.Controls.Add(this.listBoxBMR);
            this.boxBMR.Controls.Add(this.boxActivity);
            this.boxBMR.Controls.Add(this.boxGender);
            this.boxBMR.Location = new System.Drawing.Point(12, 385);
            this.boxBMR.Name = "boxBMR";
            this.boxBMR.Size = new System.Drawing.Size(699, 245);
            this.boxBMR.TabIndex = 8;
            this.boxBMR.TabStop = false;
            this.boxBMR.Text = "BMR Calculator";
            // 
            // btnBMR
            // 
            this.btnBMR.Location = new System.Drawing.Point(30, 197);
            this.btnBMR.Name = "btnBMR";
            this.btnBMR.Size = new System.Drawing.Size(248, 42);
            this.btnBMR.TabIndex = 5;
            this.btnBMR.Text = "Calculate BMR";
            this.btnBMR.UseVisualStyleBackColor = true;
            this.btnBMR.Click += new System.EventHandler(this.btnCalculateBMR_Click);
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(92, 128);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(44, 23);
            this.txtAge.TabIndex = 4;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(21, 131);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(28, 15);
            this.lblAge.TabIndex = 3;
            this.lblAge.Text = "Age";
            // 
            // listBoxBMR
            // 
            this.listBoxBMR.FormattingEnabled = true;
            this.listBoxBMR.ItemHeight = 15;
            this.listBoxBMR.Location = new System.Drawing.Point(379, 27);
            this.listBoxBMR.Name = "listBoxBMR";
            this.listBoxBMR.Size = new System.Drawing.Size(314, 169);
            this.listBoxBMR.TabIndex = 2;
            // 
            // boxActivity
            // 
            this.boxActivity.Controls.Add(this.radioExtra);
            this.boxActivity.Controls.Add(this.radioVery);
            this.boxActivity.Controls.Add(this.radioModerate);
            this.boxActivity.Controls.Add(this.radioLightly);
            this.boxActivity.Controls.Add(this.radioSedentary);
            this.boxActivity.Location = new System.Drawing.Point(165, 22);
            this.boxActivity.Name = "boxActivity";
            this.boxActivity.Size = new System.Drawing.Size(208, 169);
            this.boxActivity.TabIndex = 1;
            this.boxActivity.TabStop = false;
            this.boxActivity.Text = "Weekly activity level";
            // 
            // radioExtra
            // 
            this.radioExtra.AutoSize = true;
            this.radioExtra.Location = new System.Drawing.Point(6, 143);
            this.radioExtra.Name = "radioExtra";
            this.radioExtra.Size = new System.Drawing.Size(194, 19);
            this.radioExtra.TabIndex = 4;
            this.radioExtra.TabStop = true;
            this.radioExtra.Text = "Extra active, hard exercise or job";
            this.radioExtra.UseVisualStyleBackColor = true;
            this.radioExtra.CheckedChanged += new System.EventHandler(this.radioExtra_CheckedChanged);
            // 
            // radioVery
            // 
            this.radioVery.AutoSize = true;
            this.radioVery.Location = new System.Drawing.Point(6, 113);
            this.radioVery.Name = "radioVery";
            this.radioVery.Size = new System.Drawing.Size(148, 19);
            this.radioVery.TabIndex = 3;
            this.radioVery.TabStop = true;
            this.radioVery.Text = "Very active (6 to 7 time)";
            this.radioVery.UseVisualStyleBackColor = true;
            this.radioVery.CheckedChanged += new System.EventHandler(this.radioVery_CheckedChanged);
            // 
            // radioModerate
            // 
            this.radioModerate.AutoSize = true;
            this.radioModerate.Location = new System.Drawing.Point(6, 83);
            this.radioModerate.Name = "radioModerate";
            this.radioModerate.Size = new System.Drawing.Size(186, 19);
            this.radioModerate.TabIndex = 2;
            this.radioModerate.TabStop = true;
            this.radioModerate.Text = "Moderately active (3 to 5 time)";
            this.radioModerate.UseVisualStyleBackColor = true;
            this.radioModerate.CheckedChanged += new System.EventHandler(this.radioModerate_CheckedChanged);
            // 
            // radioLightly
            // 
            this.radioLightly.AutoSize = true;
            this.radioLightly.Location = new System.Drawing.Point(6, 53);
            this.radioLightly.Name = "radioLightly";
            this.radioLightly.Size = new System.Drawing.Size(135, 19);
            this.radioLightly.TabIndex = 1;
            this.radioLightly.TabStop = true;
            this.radioLightly.Text = "Lightly active (1 to 3)";
            this.radioLightly.UseVisualStyleBackColor = true;
            this.radioLightly.CheckedChanged += new System.EventHandler(this.radioLightly_CheckedChanged);
            // 
            // radioSedentary
            // 
            this.radioSedentary.AutoSize = true;
            this.radioSedentary.Location = new System.Drawing.Point(6, 23);
            this.radioSedentary.Name = "radioSedentary";
            this.radioSedentary.Size = new System.Drawing.Size(187, 19);
            this.radioSedentary.TabIndex = 0;
            this.radioSedentary.TabStop = true;
            this.radioSedentary.Text = "Sedentary (little or no exercise)";
            this.radioSedentary.UseVisualStyleBackColor = true;
            this.radioSedentary.CheckedChanged += new System.EventHandler(this.radioSedentary_CheckedChanged);
            // 
            // boxGender
            // 
            this.boxGender.Controls.Add(this.radioMale);
            this.boxGender.Controls.Add(this.radioFemale);
            this.boxGender.Location = new System.Drawing.Point(6, 22);
            this.boxGender.Name = "boxGender";
            this.boxGender.Size = new System.Drawing.Size(153, 92);
            this.boxGender.TabIndex = 0;
            this.boxGender.TabStop = false;
            this.boxGender.Text = "Gender";
            // 
            // radioMale
            // 
            this.radioMale.AutoSize = true;
            this.radioMale.Location = new System.Drawing.Point(24, 53);
            this.radioMale.Name = "radioMale";
            this.radioMale.Size = new System.Drawing.Size(51, 19);
            this.radioMale.TabIndex = 1;
            this.radioMale.TabStop = true;
            this.radioMale.Text = "Male";
            this.radioMale.UseVisualStyleBackColor = true;
            this.radioMale.CheckedChanged += new System.EventHandler(this.radioMale_CheckedChanged);
            // 
            // radioFemale
            // 
            this.radioFemale.AutoSize = true;
            this.radioFemale.Location = new System.Drawing.Point(24, 22);
            this.radioFemale.Name = "radioFemale";
            this.radioFemale.Size = new System.Drawing.Size(63, 19);
            this.radioFemale.TabIndex = 0;
            this.radioFemale.TabStop = true;
            this.radioFemale.Text = "Female";
            this.radioFemale.UseVisualStyleBackColor = true;
            this.radioFemale.CheckedChanged += new System.EventHandler(this.radioFemale_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 642);
            this.Controls.Add(this.boxBMR);
            this.Controls.Add(this.groupFuture);
            this.Controls.Add(this.btnSaving);
            this.Controls.Add(this.groupplan);
            this.Controls.Add(this.boxResults);
            this.Controls.Add(this.btnBMI);
            this.Controls.Add(this.boxUnit);
            this.Controls.Add(this.boxBMI);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Super Calculator by ";
            this.boxBMI.ResumeLayout(false);
            this.boxBMI.PerformLayout();
            this.boxUnit.ResumeLayout(false);
            this.boxUnit.PerformLayout();
            this.boxResults.ResumeLayout(false);
            this.boxResults.PerformLayout();
            this.groupplan.ResumeLayout(false);
            this.groupplan.PerformLayout();
            this.groupFuture.ResumeLayout(false);
            this.groupFuture.PerformLayout();
            this.boxBMR.ResumeLayout(false);
            this.boxBMR.PerformLayout();
            this.boxActivity.ResumeLayout(false);
            this.boxActivity.PerformLayout();
            this.boxGender.ResumeLayout(false);
            this.boxGender.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox boxBMI;
        private TextBox txtH;
        private TextBox txtW;
        private TextBox txtH2;
        private TextBox txtName;
        private Label lblW;
        private Label lblH;
        private Label lblName;
        private GroupBox boxUnit;
        private RadioButton radioI;
        private RadioButton radioM;
        private Button btnBMI;
        private GroupBox boxResults;
        private Label lblCategoryValue;
        private Label lblBMIValue;
        private Label lblCategory;
        private Label lblBMI;
        private Label lblOutputW;
        private Label lblOutputBMI;
        private GroupBox groupplan;
        private TextBox txtDeposit;
        private TextBox txtBalance;
        private Label lblPeriod;
        private Label lblDeposit;
        private Button btnSaving;
        private GroupBox groupFuture;
        private Label lblAmount;
        private Label lblEarnedValue;
        private Label lblAmountValue;
        private Label lblFees;
        private Label lblGrowth;
        private TextBox txtFees;
        private TextBox txtInterest;
        private TextBox txtPeriod;
        private Label lblFeesTotalValue;
        private Label lblBalanceValue;
        private Label lblFeesTotal;
        private Label lblBalance;
        private Label lblEarned;
        private GroupBox boxBMR;
        private Button btnBMR;
        private TextBox txtAge;
        private Label lblAge;
        private ListBox listBoxBMR;
        private GroupBox boxActivity;
        private GroupBox boxGender;
        private RadioButton radioMale;
        private RadioButton radioFemale;
        private Label lblInitialBalance;
        private RadioButton radioExtra;
        private RadioButton radioVery;
        private RadioButton radioModerate;
        private RadioButton radioLightly;
        private RadioButton radioSedentary;
    }
}