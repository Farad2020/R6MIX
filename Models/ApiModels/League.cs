using R6MIX.Models.ApiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace R6MIX.Models
{
    public class League
    {
        public int id { get; set; }
        public string image_url { get; set; }
        public DateTime modified_at { get; set; }
        public string name { get; set; }
        public List<Series> series { get; set; }
        public string slug { get; set; }
        public object url { get; set; }
        public Videogame videogame { get; set; }
    }
}
