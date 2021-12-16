using System;
using System.Collections.Generic;
using System.Text;

namespace PRGGame
{
    public abstract class Creature
    {
        public uint Health { get; set; }
        public uint MaximumHealth { get; set; }
        public Creature(uint maxhealth)
        {
            MaximumHealth = maxhealth;
            Health = maxhealth;
        }
    }
}
