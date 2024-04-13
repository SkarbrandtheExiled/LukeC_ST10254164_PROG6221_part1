using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LukeC_ST10254164_PROG6221_part1.classes
{
    internal class ingredientClass
    {
        //---------------------------Ingrediants method----------------------------//
        public static void ingredients()
        {
            //must ask for the number of ingrediants for the recipe
            Console.WriteLine("please enter the number of ingrediants for the recipe: ");
            string numOfIngredient = Console.ReadLine();

            //ask and store the name of the ingrediant in an array
            Console.WriteLine("please enter the name of ingrediant 1: "); //ingrediant 1/x
            string[] ingredientName = Console.ReadLine();

            //
            Console.WriteLine("number of ingrediants; " + numOfIngredient);
        }
    }
}
