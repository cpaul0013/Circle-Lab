using System;
using System.Collections.Generic;
using System.Text;

namespace Circle_Lab
{
    class Circle
    {
        private double Radius;
        public double Area;
        public double Circum;

        public Circle(double radius)
        {
            Radius = radius;

        }

        public double CalculateCircumference()
        {
            Circum = Radius * 2 * Math.PI;
            return Circum;

           
        }

        public string CalculateFormattedCircumference()
        {
            return FormatNumber(Circum);


        }

        public double CalculateArea()
        {
            Area = Radius * Radius * Math.PI;
            return Area;


        }

        public string CalculateFormattedArea()
        {

            return FormatNumber(Area);
            

        }

        private string FormatNumber(double x)
        {
            return x.ToString("0.00");
            

        }




    }
}
