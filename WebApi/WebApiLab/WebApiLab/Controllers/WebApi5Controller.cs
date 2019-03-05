using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiLab.Controllers
{
    [Route("webapi5")]
    public class WebApi5Controller : Controller
    {

        [HttpGet("addperson")]
        public IActionResult AddPerson(SimplePerson person)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok($"'{person.Name}' som är '{person.Age}' år lades till i databasen");
        }
    }

    public class SimplePerson
    {
        [Required(ErrorMessage = "Du måste ange ett namn")]
        //[StringLength(20, ErrorMessage="")] <-- Går att använda istället för raden nedan.
        [RegularExpression("^[A-ZÅÄÖa-zåäö]{2,20}$", ErrorMessage = "Namnet får endast innehålla bokstäverna A-Ö och vara 2-20 i längd.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Du måste ange en ålder")]
        [Range(0, 120, ErrorMessage = "Åldern måste vara mellan 0 och 120")]
        public int? Age { get; set; }
    }
}
