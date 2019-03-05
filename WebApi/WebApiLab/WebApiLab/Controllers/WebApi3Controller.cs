using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiLab.Controllers
{
    [Route("webapi3")]
    public class WebApi3Controller : Controller
    {

        [HttpPost("breakfast")]
        public IActionResult Breakfast(string breakfast)
        {
            if (string.IsNullOrWhiteSpace(breakfast))
            {
                return Ok("Skriv in din frukostmat");
            }
            else if (breakfast.ToLower() == "mango")
            {
                return Ok("Mango är gott!");
            }
            else
                return Ok(breakfast + " är äckligt!");
        }

        [HttpPost("raisedtotwo")]
        public IActionResult RaisedToTwo(int number)
        {
            return Ok($"{number} * {number} = {number * number}");
        }

        [HttpPost("numberlist")]
        public IActionResult NumberList(int number1, int number2)
        {
            List<int> numberList = new List<int>();
            for (int i = number1; i <= number2; i++)
            {
                numberList.Add(i);
            }
            return Ok(numberList.Select(x => x));
        }

        [HttpPost("backgroundcolor")]
        public IActionResult BackgroundColor(string backgroundColor)
        {
            string html = $"<body style ='background-color:{backgroundColor}'></body>";
            return Content(html, "text/html");
        }

    }
}
