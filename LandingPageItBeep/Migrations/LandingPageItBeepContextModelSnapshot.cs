﻿// <auto-generated />
using LandingPageItBeep.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LandingPageItBeep.Migrations
{
    [DbContext(typeof(LandingPageItBeepContext))]
    partial class LandingPageItBeepContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LandingPageItBeep.Models.Lookup", b =>
                {
                    b.Property<int>("LookupID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CraetedBy");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("LookupName");

                    b.Property<string>("LookupNameEn");

                    b.HasKey("LookupID");

                    b.ToTable("Lookups");
                });
#pragma warning restore 612, 618
        }
    }
}
