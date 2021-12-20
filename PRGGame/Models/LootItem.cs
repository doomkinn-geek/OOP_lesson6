using System;
using System.Collections.Generic;
using System.Text;

namespace PRGGame.Models
{
    public enum LootQuality
    {
        Poor,
        Common,
        UnCommon,
        Rare,
        Epic,
        Legendary
    };
    public class LootItem : Item
    {
        private float _dropPercentage;
        private LootQuality _quality;
        public float DropPercentage { get => _dropPercentage; }
        public LootQuality Quality { get => _quality; }
        public LootItem(string name, LootQuality quality, uint price) : base(name, ItemType.Loot, price)
        {
            _quality = quality;
            Random rnd = new Random();
            switch(_quality)
            {
                case LootQuality.Poor:
                    _dropPercentage = (float)(rnd.NextDouble() * 100);
                    break;
                case LootQuality.Common:
                    _dropPercentage = (float)(rnd.NextDouble() * 70);
                    break;
                case LootQuality.UnCommon:
                    _dropPercentage = (float)(rnd.NextDouble() * 20);
                    break;
                case LootQuality.Rare:
                    _dropPercentage = (float)(rnd.NextDouble() * 10);
                    break;
                case LootQuality.Epic:
                    _dropPercentage = (float)(rnd.NextDouble() * 5);
                    break;
                case LootQuality.Legendary:
                    _dropPercentage = (float)(rnd.NextDouble() * 1);
                    break;
            }            
        }
    }
}
