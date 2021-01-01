using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proje.Models;

namespace Proje.Component
{
    public class Instafeed : ViewComponent
    {
        private AgencyContext db;
        public Instafeed(AgencyContext ctx)
        {
            db = ctx;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var insta = await db.InstaPosts.Take(8).ToListAsync();
            return View(insta);
        }

    }
}
