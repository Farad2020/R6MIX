using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace R6MIX.Models
{
    public class Operator
    {
        public int Id { get; set; }

        [System.ComponentModel.DisplayName("Name")]
        public string Name { get; set; }

        [System.ComponentModel.DisplayName("Image")]
        public string OpImgLink { get; set; }

        [System.ComponentModel.DisplayName("Icon")]
        public string OpIconLink { get; set; }

        [System.ComponentModel.DisplayName("Role")]
        public string Role { get; set; }

        [System.ComponentModel.DisplayName("Origin")]
        public string Origin { get; set; }

        [System.ComponentModel.DisplayName("Biography")]
        public string Biography { get; set; }

        [System.ComponentModel.DisplayName("Pshycological Portrait")]
        public string PshycoPortrait { get; set; }

        [System.ComponentModel.DisplayName("Armor")]
        public int Armor { get; set; }

        [System.ComponentModel.DisplayName("Speed")]
        public int Speed { get; set; }

        [System.ComponentModel.DisplayName("Difficulty")]
        public int Difficulty { get; set; }

        [System.ComponentModel.DisplayName("Side")]
        public Side OpSide { get; set; }

        [System.ComponentModel.DisplayName("Loadout")]
        public Loadout OpLoadout { get; set; }

        [System.ComponentModel.DisplayName("Unique Ability Name")]
        public string AbilityName { get; set; }

        [System.ComponentModel.DisplayName("Unique Ability Icon")]
        public string AbilityIcon { get; set; }

        [System.ComponentModel.DisplayName("Unique Ability TLDR")]
        public string AbilityTLDR { get; set; }

        [System.ComponentModel.DisplayName("Unique Ability Demostraition Link")]
        public string AbilityDemoLink { get; set; }
    }
}
