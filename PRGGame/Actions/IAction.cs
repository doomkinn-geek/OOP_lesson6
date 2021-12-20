using System;
using System.Collections.Generic;
using System.Text;
using PRGGame.Models;

namespace PRGGame.Actions
{
    public interface IAction
    {        
        void Execute(Creature actor, Creature target);
    }
}
