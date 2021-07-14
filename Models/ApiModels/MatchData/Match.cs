using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace R6MIX.Models.ApiModels.MatchData
{
    public class Match
    {
        public Series serie { get; set; }
        public bool detailed_stats { get; set; }
        public string name { get; set; }
        public DateTime end_at { get; set; }
        public int serie_id { get; set; }
        public bool forfeit { get; set; }
        public Streams streams { get; set; }
        public List<Result> results { get; set; }
        public DateTime modified_at { get; set; }
        public Tournament tournament { get; set; }
        public string slug { get; set; }
        public DateTime scheduled_at { get; set; }
        public List<Team> opponents { get; set; }
        public DateTime begin_at { get; set; }
        public int league_id { get; set; }
        public string official_stream_url { get; set; }
        public Videogame videogame { get; set; }
        public List<StreamsList> streams_list { get; set; }
        public string status { get; set; }
        public string live_embed_url { get; set; }
        public DateTime original_scheduled_at { get; set; }
        public int? game_advantage { get; set; }///
        public int winner_id { get; set; }
        public List<Game> games { get; set; }
        public League league { get; set; }
        public object videogame_version { get; set; }///
        public int id { get; set; }
        public bool draw { get; set; }
        public Team winner { get; set; }
        public string match_type { get; set; }
        public int number_of_games { get; set; }
        public bool rescheduled { get; set; }
        public Live live { get; set; }
        public int tournament_id { get; set; }
    }
}
