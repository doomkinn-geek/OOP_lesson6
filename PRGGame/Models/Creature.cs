using System;
using System.Collections.Generic;
using System.Text;

namespace PRGGame.Models
{
    public abstract class Creature
    {
        public string Name { get; }
        public uint Health { get; set; }
        public uint MaximumHealth { get; set; }
        public uint Gold { get; set; }
        public uint Level { get; set; }
        public uint MaxMana { get; set; }
        public uint Mana { get; set; }
        public Item CurrentWeapon { get; set; }
        public Item CurrentSpell { get; set; }

        protected Creature(string name, 
            uint maxhealth, 
            uint maxMana = 0,
            uint gold = 0, 
            uint level = 1)
        {
            Name = name;
            MaximumHealth = maxhealth;
            Health = maxhealth;
            MaxMana = maxMana;
            Mana = 0;
            Gold = gold;
            Level = level;
        }
        public bool IsDead => Health <= 0;
        public void UseCurrentSpell(Creature victim)
        {
            CurrentSpell.PerformAction(this, victim);
        }
        public void UseCurrentWeapon(Creature victim)
        {
            CurrentWeapon.PerformAction(this, victim);
        }
        public void TakeDamage(uint hitPointsOfDamage)
        {
            Health -= hitPointsOfDamage;

            if (IsDead)
            {
                Health = 0;                
            }
        }

        public void SpendMana(uint manaCost)
        {
            Mana -= manaCost;
        }

        public void FullManaRestore()
        {
            Mana = MaxMana;
        }

        public void Heal(uint hitPointsToHeal)
        {
            Health += hitPointsToHeal;

            if (Health > MaximumHealth)
            {
                Health = MaximumHealth;
            }
        }

        public void CompleteHeal()
        {
            Health = MaximumHealth;
        }

        public void ReceiveGold(uint amountOfGold)
        {
            Gold += amountOfGold;
        }

        public void SpendGold(uint amountOfGold)
        {
            if (amountOfGold > Gold)
            {
                return;
            }
            Gold -= amountOfGold;
        }
    }
}
