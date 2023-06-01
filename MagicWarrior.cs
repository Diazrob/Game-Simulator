using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppRefresher_Complex_Interface_
{
    class MagicWarrior : Warrior
    {
        int teleportChance = 0;
        CanTeleport teleportType = new CanTeleport();

        public MagicWarrior(string name = "Warrior", double health = 0, double attkMax = 0, double BlockMax = 0, int teleportChance = 0) : base(name, health, attkMax, BlockMax)
        {
            this.teleportChance = teleportChance;
        }
        public override double Block()
        {
            Random rdn = new Random();
            int rndDodge = rdn.Next(1, 100);
            
            if (rndDodge > this.teleportChance)
            {
                Console.WriteLine($"{Name} {teleportType.teleport()}");
                return 10000;
            } else
            {
                return base.Block();
            }
        } 
    } 
}
