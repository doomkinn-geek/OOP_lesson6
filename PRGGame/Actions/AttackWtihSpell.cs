using RPGGame.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPGGame.Actions
{    
    public class AttackWtihSpell : BaseAction, IAction
    {
        private readonly uint _minDamage;
        private readonly uint _maxDamage;        
        private readonly uint _mana;

        public AttackWtihSpell(Spell spellInUse) :
            base(spellInUse)
        {
            _minDamage = spellInUse.MinimumDamage;
            _maxDamage = spellInUse.MaximumDamage;
            _mana = spellInUse.ManaCost;
        }

        public void Execute(Creature actor, Creature target)
        {
            uint damage = RandomNumberGenerator.NumberBetween(_minDamage, _maxDamage);            
            if (actor.Mana < _mana)
            {
                ReportResults("Недостаточно маны");
                return;
            }

            if (damage > 0)
            {
                ReportResults($"{actor.Name} поразил {target.Name} {damage} очков урона.");
                target.TakeDamage(damage);
                actor.SpendMana(_mana);
            }
            else
            {
                ReportResults("Ты промахнулся");
            }
        }
    }
}
