using System;
using System.Collections.Generic;
using System.Text;

namespace PRGGame.Models.Spells
{
    public class FireBolt : Ability
    {
        public FireBolt() : base("FireBolt", "Mages spell. Diale damage with fire", 50)
        {
            _damage = 200;   
        }
    }
}
