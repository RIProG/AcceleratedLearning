using System;
using System.Collections.Generic;
using System.Text;

namespace Module7
{
    class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Height { get; set; }
        public double Area { get; set; }

        public override string ToString()
        {
            return $"I'm a rectangle with length={Length} and height={Height}";
        }

        double GetRectangleArea(double inputLength, double inputHeight)
        {
            double Area = inputHeight * inputLength;
            return Area;
        }

    }
}
