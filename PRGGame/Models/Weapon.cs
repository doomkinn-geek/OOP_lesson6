using System;
using System.Collections.Generic;
using System.Text;

namespace PRGGame.Models
{
    public class Weapon : Item
    {
        public int MinimumDamage { get; set; }
        public int MaximumDamage { get; set; }

        public Weapon(uint id, string name, int minimumDamage, int maximumDamage) : base(id, name)
        {
            MinimumDamage = minimumDamage;
            MaximumDamage = maximumDamage;
        }
    }
}
