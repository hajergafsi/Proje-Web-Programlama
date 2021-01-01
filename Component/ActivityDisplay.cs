using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Proje.Models;
using Microsoft.EntityFrameworkCore;

namespace Proje.Component
{
    public class ActivityDisplay : ViewComponent
    {
      private AgencyContext db;
      public ActivityDisplay(AgencyContext ctx)
      {
          db = ctx;
      }
      public async Task<IViewComponentResult> InvokeAsync()
       {
                var activities = await db.Activities.Take(3).ToListAsync();
                return View(activities);
       }
    }
}

