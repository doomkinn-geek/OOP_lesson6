using System;
using System.Collections.Generic;
using System.Text;

namespace RPGGame.Models
{
    public class Weapon : Item
    {
        public uint MinimumDamage { get; set; }
        public uint MaximumDamage { get; set; }

        public Weapon(string name, uint minimumDamage, uint maximumDamage, uint price) : base(name, ItemType.Weapon, price)
        {
            MinimumDamage = minimumDamage;
            MaximumDamage = maximumDamage;
        }
    }
}
