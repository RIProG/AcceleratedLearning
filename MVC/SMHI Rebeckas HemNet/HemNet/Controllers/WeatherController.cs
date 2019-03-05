using HemNet.Data;
using HemNet_Azure.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace HemNet_Azure.Controllers
{
    public class WeatherController : Controller
    {
        private readonly ApplicationDbContext _context;

        public WeatherController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ViewWeather([Bind("Longitude, Latitude")] Coordinates coordinates)
        {
            var service = new SmhiService();
            var result = service.GetMeteorologicalForecast(coordinates.Longitude, coordinates.Latitude).Result;

            List<TimeTemp> timeTemps = service.FilterTemperature(result, DateTime.Now);

            var timeTempVm = new TimeTempVm();
            timeTempVm.TimeTemps = timeTemps;

            return View(timeTempVm);
        }

    }
}
