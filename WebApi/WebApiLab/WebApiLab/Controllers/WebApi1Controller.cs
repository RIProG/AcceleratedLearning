using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiLab.Models;

namespace WebApiLab.Controllers
{

    [Route("webapi1")]
    public class WebApi1Controller : Controller
    {
        [Route("AddPlanet")]
        public IActionResult AddPlanet()
        {
            string formContent = "";
            using (StreamReader reader = new StreamReader(Request.Body, Encoding.UTF8))
            {
                formContent = reader.ReadToEndAsync().Result;
            }

            Planet planet = ParsePlanet(formContent);

            return Ok("Ny planet " + planet.Name + " skapad med storleken " + planet.Size);
        }

        [HttpPost("AddPlanet2")]
        public IActionResult AddPlanet2(Planet planet)
        {
            return Ok("Planetens namn: " + planet.Name + " Planetens storlek: " + planet.Size);
        }

        [HttpGet("SearchPlanet2")]
        public IActionResult SearchPlanet2(Planet planet)
        {

            return Ok("Planetens namn: " + planet.Name + " Planetens storlek: " + planet.Size);
        }

        private Planet ParsePlanet(string formContent)
        {
            
            Planet newPlanet = new Planet();
            string[] array = formContent.Split('=');
            newPlanet.Size = int.Parse(array[2]);
            string[] array2 = array[1].Split('&');
            newPlanet.Name = array2[0];
           
            return newPlanet;
        }
    }

}
