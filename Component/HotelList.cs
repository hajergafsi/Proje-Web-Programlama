using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proje.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proje.Component
{
    public class HotelList:ViewComponent
    {
        private AgencyContext db;
        public HotelList(AgencyContext ctx)
        {
            db = ctx;
        }
        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            if (id != 0)
            {
                var list = await db.Hotels.Where(c => c.TourId == id).ToListAsync();
                return (View("Slider", list));
            }
            return View(await db.Cities.ToListAsync());
        }
    }
}
