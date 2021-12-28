using RPGGame.Models;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace RPGGame.Actions
{
    public class AttackWithWeapon : BaseAction, IAction
    {
        private readonly uint _maxDamage;
        private readonly uint _minDamage;

        public AttackWithWeapon(Weapon itemInUse)
            : base(itemInUse)
        {
            _minDamage = itemInUse.MinimumDamage;
            _maxDamage = itemInUse.MaximumDamage;
        }
        public void Execute(Creature actor, Creature target)
        {
            uint damage = RandomNumberGenerator.NumberBetween(_minDamage, _maxDamage);            
            if (damage == 0)
            {
                ReportResults($"Вы атаковали, но атака на {target.Name} промахнулась.");
            }
            else
            {
                ReportResults($"{actor.Name} ударил {target.Name}, нанес {damage} очков урона.");
                target.TakeDamage(damage);
            }
        }
    }
}
