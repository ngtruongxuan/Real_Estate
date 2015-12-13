using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Real_Estate.Models
{
    public class LocationModel
    {
        public int id { get; set; }
        public int property_id { get; set; }
        public string location_name_eng { get; set; }
        public string location_name_vie { get; set; }
        public string status { get; set; }
    }
}