using Microsoft.EntityFrameworkCore;

namespace CityInfo.api.Entities
{
    public class CityInfoContext : DbContext
    {
        public CityInfoContext(DbContextOptions<CityInfoContext> options)
            :base(options)
        {
            Database.Migrate();
        }
        public DbSet<City> Cities { get; set; }
        public DbSet<PointOfInterest> PointsOfInterest { get; set; }


        // alternative way to configure db context
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("insert connection string here");
        //    base.OnConfiguring(optionsBuilder);
        //}
    }
}
