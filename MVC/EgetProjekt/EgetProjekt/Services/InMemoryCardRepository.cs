using EgetProjekt.Controllers;
using EgetProjekt.Models;
using System.Collections.Generic;
using System.Linq;

namespace EgetProjekt.Services
{

    public class InMemoryProductRepository : ICardRepository
    {
        static List<Card> _cards = new List<Card>();
        static int _lastId = 0;

        public void Add(Card card)
        {
            card.Id = _lastId;
            _cards.Add(card);
            _lastId++;
        }

        public IEnumerable<Card> GetAll()
        {
            return _cards;
        }

        public Card GetById(int id)
        {
            return _cards.Single(x => x.Id == id);
        }
    }

}
