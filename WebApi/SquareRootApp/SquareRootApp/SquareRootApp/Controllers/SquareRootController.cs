using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareRootApp.Controllers
{
    public class SquareRootController : Controller
    {
        [HttpGet("api/squareroot")]
        public IActionResult SquareRoot(int? number)
        {
            if (number == null)
            {
                return BadRequest("Du måste ange ett tal");
            }

            else if (number < 0)
                return BadRequest("Ange ett positivt tal!");

            return Ok(Math.Sqrt((int)number));
        }
    }
}
