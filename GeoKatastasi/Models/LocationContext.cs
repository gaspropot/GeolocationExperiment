using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GeoKatastasi.Models
{
    public class LocationContext : DbContext
    {
        public DbSet<Location> Locations { get; set; }
    }
}