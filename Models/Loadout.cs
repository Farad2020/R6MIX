using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace R6MIX.Models
{
    public class Loadout
    {
        public int Id { get; set; }

        [System.ComponentModel.DisplayName("Name")]
        public string Name { get; set; }

        [System.ComponentModel.DisplayName("Primary Weapon")]
        public string PrimaryWeapon { get; set; }

        [System.ComponentModel.DisplayName("Primary Weapon Image Link")]
        public string PrimaryWeaponImg { get; set; }

        [System.ComponentModel.DisplayName("Secondary Weapon")]
        public string SecondaryWeapon { get; set; }

        [System.ComponentModel.DisplayName("Secondary Weapon Image Link")]
        public string SecondaryWeaponImg { get; set; }

        [System.ComponentModel.DisplayName("Gadget")]
        public string Gadget { get; set; }

        [System.ComponentModel.DisplayName("Gadget Image Link")]
        public string GadgetImg { get; set; }


        [System.ComponentModel.DisplayName("Operators")]
        public ICollection<Operator> Operators { get; set; }
    }
}
