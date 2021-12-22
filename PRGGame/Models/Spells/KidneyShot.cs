using System;
using System.Collections.Generic;
using System.Text;

namespace RPGGame.Models.Spells
{
    public class KidneyShot : Ability
    {
        public KidneyShot() : base("Kidney Shot", "Rogues ability. Finishing move that stuns the target. Lasts longer per combo point", 5)
        {
            _damage = 250;
        }
    }
}
