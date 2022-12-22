namespace Assignment5
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
            this.infoListView = new System.Windows.Forms.ListView();
            this.contactTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // infoListView
            // 
            this.infoListView.Location = new System.Drawing.Point(12, 12);
            this.infoListView.MultiSelect = false;
            this.infoListView.Name = "infoListView";
            this.infoListView.Size = new System.Drawing.Size(568, 386);
            this.infoListView.TabIndex = 0;
            this.infoListView.UseCompatibleStateImageBehavior = false;
            this.infoListView.DoubleClick += new System.EventHandler(this.infoListView_DoubleClick);
            // 
            // contactTextBox
            // 
            this.contactTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.contactTextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.contactTextBox.Location = new System.Drawing.Point(585, 40);
            this.contactTextBox.Name = "contactTextBox";
            this.contactTextBox.Size = new System.Drawing.Size(203, 358);
            this.contactTextBox.TabIndex = 1;
            this.contactTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(613, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Contact Details";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 404);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(112, 34);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(130, 404);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(112, 34);
            this.editButton.TabIndex = 4;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(248, 404);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(112, 34);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(585, 404);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(203, 34);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Clear Details";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.contactTextBox);
            this.Controls.Add(this.infoListView);
            this.Name = "MainForm";
            this.Text = "Customer Registry by Francesco";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView infoListView;
        private RichTextBox contactTextBox;
        private Label label1;
        private Button addButton;
        private Button editButton;
        private Button deleteButton;
        private Button clearButton;
    }
}