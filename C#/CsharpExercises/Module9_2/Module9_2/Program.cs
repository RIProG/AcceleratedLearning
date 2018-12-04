using System;
using System.IO;

namespace Module9_2
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine(@"I'm watching this folder C:\Temp");

            var x = new FileSystemWatcher();
            x.Path = @"C:\Temp";
            x.EnableRaisingEvents = true;
            x.Created += AFileIsCreated;
            x.Deleted += AFileIsDeleted;
            x.Changed += AFileIsChanged;
            x.Renamed += AFileIsRenamed;
            Console.ReadKey();


        }

        private static void AFileIsCreated(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"{e.Name} has been created!");
        }

        private static void AFileIsChanged(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"{e.Name} has been changed!");
            //if (e.Name == "onsdag.txt")
            //{
            //    (@"C:\Temp\statistics.txt", e);
            //}
        }

        private static void AFileIsDeleted(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"{e.Name} has been deleted!");
        }

        private static void AFileIsRenamed(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"{e.Name} has been renamed!");
        }
    }
}
