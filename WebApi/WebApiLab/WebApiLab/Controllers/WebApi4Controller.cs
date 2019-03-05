using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WebApiLab.Controllers
{
    [Route("webapi4")]
    public class WebApi4Controller : Controller
    {

        [HttpPost("delachoklad")]
        public IActionResult DelaChoklad(decimal number)
        {
            if (number <= 0)
            {
                return BadRequest("Minst en person krävs för att äta choklad...");
            }
            decimal shared = 25 / number;
            return Ok("Alla får " + Math.Round(shared, 2) + " bitar var!");
        }

        [HttpGet("getorder")]
        public IActionResult GetOrder(string number)
        {
            Regex rgx = new Regex("^[a-zA-Z]{2}-[0-9]{4}$");
            if (string.IsNullOrWhiteSpace(number) || !rgx.IsMatch(number))
                return BadRequest("Fel format på ordernumret!");

            else if (rgx.IsMatch(number) && int.Parse(number.Substring(number.Length - 4)) <= 3000)
            {
                return Ok($"Order {number} hittades i databasen.");

            }
            else if (rgx.IsMatch(number) && int.Parse(number.Substring(number.Length - 4)) > 3000)
                return NotFound("Slutet på ordernumret måste vara 3000 eller lägre.");

            else
                return NotFound();

        }

        [HttpGet("getuser")]
        public IActionResult GetUser(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                var html = @"<IMG SRC='https://localhost:44332/thumbsdown.jpg'>";
                return Content(html, "text/html");
            }

            else if (name == "Stewie")
                throw new Exception("DATA ERROR!");

            else if (name == "Peter")
            {
                var html = @"<IMG SRC='https://localhost:44332/explosion.jpg'>";
                return Content(html, "text/html");
            }

            else if (name == "Lois" || name == "Meg" || name == "Chris" || name == "Brian")
            {
                var html = @"<IMG SRC='https://localhost:44332/thumbsup.png'>";
                return Content(html, "text/html");
            }

            else
            {
                var html = @"<IMG SRC='https://localhost:44332/thumbsdown.jpg'>";
                return BadRequest(html);
            }
        }

    }
}
