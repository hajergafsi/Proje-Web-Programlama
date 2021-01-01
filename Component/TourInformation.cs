using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Proje.Models;
using Microsoft.EntityFrameworkCore;

namespace Proje.Component
{
    public class TourInformation : ViewComponent
    {
        private AgencyContext db;
        public TourInformation(AgencyContext ctx)
        {
            db = ctx;
        }
        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            var tr = await db.Tours.FirstOrDefaultAsync(c => c.TourId == id);
            return View(tr);
        }
    }
}
