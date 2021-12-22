using System;
using System.Collections.Generic;
using System.Text;
using RPGGame.Models.Spells;

namespace RPGGame.Models.Classes
{
    public class Mage : PlayerClass
    {        
        public Mage() : base(BaseCharacteristic.Intelligence, 1000)
        {
            this.SpellsAvailable.Add(new FireBolt());

        }
    }
}
