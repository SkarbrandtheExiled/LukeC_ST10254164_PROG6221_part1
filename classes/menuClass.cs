using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LukeC_ST10254164_PROG6221_part1.classes
{
    internal class menuClass
    {
        public void recipeMenu()
        {
            ingredientClass recipeManager = new ingredientClass();
            bool Run = true;

            while (Run)
            {
                Console.WriteLine("Welcome to the Recipe App!");
                Console.WriteLine("1. Enter recipe details");
                Console.WriteLine("2. Display recipe");
                Console.WriteLine("3. Scale ingredients");
                Console.WriteLine("4. Reset recipe");
                Console.WriteLine("5. Exit");

                Console.WriteLine("Enter your choice: ");
                //add exception handler here
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        recipeManager.ingredients();
                        break;
                    case 2:
                        recipeManager.displayRecipe();
                        break;
                    case 3:
                        recipeManager.quantityScaling();
                        break;
                    case 4:
                        recipeManager.deleteData();
                        break;
                    case 5:
                        Run = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid option");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}
