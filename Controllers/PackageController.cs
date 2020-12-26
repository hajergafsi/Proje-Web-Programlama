using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proje.Models;

namespace Proje.Controllers
{
    public class PackageController : Controller
    {
        private readonly AgencyContext _context;
        public PackageController(AgencyContext wsc)
        {
            _context = wsc;
        }
        public async Task<IActionResult> Index(Tour tour)
        {
            var tours = await _context.Tours.ToListAsync();
            return View(tours);
        }
    }
}
