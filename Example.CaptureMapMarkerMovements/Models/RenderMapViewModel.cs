using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Example.CaptureMapMarkerMovements.Models
{
    public class RenderMapViewModel
    {
        public IEnumerable<Waypoint> Waypoints { get; set; }
        public string RawData { get; set; }
    }
}