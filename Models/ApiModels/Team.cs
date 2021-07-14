using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace R6MIX.Models.ApiModels
{
    public class Team
    {
        public object acronym { get; set; }
        public int id { get; set; }
        public string image_url { get; set; }
        public object location { get; set; }
        public DateTime modified_at { get; set; }
        public string name { get; set; }
        public string slug { get; set; }
    }
}
