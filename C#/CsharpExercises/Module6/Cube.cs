namespace Module6
{
    public class Cube
    {
        double height, width, depth;
        string color, name;

        public Cube(string name, string color, double height, double width, double depth)
        {
            this.name = name;
            this.color = color;
            this.height = height;
            this.width = width;
            this.depth = depth;
        }

        public void WriteVolume()
        {
            System.Console.WriteLine($"The volume of the cube is {height*width*depth}");
        }

        public double CalculateVolume()
        {
            double volume = height * width * depth;
            return volume;
        }

        public double CalculateArea()
        {
            double area = (2 * height * width) + (2 * width * depth) + (2 * depth * height);
            return area;
        }

        public string ChangeColor()
        {
            color = "green";
            return color;
        }

        public string CubicOrRectangular()
        {
            if (height == width && height == depth)
            {
                return "Cubic";
            }
            else
                return "Rectangular";
        }

        public string NameOfCube()
        {

            return name;
        }

    }
}