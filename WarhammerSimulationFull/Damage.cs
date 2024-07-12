using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarhammerSimulationFull
{
    internal class Damage
    {

        public double damage = 0;
        public double mortal = 0;
        public double rend = 0;
        public double damageHits = 0;

        public Damage()
        {

        }

        public Damage(double d)
        {
            this.mortal = d;
        }


    }
}
