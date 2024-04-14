

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
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
        public string userName {  get; set; } //getter and setter for the user's name 
        //------------------------user details methods------------------------//
        public void userInfo()
        {
            //simple console output to ask for the user's name
            Console.WriteLine("please enter your name: ");

            //an input stream that can be read from
          string userName = Console.ReadLine();

            //a simple greeting to start the application (should be used throughout app)
            Console.WriteLine($"welcome {userName}");

            ingredientClass recipe = new ingredientClass();
            recipe.ingredients();
        }
    }
}
//*************************************END OF FILE***********************************************//