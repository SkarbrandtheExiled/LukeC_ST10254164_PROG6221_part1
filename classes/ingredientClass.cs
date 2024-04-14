using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LukeC_ST10254164_PROG6221_part1.classes
{
    internal class ingredientClass
    {
        private string[] ingredientNames;
        private double[] ingredientQuantities;
        private string[] unitOfMeasurements;
        private List<string> steps;
        //---------------------------Ingrediants method----------------------------//
        public void ingredients()
        {
            Console.WriteLine("Enter the number of ingredients: ");
            int numIngredients = int.Parse( Console.ReadLine() );

            ingredientNames = new string[numIngredients];
            ingredientQuantities = new double[numIngredients];
            unitOfMeasurements = new string[numIngredients];

            for (int i = 0; i < numIngredients; i++)
            {
                Console.WriteLine($"Enter the name of ingredient {i + 1}: ");
                ingredientNames[i] = Console.ReadLine();

                Console.WriteLine($"Please enter the quantity of {ingredientNames[i]}: ");
                ingredientQuantities[i] = double.Parse( Console.ReadLine() );

                Console.WriteLine($"Enter the unit of measurement for {ingredientNames[i]}: ");
                unitOfMeasurements[i] = Console.ReadLine();
            }

            Console.WriteLine("Enter the number of steps: ");
            int numSteps = int.Parse( Console.ReadLine());

            steps = new List<string>(numSteps);
            for (int i = 0; i < numSteps; i++)
            {
                Console.WriteLine($"Enter step {i + 1}: ");
                steps.Add(Console.ReadLine());
            }
        }
        public void displayRecipe()
        {
            Console.WriteLine("Recipe:");

            Console.WriteLine("Ingredients:");
            for (int i = 0; i < ingredientNames.Length; i++)
            {
                Console.WriteLine($"{ingredientQuantities[i]} {unitOfMeasurements[i]} of {ingredientNames[i]}");
            }

            Console.WriteLine("Steps:");
            for (int i = 0; i < steps.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {steps[i]}");

                Console.ReadLine();
            }
        }
    }
}
