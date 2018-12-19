using System;
using System.Collections.Generic;

namespace Module2
{
    class Program
    {

        static void Main(string[] args)
        {
            char A = 'P';
            char B = Convert.ToChar(76);
            A++;
            B++;
            Console.WriteLine(A + "  " + B);

            //WorkingWithStrings();
            //WorkingWithTypes();
            //StringCreation();

            void StringCreation()
            {
                var fruktlista = new List<string>();
                string frukt1;
                string frukt2;
                string frukt3;
                string fulltext;
                int j;

                Console.Write("How man fruits do you want to add? ");
                j = Convert.ToInt32(Console.ReadLine());

                //for (int i = 0; i < j; i++)
                //{
                //    Console.Write($"Enter fruit { i + 1}: ");
                //    fruktlista.Add(Console.ReadLine());
                //}


                Console.Write("Enter fruit 1: ");
                frukt1 = Console.ReadLine();
                Console.Write("Enter fruit 2: ");
                frukt2 = Console.ReadLine();
                Console.Write("Enter fruit 3: ");
                frukt3 = Console.ReadLine();
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You entered three fruits: " + frukt1 + " " + frukt2 + " " + frukt3);

                Console.WriteLine(fulltext = string.Format("You entered three fruits: {0} {1} {2} ", frukt1, frukt2, frukt3));

                var myString = $"You entered three fruits: {frukt1} {frukt2} {frukt3}";
                Console.WriteLine(myString);

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
            }

            void WorkingWithTypes()
            {
                string name;
                int age;
                char letter;

                Console.Write("What is your name? ");
                name = Console.ReadLine();
                Console.Write("How old are you? ");
                try
                {
                    age = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {

                    age = 32;
                }

                Console.Write("What is your favorite letter? ");
                letter = Convert.ToChar(Console.ReadLine());

                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Your name is {name}");
                Console.WriteLine($"You have " + (65-age) + " years until retirement" );
                if (Char.IsDigit(letter))
                {
                    Console.WriteLine("You like numbers");
                }
                else
                {
                    Console.WriteLine("You don't like numbers");
                }

                if (name == "Rikard" && age == 32)
                {
                    Console.Beep(3000, 500);
                }

            }

            void WorkingWithStrings()
            {
                string name;
                string age;
                string letter;
                string animal;
                string food;
                string status = "0";

                Console.Write("What is your name? ");
                name = Console.ReadLine();
                Console.Write("How old are you? ");
                age = Console.ReadLine();
                Console.Write("What is your favorite letter? ");
                letter = Console.ReadLine();
                Console.Write("What is your favorite animal? ");
                animal = Console.ReadLine();
                Console.Write("What is your favorite food? ");
                food = Console.ReadLine();

                Console.WriteLine();
                Console.WriteLine("Thank you!");
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"Your name is: ");

                foreach (char letter2 in name)
                {
                    if (status == "0")
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write(name[0]);
                        status = "1";
                    }
                    else if (status == "1")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(name[1]);
                        status = "2";
                    }
                    else if (status == "2")
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(name[2]);
                        status = "3";
                    }
                    else if (status == "3")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(name[3]);
                        status = "4";
                    }
                    else if (status == "4")
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(name[4]);
                        status = "5";
                    }
                    else if (status == "5")
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write(name[5]);
                        status = "6";
                    }
                }

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                status = "0";
                Console.Write($"Your age is: ");

                foreach (char letter3 in age)
                {
                    if (status == "0")
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write(age[0]);
                        status = "1";
                    }
                    else if (status == "1")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(age[1]);
                        status = "2";
                    }
                    else if (status == "2")
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(age[2]);
                        status = "3";
                    }


                }

                status = "0";
                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine();
                Console.WriteLine($"Your favorite letter is: {letter}");
                Console.WriteLine($"Your favorite animal is: {animal}");
                Console.WriteLine($"Your favorite food is: {food}");
                Console.WriteLine();

            }
        }
    }
}
