using R6MIX.Models.ApiModels.MatchData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace R6MIX.Models.ApiModels
{
    public class Tournament
    {
        public DateTime begin_at { get; set; }
        public DateTime end_at { get; set; }
        public int id { get; set; }
        public League league { get; set; }
        public int league_id { get; set; }
        public bool live_supported { get; set; }
        public DateTime modified_at { get; set; }
        public string name { get; set; }
        public double prizepool { get; set; }
        public int serie_id { get; set; }
        public Series serie { get; set; }
        public string slug { get; set; }
        public List<Team> teams { get; set; }
        public Videogame videogame { get; set; }
        public int winner_id { get; set; }
        public string winner_type { get; set; }
        public List<Match> matches { get; set; }
    }
}
