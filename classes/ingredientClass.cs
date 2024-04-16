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

        //an array that must store the names of the ingredients (with the data type string)
        public string[] ingredientNames;
        //an array that stores the quantity/ number of those ingredients (data type is double to ensure users can include fractions)
        public double[] ingredientQuantities;
        // an array that stores the unit of measurments for the ingredients (data type is a string because some recipes don't use numbers to indicate measurements)
        public string[] unitOfMeasurements; 
        //a list that stores input from the user to be used when formatting the input
        public List<string> steps;
        //---------------------------Ingrediants method----------------------------//
        public void ingredients()
        {
            //prompt asking for the number of ingredients in the recipe
            Console.WriteLine("Please enter the number of ingredients in the recipe: ");
            //must fix this to have error handling
            int numIngredients = int.Parse( Console.ReadLine() ); 

            ingredientNames = new string[numIngredients];
            ingredientQuantities = new double[numIngredients];
            unitOfMeasurements = new string[numIngredients];

            for (int i = 0; i < numIngredients; i++)
            {
                //prompt asks for the name of the ingredient and adds it to the 'ingredientNames' array
                Console.WriteLine($"Please enter the name of ingredient {i + 1}: "); 
                ingredientNames[i] = Console.ReadLine();

                //if statement contaning a try-catch that manages exception handling
                if (!string.IsNullOrWhiteSpace(ingredientNames[i])) 
                {
                    Console.WriteLine($"Please enter the quantity of {ingredientNames[i]}: ");

                    //a try-cacth that checks if the value inputed matches the required data types
                    try
                    {
                        ingredientQuantities[i] = double.Parse(Console.ReadLine()); 
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Please enter a valid number for the quantity");
                        // Decrements i to repeat the same index
                        i--; 
                        continue;
                    }

                    Console.WriteLine($"Please enter the unit of measurement for {ingredientNames[i]}: ");
                    unitOfMeasurements[i] = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Please enter a valid name for the ingredient");
                    // Decrements i to repeat the same index
                    i--; 
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
            //calls the displayRecipe method to show the full recipe
            displayRecipe();
        }
        //----------------------------displayRecipe method----------------------------------//
        //this method must prompt the user for the ingredient's name, quantitiy, and unit of measurement
        public void displayRecipe() 
        {
            Console.WriteLine("\nFull recipe: ");
            Console.WriteLine("----------------------------");

            //loops through the arrays to display all the information in the desired format
            Console.WriteLine("\nIngredients: ");
            //add exception handler here
            for (int i = 0; i < ingredientNames.Length; i++)
            {
                Console.WriteLine($"{ingredientQuantities[i]} {unitOfMeasurements[i]} of {ingredientNames[i]}");
            }
            Console.WriteLine("------------------------");
            Console.WriteLine("\nSteps: ");
            for (int i = 0; i < steps.Count; i++)
            {
                //displays the steps in the order given by the user
                Console.WriteLine($"{i + 1}: {steps[i]}");
            }
            Console.WriteLine("---------------------------");


            //a quite function that allows the user to see the application before they close it and lose all stored information
            Console.WriteLine("Press 'enter' to return to menu");
            Console.ReadLine();
        }

        //--------------------deleteData method---------------------------//
        //method must delete the data inputted by the user and loop the application back to the start
        public void deleteData() 
        {
            //sets all the variables that use user input to null
ingredientNames = null;
            ingredientQuantities = null;
                unitOfMeasurements = null;
            steps = null;

            //re-calls the method to make the user start from scratch
            ingredients(); 
        }
        //------------------------quantityScaling method-------------------//
        public void quantityScaling()
        {
            Console.WriteLine("please enter a value to indicate how much the recipe must be scaled: ");
            double scalingNum = double.Parse(Console.ReadLine());

            for (int i = 0; i < ingredientQuantities.Length; i++)
            {
                ingredientQuantities[i] *= scalingNum;
            }

            Console.WriteLine("\nScaled Recipe:");
        }
        //---------------------displayScaling---------------------//
        public void displayScaling()
        {
            Console.WriteLine("\nfull Recipe: ");
            Console.WriteLine("-----------------------");
            Console.WriteLine("\nIngredients: ");
            for (int i = 0; i < ingredientNames.Length; i++)
            {
                Console.WriteLine($"{ingredientQuantities[i]} {unitOfMeasurements[i]} of {ingredientNames[i]}");
            }
            Console.WriteLine("------------------------");
            Console.WriteLine("\nSteps: ");
            for (int i = 0; i < steps.Count; i++)
            {
                //displays the steps in the order given by the user
                Console.WriteLine($"{i + 1}: {steps[i]}");
            }
            Console.WriteLine("---------------------------");
        }
    }
}
