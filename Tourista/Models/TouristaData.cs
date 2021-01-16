using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tourista.Models
{
    public class TouristaData
    {
        public string Category { get; set; }
        public string Names { get; set; }
        public double Latitudes { get; set; }
        public double Longitudes { get; set; }
        public string MarkerID { get; set; }
        public string Description { get; set; }
    }
}
