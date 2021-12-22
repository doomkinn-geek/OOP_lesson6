using System;
using System.Collections.Generic;
using System.Text;

namespace RPGGame.Models.Spells
{
    class IceBolt : Ability
    {
        public IceBolt() : base("IceBolt", "Mages spell. Diale damage with ice", 25)
        {
            _damage = 70;
        }
    }
}
