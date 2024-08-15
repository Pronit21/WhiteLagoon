using Microsoft.EntityFrameworkCore;
using WhiteLagoon.Domain.Entities;


namespace WhiteLagoon.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Villa> Villas { get; set; }

        public DbSet<VillaNumber> VillaNumbers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Villa>().HasData(
                new Villa
                {
                    Id = 1,
                    Name = "Villa 1",
                    Description = "Villa 1 Description",
                    Price = 100,
                    Sqft = 1000,
                    Occupancy = 5,
                    ImageUrl = "https://via.placeholder.com/150",
                    Created_Date = new DateTime(2021, 1, 1),
                    Updated_Date = new DateTime(2021, 1, 1)
                },
                new Villa
                {
                    Id = 2,
                    Name = "Villa 2",
                    Description = "Villa 2 Description",
                    Price = 200,
                    Sqft = 2000,
                    Occupancy = 10,
                    ImageUrl = "https://via.placeholder.com/150",
                    Created_Date = new DateTime(2021, 1, 1),
                    Updated_Date = new DateTime(2021, 1, 1)
                });

            modelBuilder.Entity<VillaNumber>().HasData(
                               new VillaNumber
                               {
                                   Villa_Number = 101,
                                   VillaId = 1,
                                   SpecialDetails = "Special Details for Villa 1"
                               },
                               new VillaNumber
                               {
                                   Villa_Number = 102,
                                   VillaId = 1,
                                   SpecialDetails = "Special Details for Villa 2"
                               },
                               new VillaNumber
                               {
                                   Villa_Number = 103,
                                   VillaId = 1,
                                   SpecialDetails = "Special Details for Villa 1"
                               },
                               new VillaNumber
                               {
                                   Villa_Number = 201,
                                   VillaId = 2,
                                   SpecialDetails = "Special Details for Villa 2"
                               },
                               new VillaNumber
                               {
                                   Villa_Number = 202,
                                   VillaId = 2,
                                   SpecialDetails = "Special Details for Villa 2"
                               },
                               new VillaNumber
                               {
                                   Villa_Number = 203,
                                   VillaId = 2,
                                   SpecialDetails = "Special Details for Villa 2"
                               },
                               new VillaNumber
                               {
                                   Villa_Number = 301,
                                   VillaId = 3,
                                   SpecialDetails = "Special Details for Villa 2"
                               },
                               new VillaNumber
                               {
                                   Villa_Number = 302,
                                   VillaId = 3,
                                   SpecialDetails = "Special Details for Villa 2"
                               }
                               );
        }
    }
}
