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
        public void quantity(double value) //method to scale the quantities given by the user if the user wants to 
        { 
                Value = value;
            }

        public double Value { get; set; }

        public void Scale(double factor)
        {
            Value *= factor;
        }
    }
}
