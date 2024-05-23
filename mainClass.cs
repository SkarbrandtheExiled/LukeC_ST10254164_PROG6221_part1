/// <summary>
/// Name: Luke Michael Carolus
/// StudentID: ST10254164
/// Group 1
/// Module: PROG6221
/// </summary>
/// 

///<summary>
/// References:
/// https://www.codeproject.com/Questions/1180559/How-do-I-add-at-an-array-with-user-input
///https://www.youtube.com/watch?v=1ZO-McTuxtw
/// GeeksforGeeks, 2022. C# | List Class. [Online] Available at: https://www.geeksforgeeks.org/c-sharp-list-class/[Accessed 12 April 2024].
/// GeeksforGeeks, 2023. C# Decision Making (if, if-else, if-else-if ladder, nested if, switch, nested switch). [Online] Available at: https://www.geeksforgeeks.org/c-sharp-decision-making-else-else-ladder-nested-switch-nested-switch/?ref=shm[Accessed 10 April 2024].
/// Troelsen, A. & Japikse, P., 2022. Pro C# 10 with. NET 6: Foundational Principles and Practices in Programming.. 11 ed. s.l.:Apress.
///</ summary >

using LukeC_ST10254164_PROG6221_part2.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//********************************************START OF FILE**********************************//
namespace LukeC_ST10254164_PROG6221_part2
{
    internal class mainClass
    {
        //main class that calls the requested class to start the application
        static void Main(string[] args)
        {
            //create an instance of the class that must be used (known as instantiation), then using that instance call the desired method in that class
            infoClass Users = new infoClass();
            Users.userInfo();
        }
    }
}
//*************************************END OF FILE***********************************************//