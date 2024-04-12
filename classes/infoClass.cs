using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
//********************************************START OF FILE**********************************//
namespace LukeC_ST10254164_PROG6221_part1.classes
{
    /// <summary>
/// Name: Luke Michael Carolus
/// StudentID: ST10254164
/// Module: PROG6221
/// </summary>
/// 
    internal class infoClass
    {
        //------------------------user details methods------------------------//
        public static void userInfo()
        {
            //simple console output to ask for the user's name
            Console.WriteLine("please enter your name: ");

            //an input stream that can be read from
          string userName = Console.ReadLine();

            //a simple greeting to start the application (should be used throughout app)
            Console.WriteLine("welcome " + userName);

            //calls the next method for continouity
            infoClass.ingredients();

        }
        //---------------------------Ingrediants method----------------------------//
        public static void ingredients() 
        { 
            //must ask for the number of ingrediants for the recipe
            Console.WriteLine("please enter the number of ingrediants for the recipe: ");
            string numOfIngrediant = Console.ReadLine();

            //ask and store the name of the ingrediant in an array
            Console.WriteLine("please enter the name of ingrediant 1: "); //ingrediant 1/x
           string[] ingrediantName = Console.ReadLine();

            //
            Console.WriteLine("number of ingrediants; " + numOfIngrediant);
            infoClass.quantity();
        }
        //----------------------------Quantity method----------------------------//
        public static void quantity() 
        { 
            //must ask for the amount of the ingrediant is needed
        Console.WriteLine("please enter the quantity of the ingrediant: ");
           string ingrediant = Console.ReadLine();
            Console.WriteLine("quanity =: " + ingrediant);

            Console.WriteLine("please enter the unit of measurement you want to use: ");
            string unitOfMeasurment = Console.ReadLine();
            Console.WriteLine("Confirmed! Your unit of measurment is: " + unitOfMeasurment);
            //wait for enter key before closing app
            Console.WriteLine("press enter to quit application");
            Console.ReadLine();
        }
    }
}
//*************************************END OF FILE***********************************************//