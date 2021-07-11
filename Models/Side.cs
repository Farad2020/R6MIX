using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace R6MIX.Models
{
    public class Side
    {
        public int Id { get; set; }

        [System.ComponentModel.DisplayName("Name")]
        public string Name { get; set; }

        [System.ComponentModel.DisplayName("Icon")]
        public string Icon { get; set; }

        [System.ComponentModel.DisplayName("Operators")]
        public ICollection<Operator> Operators { get; set; }
    }
}
