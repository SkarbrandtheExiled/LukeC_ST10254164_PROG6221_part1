using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LukeC_ST10254164_PROG6221_part2.classes
{
    //********************************************START OF FILE**********************************//
    internal class recipeChoiceClass
    {
        //this method is not functioning yet
        public void RecipeChoice(ingredientClass recipeData)
        {
            if (recipeData.recipeNames.Count == 0)
            {
                Console.WriteLine("No recipes to display");
                return; // Exit the method if no recipes available
            }

            // Display the recipe menu
            Console.WriteLine("Please choose which recipe you want to view:");
            for (int i = 0; i < recipeData.recipeNames.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {recipeData.recipeNames[i]}");
            }

            // Get user input for recipe choice
            int recipeIndex;
            while (true) // Loop until valid input is received
            {
                Console.Write("Enter the number of the recipe to display: ");
                string userInput = Console.ReadLine();

                if (int.TryParse(userInput, out recipeIndex) &&
                    recipeIndex >= 1 && recipeIndex <= recipeData.recipeNames.Count)
                {
                    break; // Exit loop on valid input
                }

                Console.WriteLine("Invalid recipe selection. Please try again.");
            }

            // Display the selected recipe
            string selectedRecipeName = recipeData.recipeNames[recipeIndex - 1];
            Console.WriteLine($"\nSelected Recipe: {selectedRecipeName}");

            recipeData.DisplayRecipe();
        }
        }
}
//*************************************END OF FILE***********************************************//