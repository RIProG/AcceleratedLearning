using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiLab.Controllers
{

    [Route("webapi0")]
    public class WebApi0Controller : Controller
    {
        [Route("kalle")]
        public string Kalle()
        {
            return "Hej från servern!";
        }

        [Route("kalle2")]
        public string Kalle2()
        {
            return "Klockan är " + DateTime.Now;
        }

        [Route("kalle3")]
        public int Kalle3()
        {
            int i = 10 + 32;
            return i;
        }

        [Route("kalle4"), HttpPost]
        public IActionResult Kalle4()
        {
            //return BadRequest();
            return Ok("Klockan är " + DateTime.Now);
        }
    }
}
