using LukeC_ST10254164_PROG6221_part2.classes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LukeC_ST10254164_PROG6221_part1.classes
{
    internal class DelegateClass
    {

        public delegate void CalorieDisplayDelegate(double totalCalories, double calorieLimit);
        public void totalCalories(CalorieDisplayDelegate displayCalorieHandler)
        {
            double totalCalories = calorieCount.Sum();
            double calorieLimit = 300;

            displayCalorieHandler(totalCalories, calorieLimit);
        }
    }
}
