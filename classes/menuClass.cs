///summary
/// displays a menu-like system which gives the user the ability to choose what they want to do
///contains instantiation to access the ingedientClass
///

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LukeC_ST10254164_PROG6221_part1.classes
{
    //********************************************START OF FILE**********************************//
    internal class menuClass
    {
        //------------------recipeMenu-----------------------//
        //creates a menu that allows the users to pick what they want to see/ do
        public void recipeMenu()
        {
            //creates an instance of the ingredientClass so that methods from it can be used in other classes
            ingredientClass recipeManager = new ingredientClass();
            bool Run = true;
            //neeed exception handler
            while (Run)
            {
                Console.WriteLine("Welcome to the Recipe App!");
                Console.WriteLine("1. Enter recipe details");
                Console.WriteLine("2. Display recipe");
                Console.WriteLine("3. Scale ingredients");
                Console.WriteLine("4. Delete recipe");
                Console.WriteLine("5. Exit");

                Console.WriteLine("Enter your choice: ");

                int choices = int.Parse(Console.ReadLine());

                //a switch-case that allows the user to selcet an option by inputting a number from the menu
                switch (choices)
                {
                    //calls a method from the ingredient class
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
//*************************************END OF FILE***********************************************//