﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace R6MIX.Models.ApiModels
{
    public class Videogame
    {
        public object current_version { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public string slug { get; set; }
    }
}
