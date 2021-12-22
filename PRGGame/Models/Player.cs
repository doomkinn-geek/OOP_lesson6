using System;
using System.Collections.Generic;
using System.Text;

namespace RPGGame.Models
{
    public class Player : Creature
    {
        private string _characterClass;
        public uint ExperiencePoints { get; set; }
        public string CharacterClass
        {
            get => _characterClass;             
        }
        public Player(string name, string characterClass, int experiencePoints,
            uint maxHitPoints, int currentHitPoints, int magicPoints, int maxMana, int gold) :
            base(name, maxHitPoints)
        {
            _characterClass = characterClass;
            ExperiencePoints = 0;
        }
        public void AddExperience(uint experiencePoints)
        {
            ExperiencePoints += experiencePoints;
        }

        private void SetLevelAndMaximumHitPoints()
        {
            uint originalLevel = Level;

            Level = (ExperiencePoints / 100) + 1;

            if (Level != originalLevel)
            {
                Health = Level * 20;
                MaxMana = Level * 10;                
            }
        }
    }
}
