using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Real_Estate.Models
{
    public class PropertyModel
    {
        public int id { get; set; }
        public int parent_id { get; set; }
        public string name_eng { get; set; }
        public string name_vie { get; set; }
        public string status { get; set; }
        public List<LocationModel> ls_Location = new List<LocationModel>();
    }
}