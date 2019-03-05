using EgetProjekt.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace EgetProjekt.ViewModels
{
    public class CardListVm
    {
        public IEnumerable<SelectListItem> AllCards { get; set; }
        public Card Card { get; set; }
    }
}
