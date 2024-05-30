/// <summary>
/// contains methods that handle infromation relevant to the recipe
/// contain the arrays that will hold the name, quantities, and unit of measurements
/// 
/// </summary>
/// 


using LukeC_ST10254164_PROG6221_part1.classes;
using System;
using System.Collections.Generic;
using System.Linq;


namespace LukeC_ST10254164_PROG6221_part2.classes
{
    //********************************************START OF FILE**********************************//
    internal class ingredientClass
    {
        //-------creation and declaration of fields that will be used to store user data-------//
        //an array that must store the names of the ingredients (with the data type string)
        public string[] ingredientNames;

        //an array that stores the quantity/ number of those ingredients (data type is double to ensure users can include fractions)
        public double[] ingredientQuantities;

        // an array that stores the unit of measurments for the ingredients (data type is a string because some recipes don't use numbers to indicate measurements)
        public string[] unitOfMeasurements;

        //a list that stores input from the user to be used when formatting the input, the list will be equal to the size of the number of steps. useful for storing sentences
        public List<string> steps;

        //a list that stores the different recipes
        public List<string> recipeNames = new List<string>();

        public double[] calorieCount;

        public string[] foodGroup;

        //---------------------------Ingrediants method----------------------------//
        //this method is responsible for handling all data relevant to the ingredients of the recipe
        public void Ingredients()
        {
            //add recipe name first
            AddRecipe();
            //prompt asking for the number of ingredients in the recipe
            Console.WriteLine("Please enter the number of ingredients in the recipe: ");
            //must fix this to have error handling
            int numIngredients = int.Parse(Console.ReadLine());

            //responsible for creating and initialising arrays to store the ingredient names, quantities, and units of measurement for the recipe
            ingredientNames = new string[numIngredients];
            ingredientQuantities = new double[numIngredients];
            unitOfMeasurements = new string[numIngredients];
            calorieCount = new double[numIngredients];
            foodGroup = new string[numIngredients];


            for (int i = 0; i < numIngredients; i++)
            {
                //prompt asks for the name of the ingredient and adds it to the 'ingredientNames' array
                Console.WriteLine($"Please enter the name of ingredient {i + 1}: ");
                ingredientNames[i] = Console.ReadLine();

                //if statement contaning a try-catch that manages exception handling in the event that the usesr inputs nothing
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

                //responsible for asking for the calorie count of the ingredients
                Console.WriteLine($"please enter the number of calories for {ingredientNames[i]}: ");
                calorieCount[i] = double.Parse(Console.ReadLine());

                Console.WriteLine($"please enter the food group for {ingredientNames[i]}: ");
                foodGroup[i] = Console.ReadLine();
                //responsibe for getting the food group
            }

            Console.WriteLine("Please enter the number of steps: ");
            int numSteps = int.Parse(Console.ReadLine());

            //a storage container for lists of strings. the numSteps in brackets sets the size of the list meaning the storage will always be equal to the numer set by the user
            steps = new List<string>(numSteps);

            //iterates through each step and prompts the user for input
            for (int i = 0; i < numSteps; i++)
            {
                Console.WriteLine($"Please enter step {i + 1}: ");
                steps.Add(Console.ReadLine());
            }
            //calls the displayRecipe method to show the full recipe
            DisplayRecipe();
        }
        //----------------------------displayRecipe method----------------------------------//
        //this method must prompt the user for the ingredient's name, quantitiy, and unit of measurement
        public void DisplayRecipe()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\nFull recipe: ");
            Console.WriteLine("----------------------------");
            //checks if there is any data to display 
            if (ingredientNames == null || ingredientQuantities == null || unitOfMeasurements == null || calorieCount == null || foodGroup == null)
            {
                // Inform the user there are no ingredients
                Console.WriteLine("No ingredients provided.");

            }
            else
            {
                Console.WriteLine("\nIngredients: ");
                // Loop through the arrays to display all the information in the desired format
                for (int i = 0; i < ingredientNames.Length; i++)
                {
                    // Check if ingredient name exists
                    if (ingredientNames[i] != null)
                    {
                        Console.WriteLine($"{ingredientQuantities[i]} {unitOfMeasurements[i]} of {ingredientNames[i]} (number of calories: {calorieCount[i]} food group: {foodGroup[i]})");
                    }
                }
            }
            Console.WriteLine("------------------------");
            Console.WriteLine("\nSteps: ");

            for (int i = 0; i < steps?.Count; i++)
            {
                //checks if steps exists
                if (steps[i] != null)
                {
                    //displays the steps in the order given by the user
                    Console.WriteLine($"{i + 1}: {steps[i]}");
                }
                else
                {
                    Console.WriteLine("no steps to display");
                }
            }
            Console.WriteLine("---------------------------");
            //a quit function that allows the user to see the application before they close it and lose all stored information
            Console.WriteLine("Press 'enter' to return to menu");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
        }

        //------------------------quantityScaling method-------------------//
        //responsible for scaling the user input 
        //consider moving this
        public void QuantityScaling()
        {
            Console.WriteLine("please enter a value to indicate how much the recipe must be scaled: ");
            //user inputs a value (e.g 1,2, 5) and multiplies that number by the value given for ingredientQuantities
            double scalingNum = double.Parse(Console.ReadLine());

            for (int i = 0; i < ingredientQuantities.Length; i++) //exception handle
            {
                ingredientQuantities[i] *= scalingNum;
            }
            ScalingRecipe recipeScale = new ScalingRecipe(ingredientNames, ingredientQuantities, unitOfMeasurements, calorieCount, foodGroup, steps);
            recipeScale.DisplayScaling();
        }

        //------------------addRecipe------------------------------//
        //responsible for displaying a prompt and showing the new added recipe names
        public void AddRecipe() //add recipe method does not add to the array!!NB
        {
            Console.WriteLine("please enter the name of the recipe: ");
            string recipeName = Console.ReadLine();
            recipeNames.Add(recipeName); 
            Console.WriteLine($"recipe {recipeName} has been added");
        }

        public void DisplayCalories(double totalCalories, double calorieLimit)
        {
            if (totalCalories > calorieLimit)
            {
                DisplayExceededCalories(totalCalories, calorieLimit);
            }
            else
            {
                DisplayTotalCalories(totalCalories, calorieLimit);
            }
        }


        //-----------------delegateMethods-----------------------//
        public delegate void CalorieDisplayDelegate(double totalCalories, double calorieLimit);
        public static void DisplayExceededCalories(double totalCalories, double calorieLimit)
        {
            Console.WriteLine($"Number of calories ({totalCalories}) has exceeded the maximum limit of {calorieLimit} calories.");
        }

        public static void DisplayTotalCalories(double totalCalories, double calorieLimit)
        {
            Console.WriteLine($"Total calories: {totalCalories}");
        }
        public void totalCalories(CalorieDisplayDelegate displayCalories)
        {
            double totalCalories = calorieCount.Sum();

            double calorieLimit = 300;

            displayCalories(totalCalories, calorieLimit);
        }
      
    } //end of delegate file
}
//*************************************END OF FILE***********************************************//