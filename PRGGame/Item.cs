using System;
using System.Collections.Generic;
using System.Text;

namespace PRGGame
{
    public class Item
    {
        public uint ID { get; set; }
        public string Name { get; set; }
        public Item(uint id, string name)
        {
            ID = id;
            Name = name;
        }
    }
}
