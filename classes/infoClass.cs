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
        //------------------------user details------------------------//
        public static void userInfo()
        {
            //simple console output to ask for the user's name
            Console.WriteLine("please enter your name: ");

            //an input stream that can be read from
          string userName = Console.ReadLine();

            //a simple greeting to start the application (should be used throughout app)
            Console.WriteLine("welcome " + userName);
        }
        //---------------------------Ingrediants method----------------------------//
        public static void ingredients() 
        { 
            //must ask for the name / type of the ingrediant
            Console.WriteLine("please enter the name of the ingrediant: ");
            string ingrediant = Console.ReadLine(); 
        }
        //----------------------------Quantity method----------------------------//
        public static void quantity() 
        { 
            //must ask for the amount of the ingrediant is needed
        Console.WriteLine("please enter the volume of the ingrediants: ");
           double volume = Console.Read;
        }
    }
}
//*************************************END OF FILE***********************************************//