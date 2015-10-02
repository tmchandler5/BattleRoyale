using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleRoyale.Character_Resources
{
    class Character
    {
        public int Health { get; protected set; }
        public int Strength { get; set; }
        public int Armor { get; set; }


        public Character()
        {
            Health = 1000;
        }

        //public int receiveDamage(int rawDmg)
        //{
        //    double recDmg = rawDmg - (((Armor * 2.0) / 100.0) * rawDmg);
        //    Health = Health - (int)recDmg;
        //    return (int)recDmg;
        //}


        //public int doDamage()
        //{
        //    int doDmg = (Strength * 2) + new Random().Next(50, 101);
        //    return doDmg;
        //}

        public int defenceTotal()
        {
            int defTtl = (Armor * 2);
            return defTtl;
        }

        public int attackTotal()
        {
            int atkTtl = (Strength * 2) + new Random().Next(60, 101);
            return atkTtl;
        }

        public int doDamage()
        {
            int dealDmg = attackTotal() - defenceTotal();
            return dealDmg;
        }

    }
}
