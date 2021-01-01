using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proje.Models;
namespace Proje.Component
{
    public class CountsComponent: ViewComponent
    {

        private AgencyContext db;
        public CountsComponent(AgencyContext ctx)
        {
            db = ctx;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var ccity = await db.Cities.CountAsync();
            var ccountry = await db.Countries.CountAsync();
            var ct = await db.Tours.CountAsync();
            Counts cnt = new Counts(ccity,ccountry,ct);
            return View(cnt);
        }

    }
}
