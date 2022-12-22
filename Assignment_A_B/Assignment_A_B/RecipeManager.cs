using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_A_B
{
    internal class RecipeManager
    {
        private Recipe[] recipeList = Array.Empty<Recipe>();
        private int NumOfElemns = 0;
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="maxNumOfElements">Number of elements in array</param>
        public RecipeManager(int maxNumOfElements)
        {
            recipeList = new Recipe[maxNumOfElements];
        }
        /// <summary>
        /// Append a recipe to the internal array.
        /// </summary>
        /// <param name="recipe">Recipe to add</param>
        public bool Add(Recipe recipe)
        {
            for(int i = 0; i<NumOfElemns;i++){
                if (recipeList[i].Name.Equals(recipe.Name))
                {
                    return false;
                }
            }
            recipeList[NumOfElemns] = recipe;
            NumOfElemns++;
            return true;
        }
        /// <summary>
        /// Methods to create and add a recipe to the recipes manager.
        /// </summary>
        /// <param name="name">Recipe name</param>
        /// <param name="foodCategory">Food category type</param>
        /// <param name="ingredients">Ingredients list</param>
        public bool Add(string name, FoodCategory foodCategory, string[] ingredients)
        {
            Recipe recipe = new(ingredients.Length);
            recipe.Name = name;
            recipe.Category = foodCategory;
            recipe.Ingredients = ingredients;
            return Add(recipe);
        }
        /// <summary>
        /// Set element at index to the given recipe.
        /// </summary>
        /// <param name="index">Index to substitute</param>
        /// <param name="recipe">Recipe</param>
        public void ChangeElement(int index, Recipe recipe)
        {
            if (CheckIndex(index))
            {
                recipeList[index] = recipe;
            }
        }
        /// <summary>
        /// Check if the index is a valid number.
        /// If so return true, otherwise false.
        /// </summary>
        /// <param name="index">Index to substitute</param>
        private bool CheckIndex(int index)
        {
            if (index > NumOfElemns)
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// Method to delete a recipe given an index.
        /// Shift all the next ones of 1 position to fill everything.
        /// </summary>
        /// <param name="index">Index to substitute</param>
        public void DeleteElement(int index)
        {
            if (CheckIndex(index))
            {
                for (int i = index; i < NumOfElemns - 1; i++)
                {
                    ChangeElement(i, recipeList[i + 1]);
                }
                NumOfElemns--;
            }
        }
        /// <summary>
        /// Method to find a vacant position in the recipes list.
        /// </summary>
        private int findVacantPosition()
        {
            for (int i = 0; i < NumOfElemns; i++)
            {
                if (recipeList[i]==null)
                {
                    return i;
                }
            }
            return -1;
        }
        /// <summary>
        /// Method to retrieve the current number of recipess.
        /// </summary>
        public int getCurrentNumberOfRecipes() {
            return NumOfElemns;
        }
        /// <summary>
        /// Method to get the recipe at index given.
        /// </summary>
        /// <param name="index">Index to retrieve</param>
        public Recipe GetRecipeAt(int index)
        {
            //return CheckIndex(index) ? recipeList[index] : new Recipe(50);
            return recipeList[index];
        }
        /// <summary>
        /// Method to stringify all the recipes.
        /// </summary>
        public string[] RecipeListToString()
        {
            string[] result = new string[NumOfElemns];
            for (int i = 0; i < NumOfElemns; i++)
            {
                result[i] = recipeList[i].Name + " " + recipeList[i].Category + " " + recipeList[i].Ingredients.Length;
            }
            return result;
        }
    }
}
