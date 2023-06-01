using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppRefresher_Complex_Interface_
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior thor = new Warrior("Thor", 100, 26, 10);
            Warrior loki= new Warrior("Loki", 100, 26, 10);

            Battle.StartFight(thor, loki);
        }
    }
}
