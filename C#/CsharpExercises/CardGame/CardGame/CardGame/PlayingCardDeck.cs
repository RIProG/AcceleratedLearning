using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardGame
{
    public class PlayingCardDeck
    {

        public PlayingCardDeck()
        {
            Reset();
        }

        public List<PlayingCard> Cards { get; set; }

        public void Reset()
        {
            Cards = Enumerable.Range(1, 4)
                .SelectMany(s => Enumerable.Range(1, 13)
                                    .Select(c => new PlayingCard()
                                    {
                                        CardSuit = (CardSuit)s,
                                        CardRank = (CardRank)c
                                    }
                                            )
                            )
                   .ToList();
        }

        public void Shuffle()
        {
            Cards = Cards.OrderBy(c => Guid.NewGuid())
                         .ToList();
        }

        public PlayingCard TakeCard()
        {
            var card = Cards.FirstOrDefault();
            Cards.Remove(card);

            return card;
        }

        public IEnumerable<PlayingCard> TakeCards(int numberOfCards)
        {
            var cards = Cards.Take(numberOfCards);

            var takeCards = cards as PlayingCard[] ?? cards.ToArray();
            Cards.RemoveAll(takeCards.Contains);

            return takeCards;
        }
        //List<PlayingCard> Deck = new List<PlayingCard>();

        //    foreach (PlayingCard.CardRank rank in Enum.GetValues(typeof(PlayingCard.CardRank)))
        //    {
        //        Deck.Add(new PlayingCard(PlayingCard.CardSuit.Clubs, rank));
        //        Deck.Add(new PlayingCard(PlayingCard.CardSuit.Diamonds, rank));
        //        Deck.Add(new PlayingCard(PlayingCard.CardSuit.Hearts, rank));
        //        Deck.Add(new PlayingCard(PlayingCard.CardSuit.Spades, rank));
        //    }
    }

}
