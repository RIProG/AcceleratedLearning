using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Controllers
{
    [Route("api")]
    public class HomeController : Controller
    {
        [HttpGet("GetWeather")]
        public IActionResult GetWeather(string day)
        {

            if (day == null || day.Length == 0)
            {
                return BadRequest("Du måste ange en veckodag");
            }

            switch (day.ToLower())
            {
                case "måndag":
                    return Ok("Klart väder Mån");
                    break;
                case "tisdag":
                    return Ok("Klart väder Tis");
                    break;
                case "onsdag":
                    return Ok("Klart väder Ons");
                    break;
                case "torsdag":
                    return Ok("Klart väder Tor");
                    break;
                case "fredag":
                    return Ok("Klart väder Fre");
                    break;
                case "lördag":
                    return NoContent();
                    break;
                case "söndag":
                    return NoContent();
                    break;

                default:
                    return BadRequest("Kan du inte veckodagarna eller?");
                    break;
            }
            return Ok();
        }

    }
}
