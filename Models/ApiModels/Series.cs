using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace R6MIX.Models.ApiModels
{
    public class Series
    {
        public DateTime begin_at { get; set; }
        public object description { get; set; }
        public DateTime end_at { get; set; }
        public string full_name { get; set; }
        public int id { get; set; }
        public int league_id { get; set; }
        public DateTime modified_at { get; set; }
        public string name { get; set; }
        public string season { get; set; }
        public string slug { get; set; }
        public string tier { get; set; }
        public object winner_id { get; set; }
        public object winner_type { get; set; }
        public int year { get; set; }
    }
}
