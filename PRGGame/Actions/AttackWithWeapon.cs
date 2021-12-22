using RPGGame.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPGGame.Actions
{
    public class AttackWithWeapon : BaseAction, IAction
    {
        private readonly int _maxDamage;
        private readonly int _minDamage;

        public AttackWithWeapon(Item itemInUse, int minDamage, int maxDamage)
            : base(itemInUse)
        {
            _minDamage = minDamage;
            _maxDamage = maxDamage;
        }
        public void Execute(Creature actor, Creature target)
        {
            throw new NotImplementedException();
        }
    }
}
