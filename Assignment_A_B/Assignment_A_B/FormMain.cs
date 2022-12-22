using System.Xml.Linq;

namespace Assignment_A_B
{
    public partial class FormMain : Form
    {
        private Recipe currentRecipe;
        private RecipeManager rm = new(200);
        public FormMain()
        {
            InitializeComponent();
            currentRecipe = new Recipe(50);
            InitializeGUI();
        }
        /// <summary>
        /// Method to inilialize GUI
        /// </summary>
        private void InitializeGUI()
        {
            categoryComboBox.Items.Add(FoodCategory.Soups);
            categoryComboBox.Items.Add(FoodCategory.Meats);
            categoryComboBox.Items.Add(FoodCategory.Vegan);
            categoryComboBox.Items.Add(FoodCategory.Pasta);
            categoryComboBox.Items.Add(FoodCategory.Stew);
            categoryComboBox.Items.Add(FoodCategory.Pizza);
            categoryComboBox.Items.Add(FoodCategory.Fish);
            categoryComboBox.Items.Add(FoodCategory.Seafood);
            categoryComboBox.Items.Add(FoodCategory.Vegetarian);
            categoryComboBox.Items.Add(FoodCategory.Vegetarian_Dairy_Egg);
            categoryComboBox.Items.Add(FoodCategory.Other);
            categoryComboBox.SelectedItem = FoodCategory.Other;
            ColumnHeader header1 = new();
            header1.Text = "Name";
            header1.TextAlign = HorizontalAlignment.Center;
            header1.Width = 160;
            recipesListView.Columns.Add(header1);
            ColumnHeader header2 = new();
            header2.Text = "Category";
            header2.TextAlign = HorizontalAlignment.Center;
            header2.Width = 160;
            recipesListView.Columns.Add(header2);
            ColumnHeader header3 = new();
            header3.Text = "No. of ingredients";
            header3.TextAlign = HorizontalAlignment.Center;
            header3.Width = 196;
            recipesListView.Columns.Add(header3);
            recipesListView.View = View.Details;
        }
        /// <summary>
        /// Method to read recipe name and insert into current Recipe
        /// </summary>
        private bool ReadRecipeName()
        {
            if (!string.IsNullOrEmpty(recipeNameTextBox.Text.Trim()))
            {
                currentRecipe.Name = recipeNameTextBox.Text.Trim();
            }
            else
            {
                recipeNameTextBox.Text = "Undefined";
                MessageBox.Show("Invalid name");
                return false;
            }
            return true;
        }
        /// <summary>
        /// Method to read recipe description and insert into current Recipe
        /// </summary>
        private bool ReadDescription()
        {
            if (!string.IsNullOrEmpty(descriptionTextBox.Text))
            {
                currentRecipe.Description = descriptionTextBox.Text;
            }
            else
            {
                descriptionTextBox.Text = "";
                MessageBox.Show("Invalid description");
                return false;
            }
            return true;
        }
        /// <summary>
        /// Method to read recipe category and insert into current Recipe
        /// </summary>
        private bool ReadCategory()
        {
            currentRecipe.Category = (FoodCategory)categoryComboBox.Items[categoryComboBox.SelectedIndex];
            return true;
        }
        /// <summary>
        /// Method triggered by the button Add Recipe
        /// Add the recipe to the listBox
        /// </summary>
        private void addRecipe_Click(object sender, EventArgs e)
        {
            if (!(ReadRecipeName()&&ReadDescription()&&ReadCategory())){
                return;
            }
            if (currentRecipe.NumOfElemns<1)
            {
                MessageBox.Show("Not enough ingredients","Error");
                return;
            }
            if (rm.Add(currentRecipe))
            {
                ListViewItem lvi = new(currentRecipe.Name);
                lvi.SubItems.Add(currentRecipe.Category.ToString());
                lvi.SubItems.Add(currentRecipe.NumOfElemns.ToString());
                recipesListView.Items.Add(lvi);
            }
            else
            {
                MessageBox.Show("No duplicate allowed","Error");
            }
        }
        /// <summary>
        /// Method triggered by the button Add Ingredients
        /// Add the ingredients to the current recipe
        /// </summary>
        private void addIngredients_Click(object sender, EventArgs e)
        {
            AddIngredientsForm f = new();
            DialogResult dialogResult = f.ShowDialog();
            if(dialogResult == DialogResult.OK)
            {
                if (f.GetNumIngredients() <= 0)
                {
                    MessageBox.Show("No Ingredients","Error");
                }
                else
                {
                    currentRecipe.Ingredients = f.GetIngredients();
                    currentRecipe.NumOfElemns = f.GetNumIngredients();
                }
            }
        }
        /// <summary>
        /// Method triggered by the click onto a recipe
        /// </summary>
        private void recipesListView_DoubleClick(object sender, EventArgs e)
        {
            if (recipesListView.SelectedItems.Count != 1)
            {
                return;
            }
            if (recipesListView.SelectedIndices[0]>rm.getCurrentNumberOfRecipes())
            {
                return;
            }
            MessageBox.Show("Ingredients:\n" + rm.GetRecipeAt(recipesListView.SelectedIndices[0]).GetIngredientsString() + "\n\n" + rm.GetRecipeAt(recipesListView.SelectedIndices[0]).Description);
        }
        /// <summary>
        /// Method triggered by the click of the clear selection button
        /// </summary>
        private void clearSelectionButton_Click(object sender, EventArgs e)
        {
            recipesListView.SelectedIndices.Clear();
        }
        /// <summary>
        /// Method triggered by the click of the delete button
        /// </summary>
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (recipesListView.SelectedItems.Count != 1)
            {
                return;
            }
            if (recipesListView.SelectedIndices[0] > rm.getCurrentNumberOfRecipes())
            {
                return;
            }
            rm.DeleteElement(recipesListView.SelectedIndices[0]);
            recipesListView.Items.RemoveAt(recipesListView.SelectedIndices[0]);
        }
        /// <summary>
        /// Method triggered by the click of the begin edit button
        /// </summary>
        private void editBeginButton_Click(object sender, EventArgs e)
        {
            if (recipesListView.SelectedItems.Count != 1)
            {
                return;
            }
            recipesListView.LabelEdit = true;
            recipesListView.SelectedItems[0].BeginEdit();
        }
        /// <summary>
        /// Method triggered by the click of the end edit button
        /// </summary>
        private void editFinishButton_Click(object sender, EventArgs e)
        {
            if (recipesListView.SelectedItems.Count != 1)
            {
                return;
            }
            int index = recipesListView.SelectedIndices[0];
            Recipe r = new(50)
            {
                Ingredients = rm.GetRecipeAt(index).Ingredients,
                Name = recipesListView.SelectedItems[0].Name
            };
            rm.ChangeElement(index,r);
            recipesListView.LabelEdit = false;
        }
    }
}