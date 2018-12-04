using System;

namespace Module8_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] animals;
            int animalcount = 0;
            bool loop = true;

            while (loop == true)
            {

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Enter a list of animals: ");
                Console.ForegroundColor = ConsoleColor.Green;
                string animalInput = Console.ReadLine();

                try
                {
                    animals = ParseAnimals(animalInput);
                    foreach (string animal in animals)
                    {
                        animalcount++;
                    }
                    loop = false;
                }
                catch (ArgumentException ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);

                }
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"There are {animalcount} animals in the list");
        }

        private static string[] ParseAnimals(string animalInput)
        {
            string[] animals = animalInput.Split(',');
            foreach (string animal in animals)
            {
                if (animal.Length > 20)
                    throw new ArgumentException($"This animal '{animal}' has too many letters");

                foreach (char input in animal)
                {
                    if (!char.IsLetter(input))
                    {
                        throw new ArgumentException($"Animal: '{animal}' contains invalid letters");
                    }
                }

                if (string.IsNullOrWhiteSpace(animal))
                    throw new ArgumentException($"One or more of the animals contains no letters");
            }
            return animals;

        }



    }
}
