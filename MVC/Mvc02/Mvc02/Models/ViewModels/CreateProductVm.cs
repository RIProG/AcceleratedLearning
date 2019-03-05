using Microsoft.AspNetCore.Mvc.Rendering;
using Mvc02.Models.Entities;
using System.Collections.Generic;

namespace Mvc02.Models.ViewModels
{
    public class CreateProductVm
    {
        public IEnumerable<SelectListItem> AllCategories { get; set; }
        public Product Product { get; set; }
    }
}
