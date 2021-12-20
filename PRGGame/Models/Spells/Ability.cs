using System;
using System.Collections.Generic;
using System.Text;

namespace PRGGame.Models.Spells
{
    public class Ability : Item
    {
        private string _description;
        public string Description { get => _description; }
        public uint AbilityLevel { get; set; }
        protected uint _damage;
        protected uint Damage { get => AbilityLevel * _damage; }        
        public Ability(string name, string description, uint manaCost) : base(name, ItemType.Ability, manaCost)
        {            
            _description = description;
            AbilityLevel = 1;
            _damage = 0;
        }
        public void IncreaseLevel()
        {
            AbilityLevel++;
        }
    }
}
