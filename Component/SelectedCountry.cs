using Proje.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace Proje.Component
{
    public class SelectedCountry: ViewComponent
    {
        private AgencyContext db;
        public SelectedCountry(AgencyContext ctx)
        {
            db = ctx;
        }
        public async Task<IViewComponentResult> InvokeAsync(string code)
        {
            var country = await db.Countries.FirstOrDefaultAsync(x => x.CountryCode == code);
            return View(country);
        }

    }
}
