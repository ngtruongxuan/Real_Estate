using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Real_Estate.Models
{
    public class ImageModel
    {
        public int id { get; set; }
        public int real_estate_id { get; set; }
        public DateTime create_date { get; set; }
        public string link_image { get; set; }
        public string last_update { get; set; }
    }
}