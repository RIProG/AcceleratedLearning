using System;
using System.Collections.Generic;

namespace DemoWithOneProject2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ClearAndInitDatabase();
            //DisplayAllFruits();
            //DisplayJustSkenfrukter();
            DisplayAllBaskets();

        }

        private static void DisplayAllBaskets()
        {
            var dataAccess = new DataAccess();
            IEnumerable<Basket> baskets = dataAccess.GetAllBaskets();

            foreach (var b in baskets)
            {
                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine("VARUKORG: " + b.Name);
                Console.WriteLine();

                IEnumerable<Fruit> fruits = dataAccess.GetAllFruitsInBasktes(b.Id);

                foreach (var f in fruits)
                {
                    Console.WriteLine(f.Name + " " + f.Category + " " + f.Price);
                }

            }
        }

        private static void ClearAndInitDatabase()
        {
            var dataAccess = new DataAccess();
            dataAccess.AddCategoriesAndFruits();
            //dataAccess.ClearDatabase();

        }

        public static void DisplayAllFruits()
        {
            var dataAccess = new DataAccess();

            foreach (Fruit x in dataAccess.GetAllFruits())
            {
                Console.WriteLine(x.Id + " " + x.Name + " " + x.Category.Name + " " + x.Price);
            }
        }

        private static void DisplayJustSkenfrukter()
        {
            var dataAccess = new DataAccess();
            List<Fruit> fruits = dataAccess.GetFruitsInCategory("Skenfrukt");
            Console.WriteLine();
            Console.WriteLine("SKENFRUKTER");
            Console.WriteLine();
            foreach (var fruit in fruits)
            {
                Console.WriteLine(fruit.Name);
            }
        }
    }
}
