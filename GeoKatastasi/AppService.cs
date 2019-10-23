using GeoKatastasi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GeoKatastasi
{
    public class AppService
    {
        LocationContext context = new LocationContext();

        internal bool AddLocation(decimal lat, decimal lng)
        {
            context.Locations.Add(new Location
            {
                latitude = lat,
                longitude = lng
            });

            context.SaveChanges();
            return true;
        }
    }
}