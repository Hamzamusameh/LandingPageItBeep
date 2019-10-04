using LandingPageItBeep.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LandingPageItBeep.DAL
{
    public class LandingPageItBeepContext : DbContext
    {
        public DbSet<Lookup> Lookups { get; set; }

        public LandingPageItBeepContext(DbContextOptions<LandingPageItBeepContext> options) : base(options)
        {

        }
    }
}
