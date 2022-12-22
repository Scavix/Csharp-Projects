namespace Assignment_7
{
    partial class UserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.solutionListView = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.cityFromComboBox = new System.Windows.Forms.ComboBox();
            this.cityToComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.timeMaxTextBox = new System.Windows.Forms.TextBox();
            this.transportationListBox = new System.Windows.Forms.CheckedListBox();
            this.detailsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.buyButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.childrenTextBox = new System.Windows.Forms.TextBox();
            this.priceMaxTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.adultsTextBox = new System.Windows.Forms.TextBox();
            this.directCheckBox = new System.Windows.Forms.CheckBox();
            this.viewButton = new System.Windows.Forms.Button();
            this.globePictureBox = new System.Windows.Forms.PictureBox();
            this.labelLogo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.globePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // solutionListView
            // 
            this.solutionListView.Location = new System.Drawing.Point(12, 52);
            this.solutionListView.MultiSelect = false;
            this.solutionListView.Name = "solutionListView";
            this.solutionListView.Size = new System.Drawing.Size(912, 418);
            this.solutionListView.TabIndex = 0;
            this.solutionListView.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "From";
            // 
            // cityFromComboBox
            // 
            this.cityFromComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cityFromComboBox.FormattingEnabled = true;
            this.cityFromComboBox.Location = new System.Drawing.Point(72, 12);
            this.cityFromComboBox.Name = "cityFromComboBox";
            this.cityFromComboBox.Size = new System.Drawing.Size(182, 33);
            this.cityFromComboBox.TabIndex = 2;
            // 
            // cityToComboBox
            // 
            this.cityToComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cityToComboBox.FormattingEnabled = true;
            this.cityToComboBox.Location = new System.Drawing.Point(301, 12);
            this.cityToComboBox.Name = "cityToComboBox";
            this.cityToComboBox.Size = new System.Drawing.Size(182, 33);
            this.cityToComboBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "To";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(1198, 293);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(112, 50);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(489, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Max €";
            // 
            // timeMaxTextBox
            // 
            this.timeMaxTextBox.Location = new System.Drawing.Point(746, 12);
            this.timeMaxTextBox.Name = "timeMaxTextBox";
            this.timeMaxTextBox.Size = new System.Drawing.Size(57, 31);
            this.timeMaxTextBox.TabIndex = 8;
            // 
            // transportationListBox
            // 
            this.transportationListBox.CheckOnClick = true;
            this.transportationListBox.FormattingEnabled = true;
            this.transportationListBox.Location = new System.Drawing.Point(930, 52);
            this.transportationListBox.Name = "transportationListBox";
            this.transportationListBox.Size = new System.Drawing.Size(258, 172);
            this.transportationListBox.TabIndex = 10;
            // 
            // detailsRichTextBox
            // 
            this.detailsRichTextBox.Location = new System.Drawing.Point(930, 230);
            this.detailsRichTextBox.Name = "detailsRichTextBox";
            this.detailsRichTextBox.ReadOnly = true;
            this.detailsRichTextBox.Size = new System.Drawing.Size(258, 240);
            this.detailsRichTextBox.TabIndex = 11;
            this.detailsRichTextBox.Text = "";
            // 
            // buyButton
            // 
            this.buyButton.Location = new System.Drawing.Point(1198, 230);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(112, 50);
            this.buyButton.TabIndex = 12;
            this.buyButton.Text = "Buy";
            this.buyButton.UseVisualStyleBackColor = true;
            this.buyButton.Click += new System.EventHandler(this.buyButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(615, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Max time (min)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(899, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "No. adults/children";
            // 
            // childrenTextBox
            // 
            this.childrenTextBox.Location = new System.Drawing.Point(1125, 15);
            this.childrenTextBox.Name = "childrenTextBox";
            this.childrenTextBox.Size = new System.Drawing.Size(62, 31);
            this.childrenTextBox.TabIndex = 15;
            // 
            // priceMaxTextBox
            // 
            this.priceMaxTextBox.Location = new System.Drawing.Point(552, 12);
            this.priceMaxTextBox.Name = "priceMaxTextBox";
            this.priceMaxTextBox.Size = new System.Drawing.Size(57, 31);
            this.priceMaxTextBox.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(1198, 419);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 50);
            this.button1.TabIndex = 17;
            this.button1.Text = "Leave";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // adultsTextBox
            // 
            this.adultsTextBox.Location = new System.Drawing.Point(1057, 15);
            this.adultsTextBox.Name = "adultsTextBox";
            this.adultsTextBox.Size = new System.Drawing.Size(62, 31);
            this.adultsTextBox.TabIndex = 18;
            // 
            // directCheckBox
            // 
            this.directCheckBox.AutoSize = true;
            this.directCheckBox.Location = new System.Drawing.Point(809, 16);
            this.directCheckBox.Name = "directCheckBox";
            this.directCheckBox.Size = new System.Drawing.Size(84, 29);
            this.directCheckBox.TabIndex = 19;
            this.directCheckBox.Text = "Direct";
            this.directCheckBox.UseVisualStyleBackColor = true;
            // 
            // viewButton
            // 
            this.viewButton.Location = new System.Drawing.Point(1198, 356);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(112, 50);
            this.viewButton.TabIndex = 20;
            this.viewButton.Text = "View";
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // globePictureBox
            // 
            this.globePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("globePictureBox.Image")));
            this.globePictureBox.Location = new System.Drawing.Point(1207, -3);
            this.globePictureBox.Name = "globePictureBox";
            this.globePictureBox.Size = new System.Drawing.Size(103, 112);
            this.globePictureBox.TabIndex = 21;
            this.globePictureBox.TabStop = false;
            // 
            // labelLogo
            // 
            this.labelLogo.BackColor = System.Drawing.Color.Transparent;
            this.labelLogo.Font = new System.Drawing.Font("Rage Italic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLogo.ForeColor = System.Drawing.Color.Black;
            this.labelLogo.Location = new System.Drawing.Point(1194, 112);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(130, 112);
            this.labelLogo.TabIndex = 22;
            this.labelLogo.Text = "Ticket Search System";
            this.labelLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 482);
            this.Controls.Add(this.globePictureBox);
            this.Controls.Add(this.labelLogo);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.directCheckBox);
            this.Controls.Add(this.adultsTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.priceMaxTextBox);
            this.Controls.Add(this.childrenTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buyButton);
            this.Controls.Add(this.detailsRichTextBox);
            this.Controls.Add(this.transportationListBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.timeMaxTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cityToComboBox);
            this.Controls.Add(this.cityFromComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.solutionListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UserForm";
            this.Text = "Ticket Search System by Francesco";
            ((System.ComponentModel.ISupportInitialize)(this.globePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView solutionListView;
        private Label label1;
        private ComboBox cityFromComboBox;
        private ComboBox cityToComboBox;
        private Label label2;
        private Button searchButton;
        private Label label3;
        private TextBox timeMaxTextBox;
        private RichTextBox detailsRichTextBox;
        private Button buyButton;
        private Label label5;
        private Label label4;
        private TextBox childrenTextBox;
        private TextBox priceMaxTextBox;
        private Button button1;
        private TextBox adultsTextBox;
        public CheckedListBox transportationListBox;
        private CheckBox directCheckBox;
        private Button viewButton;
        private PictureBox globePictureBox;
        private Label labelLogo;
    }
}