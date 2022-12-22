using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_A_B
{
    public partial class AddIngredientsForm : Form
    {
        private string[] ingredients = Array.Empty<string>();
        private int numOfElemns = 0;
        /// <summary>
        /// Constructor
        /// </summary>
        public AddIngredientsForm()
        {
            InitializeComponent();
            UpdateGUI();
        }
        /// <summary>
        /// Method to update the gui and update the listbox
        /// </summary>
        public void UpdateGUI()
        {
            ingredientTextBox.Text = "";
            countIngredientsLabel.Text = numOfElemns.ToString();
        }
        /// <summary>
        /// Method to get the ingredients list
        /// </summary>
        public string[] GetIngredients()
        {
            return ingredients;
        }
        /// <summary>
        /// Method to get the number of ingredients
        /// </summary>
        public int GetNumIngredients()
        {
            return numOfElemns;
        }
        /// <summary>
        /// Method trieggered by clicking add button
        /// it adds the ingredient to the listbox
        /// </summary>
        private void addButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ingredientTextBox.Text.Trim()))
            {
                string[] res = new string[numOfElemns + 1];
                for (int i = 0; i < numOfElemns; i++)
                {
                    res[i] = ingredients[i];
                }
                res[numOfElemns] = ingredientTextBox.Text.Trim();
                ingredientsListBox.Items.Add(ingredientTextBox.Text.Trim());
                numOfElemns += 1;
                ingredients = res;
                UpdateGUI();
            }
            else
            {
                MessageBox.Show("Invalid name");
            }
        }
        /// <summary>
        /// Method trieggered by clicking add button
        /// it deletes the ingredient to the listbox
        /// </summary>
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (ingredientsListBox.SelectedIndices.Count==0)
            {
                return;
            }
            string[] res = new string[numOfElemns - 1];
            int tmp = 0;
            for (int i = 0; i < numOfElemns; i++)
            {
                if (ingredientsListBox.SelectedIndex == i)
                {
                    tmp = 1;
                }
                else
                {
                    res[i-tmp] = ingredients[i];
                }
            }
            numOfElemns-=1;
            ingredientsListBox.Items.RemoveAt(ingredientsListBox.SelectedIndex);
            ingredients = res;
            UpdateGUI();
        }
    }
}
