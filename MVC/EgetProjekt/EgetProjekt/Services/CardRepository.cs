using EgetProjekt.Controllers;
using EgetProjekt.Models;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EgetProjekt.Services
{
    public class CardRepository : ICardRepository
    {
        private IHostingEnvironment _env;

        public CardRepository(IHostingEnvironment env)
        {
            _env = env;
        }

        public IEnumerable<Card> GetAll()
        {
            string root = _env.ContentRootPath;
            string filename = GetFilenameForCardList();
            IEnumerable<Card> allCards = File.ReadAllLines(filename).Select(x => new Card
            {
                Id = int.Parse(x.Split(",")[0]),
                Url = x.Split(",")[1]
            }); ;

            return allCards;
        }

        public Card GetById(int id)
        {
            return GetAll().Single(x => x.Id == id);
        }

        public void Add(Card card)
        {
            card.Id = GetAll().Max(x => x.Id) + 1;
            File.AppendAllText(GetFilenameForCardList(), $"{card.Id},{card.Url}\n");
        }

        private string GetFilenameForCardList()
        {
            string root = _env.ContentRootPath;
            string filename = Path.Combine(root, "Data", "Cards.txt");
            return filename;
        }

        public void ClearAll()
        {
            string path = GetFilenameForCardList();
            File.WriteAllText(path, String.Empty);
        }
    }
}
