using System;
using System.Collections.Generic;
using System.Text;

namespace PRGGame
{
    public enum SpellType
    {
        Magical,
        Phisical        
    };
    public class Spell
    {
        private SpellType _type;
        private string _name;
        private string _description;
        public SpellType Type { get => _type; }
        public string Name { get => _name; }
        public string Description { get => _description; }
        public Spell(SpellType type, string name, string description)
        {
            _type = type;
            _name = name;
            _description = description;
        }
    }
}
