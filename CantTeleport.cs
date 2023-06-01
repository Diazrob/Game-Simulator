using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppRefresher_Complex_Interface_
{
    class CantTeleport : Teleports
    {
        public string teleport()
        {
            return ("Fails at teleporting");
        }
    }
}
