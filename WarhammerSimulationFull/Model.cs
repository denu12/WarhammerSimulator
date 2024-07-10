using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarhammerSimulationFull
{
    internal class Model
    {

        public int health, save, ward;
        public List<Weapon> weapons;
        public Model(int health, int save, int ward, List<Weapon> weapons) { 
            this.health = health;
            this.save = save;
            this.ward = ward;
            this.weapons = weapons;
        }

        public Model copy()
        {
            Model result = new Model(health, save, ward, weapons);  
            return result;
        }

        public List<Damage> simulateAttackSequence(Random random, int MinusHit = 0, int Minuswound = 0, int minusAtk = 0)
        {
            List<Damage> result = new List<Damage>();
            foreach (var weapon in weapons) 
                result.Add(weapon.simulateAttackSequence(random, MinusHit, Minuswound, minusAtk));
            return result;
        }

        public List<Damage> simulateRoundsDmg(Random random, double rounds)
        {
            List<Damage> overallDamage = new List<Damage>();
            foreach (Weapon weapon in this.weapons)
                overallDamage.Add(weapon.simulateRoundsDmg(random, rounds));

            return overallDamage;
        }
    }
}
