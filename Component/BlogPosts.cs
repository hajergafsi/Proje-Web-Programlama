using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Proje.Models;
using Microsoft.EntityFrameworkCore;

namespace Proje.Component
{
    public class BlogPosts : ViewComponent
    {
        private AgencyContext db;
        public BlogPosts(AgencyContext ctx)
        {
            db = ctx;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var posts = await db.BlogPosts.Take(3).ToListAsync();
            return View(posts);
        }
    }
}
