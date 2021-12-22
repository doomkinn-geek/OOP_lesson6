using System;
using System.Collections.Generic;
using System.Text;

namespace RPGGame.Models
{
    public class Monster : Creature
    {   
        public int MaximumDamage { get; set; }
        public int RewardExperience { get; set; }
        public int RewardGold { get; set; }
        public List<LootItem> LootTable { get; set; }
        public Monster(string name, int maximumDamage, int rewardExperience, int rewardGold, uint maximumHealth) : base("",maximumHealth)
        {   
            MaximumDamage = maximumDamage;
            RewardExperience = rewardExperience;
            RewardGold = rewardGold;
            LootTable = new List<LootItem>();
        }
    }
}
