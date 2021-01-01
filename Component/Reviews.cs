using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Proje.Models;
using Microsoft.EntityFrameworkCore;

namespace Proje.Component
{
    public class Reviews : ViewComponent
    {
        private AgencyContext db;
        public Reviews(AgencyContext ctx)
        {
            db = ctx;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var reviews = await db.Reviews.ToListAsync();
            return View(reviews);
        }
    }
}
