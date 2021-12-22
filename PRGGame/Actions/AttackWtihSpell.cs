using RPGGame.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPGGame.Actions
{    
    public class AttackWtihSpell : BaseAction, IAction
    {
        private readonly int _damage;
        private readonly int _mana;

        public AttackWtihSpell(Item spellInUse, int magicDamage, int manaCost) :
            base(spellInUse)
        {
            _damage = magicDamage;
            _mana = manaCost;
        }

        public void Execute(Creature actor, Creature victim)
        {
            int damage = _damage;            
        }
    }
}
