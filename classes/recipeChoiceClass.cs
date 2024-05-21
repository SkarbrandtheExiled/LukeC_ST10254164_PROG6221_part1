using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LukeC_ST10254164_PROG6221_part1.classes
{
    //********************************************START OF FILE**********************************//
    internal class recipeChoiceClass
    {
        //this method is not functioning yet
        public void recipeChoice()
        {
            ingredientClass ingredientSelection = new ingredientClass();

            Console.WriteLine("please choose which recipe you want to view:");
            if (ingredientSelection.recipeNames.Count == 0) //error the recipe number is always 0!!
            {
                Console.WriteLine("No recipes to display");
            }
            else
            {
                for (int i = 0; i < ingredientSelection.RecipeNames.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {ingredientSelection.RecipeNames[i]}");
                }
                //must display a menu showing all the recipes that have already been made
            }

            Console.Write("Enter the number of the recipe to display: ");
            int recipeIndex;
            //change the code below to something that is easier to understand and works
            if (int.TryParse(Console.ReadLine(), out recipeIndex) && recipeIndex >= 1 && recipeIndex <= ingredientSelection.RecipeNames.Count)
            {
                string selectedRecipeName = ingredientSelection.RecipeNames[recipeIndex - 1];
                Console.WriteLine($"\nSelected Recipe: {selectedRecipeName}");
                // Call the displayRecipe method from the ingredientClass to display the recipe details
                ingredientSelection.displayRecipe();
            }
            else
            {
                Console.WriteLine("Invalid recipe selection.");
            }
        }
    }
}
//*************************************END OF FILE***********************************************//