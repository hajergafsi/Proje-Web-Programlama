using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proje.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proje.Component
{
    public class TourList : ViewComponent
    {
        private AgencyContext db;
        public TourList(AgencyContext ctx)
        {
            db = ctx;
        }
        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            if (id != 0)
            {
                return View(await db.Tours.Where(x => x.TourId == id).ToListAsync());
            }
            return View(await db.Tours.Take(3).ToListAsync());
        }
    }
}
