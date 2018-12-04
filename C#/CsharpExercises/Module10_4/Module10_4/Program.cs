using System;
using System.Collections.Generic;

namespace Module10_4
{
    class Program
    {

        static void Main(string[] args)
        {
            List<string> nameList = new List<string>();
            int nameCounter = 0;
            bool loop = true;
            bool validName;

            while (loop == true)
            {
                string inputName = AskForName();
                (validName, loop) = ValidateName(inputName);
                if (validName == true)
                {
                    nameCounter++;
                    nameList.Add(inputName);
                }

            }
            nameList.Sort();
            Console.ForegroundColor = ConsoleColor.White;

            if (nameCounter > 2)
            {
                nameList.RemoveAt(nameCounter-1);
                nameList.RemoveAt(0);
            }

            foreach (string name in nameList)
            {
                Console.WriteLine(name);
            }
        }


        private static string AskForName()
        {
            Console.Write("Enter a name: ");
            Console.ForegroundColor = ConsoleColor.Green;
            string inputName = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            return inputName;
        }
        private static (bool, bool) ValidateName(string inputName)
        {
            bool validName;
            bool loop;
            if (inputName.ToLower() == "quit")
            {
                validName = false;
                loop = false;
                return (validName, loop);
            }
            else if (inputName.ToLower() != "quit")
            {
                foreach (char letter in inputName)
                {
                    if (!char.IsLetter(letter))
                    {
                        validName = false;
                        loop = true;
                        return (validName, loop);
                    }
                }
            }
            else
            {
                validName = true;
                loop = true;
                return (validName, loop);
            }
            return (true, true);

        }
    }
}
