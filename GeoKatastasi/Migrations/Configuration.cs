namespace GeoKatastasi.Migrations
{
    using GeoKatastasi.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<GeoKatastasi.Models.LocationContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(GeoKatastasi.Models.LocationContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            Location l1 = new Location { Id = 1 ,latitude = 45.55172M, longitude = -85.75345M };
            Location l2 = new Location { Id = 2, latitude = 9.98112M, longitude = -78.48603M };
            Location l3 = new Location { Id = 3, latitude = 27.22975M, longitude = 47.61679M };
            Location l4 = new Location { Id = 4, latitude = -64.20181M, longitude = 39.42730M };

            context.Locations.AddOrUpdate(x => x.Id, l1, l2, l3, l4);
            context.SaveChanges();

        }
    }
}
