using System;
using System.Collections.Generic;
using System.Linq;

namespace Module3
{
    class Program
    {
        static void Main(string[] args)
        {
            ConditionalOperator();

            void ConditionalOperator()
            {
                int number;

                Console.Write("Enter a number: ");
                number = Convert.ToInt32(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.Green;
                string message = (number < 20) ? "Lower than 20" : (number == 20) ? "Equal to 20" : "Higher than 20";
                Console.WriteLine();
                Console.WriteLine(message);

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();

            }
            
            //GuessingGame();

            void GuessingGame()
            {
                Random rnd = new Random();
                int correctnumber = rnd.Next(1, 100);
                int guess = 0;

                for (int numberofguesses = 0; numberofguesses < 6; numberofguesses++)
                {
                    if (guess != correctnumber)
                    {
                        Console.Write("Guess a number between 1-100: ");
                        guess = Convert.ToInt32(Console.ReadLine());
                        if (guess < correctnumber)
                        {
                            Console.WriteLine("Your guess is too low.");
                        }
                        else if (guess > correctnumber)
                        {
                            Console.WriteLine("Your guess is too high.");
                        }
                    }
                    else if (guess == correctnumber)
                    {
                        Console.WriteLine("Your guess is correct! The right number is " + correctnumber + "!");
                        Console.WriteLine("You guessed " + (numberofguesses) + " times.");
                        break;

                    }
                }
                if (guess != correctnumber)
                    Console.WriteLine("You failed to guess the correct number. The correct number was " + correctnumber);


            }

            //IfStatement2();

            void IfStatement2()
            {
                int comparingnumber;
                int inputnumber;
                Console.Write("Enter a number: ");
                inputnumber = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter a number to compare your number to: ");
                comparingnumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;

                if (inputnumber < comparingnumber)
                {
                    Console.WriteLine("Lower than " + comparingnumber);
                }

                else if (inputnumber > comparingnumber)
                {
                    Console.WriteLine("Higher than " + comparingnumber);
                }

                else if (inputnumber == comparingnumber)
                {
                    Console.WriteLine("Equal to " + comparingnumber);
                }


                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;


            }

            //ForeachStatementBreak();

            void ForeachStatementBreak()
            {
                string input;
                string surname = "Andersson";

                Console.Write("Enter names in a list (like Maria,Peter,Lisa): ");
                input = Console.ReadLine();
                string[] names = input.Split(',');
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Green;


                foreach (string name in names)
                {
                    if (name == "AllowZelda")

                        foreach (string name2 in names)
                        {
                            if (name2 != "AllowZelda")
                            {
                                Console.WriteLine(name2 + " " + surname);
                            }

                        }

                }

                if (!names.Contains("AllowZelda"))
                {
                    foreach (string name in names)
                    {
                        if (name != "Zelda")
                            Console.WriteLine(name + " " + surname);
                        else
                            break;
                    }
                }

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;

            }

            //ForeachStatement();

            void ForeachStatement()
            {
                string input;
                string surname;
                int i = 0;

                Console.Write("Enter names in a list (like Maria,Peter,Lisa): ");
                input = Console.ReadLine();
                string[] names = input.Split(',');
                Console.Write("Vilket efternamn har personerna? ");
                surname = Console.ReadLine();
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Green;
                foreach (string name in names)
                {
                    Console.WriteLine("[" + i + "] " + name + " " + surname);
                    i++;
                }
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;

            }

            //ForStatement();

            void ForStatement()
            {
                string name;
                int repeat;
                int columns;
                int rows;

                Console.Write("Number of columns: ");
                columns = Convert.ToInt32(Console.ReadLine());

                Console.Write("Number of rows: ");
                rows = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter your name: ");
                name = Console.ReadLine();

                //Console.Write("Times to repeat: ");
                //repeat = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine();


                Console.ForegroundColor = ConsoleColor.Green;
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        Console.Write(name);

                    }
                    Console.WriteLine();
                }

                //for (int i = 0; i < repeat; i++)
                //{
                //    Console.WriteLine("Your name is " + name);
                //}

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
            }

            //WhileStatement();

            void WhileStatement()
            {
                string name;
                int repeat;
                int i = 0;

                Console.Write("Write your name: ");
                name = Console.ReadLine();
                while (name.Length <= 1)
                {
                    Console.WriteLine("Please submit a longer name.");
                    Console.Write("Write your name: ");
                    name = Console.ReadLine();
                }

                while (name.Length > 10)
                {
                    Console.WriteLine("Please submit a shorter name.");
                    Console.Write("Write your name: ");
                    name = Console.ReadLine();
                }

                Console.Write("Times to repeat: ");
                repeat = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                while (repeat < 2)
                {
                    Console.WriteLine("Please choose a larger amount of times to loop.");
                    Console.Write("Times to repeat: ");
                    repeat = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                }

                while (repeat > 10)
                {
                    Console.WriteLine("Please choose a smaller number of times to loop.");
                    Console.Write("Times to repeat: ");
                    repeat = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                }

                Console.ForegroundColor = ConsoleColor.Green;
                while (i < repeat)
                {
                    Console.WriteLine("Your name is " + name);
                    i++;
                }

                //while (true)
                //{
                //    if (i < repeat)
                //    {
                //        Console.WriteLine("Your name is " + name);
                //        i++;
                //    }
                //    else
                //        break;
                //}

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
            }

            //IfStatement();
            void IfStatement()
            {
                int normalsleep;
                int bed;
                int wakeup;
                int amountofsleep;

                Console.Write("How many hours do you normally sleep? ");
                normalsleep = Convert.ToInt32(Console.ReadLine());
                Console.Write("When did you got to bed yesterday? ");
                bed = Convert.ToInt32(Console.ReadLine());
                Console.Write("When did you wake up? ");
                wakeup = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                if (bed <= wakeup)

                    amountofsleep = wakeup - bed;

                else
                    amountofsleep = 24 - bed + wakeup;

                Console.ForegroundColor = ConsoleColor.Green;
                if (amountofsleep < normalsleep - 1)
                {
                    Console.WriteLine("You've only slept " + amountofsleep + " hours. Go back to bed!");
                }
                else if (amountofsleep > normalsleep + 1)
                {
                    Console.WriteLine("You've slept " + amountofsleep + " hours. That's alot.");
                }
                else
                    Console.WriteLine("You have slept well.");

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();

            }
        }
    }
}
