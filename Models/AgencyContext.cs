﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Proje.Models
{
    public class AgencyContext : DbContext
    {
        
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Tour> Tours { get; set; }
        public DbSet<Hotel> Hotels { get; set; }

        public AgencyContext (DbContextOptions<AgencyContext> options): base(options)
        {

        }
    }
}