using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Proje.Models
{
    public class AgencyContext : IdentityDbContext<User>
    {       
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Tour> Tours { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<CreditCard> CreditCards { get; set; }
        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Activities> Activities { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<About> About { get; set; }
        public DbSet<InstaPost> InstaPosts { get; set; }

        public AgencyContext (DbContextOptions<AgencyContext> options): base(options)
        {

        }
    }
}
