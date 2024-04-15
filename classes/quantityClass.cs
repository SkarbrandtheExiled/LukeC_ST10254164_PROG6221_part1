using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LukeC_ST10254164_PROG6221_part1.classes
{
    internal class quantityScaleClass
    {
        public string ingredient {  get; set; }
        public string unitOfMeasurment { get; set; }
        //----------------------------Quantity method----------------------------//
        //method to scale the quantities given by the user if the user wants to
        public void quantityScaling(double value)
        {
            Console.WriteLine("please enter a value to indicate how much the recipe must be scaled: ");
                
            }

        public double Value { get; set; }

        public void Scale(double factor)
        {
            Value *= factor;
        }
    }
}
