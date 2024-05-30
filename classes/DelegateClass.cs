﻿using LukeC_ST10254164_PROG6221_part2.classes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LukeC_ST10254164_PROG6221_part1.classes
{
    internal class DelegateClass
    {
        ingredientClass calory = new ingredientClass();

        public delegate void CalorieDisplayDelegate(double totalCalories, double calorieLimit);
        public void totalCalories(CalorieDisplayDelegate displayCalories)
        {
            double totalCalories = calory.calorieCount.Sum();

            double calorieLimit = 300;

            displayCalories(totalCalories, calorieLimit);
        }
    }
}
