using System;
using System.Collections.Generic;
using System.Text;
using RPGGame.Models;

namespace RPGGame.Actions
{
    public interface IAction
    {        
        void Execute(Creature actor, Creature target);
    }
}
