using System;

namespace OneToOne
{
    class Program
    {
        static void Main(string[] args)
        {
            string language = AskForLanguage();
            bool upperCase = AskForUppercaseOrNot(language);
            int a = AskForNumber(1, "english", upperCase);
            int b = AskForNumber(2, "swedish", upperCase);
            int sum = a + b;
            DisplaySum(sum, "english", upperCase);

            int AskForNumber(int orderNumber, string languageInput, bool upperLetters)
            {
                int number = 0;
                string tal = "";
                string askForNumbersSwedish = $"Skriv tal {orderNumber}: ";
                string askForNumbersEnglish = $"Enter number {orderNumber}: ";
                do
                {
                    if (language == "swedish")
                    {
                        if (upperLetters == true)
                        {
                            Console.Write(askForNumbersSwedish.ToUpper());
                        }
                        else
                            Console.Write(askForNumbersSwedish);
                    }
                    else if (language == "english")
                    {
                        if (upperLetters == true)
                        {
                            Console.Write(askForNumbersEnglish.ToUpper());
                        }
                        else
                            Console.Write(askForNumbersEnglish);
                    }
                    tal = Console.ReadLine();
                    try
                    {
                        number = int.Parse(tal);
                    }
                    catch (Exception)
                    {
                        if (language == "swedish")
                        {

                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Du måste ange ett heltal.");
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                        else if (language == "english")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("You have to enter an integer.");
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                    }
                } while (number == 0);

                return number;

            }

            void DisplaySum(int input, string languageInput, bool upperLetters)
            {
                string sumSwedish = $"Summan av talen är {input}";
                string sumEnglish = $"The sum of the integers are {input}";
                if (language == "swedish")
                {
                    if (upperLetters == true)
                    {
                        Console.WriteLine(sumSwedish.ToUpper());
                    }
                    else
                        Console.WriteLine(sumSwedish);
                }
                else if (language == "english")
                {
                    if (upperLetters == true)
                    {
                        Console.WriteLine(sumEnglish.ToUpper());
                    }
                    else
                        Console.WriteLine(sumEnglish);
                }
            }

        }

        private static bool AskForUppercaseOrNot(string language)
        {
            bool upperOrNot;
            string input;
            do
            {
                if (language == "swedish")
                {
                    Console.Write("Stora bokstäver? (j/n): ");
                    input = Console.ReadLine();
                    if (input.ToLower() == "j")
                    {
                        upperOrNot = true;
                        break;
                    }
                    else
                    {
                        upperOrNot = false;
                        break;
                    }
                }
                else
                {
                    Console.Write("Uppercase letters? (y/n): ");
                    input = Console.ReadLine();
                    if (input.ToLower() == "y")
                    {
                        upperOrNot = true;
                        break;
                    }
                    else
                    {
                        upperOrNot = false;
                        break;
                    }
                }
            } while (upperOrNot != true || upperOrNot != false);

            return upperOrNot;
        }

        private static string AskForLanguage()
        {
            string language = "";

            do
            {
                Console.Write("(S)wedish or (E)nglish? ");
                language = Console.ReadLine();

                if (language.ToLower() == "s")
                {
                    language = "swedish";
                    break;
                }
                else if (language.ToLower() == "e")
                {
                    language = "english";
                    break;
                }

            } while (language != "english" || language != "swedish");

            return language;
        }
    }
}
