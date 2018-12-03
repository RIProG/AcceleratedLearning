using System;
using System.Linq;

namespace Module6
{
    public class Program
    {

        public static void Main()
        {

            Address home = new Address
            {
                Street = "Lång gatan",
                StreetNumber = "13B",
                City = "Sundsvall",
                ZipCode = "111 22"
            };

            
            Console.WriteLine($"ZipCode\t\t{home.ZipCode}");
            Console.WriteLine();
            Console.WriteLine($"ZipCode\t\t{home.ZipCode}");
            Console.WriteLine();
            Console.WriteLine($"ZipCode\t\t{home.ZipCode}");
            Console.WriteLine();

            //Console.WriteLine($"Street\t\t{home.Street}");
            //Console.WriteLine($"StreetNumber\t{home.StreetNumber}");
            //Console.WriteLine($"City\t\t{home.City}");
            //Console.WriteLine($"ZipCode\t\t{home.ZipCode}");
            //Console.WriteLine($"FullStreet\t{home.FullStreet}");

            //string input;

            //Person lisa = new Person
            //{
            //    firstName = "Lisa",
            //    lastName = "Andersson",
            //    birthday = new DateTime(1986, 7, 27),
            //    Gender = Gender.Female,
            //    FavoriteSport = Sport.Tennis,

            //};

            //Console.WriteLine($"{lisa.firstName} is {lisa.Gender} ");
            //Console.WriteLine($"{lisa.firstName} like to play {lisa.FavoriteSport}");

            //if (lisa.FavoriteSport != Sport.Rugby)
            //    Console.WriteLine("Lisa don't like to play rugby");
            //else
            //    Console.WriteLine("Lisa like to play rugby");

            //Console.WriteLine();

            //Console.WriteLine("Here is a list of all Sport enums: ");
            //foreach (string sportName in Enum.GetNames(typeof(Sport)))
            //{
            //    Console.WriteLine("* " + sportName);
            //}
            //Console.WriteLine();

            //Console.Write("Enter a sport: ");
            //Console.ForegroundColor = ConsoleColor.Green;
            //input = Console.ReadLine();
            //Console.ForegroundColor = ConsoleColor.White;

            //Sport y = (Sport)Enum.Parse(typeof(Sport), input);
            //Console.WriteLine($"Oh, I know {input}!" );

            //Console.WriteLine();

            //Cube mycube = new Cube("Klas", "red", 2, 3, 4);
            //Cube mysupercube = new Cube("Stina", "blue",100, 100, 100);

            //double volume = mycube.CalculateVolume();
            //Console.WriteLine($"Volume: {volume}");
            //double supervolume = mysupercube.CalculateVolume();
            //Console.WriteLine($"Volume: {supervolume}");

            //double area = mycube.CalculateArea();
            //Console.WriteLine($"Area: {area}");
            //double superarea = mysupercube.CalculateArea();
            //Console.WriteLine($"Area: {superarea}");

            //string cubecolor = mycube.ChangeColor();
            //Console.WriteLine($"Color: {cubecolor}");
            //string supercubecolor = mysupercube.ChangeColor();
            //Console.WriteLine($"Color: {supercubecolor}");

            //Console.WriteLine(mycube.CubicOrRectangular());
            //Console.WriteLine(mysupercube.CubicOrRectangular());

            //Console.WriteLine(mycube.NameOfCube());
            //Console.WriteLine(mysupercube.NameOfCube());

            //mycube.WriteVolume();
            //mysupercube.WriteVolume();
            //Console.WriteLine();


            //Circle bob = new Circle("Bob", 8);
            //Circle lisa = new Circle("Lisa", 30);
            //Circle ali = new Circle("Ali");
            //Circle unknown = new Circle();

            //bob.SayHello();
            //lisa.SayHello();
            //ali.SayHello();
            //unknown.SayHello();

            //Console.WriteLine();

            //bob.WriteArea();
            //lisa.WriteArea();
            //ali.WriteArea();
            //unknown.WriteArea();


            //var c1 = new Car("röd", 1000);
            //var c2 = new Car("blå", 1300);
            //var c3 = new Car("grön", 1700);

            //c2.Color = "yellow";
            //c3.Weight = 500;
            //Console.WriteLine(c2.Color + c3.Weight);

            //Console.WriteLine($"Färgen på bilen 'c1' är {c1.GetColor()} och vikten är {c1.GetWeight()}");
            //Console.WriteLine($"Färgen på bilen 'c2' är {c2.GetColor()} och vikten är {c2.GetWeight()}");
            //Console.WriteLine($"Färgen på bilen 'c3' är {c3.GetColor()} och vikten är {c3.GetWeight()}");

            //c1.SetColor("röd");
            //c2.SetColor("blå");
            //c3.SetColor("grön");

            //c1.SetWeight(1300);
            //c2.SetWeight(1500);
            //c3.SetWeight(1700);
            //    }
            //}
            //public class Car
            //{
            //    public string Color { get; set; }
            //    public int Weight { get; set; }

            //    public Car()
            //    {
            //        Color = "lila";
            //        Weight = 999;
            //    }

            //    public Car(string color, int weight)
            //    {
            //        Color = color;
            //        Weight = weight;
            //    }

            //public void SetColor(string x)
            //{
            //    color = x;
            //}

            //public string GetColor()
            //{
            //    return color;
            //}

            //public void SetWeight(int x)
            //{
            //    weight = x;
            //}

            //public int GetWeight()
            //{
            //    return weight;
            //}

            //public Car(string c, int w)
            //{
            //    color = c;
            //    weight = w;
            //}

            //public Car()
            //{
            //}
        }
    }


}


