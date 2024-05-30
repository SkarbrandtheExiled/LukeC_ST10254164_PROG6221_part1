using LukeC_ST10254164_PROG6221_part2.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LukeC_ST10254164_PROG6221_part1.classes
{
    internal class ScalingRecipe
    {
        private string[] ingredientNames;
        private double[] ingredientQuantities;
        private string[] unitOfMeasurements;
        private double[] calorieCount;
        private string[] foodGroup;
        private List<string> steps;

        public ScalingRecipe(string[] ingredientNames, double[] ingredientQuantities, string[] unitOfMeasurements, double[] calorieCount, string[] foodGroup, List<string> steps)
        {
            this.ingredientNames = ingredientNames;
            this.ingredientQuantities = ingredientQuantities;
            this.unitOfMeasurements = unitOfMeasurements;
            this.calorieCount = calorieCount;
            this.foodGroup = foodGroup;
            this.steps = steps;
        }

        //---------------------displayScaling---------------------//
        //displays the new values after scaling them
        public void DisplayScaling()
        {

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nScaled Recipe:");
            Console.WriteLine("-----------------------");
            Console.WriteLine("\nIngredients: ");
            for (int i = 0; i < ingredientNames.Length; i++)
            {
                //a prompt that displays a message containg the value for the new quantities
                Console.WriteLine($"{ingredientQuantities[i]} {unitOfMeasurements[i]} of {ingredientNames[i]} (calories: {calorieCount[i]}, food group: {foodGroup[i]}");
            }
            Console.WriteLine("------------------------");
            Console.WriteLine("\nSteps: ");
            //loops through the steps list
            for (int i = 0; i < steps.Count; i++)
            {
                //displays the steps in the order writen by the user
                Console.WriteLine($"{i + 1}: {steps[i]}");
            }
            Console.WriteLine("---------------------------");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
