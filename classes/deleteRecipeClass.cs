using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LukeC_ST10254164_PROG6221_part2.classes
{
    internal class deleteRecipeClass
    {
        ingredientClass ingredients = new ingredientClass();

        //--------------------deleteData method---------------------------//
        //method must delete the data inputted by the user and loop the application back to the start
        public void deleteData()
        {
            Console.WriteLine("Are you sure you want to delete all your data?");
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No");
            Console.WriteLine("Enter your choice: ");
            int decision = int.Parse(Console.ReadLine());
            //add exception handling
            {
                switch (decision)
                {
                    case 1:
                        //sets all the variables that use user input to null
                       ingredients.ingredientNames = null;
                        ingredients.ingredientQuantities = null;
                       ingredients.unitOfMeasurements = null;
                        ingredients.steps = null;
                        Console.WriteLine("data deleted!");
                        break;
                    //does nothing to the data and just sends them back to the menu
                    case 2:
                        ingredients.displayRecipe();
                        Console.WriteLine("data still present");
                        break;

                    default:
                        Console.WriteLine("please enter a valid input");
                        break;
                }
            }
        }
    }
}
//--------------------------------END OF FILE--------------------------------//