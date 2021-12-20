using System;
using System.Collections.Generic;
using System.Text;

namespace PRGGame.Models.Classes
{
    class IceBolt : Ability
    {
        public IceBolt() : base("IceBolt", "Diale damage with ice", 25)
        {
            _damage = 70;
        }
    }
}
