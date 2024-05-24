using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LukeC_ST10254164_PROG6221_part2.classes
{
    internal class displayRecipeClass
    {
        ingredientClass displayIngredients = new ingredientClass();

        //this class is not functioning 
        //----------------------------displayRecipe method----------------------------------//
        //this method must prompt the user for the ingredient's name, quantitiy, and unit of measurement
        public void displayRecipe()
        {
            Console.WriteLine("\nFull recipe: ");
            Console.WriteLine("----------------------------");
            //checks if there is any data to display 
            if (displayIngredients.ingredientNames == null ||displayIngredients.ingredientQuantities == null || displayIngredients.unitOfMeasurements == null)
            {
                // Inform the user there are no ingredients
                Console.WriteLine("No ingredients provided.");

            }
            else
            {
                Console.WriteLine("\nIngredients: ");
                // Loop through the arrays to display all the information in the desired format
                for (int i = 0; i < displayIngredients.ingredientNames.Length; i++)
                {
                    // Check if ingredient name exists
                    if (displayIngredients.ingredientNames[i] != null)
                    {
                        Console.WriteLine($"{displayIngredients.ingredientQuantities[i]} {displayIngredients.unitOfMeasurements[i]} of {displayIngredients.ingredientNames[i]} (number of calories: {displayIngredients.calorieCount}/n food group: {displayIngredients.foodGroup})");
                    }
                }
            }
            Console.WriteLine("------------------------");
            Console.WriteLine("\nSteps: ");

            for (int i = 0; i < displayIngredients.steps?.Count; i++)
            {
                //checks if steps exists
                if (displayIngredients.steps[i] != null)
                {
                    //displays the steps in the order given by the user
                    Console.WriteLine($"{i + 1}: {displayIngredients.steps[i]}");
                }
                else
                {
                    Console.WriteLine("no steps to display");
                }
            }
            Console.WriteLine("---------------------------");
            //a quite function that allows the user to see the application before they close it and lose all stored information
            Console.WriteLine("Press 'enter' to return to menu");
            Console.ReadLine();
        }
    }
}
//--------------------------END OF FILE-------------------------------//