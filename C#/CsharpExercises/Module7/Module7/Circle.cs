using System;
using System.Collections.Generic;
using System.Text;

namespace Module7
{
    class Circle : Shape
    {
        public double Radius { get; set; }
        public double Area { get; set; }

        public override string ToString()
        {
            return $"I'm a circle with radius={Radius}";
        }

        double GetCircleArea(double inputRadius)
        {
            double area = Math.Pow(inputRadius, 2) * Math.PI;
            return area;
        }

    }

}
