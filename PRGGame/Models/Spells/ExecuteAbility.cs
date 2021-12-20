using System;
using System.Collections.Generic;
using System.Text;

namespace PRGGame.Models.Spells
{
    public class ExecuteAbility : Ability
    {
        public ExecuteAbility() : base("Execute", "Warriors ability. Diale phisical damage", 50)
        {
            _damage = 400;
        }
    }
}
