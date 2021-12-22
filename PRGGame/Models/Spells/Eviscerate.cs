using System;
using System.Collections.Generic;
using System.Text;

namespace RPGGame.Models.Spells
{
    public class Eviscerate : Ability
    {
        public Eviscerate() : base("Eviscerate", "Rogues ability. Finishing move that disembowels the target, causing damage per combo point.", 10)
        {
            _damage = 350;
        }
    }
}
