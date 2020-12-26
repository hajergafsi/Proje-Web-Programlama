using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Proje.Models;

namespace Proje.Component
{
    public class CityList : ViewComponent
    {
        private AgencyContext db;
        public CityList(AgencyContext ctx)
        {
            db = ctx;
        }
        public async Task<IViewComponentResult> InvokeAsync(int id,string mode)
        {
            if(id != 0 && mode == "list")
            {
                var list = await db.Cities.Where(c => c.TourId == id).ToListAsync();
                return (View("CityList", list));
            }
            if (id != 0 && mode == "Slider")
            {
                var list = await db.Cities.Where(c => c.TourId == id).ToListAsync();
                return (View("Slider",list));
            }       
            return View(await db.Cities.ToListAsync());
        }
    }
}
