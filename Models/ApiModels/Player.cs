using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace R6MIX.Models.ApiModels
{
    public class Player
    {
        public object birth_year { get; set; }
        public object birthday { get; set; }
        public Team current_team { get; set; }
        public Videogame current_videogame { get; set; }
        public object first_name { get; set; }
        public object hometown { get; set; }
        public int id { get; set; }
        public object image_url { get; set; }
        public object last_name { get; set; }
        public string name { get; set; }
        public string nationality { get; set; }
        public object role { get; set; }
        public string slug { get; set; }
    }
}
