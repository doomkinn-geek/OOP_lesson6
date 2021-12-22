using RPGGame.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPGGame.Actions
{
    public class Heal : BaseAction, IAction
    {
        private readonly int _hitPointsHealed;

        public Heal(Item itemInUse, int hitPointsHealed)
            : base(itemInUse)
        {
            _hitPointsHealed = hitPointsHealed;
        }

        public void Execute(Creature actor, Creature victim)
        {
            
        }
    }
}
