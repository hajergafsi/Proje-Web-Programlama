using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proje.Models;

namespace Proje.Controllers
{
    public class TourController : Controller
    {
        private readonly AgencyContext _context;
        public TourController(AgencyContext wsc)
        {
            _context = wsc;
        }
        [Route("Tour/{id:int}")]
        public IActionResult Index(int id)
        {
            var cs = _context.Tours.Where(m => m.TourId == id).FirstOrDefault();
            return View(cs);
        }
        public async Task<IActionResult> Details()
        {
            var tours = await _context.Tours.ToListAsync();
            return View(tours);
        }
    }
}
