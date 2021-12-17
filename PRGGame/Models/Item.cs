using PRGGame.Actions;
using System;
using System.Collections.Generic;
using System.Text;

namespace PRGGame.Models
{
    public enum ItemType
    {
        Weapon,
        Spell,
        Consumable
    }
    public class Item
    {
        public uint ID { get; set; }
        public string Name { get; set; }
        public ItemType Type { get; }
        public IAction Action { get; set; }
        public uint Price { get; }
        public Item(uint id, 
            string name, 
            ItemType type,
            uint price,
            IAction action = null)
        {
            ID = id;
            Name = name;
            Type = type;
            Action = action;
            Price = price;
        }
        public void PerformAction(Creature actor, Creature victim)
        {
            Action?.Execute(actor, victim);
        }
    }
}
