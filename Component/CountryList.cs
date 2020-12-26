using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Proje.Models;

namespace Proje.Component
{
    public class CountryList:ViewComponent
    {
        private AgencyContext db;
        public  CountryList(AgencyContext ctx)
        {
            db = ctx;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await db.Countries.ToListAsync());
        }
    }
}
