using System;
using System.IO;

namespace Module8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool loop = true;
            string filename = "";

            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Enter a file name: ");
                Console.ForegroundColor = ConsoleColor.Green;
                try
                {
                    filename = Console.ReadLine();
                    var sw = File.CreateText(filename);
                    sw.Close();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"The file {filename} is now created");
                    loop = false;
                }
                catch (UnauthorizedAccessException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You're not authorzied to create this file");
                }
                catch (DirectoryNotFoundException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Input output exception");
                }
                catch (ArgumentException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("The file name is not valid");
                }
                catch (PathTooLongException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("The file name is too long!");
                }
                catch (SystemException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("The file name is not valid");
                }
            } while (loop == true);

            if (loop == false)
            {
                Console.Write("Enter some text to the file : ");
                string writeText = Console.ReadLine();
                File.WriteAllText(filename, $"{writeText}");
            }

        }
    }
}
