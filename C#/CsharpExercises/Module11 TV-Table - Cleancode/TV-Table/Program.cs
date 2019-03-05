using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TV_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = GetTextFilePath();
            List<Show> allShows = GetAllShowsFromTextFile(filePath);

            DisplayTitlesOfAllShows(allShows);
            DisplayShowsStartingAfter21(allShows);
            DisplayShowsFromSvt2Chronological(allShows);
            LookForShow(allShows, "Kulturnyheterna");
            LookForShow(allShows, "Ensam pappa söker");
            DisplayAllShowsStartingAfter20(allShows);
            DisplayTitleOfAllShowsInUpperCases(allShows);
            DisplayAllChannels(allShows);

            Console.ReadKey();
        }

        private static void DisplayAllChannels(List<Show> allShows)
        {
            Console.WriteLine("ALLA KANALER");
            Console.WriteLine();
            foreach (string show in allShows.Select(o => o.Channel).Distinct())
            {
                Console.WriteLine(show);
            }
        }

        private static void DisplayTitleOfAllShowsInUpperCases(List<Show> allShows)
        {
            Console.WriteLine("ALLA PROGRAMNAMN MED STORA BOKSTÄVER");
            Console.WriteLine();
            foreach (Show show in allShows)
            {
                Console.WriteLine(show.Name.ToUpper());
            }
            Console.WriteLine();
        }

        private static void DisplayAllShowsStartingAfter20(List<Show> allShows)
        {

            Console.WriteLine("ALLA PROGRAM SOM BÖRJAR KL 20.00");
            Console.WriteLine();
            foreach (Show show in allShows)
            {
                if (show.Time.TotalHours == 20)
                {
                    Console.WriteLine($"{show.Channel} {show.Time} {show.Name}");
                }
            }
        }

        private static void LookForShow(List<Show> allShows, string show)
        {
            Console.WriteLine($"FINNS PROGRAMMET '{show}'?");
            Console.WriteLine();

            if (allShows.Any(p => p.Name == show))
            {
                Console.WriteLine("Ja");
            }
            else
            {
                Console.WriteLine("Nej");
            }
            Console.WriteLine();
        }

        private static void DisplayShowsFromSvt2Chronological(List<Show> allShows)
        {
            var svt2List = new List<Show>();

            Console.WriteLine("PROGRAM FRÅN SVT2 I KRONOLOGISK ORDNING");
            Console.WriteLine();
            foreach (Show show in allShows)
            {
                if (show.Channel == "SVT2")
                {
                    svt2List.Add(show);
                }
            }

            svt2List.OrderBy(x => x.Time).ToList();

            foreach (Show show in svt2List)
            {
                Console.WriteLine($"{show.Channel} {show.Time} {show.Name}");
            }
            Console.WriteLine();
        }

        private static void DisplayShowsStartingAfter21(List<Show> allShows)
        {
            Console.WriteLine("PROGRAM SOM BÖRJAR SENARE ÄN KL 21");
            Console.WriteLine();
            foreach (Show show in allShows)
            {
                if (show.Time.Hours >= 21)
                {
                    Console.WriteLine($"{show.Channel} {show.Time} {show.Name}");
                }
            }
            Console.WriteLine();
        }

        private static void DisplayTitlesOfAllShows(List<Show> allShows)
        {
            Console.WriteLine("ALLA TITLAR");
            Console.WriteLine();
            foreach (Show show in allShows)
            {
                Console.WriteLine(show.Name);
            }
            Console.WriteLine();
        }

        private static string GetTextFilePath()
        {
            string filePath = @"C:\Project\AcceleratedLearning\C#\CsharpExercises\Module11 TV-Table\TV-Table\tv-data.txt";
            return filePath;
        }

        private static List<Show> GetAllShowsFromTextFile(string filePath)
        {
            var showList = new List<Show>();
            string[] readText = File.ReadAllLines(filePath);
            foreach (string item in readText)
            {
                Show newShow = new Show();
                newShow.Channel = item.Split('*')[0];
                newShow.Time = TimeSpan.Parse(item.Split('*')[1]);
                newShow.Name = item.Split('*')[2];
                showList.Add(newShow);
            }
            return showList;
        }
    }
}
