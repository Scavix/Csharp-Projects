namespace Assignment_A_B
{
    partial class FormMain
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addRecipeButton = new System.Windows.Forms.Button();
            this.descriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.recipeNameTextBox = new System.Windows.Forms.TextBox();
            this.recipeNameLabel = new System.Windows.Forms.Label();
            this.addIngredientsButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.recipesListView = new System.Windows.Forms.ListView();
            this.clearSelectionButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editFinishButton = new System.Windows.Forms.Button();
            this.editBeginButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addRecipeButton);
            this.groupBox1.Controls.Add(this.descriptionTextBox);
            this.groupBox1.Controls.Add(this.categoryComboBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.recipeNameTextBox);
            this.groupBox1.Controls.Add(this.recipeNameLabel);
            this.groupBox1.Controls.Add(this.addIngredientsButton);
            this.groupBox1.Location = new System.Drawing.Point(11, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(506, 427);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add new Recipe";
            // 
            // addRecipeButton
            // 
            this.addRecipeButton.Location = new System.Drawing.Point(21, 382);
            this.addRecipeButton.Name = "addRecipeButton";
            this.addRecipeButton.Size = new System.Drawing.Size(477, 38);
            this.addRecipeButton.TabIndex = 6;
            this.addRecipeButton.Text = "Add Recipe";
            this.addRecipeButton.UseVisualStyleBackColor = true;
            this.addRecipeButton.Click += new System.EventHandler(this.addRecipe_Click);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(21, 143);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(477, 227);
            this.descriptionTextBox.TabIndex = 5;
            this.descriptionTextBox.Text = "";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(111, 93);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(201, 33);
            this.categoryComboBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Category";
            // 
            // recipeNameTextBox
            // 
            this.recipeNameTextBox.Location = new System.Drawing.Point(166, 43);
            this.recipeNameTextBox.Name = "recipeNameTextBox";
            this.recipeNameTextBox.Size = new System.Drawing.Size(334, 31);
            this.recipeNameTextBox.TabIndex = 2;
            this.recipeNameTextBox.Text = " ";
            this.recipeNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // recipeNameLabel
            // 
            this.recipeNameLabel.AutoSize = true;
            this.recipeNameLabel.Location = new System.Drawing.Point(21, 43);
            this.recipeNameLabel.Name = "recipeNameLabel";
            this.recipeNameLabel.Size = new System.Drawing.Size(137, 25);
            this.recipeNameLabel.TabIndex = 1;
            this.recipeNameLabel.Text = "Name of Recipe";
            // 
            // addIngredientsButton
            // 
            this.addIngredientsButton.Location = new System.Drawing.Point(319, 93);
            this.addIngredientsButton.Name = "addIngredientsButton";
            this.addIngredientsButton.Size = new System.Drawing.Size(180, 38);
            this.addIngredientsButton.TabIndex = 0;
            this.addIngredientsButton.Text = "Add Ingredients";
            this.addIngredientsButton.UseVisualStyleBackColor = true;
            this.addIngredientsButton.Click += new System.EventHandler(this.addIngredients_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.recipesListView);
            this.groupBox2.Controls.Add(this.clearSelectionButton);
            this.groupBox2.Controls.Add(this.deleteButton);
            this.groupBox2.Controls.Add(this.editFinishButton);
            this.groupBox2.Controls.Add(this.editBeginButton);
            this.groupBox2.Location = new System.Drawing.Point(523, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(528, 427);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // recipesListView
            // 
            this.recipesListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.recipesListView.Location = new System.Drawing.Point(6, 30);
            this.recipesListView.MultiSelect = false;
            this.recipesListView.Name = "recipesListView";
            this.recipesListView.Size = new System.Drawing.Size(516, 340);
            this.recipesListView.TabIndex = 5;
            this.recipesListView.UseCompatibleStateImageBehavior = false;
            this.recipesListView.DoubleClick += new System.EventHandler(this.recipesListView_DoubleClick);
            // 
            // clearSelectionButton
            // 
            this.clearSelectionButton.Location = new System.Drawing.Point(357, 382);
            this.clearSelectionButton.Name = "clearSelectionButton";
            this.clearSelectionButton.Size = new System.Drawing.Size(165, 38);
            this.clearSelectionButton.TabIndex = 4;
            this.clearSelectionButton.Text = "Clear Selection";
            this.clearSelectionButton.UseVisualStyleBackColor = true;
            this.clearSelectionButton.Click += new System.EventHandler(this.clearSelectionButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(240, 382);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(111, 38);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editFinishButton
            // 
            this.editFinishButton.Location = new System.Drawing.Point(123, 382);
            this.editFinishButton.Name = "editFinishButton";
            this.editFinishButton.Size = new System.Drawing.Size(111, 38);
            this.editFinishButton.TabIndex = 2;
            this.editFinishButton.Text = "Edit-Finish";
            this.editFinishButton.UseVisualStyleBackColor = true;
            this.editFinishButton.Click += new System.EventHandler(this.editFinishButton_Click);
            // 
            // editBeginButton
            // 
            this.editBeginButton.Location = new System.Drawing.Point(6, 382);
            this.editBeginButton.Name = "editBeginButton";
            this.editBeginButton.Size = new System.Drawing.Size(111, 38);
            this.editBeginButton.TabIndex = 1;
            this.editBeginButton.Text = "Edit-Begin";
            this.editBeginButton.UseVisualStyleBackColor = true;
            this.editBeginButton.Click += new System.EventHandler(this.editBeginButton_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormMain";
            this.Text = "Apu Recipe book by Francesco";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label recipeNameLabel;
        private Button addIngredientsButton;
        private GroupBox groupBox2;
        private Button addRecipeButton;
        private RichTextBox descriptionTextBox;
        private ComboBox categoryComboBox;
        private Label label2;
        private TextBox recipeNameTextBox;
        private Button clearSelectionButton;
        private Button deleteButton;
        private Button editFinishButton;
        private Button editBeginButton;
        private ListView recipesListView;
    }
}