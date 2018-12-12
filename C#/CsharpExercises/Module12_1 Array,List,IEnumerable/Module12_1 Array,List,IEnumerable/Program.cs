using System;
using System.Collections.Generic;

namespace Module12_1_Array_List_IEnumerable
{
     class Program
    {
        static void Main(string[] args)
        {
            string[] rockstarsArray = new string[] { "Jim Morrison", "Ozzy Osborne", "David Bowie", "Freddie Mercury" };
            List<string> rockstarsList = new List<string> { "Jim Morrison", "Ozzy Osborne", "David Bowie", "Freddie Mercury" };
            DisplayArrayOfRockStars(rockstarsArray);
            DisplayListOfRockStars(rockstarsList);
            DisplayListOrArrayOfRockstars(rockstarsArray);
            DisplayListOrArrayOfRockstars(rockstarsList);
        }
        
        static void DisplayArrayOfRockStars(string[] rockstars)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("My rockstars: (array)");
            Console.ForegroundColor = ConsoleColor.Gray;
            foreach (string rockstar in rockstars)
            {
                Console.WriteLine(rockstar);
            }
            Console.WriteLine();
        }

       static void DisplayListOfRockStars(List<string> rockstars)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("My rockstars: (string)");
            Console.ForegroundColor = ConsoleColor.Gray;
            foreach (string rockstar in rockstars)
            {
                Console.WriteLine(rockstar);
            }
            Console.WriteLine();
        }

        static void DisplayListOrArrayOfRockstars(IEnumerable<string> rockstars)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("My rockstars: (ienumerable)");
            Console.ForegroundColor = ConsoleColor.Gray;
            foreach (string rockstar in rockstars)
            {
                Console.WriteLine(rockstar);
            }
            Console.WriteLine();
        }
    }
}
