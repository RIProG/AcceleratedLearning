using System;

namespace Module8
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal input = 1;
            Console.WriteLine("The chocolate contains 24 pieces. ");
            Console.Write("How many want to share? ");
            Console.ForegroundColor = ConsoleColor.Green;

            try
            {
                input = Convert.ToDecimal(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Everyone get {24 / input} pieces");
                Console.WriteLine();

            }

            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong format on input");
                Console.WriteLine();
            }

            catch (Exception)
            {
                if (input == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Zero people can't divide a chocolate");
                    Console.WriteLine();
                }

                if (input < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You can't be less than a person. That's just illogical'");
                    Console.WriteLine();
                }

            }


            Console.ForegroundColor = ConsoleColor.White;


        }
    }
}
