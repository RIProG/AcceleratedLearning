using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiLab.Controllers
{
    [Route("webapi2")]
    public class WebApi2Controller : Controller
    {
        [Route("helloworld")]
        public string HelloWorld()
        {
            return "Hello world";
        }

        [Route("weekday")]
        public string WeekDay()
        {
            
            return "Idag är det " + DateTime.Now.DayOfWeek;
        }

        [HttpGet("dagensfloskel")]
        public string DagensFloskel()
        {
            var dateAndTime = DateTime.Now;
            var weekday = dateAndTime.ToString("dddd");
            if (weekday == "måndag")
            {
                return "Måndag hela veckan...";
            }
            else if (weekday == "tisdag")
            {
                return "It's tuesday afternoooon...";
            }
            else if (weekday == "onsdag")
            {
                return "Odens dag!";
            }
            else if (weekday == "torsdag")
            {
                return "Tors dag!";
            }
            else if (weekday == "fredag")
            {
                return "Friday I'm in love!";
            }
            else if (weekday == "lördag")
            {
                return "Saturday night fevaah!";
            }
            else 
            {
                return "Sunday bloody sunday...";
            }
        }
    }
}
