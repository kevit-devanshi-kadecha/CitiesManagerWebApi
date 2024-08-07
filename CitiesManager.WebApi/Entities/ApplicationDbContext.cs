using CitiesManager.WebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CitiesManager.WebApi.Entities
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public ApplicationDbContext() { }

        public virtual DbSet<City> CitiesData { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<City>().HasData(new City()
            {
                Id = Guid.Parse("7321012A-1A9A-4EF0-9999-E2F84988196D"),
                CityName = "USA"
            });
            modelBuilder.Entity<City>().HasData(new City()
            {
                Id = Guid.Parse("C2DEB2AA-D4CA-4B6B-AEF5-3962454AC3A3"),
                CityName = "New york"
            });
        }
    }
}
