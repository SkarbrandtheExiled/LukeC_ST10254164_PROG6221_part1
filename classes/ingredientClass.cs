using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LukeC_ST10254164_PROG6221_part1.classes
{
    internal class ingredientClass
    {
        public string numOfIngredients {  get; set; }
        public string nameOfIngredient { get; set; }
        //---------------------------Ingrediants method----------------------------//
        public void ingredients()
        {
            //must ask for the number of ingrediants for the recipe
            Console.WriteLine("please enter the number of ingrediants for the recipe: ");
            string numOfIngredients = Console.ReadLine();
            Console.WriteLine($"number of ingrediants {numOfIngredients}");

            //ask and store the name of the ingrediant in an array
            Console.WriteLine($"please enter the name of ingrediant {nameOfIngredient}"); //ingrediant 1/x
            foreach (var item in numOfIngredients)
            {
                
            }
            //string[] ingredientName = new ingredientName[numOfIngredient];

        }
    }
}
