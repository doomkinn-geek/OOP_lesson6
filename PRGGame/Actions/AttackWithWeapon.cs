using PRGGame.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PRGGame.Actions
{
    public class AttackWithWeapon : BaseAction, IAction
    {
        private readonly int _maxDamage;
        private readonly int _minDamage;

        public AttackWithWeapon(Item itemInUse, int minDamage, int maxDamage)
            : base(itemInUse)
        {
        }
        public void Execute(Creature actor, Creature target)
        {
            throw new NotImplementedException();
        }
    }
}
