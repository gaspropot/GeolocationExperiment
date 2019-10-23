using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GeoKatastasi.Models
{
    public class Location
    {
        public int Id { get; set; }
        public decimal latitude { get; set; }
        public decimal longitude { get; set; }
    }
}