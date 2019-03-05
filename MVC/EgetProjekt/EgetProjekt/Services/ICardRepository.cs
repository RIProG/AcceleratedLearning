using EgetProjekt.Models;
using System.Collections.Generic;

namespace EgetProjekt.Controllers
{
    public interface ICardRepository
    {
        IEnumerable<Card> GetAll();
        Card GetById(int id);
        void Add(Card card);
        void ClearAll();

    }
}