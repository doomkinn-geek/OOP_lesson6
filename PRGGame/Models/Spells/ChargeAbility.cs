using System;
using System.Collections.Generic;
using System.Text;

namespace RPGGame.Models.Spells
{
    public class ChargeAbility : Ability
    {
        public ChargeAbility() : base("Charge", "Warriors ability. Charge to an enemy, dealing Physical damage, rooting it for 1 sec", 20)
        {
            _damage = 250;
        }
    }
}
