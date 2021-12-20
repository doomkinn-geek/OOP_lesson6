using System;
using System.Collections.Generic;
using System.Text;

namespace PRGGame.Models.Classes
{
    public enum BaseCharacteristic
    {
        notDefined,
        Intelligence,
        Strength,
        Agility
    };    
    public abstract class PlayerClass : Creature
    {
        private BaseCharacteristic _mainCharacteristic;
        public List<Ability> SpellsAvailable { get; }
        public BaseCharacteristic MainCharacteristic { get => _mainCharacteristic; }
        protected PlayerClass(BaseCharacteristic _characteristic, uint _health) : base("", _health)
        {
            _mainCharacteristic = _characteristic;
            SpellsAvailable = new List<Ability>();
        }
    }
}
