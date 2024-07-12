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
        public Boolean ChargeAtk;
        public Boolean ChargeMortal = false;


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
                AntiCharge = split[5] == "anticharge";
                ChargeAtk = split[5] == "chargeAtk";
            }

            if (split.Length > 6)
            {
                AntiInf = split[6] == "inf";
                AntiCharge = split[6] == "anticharge";
                if(Charge == false)
                    Charge = split[6] == "charge";
                ChargeAtk = split[6] == "chargeAtk";
                ChargeMortal = split[6] == "chargeMortal";
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

            int realAtks = (int) attacks;
            if (turn == 1 && ChargeAtk)
                realAtks++;

            realAtks = (int) Math.Max(1, realAtks - minusAtk);

            Boolean recordCritMortal = this.CritMortal;

            if (turn == 1 && ChargeMortal)
                this.CritMortal = true;


            double dmg = this.damage;

            if (turn == 1 && this.Charge) {
                dmg = dmg + 1;
            }
            if(turn == 1 && this.AntiCharge)
            {
                result.rend++;
            }

            result.damage = dmg;

            for (int i = 0; i < realAtks; ++i)
            {
                int hitRoll = random.Next(6) + 1;
                int woundrolls = 1;

                if (hitRoll == 6 && CritMortal)
                    result.mortal += dmg;
                else
                if (hitRoll == 6 && CritAutowound)
                    result.damageHits += 1;
                else if (hitRoll == 6 && CritHit)
                {
                    woundrolls += 2;
                    for (int j = 0; j < woundrolls; ++j)
                    {
                        int woundRoll = random.Next(6) + 1;
                        if (woundRoll - Minuswound >= this.wound)
                            result.damageHits += 1;
                    }
                }
                else
                if (hitRoll - MinusHit >= this.hit)
                    for (int j = 0; j < woundrolls; ++j)
                    {
                        int woundRoll = random.Next(6) + 1;
                        if (woundRoll - Minuswound >= this.wound)
                            result.damageHits += 1;
                    }
            }
            this.CritMortal = recordCritMortal;
            return result;
        }

        public List<Damage> simulateRoundsDmg(Random random, double rounds, int turn)
        {

            List<Damage> acumulativeResult = new List<Damage>();

            for(int i = 0;i < rounds; ++i)
            {
                Damage minorResult = this.simulateAttackSequence(random, 0, 0, 0, turn);
                acumulativeResult.Add(minorResult);
            }

            return acumulativeResult;
        }

        

    }
}
