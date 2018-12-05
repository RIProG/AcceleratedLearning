using System;
using System.Collections.Generic;
using System.Linq;

namespace Module11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> tal = new List<double> { 4, 6, 10 };
            double sum = 0;
            double average;
            int counter = 0;

            foreach (double number in tal)
            {
                Console.WriteLine(number);
                sum += number;
                counter++;
            }
            //Utan Linq
            average = (sum / counter);
            Console.WriteLine($"Average: {average} ");
            Console.WriteLine();
            Console.WriteLine(tal.Count);
            Console.WriteLine();
            NumberHigherThanFive(tal);
            Console.WriteLine();

            //Med Linq
            Console.WriteLine(tal.Average()); //Medeltalet av listan
            Console.WriteLine(tal.Sum()); //Summan av listan
            Console.WriteLine(tal.Count()); //Antal element i listan
            Console.WriteLine();
            //Alternativ 1 med metod (OBS FindAll() var ej med Linq)
            List<double> talgreaterthanfive = tal.FindAll(GreaterThanFive);
            Console.WriteLine("These numbers are larger than five: ");
            foreach (var item in talgreaterthanfive)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("These numbers are larger than five: ");
            //Alternativ 2 utan metod
            var linqList5 = from x in tal where x > 5 select x;
            foreach (var number in linqList5)
            {
                Console.WriteLine(number);
            }

            //Stjärnlista utan Linq
            Console.WriteLine();
            List<string> starifiedList = StarifyList(tal);
            foreach (var item in starifiedList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //Stjärnlista med Linq (se även Join-funktionen (funkar typ motsatt mot Split, du kan lägga in ett tecken för varje listvärde)
            List<string> starslistLinq = tal.Select(x => "*" + x + "*").ToList();
            foreach (var item in starslistLinq)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

        }
            private static List<string> StarifyList(List<double> tal)
            {
            List<string> starifiedList = new List<string>();
            foreach (var number in tal)
            {
                string convertedValue =$"*{Convert.ToString(number)}*";
                starifiedList.Add(convertedValue);
            }
            return starifiedList;
            }

        //Alla tal högre än fem utan Linq
        private static void NumberHigherThanFive(List<double> tal)
        {
            Console.WriteLine("These numbers are larger than five:");
            foreach (double number in tal)
            {
                if (number > 5)
                {
                    Console.WriteLine(number);
                }
            }
        }

        //Alla tal högre än fem med Linq


        public static bool GreaterThanFive(double value)
        {
            if (value > 5)
                return true;
            else
                return false;
        }


    }
}
