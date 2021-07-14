using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace R6MIX.Models.ApiModels.MatchData
{
    public class Streams
    {
        public English english { get; set; }
        public Official official { get; set; }
        public Russian russian { get; set; }
    }
}
