using System;
using System.Collections.Generic;
using System.Text;

namespace Module7
{
    class Triangle : Shape
    {
        public double BaseLength { get; set; } 
        public double Height { get; set; }
        public double Area { get; set; }

        public override string ToString()
        {
            return $"I'm a triangle with baselength={BaseLength} and height={Height}";
        }

        double GetTriangleArea(double BaseLength, double Height)
        {
            double Area = (BaseLength * Height) / 2;
            return Area;
        }
    }
}
