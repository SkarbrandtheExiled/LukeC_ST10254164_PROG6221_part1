using LukeC_ST10254164_PROG6221_part1.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//********************************************START OF FILE**********************************//
namespace LukeC_ST10254164_PROG6221_part1
{
    internal class mainClass
    {/// <summary>
/// Name: Luke Michael Carolus
/// StudentID: ST10254164
/// Module: PROG6221
/// </summary>
/// 

        //main class that calls the requested class to start the application
        static void Main(string[] args)
        {
            //create an instance of the class that must be used (known as instantiation), then using that instance call the desired method in that class
            infoClass Users = new infoClass();
            Users.userInfo();
        }
    }
}
//references:

//*************************************END OF FILE***********************************************//