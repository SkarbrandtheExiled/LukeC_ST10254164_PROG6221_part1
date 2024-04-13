using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LukeC_ST10254164_PROG6221_part1.classes
{
    internal class quantityClass
    {

        //----------------------------Quantity method----------------------------//
        public static void quantity()
        {
            //must ask for the amount of the ingrediant is needed
            Console.WriteLine("please enter the quantity of the ingrediant: ");
            string ingredient = Console.ReadLine();
            Console.WriteLine("quanity =: " + ingredient);

            //prompt to ask for the unit of measurement desired by the user
            Console.WriteLine("please enter the unit of measurement you want to use: ");
            string unitOfMeasurment = Console.ReadLine();
            Console.WriteLine("Confirmed! Your unit of measurment is: " + unitOfMeasurment);

            //wait for enter key before closing app
            Console.WriteLine("press enter to quit application");
            Console.ReadLine();
        }
    }
}
