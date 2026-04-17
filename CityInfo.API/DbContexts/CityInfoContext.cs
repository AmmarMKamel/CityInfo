using CityInfo.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace CityInfo.API.DbContexts
{
    public class CityInfoContext : DbContext
    {
        public DbSet<City> Cities { get; set; }
        public DbSet<PointOfInterest> PointsOfInterest { get; set; }

        public CityInfoContext(DbContextOptions<CityInfoContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>().HasData(
                new City("New York")
                {
                    Id = 1,
                    Description = "The one with the big park"
                },
                new City("Smart Valley")
                {
                    Id = 2,
                    Description = "Egypt's Silicon Valley"
                },
                new City("Makkah")
                {
                    Id = 3,
                    Description = "An amazing place for muslims"
                });

            modelBuilder.Entity<PointOfInterest>().HasData(
                new PointOfInterest("Central Park")
                {
                    Id = 1,
                    Description = "An 843-acre green oasis in Manhattan",
                    CityId = 1
                },
                new PointOfInterest("Statue of Liberty")
                {
                    Id = 2,
                    Description = "A colossal neoclassical sculpture gifted by France in 1886",
                    CityId = 1
                },
                new PointOfInterest("Egyptian Museum")
                {
                    Id = 3,
                    Description = "Home to the world's largest collection of ancient Egyptian artifacts",
                    CityId = 2
                },
                new PointOfInterest("Nile River")
                {
                    Id = 4,
                    Description = "The longest river in the world, stretching over 6,695 km",
                    CityId = 2
                },
                new PointOfInterest("Masjid Al-Haram")
                {
                    Id = 5,
                    Description = "The holiest site in Islam, surrounded by the Kaaba",
                    CityId = 3
                },
                new PointOfInterest("Mount Arafat")
                {
                    Id = 6,
                    Description = "A hill considered sacred in Islam, site of the Prophet Muhammad's final sermon",
                    CityId = 3
                });

            base.OnModelCreating(modelBuilder);
        }
    }
}
