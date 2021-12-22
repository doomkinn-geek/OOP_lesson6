using System;
using System.Collections.Generic;
using System.Text;

namespace RPGGame.Models.Spells
{
    public class FireBolt : Ability
    {
        public FireBolt() : base("FireBolt", "Mages spell. Diale damage with fire", 50)
        {
            _damage = 200;   
        }
    }
}
