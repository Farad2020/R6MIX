using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace R6MIX.Models.ApiModels.MatchData
{
    public class StreamsList
    {
        public string embed_url { get; set; }
        public string language { get; set; }
        public bool main { get; set; }
        public bool official { get; set; }
        public string raw_url { get; set; }
    }
}
