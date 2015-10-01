using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleRoyale.Character_Resources
{
    class Player : Character
    {
        public Player()
        {
            Random rnd = new Random();
            Strength = rnd.Next(5, 11);
            System.Threading.Thread.Sleep(100);
            Armor = rnd.Next(5, 11);
        }


    }
}
