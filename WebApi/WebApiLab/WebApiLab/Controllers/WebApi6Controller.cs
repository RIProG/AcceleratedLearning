using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiLab.Controllers
{

    [Route("webapi6")]
    public class WebApi6Controller : Controller
    {
        [HttpGet("AddDocument")]
        public IActionResult AddDocument(Document document)
        {
            return Ok(document);
        }

    }

    public class Document
    {
        public string Title { get; set; }
        public int? Pages { get; set; }
        public bool? Summary { get; set; }
        public DateTime Published { get; set; }
        public decimal Price { get; set; }
        public string Type { get; set; }
        public List<string> Tags { get; set; }
        public int Grade { get; set; }
    }

}
