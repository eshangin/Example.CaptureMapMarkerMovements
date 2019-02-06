using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Example.CaptureMapMarkerMovements.Models
{
    public class Waypoint
    {
        public decimal Lat { get; set; }
        public decimal Lng { get; set; }
        public decimal Speed { get; set; }
        public string Date { get; set; }
    }
}