using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_A_B
{
    internal class Recipe
    {
        public string Name { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        public FoodCategory Category { get; set; } = FoodCategory.Other;
        public string[] Ingredients { get; set; } = Array.Empty<string>();
        public int NumOfElemns { get; set; } = 0;
        public int MaxNumberOfIngrediends { get; } = 50;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="maxNumOfElements">Number of elements in array</param>
        public Recipe(int maxNumOfElements)
        {
            Name = "";
            Description = "";
            Ingredients = new string[maxNumOfElements];
        }
        /// <summary>
        /// Methods to add Ingredients in the recipe
        /// </summary>
        /// <param name="Ingredient">Ingredient name</param>
        public bool AddIngredients(string ingredient)
        {
            bool result = false;
            if (ChangeIngredientAt(NumOfElemns, ingredient))
            {
                result = true;
                NumOfElemns++;
            }
            return result;
        }
        /// <summary>
        /// Methods to change ingredients given index.
        /// </summary>
        /// <param name="Ingredient">Index of the ingredient to change</param>
        public bool ChangeIngredientAt(int index, string value)
        {
            if (CheckIndex(index))
            {
                Ingredients[index] = value;
                return true;
            }
            return false;
        }
        /// <summary>
        /// Methods to check if index is allowed.
        /// </summary>
        private bool CheckIndex(int index)
        {
            if (index > Ingredients.Length)
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// Clone array in case something wrong
        /// Try to delete, if ok return true
        /// If not, clone again the arrary in Ingredients and return false
        /// </summary>
        /// <param name="index">Index of ingredient to delete</param>
        public bool DeleteIngredientAt(int index)
        {
            string[] clone = new string[Ingredients.Length];
            Ingredients.CopyTo(clone, 0);
            for (int i = index; i < NumOfElemns - 1; i++)
            {
                if (!ChangeIngredientAt(i, Ingredients[i + 1]))
                {
                    clone.CopyTo(Ingredients, 0);
                    return false;
                }
            }
            NumOfElemns--;
            return true;
        }
        /// <summary>
        /// To string of all ingredients
        /// </summary>
        public string GetIngredientsString()
        {
            string result = "";
            for (int i = 0; i < NumOfElemns; i++)
            {
                result += Ingredients[i] + ", ";
            }
            result = result.Substring(0, result.Length - 2);
            if (result.Trim() == "")
            {
                return "ok";
            }
            else
            {
                return result;
            }
        }
    }
}
