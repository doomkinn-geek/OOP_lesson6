using System;
using System.Collections.Generic;
using System.Text;

namespace PRGGame.Models
{
    public class Weapon : Item
    {
        public int MinimumDamage { get; set; }
        public int MaximumDamage { get; set; }

        public Weapon(string name, int minimumDamage, int maximumDamage, uint price) : base(name, ItemType.Weapon, price)
        {
            MinimumDamage = minimumDamage;
            MaximumDamage = maximumDamage;
        }
    }
}
