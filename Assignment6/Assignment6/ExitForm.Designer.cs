namespace Assignment6
{
    partial class ExitForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.yesButtonExit = new System.Windows.Forms.Button();
            this.noButtonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Do you really want to leave?";
            // 
            // yesButtonExit
            // 
            this.yesButtonExit.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.yesButtonExit.Location = new System.Drawing.Point(56, 62);
            this.yesButtonExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.yesButtonExit.Name = "yesButtonExit";
            this.yesButtonExit.Size = new System.Drawing.Size(78, 20);
            this.yesButtonExit.TabIndex = 1;
            this.yesButtonExit.Text = "Yes";
            this.yesButtonExit.UseVisualStyleBackColor = true;
            // 
            // noButtonExit
            // 
            this.noButtonExit.DialogResult = System.Windows.Forms.DialogResult.No;
            this.noButtonExit.Location = new System.Drawing.Point(211, 62);
            this.noButtonExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.noButtonExit.Name = "noButtonExit";
            this.noButtonExit.Size = new System.Drawing.Size(78, 20);
            this.noButtonExit.TabIndex = 2;
            this.noButtonExit.Text = "No";
            this.noButtonExit.UseVisualStyleBackColor = true;
            // 
            // ExitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 113);
            this.Controls.Add(this.noButtonExit);
            this.Controls.Add(this.yesButtonExit);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ExitForm";
            this.Text = "Exit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button yesButtonExit;
        private Button noButtonExit;
    }
}