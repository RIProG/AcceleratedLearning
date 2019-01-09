using System;
using System.Collections.Generic;


namespace CardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayingCardDeck deck = new PlayingCardDeck();
            Console.WriteLine(deck);

            //Console.WriteLine("1. Spela ett parti");
            //Console.WriteLine("2. Visa spelregler");
            //Console.WriteLine("3. Visa highscores");
            //Console.WriteLine("4. Avsluta spelet");
        }
    }
}
