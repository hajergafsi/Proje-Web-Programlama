using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc.Localization;
using Proje.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;

namespace Proje.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHtmlLocalizer<HomeController> _localizer;
        private readonly AgencyContext _context;
        public HomeController(IHtmlLocalizer<HomeController> localizer, ILogger<HomeController> logger, AgencyContext wsc)
        {
            _localizer = localizer;
            _logger = logger;
            _context = wsc;
        }
        public IActionResult Index()
        {
            TempData["BookingId"] = null;
            TempData["CardId"] = null;
            return View();
        }

        [HttpPost]
        public IActionResult CultureManagement(string culture, string returnUrl)
        {
            Response.Cookies.Append(CookieRequestCultureProvider.DefaultCookieName, CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)), new CookieOptions { Expires = DateTimeOffset.Now.AddDays(30) });
            return LocalRedirect(returnUrl);
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
