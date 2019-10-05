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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Lookup>()
                .HasData(
                    new Lookup
                    {
                        LookupID = 1,
                        LookupName = "العروض",
                        LookupNameEn = "Offers",
                        IsDeleted = false
                    },
                    new Lookup
                    {
                        LookupID = 2,
                        LookupName = "وقت الطلب",
                        LookupNameEn = "Order Time",
                        IsDeleted = false
                    }
                );

            modelBuilder.Entity<LookupCategory>()
                .HasData(
                    new LookupCategory
                    {
                        LookupCategoryID = 1,
                        LookupID = 1,
                        LookupName = "عرض 1",
                        LookupNameEn = "Offer 1"
                    },
                    new LookupCategory
                    {
                        LookupCategoryID = 2,
                        LookupID = 1,
                        LookupName = "عرض 2",
                        LookupNameEn = "Offer 2"
                    },
                    new LookupCategory
                    {
                        LookupCategoryID = 3,
                        LookupID = 1,
                        LookupName = "عرض 3",
                        LookupNameEn = "Offer 3"
                    },
                    new LookupCategory
                    {
                        LookupCategoryID = 4,
                        LookupID = 2,
                        LookupName = "استفسار عام",
                        LookupNameEn = "General Inquiry"
                    },
                    new LookupCategory
                    {
                        LookupCategoryID = 5,
                        LookupID = 2,
                        LookupName = "خلال شهر",
                        LookupNameEn = "During Months"
                    },
                    new LookupCategory
                    {
                        LookupCategoryID = 6,
                        LookupID = 2,
                        LookupName = "خلال اسبوع",
                        LookupNameEn = "During Week"
                    }
                );
        }
    }
}
