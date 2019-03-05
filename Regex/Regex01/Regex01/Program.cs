using System;
using System.Text.RegularExpressions;

namespace Regex01
{
    public class Program
    {
        static void Main(string[] args)
        {
            Regex rgx = new Regex("^([A-Z]{2})-([0-9]{3})-([0-9]{3})$");
            Console.WriteLine("Ange produktnummer: ");
            string produktNummer = Console.ReadLine();

            Match match = rgx.Match(produktNummer);
            if (match.Success)
            {
                Console.WriteLine("Första delen " + match.Groups[1].Value);
                Console.WriteLine("Första delen " + match.Groups[2].Value);
                Console.WriteLine("Första delen " + match.Groups[3].Value);
            }
            else
            {
                Console.WriteLine("Felaktig format");
            }


        }
    }
}
