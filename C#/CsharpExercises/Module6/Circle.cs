using System;

namespace Module6
{
    public class Circle
    {
        private string name;
        private int radius;

        public Circle(string name, int radius)
        {
            this.name = name;
            this.radius = radius;
        }

        public Circle(string name)
        {
            if (name == "Ali")
            {
                this.name = name;
                radius = 5;
            }
            else
                this.name = name;
                radius = 10;
        }

        public Circle()
        {
            name = "Unknown";
            radius = 5;
        }

        public void SayHello()
        {

            Console.WriteLine($"I'm a circle with the name {name}!");
        }

        public void WriteArea()
        {
            double area = Math.Pow(radius, 2) * Math.PI;
            Console.WriteLine($"My name is {name}. I have a radius of {radius} and an area of {Math.Round(area,2)}.");
        }
    }
}