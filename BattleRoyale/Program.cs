using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleRoyale.Character_Resources;

namespace BattleRoyale
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player();
            System.Threading.Thread.Sleep(100);
            Player enemy1 = new Player();

            //while (player1.Health >= 0 && enemy1.Health >= 0)
            //{
            //    Console.WriteLine("Player 1 does " + enemy1.receiveDamage(player1.doDamage()) + " damage to Enemy1.");
            //    Console.WriteLine("Enemy1 has " + enemy1.Health + " health.\n");


            //    if (enemy1.Health > 0)
            //    {
            //        Console.WriteLine("Enemy 1 does " + player1.receiveDamage(enemy1.doDamage()) + " damage to Player1.");
            //        Console.WriteLine("Player1 has " + player1.Health + " health.\n");

            //    }
            //}
            





            {
                Console.WriteLine(player1.attackTotal());
                Console.WriteLine(enemy1.defenceTotal());
                Console.WriteLine(player1.doDamage());
            }
            System.Threading.Thread.Sleep(99999);
        }

    }
}
