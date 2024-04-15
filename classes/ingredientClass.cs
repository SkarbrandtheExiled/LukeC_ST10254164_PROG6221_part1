using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LukeC_ST10254164_PROG6221_part1.classes
{
    internal class ingredientClass
    {
        //-------initalisation of arrays that will be used to store user data------//
        private string[] ingredientNames; //an array that must store the names of the ingredients (with the data type string)
        private double[] ingredientQuantities; //an array that stores the quantity/ number of those ingredients (data type is double to ensure users can include fractions)
        private string[] unitOfMeasurements; // an array that stores the unit of measurments for the ingredients (data type is a string because some recipes don't use numbers to indicate measurements)
        private List<string> steps;
        //---------------------------Ingrediants method----------------------------//
        public void ingredients()
        {
            Console.WriteLine("Please enter the number of ingredients: ");
            int numIngredients = int.Parse( Console.ReadLine() ); //must fix this to have error handling

            ingredientNames = new string[numIngredients];
            ingredientQuantities = new double[numIngredients];
            unitOfMeasurements = new string[numIngredients];

            for (int i = 0; i < numIngredients; i++)
            {
                Console.WriteLine($"Please enter the name of ingredient {i + 1}: ");
                ingredientNames[i] = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(ingredientNames[i]))
                {
                    Console.WriteLine($"Please enter the quantity of {ingredientNames[i]}: ");

                    try
                    {
                        ingredientQuantities[i] = double.Parse(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number for the quantity.");
                        i--; // Decrement i to repeat the same index
                        continue;
                    }

                    Console.WriteLine($"Please enter the unit of measurement for {ingredientNames[i]}: ");
                    unitOfMeasurements[i] = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Please enter a valid name for the ingredient.");
                    i--; // Decrement i to repeat the same index
                }
            }

            Console.WriteLine("Please enter the number of steps: ");
            int numSteps = int.Parse( Console.ReadLine());

            steps = new List<string>(numSteps);
            for (int i = 0; i < numSteps; i++)
            {
                Console.WriteLine($"Please enter step {i + 1}: ");
                steps.Add(Console.ReadLine());
            }
            displayRecipe();
        }
//----------------------------displayRecipe method----------------------------------//
        public void displayRecipe()
        {
            Console.WriteLine("\nfull recipe:");

            Console.WriteLine("Ingredients:");
            for (int i = 0; i < ingredientNames.Length; i++)
            {
                Console.WriteLine($"{ingredientQuantities[i]} {unitOfMeasurements[i]} of {ingredientNames[i]}");
            }

            Console.WriteLine("\nSteps:");
            for (int i = 0; i < steps.Count; i++)
            {
                Console.WriteLine($"{i + 1}: {steps[i]}");
            }
            Console.WriteLine("press 'enter' to quite application");
            Console.ReadLine();
        }
        //--------------------deleteData method---------------------------//
        public void deleteData() //method must delete the data inputted by the user and loop the application back to the start
        {

        }
    }
}
