using System;
using System.Collections.Generic;

namespace DemoWithOneProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            FruitContext context = new FruitContext();

            //context.Database.EnsureDeleted();
            //context.Database.EnsureCreated();


            context.Fruits.Add(new Fruit{Name = "Äpple", Color = "Rött"});
            
            context.SaveChanges();

            foreach (Fruit item in context.Fruits)
            {
                Console.WriteLine(item.Id + "  " +  item.Name + " " + item.Color);
            }

        }
    }
}
