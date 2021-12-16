using System;
using System.Collections.Generic;
using System.Text;

namespace PRGGame
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
        public BaseCharacteristic MainCharacteristic { get => _mainCharacteristic; }
        public PlayerClass(BaseCharacteristic _characteristic, uint _health) : base(_health)
        {
            _mainCharacteristic = _characteristic;
        }
    }
}
