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
            List<Show> allShows = GetShowsFromTextFile();

            DisplayInfoAboutShows(allShows);

            Console.ReadKey();
        }

        private static void DisplayInfoAboutShows(List<Show> allShows)
        {
            Console.WriteLine("ALLA TITLAR");
            Console.WriteLine();
            foreach (Show show in allShows)
            {
                Console.WriteLine(show.Name);
            }
            Console.WriteLine();

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

            //Två olika sätt att sortera listan efter property.
            svt2List.OrderBy(x => x.Time).ToList();
            //svt2List.Sort((x, y) => x.Time.CompareTo(y.Time));

            foreach (Show show in svt2List)
            {
                Console.WriteLine($"{show.Channel} {show.Time} {show.Name}");
            }
            Console.WriteLine();

            Console.WriteLine("FINNS PROGRAMMET 'KULTURNYHETERNA'?");
            Console.WriteLine();

            if (allShows.Any(p => p.Name == "Kulturnyheterna"))
            {
                Console.WriteLine("Ja");
            }
            else
            {
                Console.WriteLine("Nej");
            }
            Console.WriteLine();


            Console.WriteLine("FINNS PROGRAMMET 'ENSAM PAPPA SÖKER'?");
            Console.WriteLine();
            if (allShows.Any(p => p.Name == "Ensam pappa söker"))
            {
                Console.WriteLine("Ja");
            }
            else
            {
                Console.WriteLine("Nej");
            }
            Console.WriteLine();

            Console.WriteLine("ALLA PROGRAM SOM BÖRJAR KL 20.00");
            Console.WriteLine();
            //allShows.Where(x => x.Time.Hours == 20.00)
            foreach (Show show in allShows)
            {
                if (show.Time.Hours == 20 && show.Time.Minutes == 00) //Kan också använda show.Time.TotalHours == 20
                {
                    Console.WriteLine($"{show.Channel} {show.Time} {show.Name}");
                }
            }

            Console.WriteLine("ALLA PROGRAMNAMN MED STORA BOKSTÄVER");
            Console.WriteLine();
            foreach (Show show in allShows) //alternativs allshows.Select(x=>x.Name.ToUpper())
            {
                Console.WriteLine(show.Name.ToUpper());
            }
            Console.WriteLine();
            Console.WriteLine("ALLA KANALER");
            Console.WriteLine();
            foreach (string show in allShows.Select(o => o.Channel).Distinct())
            {
                Console.WriteLine(show);
            }
        }

        private static List<Show> GetShowsFromTextFile()
        {
            var showList = new List<Show>();
            string[] readText = File.ReadAllLines(@"C:\Project\AcceleratedLearning\C#\CsharpExercises\Module11 TV-Table\TV-Table\tv-data.txt");
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
