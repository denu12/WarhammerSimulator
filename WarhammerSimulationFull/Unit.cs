using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WarhammerSimulationFull
{
    internal class Unit
    {
        public double modelcount, points;
        public List<Model> models = new List<Model>();
        public string name = "";
        public double totalPoints;
        public double victoryscore;
        public int minusWound, minusHit, minusAtk;
        public string faction = "";
        public int wardFirstTurn = 7;
        public Boolean Etherial=false;
        public Boolean MortalKickback =false;
        public int MortalKickBackNumber = 0;


        public Unit() { 
        
        }

        public override string ToString()
        {
            return this.name;
        }
        public Unit(string baseLine, List<string> weapons)
        {
            string[] split = baseLine.Split(';');
            this.name = split[0];
            this.modelcount = double.Parse(split[1]);
            this.points = double.Parse(split[2]);

            int health = int.Parse(split[3]);
            int save = int.Parse(split[4]);
            int ward = int.Parse(split[5]);

            List<Weapon> weap = new List<Weapon>();

            foreach(string s in weapons)
                weap.Add(new Weapon(s));

            Model m = new Model(health, save, ward, weap);

            this.models = new List<Model>();
            for (int i = 0; i < modelcount; i++)
            {
                this.models.Add(m.copy());
            }
        }


        public Unit(string name, double  modelcount, double points, Model model, int cap)
        {
            this.modelcount = modelcount;
            this.points = points;

            double modelcost = points / modelcount;



            this.models = new List<Model>();
            for(int i = 0; i < cap / modelcost ; i++)
            {
                this.models.Add(model.copy());
            }
            this.name = name;
        }

        public Unit(string name, double modelcount, double points, Model model)
        {
            this.modelcount = modelcount;
            this.points = points;
            this.name= name;
            double modelcost = points / modelcount;



            this.models = new List<Model>();
            for (int i = 0; i < modelcount; i++)
            {
                this.models.Add(model.copy());
            }
        }


       public List<Damage> simulateAttackSequence(Random random, int MinusHit = 0, int Minuswound = 0, int minusAtk = 0, int turn = 0)
        {
            List<Damage> result = new List<Damage>();
            foreach(Model model in models)
            {
                foreach (Damage d in model.simulateAttackSequence(random, MinusHit, Minuswound, minusAtk, turn))
                    result.Add(d);
            }

            return result;
        }


       public double simulateAverageDMG(Random random, double rounds, int turn, Boolean etherial = false)
        {
            List<Damage> damages = new List<Damage>();
            foreach (Model m in models)
            {
                foreach (Damage d in m.simulateRoundsDmg(random, rounds, turn))
                    damages.Add(d);
            }

            Unit dummy = new Unit("dummy", 100000, 300, new Model(1, 4, 7, null));
            dummy.Etherial = etherial;

            double result =  dummy.computeDamageTaken(random, damages, 0) / rounds;
            return result;
        }

        public double computeDamageTaken(Random random, List<Damage> damages, int turn)
        {
            MortalKickBackNumber = 0; 
            double damageTaken = 0;
            foreach (Damage d in damages)
            {

                for (int i = 0; i < d.damageHits; i++)
                {
                    int saveroll = random.Next(6) + 1;

                    if (saveroll == 6 && this.MortalKickback)
                        MortalKickBackNumber++;

                    if (!Etherial)
                    {
                        if (saveroll < this.models[0].save + d.rend)
                            damageTaken += d.damage;
                    }
                    else
                    {
                        if (saveroll < this.models[0].save)
                            damageTaken += d.damage;
                    }
                }

                damageTaken += d.mortal;
            }

            double finaldamagetaken = 0;


            for(int i = 0; i < damageTaken; ++i)
            {
                int wardRoll = random.Next(6) + 1;

                if (turn != 1)
                {
                    if (wardRoll < this.models[0].ward)
                        finaldamagetaken++;
                }
                else
                {
                    if (wardRoll < Math.Min(this.wardFirstTurn, this.models[0].ward))
                        finaldamagetaken++;
                }

            }

            return finaldamagetaken;
        }

        public void processDmg(Random random, List<Damage> damages, int turn)
        {
            int damageTaken= (int) this.computeDamageTaken(random, damages, turn);
            while( damageTaken > 0 && this.models.Count > 0 )
            {
                Model m = this.models.Last();
                if(damageTaken >= m.health)
                {
                    damageTaken -= m.health;
                    this.models.Remove(m);
                }
                else
                    m.health -= damageTaken;
            }
        }


        public Tuple<string, double, string, double> simulateFight(Unit enemy, double rounds, double points)
        {
            Random random = new Random();

            double thisCount = 0;
            double enemyCount = 0;

            for (int i = 0; i < rounds; ++i)
            {
                Unit thisUnit = new Unit();
                thisUnit.name = this.name;
                thisUnit.points = this.points;
                thisUnit.modelcount = this.modelcount;
                thisUnit.minusHit = this.minusHit;
                thisUnit.minusWound = this.minusWound;
                thisUnit.minusAtk = this.minusAtk;
                thisUnit.MortalKickback = this.MortalKickback;
                thisUnit.wardFirstTurn = this.wardFirstTurn;
                thisUnit.Etherial = this.Etherial;
                double pointsPerModel = thisUnit.points / thisUnit.modelcount;
               
                while(thisUnit.totalPoints + pointsPerModel< points)
                {
                    thisUnit.totalPoints += pointsPerModel;
                    thisUnit.models.Add(models.First().copy());
                }

                Unit enemyUnit = new Unit();
                enemyUnit.name = enemy.name;
                enemyUnit.points = enemy.points;
                enemyUnit.modelcount = enemy.modelcount;
                enemyUnit.minusHit = enemy.minusHit;
                enemyUnit.minusWound = enemy.minusWound;
                enemyUnit.minusAtk = enemy.minusAtk;
                enemyUnit.MortalKickback = enemy.MortalKickback;
                enemyUnit.wardFirstTurn = enemy.wardFirstTurn;
                enemyUnit.Etherial = enemy.Etherial;
                pointsPerModel = enemyUnit.points / enemyUnit.modelcount;

                while (enemyUnit.totalPoints + pointsPerModel < points)
                {
                    enemyUnit.totalPoints += pointsPerModel;
                    enemyUnit.models.Add(enemy.models.First().copy());
                }

                int t = 1;
                while (thisUnit.models.Count > 0 && enemyUnit.models.Count > 0)
                {

                    if(Simulator.SIMULTANEOUS == true)
                    {
                        List<Damage> personalDmg = thisUnit.simulateAttackSequence(random, enemyUnit.minusHit, enemyUnit.minusWound, enemyUnit.minusAtk, t);
                        List<Damage> enemyDMG = enemyUnit.simulateAttackSequence(random, thisUnit.minusHit, thisUnit.minusWound, thisUnit.minusAtk, t);
                        enemyUnit.processDmg(random, personalDmg, t);
                        thisUnit.processDmg(random, enemyDMG, t);
                    }
                    else
                    {
                        if (random.Next(2) > 0)
                        {
                            List<Damage> personalDmg = thisUnit.simulateAttackSequence(random, enemyUnit.minusHit, enemyUnit.minusWound, enemyUnit.minusAtk, t);
                            enemyUnit.processDmg(random, personalDmg, t);

                            List<Damage> enemyDMG = enemyUnit.simulateAttackSequence(random, thisUnit.minusHit, thisUnit.minusWound, thisUnit.minusAtk, t);
                            thisUnit.processDmg(random, enemyDMG, t);
                        }
                        else
                        {
                            List<Damage> enemyDMG = enemyUnit.simulateAttackSequence(random, thisUnit.minusHit, thisUnit.minusWound, thisUnit.minusAtk, t);
                            thisUnit.processDmg(random, enemyDMG, t);

                            List<Damage> personalDmg = thisUnit.simulateAttackSequence(random, enemyUnit.minusHit, enemyUnit.minusWound, enemyUnit.minusAtk, t);
                            enemyUnit.processDmg(random, personalDmg, t);
                        }
                    }

             
                    

                    List<Damage> enemyMortalKickback = new List<Damage> { new Damage(enemyUnit.MortalKickBackNumber) };
                    List<Damage> personalMortalKickback = new List<Damage> { new Damage(thisUnit.MortalKickBackNumber) };

                    int k;

                    if (enemyUnit.MortalKickBackNumber > 0)
                        k = 0;

                    if (thisUnit.models.Count > 0)
                        thisUnit.processDmg(random, enemyMortalKickback, t);
                    if (enemyUnit.models.Count > 0)
                        enemyUnit.processDmg(random, personalMortalKickback, t);


                    t++;

                    if(t > 8)
                        break;
                }
                thisCount += thisUnit.points / thisUnit.modelcount * thisUnit.models.Count;
                enemyCount += enemyUnit.points / enemyUnit.modelcount *enemyUnit.models.Count;
            }

            thisCount = thisCount / (rounds*points);
            enemyCount= enemyCount / (rounds*points);

            return new Tuple<string, double, string, double>(this.name, thisCount, enemy.name,enemyCount);
        }

    }
}
