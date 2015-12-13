using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Real_Estate.Models
{
    public class RealEstateModel
    {
        public int id { get; set; }
        public int location_id { get; set; }
        public string title_eng { get; set; }
        public string title_vie { get; set; }
        public string price { get; set; }
        public string code { get; set; }
        public string size { get; set; }
        public string floor { get; set; }
        public string view { get; set; }
        public DateTime create_date { get; set; }
        public int bathroom { get; set; }
        public int bedroom { get; set; }
        public string furniture { get; set; }
        public string status { get; set; }
        public DateTime last_update { get; set; }
        public float numofviews { get; set; }
    }
}