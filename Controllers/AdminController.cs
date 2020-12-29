using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proje.Models;

namespace Proje.Controllers
{
    public class AdminController : Controller
    {
        private AgencyContext _context;
        public AdminController(AgencyContext wsc)
        {
            _context = wsc;
        }
        [Authorize(Roles = "admin")]
        public IActionResult Index()
        {
            Admin admin = new Admin();
            admin.toursCount = _context.Tours.Count();         
            admin.countriesCount = _context.Countries.Count();            
            admin.hotelsCount = _context.Hotels.Count();
            admin.citiesCount = _context.Cities.Count();
            return View(admin);
        }
    }
}
