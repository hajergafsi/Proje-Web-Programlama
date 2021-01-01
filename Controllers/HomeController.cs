using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Proje.Models;

namespace Proje.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AgencyContext _context;
        public City selected { get; set; }
        public HomeController(ILogger<HomeController> logger, AgencyContext wsc)
        {
            _logger = logger;
            _context = wsc;
        }
        public IActionResult Index()
        {
            return View(selected);
        }

        public async Task<IActionResult> SearchResult(City city)
        {
            var scity = await _context.Cities.FirstOrDefaultAsync(x => x.CityID == city.CityID);
            var tours = await _context.Tours.Where(m => m.TourId == scity.TourId).ToListAsync();
            return View(scity);
        }

        public async Task<IActionResult> About()
        {
            var about = await _context.About.FirstAsync();
            return View(about);
        }


    }
}
