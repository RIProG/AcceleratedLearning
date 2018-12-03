using System;
using System.Collections.Generic;
using System.Linq;

namespace Module7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            string input;
            int circleNumber = 0;
            int rectangleNumber = 0;
            int triangleNumber = 0;

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Select (T)riangle, (R)ectangle, (C)ircle or (D)one: ");
                Console.ForegroundColor = ConsoleColor.Green;
                input = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;

                if (input == "D")
                {
                    Console.WriteLine();
                    break;
                }

                else if (input == "T")
                {
                    Console.Write("Enter base of triangle: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    bool triangleBaseOK = Double.TryParse(Console.ReadLine(), out double triangleBase);
                    //triangle.BaseLength = Convert.ToDouble(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Enter height of triangle: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    bool triangleHeightOK = Double.TryParse(Console.ReadLine(), out double triangleHeight);
                    //triangle.Height = Convert.ToDouble(Console.ReadLine());
                    if (triangleBaseOK == true && triangleHeightOK == true)
                    {
                        shapes.Add(new Triangle() { BaseLength = triangleBase, Height = triangleHeight });
                        triangleNumber++;
                    }
                }

                else if (input == "R")
                {
                    Console.Write("Enter length of rectangle: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    bool rectangleBaseOK = Double.TryParse(Console.ReadLine(), out double rectangleLength);
                    //rectangle.Length = Convert.ToDouble(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Enter height of rectangle: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    bool rectangleHeightOK = Double.TryParse(Console.ReadLine(), out double rectangleHeight);
                    //rectangle.Height = Convert.ToDouble(Console.ReadLine());
                    if (rectangleBaseOK == true && rectangleHeightOK == true)
                    {
                        shapes.Add(new Rectangle() { Length = rectangleLength, Height = rectangleHeight });
                        rectangleNumber++;
                    }
                }

                else if (input == "C")
                {
                    Console.Write("Enter radius of circle: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    bool radiusOK = Double.TryParse(Console.ReadLine(), out double circleRadius);
                    //circle.Radius = Convert.ToDouble(Console.ReadLine());
                    if (radiusOK == true)
                    {
                        shapes.Add(new Circle() { Radius = circleRadius });
                        circleNumber++;
                    }
                }
            }

            Console.ForegroundColor = ConsoleColor.White;
            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape.ToString());
            }
            Console.WriteLine();


            //var count = shapes.Count(shape => shape == Circle);


            Console.WriteLine($"You selected {circleNumber} circles, {rectangleNumber} rectangles and {triangleNumber} triangles." );
        }
    }
}
