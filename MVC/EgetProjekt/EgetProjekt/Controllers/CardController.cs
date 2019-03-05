using EgetProjekt.Models;
using EgetProjekt.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace EgetProjekt.Controllers
{
    public class CardController : Controller
    {
        private ICardRepository _repo;

        public CardController(ICardRepository repo)
        {
            _repo = repo;
        }

        [HttpPost("AddCard")]
        public IActionResult AddCard(Card card)
        {
            _repo.Add(card);

            return View("CardAdded", card);
        }

        public IActionResult CardAdded()
        {
            return View();
        }

        public IActionResult Index()
        {
            var vm = new CardListVm
            {
                AllCards = _repo.GetAll().Select(x => new SelectListItem
                {
                    Text = x.Url,
                    Value = x.Id.ToString()
                })
            };

            return View(vm);
        }

        public IActionResult ListAll()
        {
            IEnumerable<Card> allCards = _repo.GetAll();
            return View(allCards);
        }

        public IActionResult GetById(int id)
        {
            Card x = _repo.GetById(id);
            return View(x);
        }

        public IActionResult ClearAll()
        {
            return View("ClearAll");
        }

    }
}

