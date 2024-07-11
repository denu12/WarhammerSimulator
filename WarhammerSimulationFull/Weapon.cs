using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarhammerSimulationFull
{
    internal class Weapon
    {

        public double attacks, hit, wound, rend, damage;
        public Boolean CritHit, CritMortal, CritAutowound;
        public Boolean AntiInf, Charge, AntiCharge;


        public Weapon(string stats)
        {
            string[] split = stats.Split(";");
            this.attacks = int.Parse(split[0]);
            this.hit = int.Parse(split[1]);
            this.wound = int.Parse(split[2]);
            this.rend = int.Parse(split[3]);
            this.damage= double.Parse(split[4]);

            if(split.Length > 5)
            {
                CritHit = split[5] == "hit";
                CritMortal = split[5] == "mortal";
                CritAutowound = split[5] == "wound";
                Charge = split[5] == "charge";
            }

            if (split.Length > 6)
            {
                AntiInf = split[6] == "inf";
                AntiCharge = split[6] == "a";
                if(Charge == false)
                Charge = split[6] == "charge";
            }
                
        }

        public Weapon(int attacks, int hit, int wound, int rend, int damage)
        {
            this.attacks = attacks; 
            this.hit = hit;
            this.wound = wound;
            this.rend = rend;
            this.damage = damage;
        }

        public Damage simulateAttackSequence(Random random, int MinusHit = 0, int Minuswound = 0, int minusAtk = 0, int turn = 0)
        {
            Damage result = new Damage();
            result.rend = rend;

            int realAtks = (int) Math.Max(1, attacks - minusAtk);

            double dmg = this.damage;

            if (turn == 1 && this.Charge) {
                dmg = dmg + 1;
            }


            for (int i = 0; i < realAtks; ++i)
            {
                int hitRoll = random.Next(6) + 1;
                int woundrolls = 1;

                if (hitRoll == 6 && CritMortal)
                    result.mortal += dmg;
                else
                if (hitRoll == 6 && CritAutowound)
                    result.damage += dmg;
                else if(hitRoll == 6 && CritHit)
                {
                    woundrolls += 2;
                    for (int j = 0; j < woundrolls; ++j)
                    {
                        int woundRoll = random.Next(6) + 1;
                        if (woundRoll - Minuswound >= this.wound)
                            result.damage += dmg;
                    }
                }
                else
                if(hitRoll - MinusHit >= this.hit)
                    for(int j = 0; j < woundrolls; ++j)
                    {
                        int woundRoll = random.Next(6) + 1;
                        if (woundRoll - Minuswound >= this.wound)
                            result.damage += dmg;
                    }
            }
            return result;
        }

        public Damage simulateRoundsDmg(Random random, double rounds, int turn)
        {
            Damage result = new Damage();
            result.rend = rend;

            for(int i = 0;i < rounds; ++i)
            {
                Damage minorResult = this.simulateAttackSequence(random, 0, 0, 0, turn);
                result.damage += minorResult.damage;
                result.mortal += minorResult.mortal;
            }

            return result;
        }

        

    }
}
