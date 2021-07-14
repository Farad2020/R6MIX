using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace R6MIX.Models.ApiModels.MatchData
{
    public class Game
    {
        public DateTime begin_at { get; set; }
        public bool complete { get; set; }
        public bool detailed_stats { get; set; }
        public DateTime end_at { get; set; }
        public bool finished { get; set; }
        public bool forfeit { get; set; }
        public int id { get; set; }
        public int length { get; set; }
        public int match_id { get; set; }
        public int position { get; set; }
        public string status { get; set; }
        public object video_url { get; set; }
        public Team winner { get; set; }
        public string winner_type { get; set; }
    }
}
