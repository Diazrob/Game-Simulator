using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppRefresher_Complex_Interface_
{
    class Battle
    {
        // StartFight
        // war1 attacks war2, war2 damanged and health decreases
        // Get attack result
        // war2 attacks war1, war1 damanged and health decreases
        // Get attack result

        public static void StartFight(Warrior warrior1, Warrior warrior2)
        {
            while (true)
            {
                if (GetAttackResult(warrior1, warrior2) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }
                if (GetAttackResult(warrior2, warrior1) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }
            }
            
        }

        // Get attack result
        public static string GetAttackResult(Warrior warriorA, Warrior warriorB)
        {
            double warriorAAttkAmt = warriorA.Attack();
            double warriorBBlkAmt = warriorB.Block();

            double dmg2WarB = warriorAAttkAmt - warriorBBlkAmt;

            if (dmg2WarB > 0)
            {
                warriorB.Health = warriorB.Health - dmg2WarB;
            } else dmg2WarB = 0;

            Console.WriteLine("{0} attacks {1} and deals {2} damage", warriorA.Name, warriorB.Name, dmg2WarB);
            Console.WriteLine("{0} has {1} health\n", warriorB.Name, warriorB.Health);

            if (warriorB.Health <= 0)
            {
                Console.WriteLine("{0} has died and {1} is victorious\n", warriorB.Name, warriorA.Name);
                return "Game Over";
            }
            else return "Fight Again";

            
        }
    }
}
