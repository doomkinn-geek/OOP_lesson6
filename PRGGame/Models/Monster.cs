using System;
using System.Collections.Generic;
using System.Text;

namespace PRGGame.Models
{
    public class Monster : Creature
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int MaximumDamage { get; set; }
        public int RewardExperience { get; set; }
        public int RewardGold { get; set; }
        public List<LootItem> LootTable { get; set; }
        public Monster(int id, string name, int maximumDamage, int rewardExperience, int rewardGold, uint maximumHealth) : base(maximumHealth)
        {
            ID = id;
            Name = name;
            MaximumDamage = maximumDamage;
            RewardExperience = rewardExperience;
            RewardGold = rewardGold;
            LootTable = new List<LootItem>();
        }
    }
}
