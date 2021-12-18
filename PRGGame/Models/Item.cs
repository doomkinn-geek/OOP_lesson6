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
        Consumable,
        Loot
    }
    public class Item
    {        
        public string Name { get; set; }
        public ItemType Type { get; }
        public IAction Action { get; set; }
        public uint Price { get; }
        public Item(string name, 
            ItemType type,
            uint price,
            IAction action = null)
        {            
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
