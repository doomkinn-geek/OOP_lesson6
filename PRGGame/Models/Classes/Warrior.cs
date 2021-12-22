using System;
using System.Collections.Generic;
using System.Text;

namespace RPGGame.Models.Classes
{    
    public class Warrior : PlayerClass
    {
        public Warrior() : base(BaseCharacteristic.Strength, 2000)
        {

        }
    }
}
