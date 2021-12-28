using System;
using System.Collections.Generic;
using System.Text;

namespace RPGGame.Models
{
    public class Spell : Item
    {
        private uint _minimumDamage;
        private uint _maximumDamage;
        private uint _manaCost;
        public uint MinimumDamage { get => _minimumDamage; }
        public uint MaximumDamage { get => _maximumDamage; }
        public uint ManaCost { get => _manaCost; }

        public Spell(string name, uint minimumDamage, uint maximumDamage, uint manaCost) : base(name, ItemType.Weapon, 0)
        {
            _minimumDamage = minimumDamage;
            _maximumDamage = maximumDamage;
            _manaCost = manaCost;
        }
    }
}
