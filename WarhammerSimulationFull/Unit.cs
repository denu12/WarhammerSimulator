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
        public double pointsPerModel;
        public double totalPoints;
        public double victoryscore;
        public double secondaryVictoryScore;
        public int minusWound, minusHit, minusAtk;
        public string faction = "";


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
            this.pointsPerModel = points / modelcount;

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


       public List<Damage> simulateAttackSequence(Random random, int MinusHit = 0, int Minuswound = 0, int minusAtk = 0)
        {
            List<Damage> result = new List<Damage>();
            foreach(Model model in models)
            {
                foreach (Damage d in model.simulateAttackSequence(random, MinusHit, Minuswound, minusAtk))
                    result.Add(d);
            }

            return result;
        }


       public double simulateAverageDMG(Random random, double rounds)
        {
            List<Damage> damages = new List<Damage>();
            foreach (Model m in models)
            {
                foreach (Damage d in m.simulateRoundsDmg(random, rounds))
                    damages.Add(d);
            }

            Unit dummy = new Unit("dummy", 100000, 300, new Model(1, 4, 7, null));

            double result =  dummy.computeDamageTaken(random, damages) / rounds;
            return result;
        }

        public double computeDamageTaken(Random random, List<Damage> damages)
        {
            int damageTaken = 0;
            foreach (Damage d in damages)
            {

                for (int i = 0; i < d.damage; i++)
                {
                    int saveroll = random.Next(6) + 1;
                    if (saveroll < this.models[0].save + d.rend)
                        damageTaken++;
                }

                damageTaken += (int) d.mortal;
            }

            double finaldamagetaken = 0;
            for(int i = 0; i < damageTaken; ++i)
            {
                int wardRoll = random.Next(6) + 1;
                if(wardRoll < this.models[0].ward)
                    finaldamagetaken++;
            }

            return finaldamagetaken;
        }

        public void processDmg(Random random, List<Damage> damages)
        {
            int damageTaken= (int) this.computeDamageTaken(random, damages);
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
                thisUnit.pointsPerModel = this.pointsPerModel;
                thisUnit.minusHit = this.minusHit;
                thisUnit.minusWound = this.minusWound;
                thisUnit.minusAtk = this.minusAtk;
               
                while(thisUnit.totalPoints + thisUnit.pointsPerModel< points)
                {
                    thisUnit.totalPoints += thisUnit.pointsPerModel;
                    thisUnit.models.Add(models.First().copy());
                }

                Unit enemyUnit = new Unit();
                enemyUnit.name = enemy.name;
                enemyUnit.pointsPerModel = enemy.pointsPerModel;
                enemyUnit.minusHit = enemy.minusHit;
                enemyUnit.minusWound = enemy.minusWound;
                enemyUnit.minusAtk = enemy.minusAtk;

                while (enemyUnit.totalPoints + enemy.pointsPerModel < points)
                {
                    enemyUnit.totalPoints += enemy.pointsPerModel;
                    enemyUnit.models.Add(enemy.models.First().copy());
                }

                while (thisUnit.models.Count > 0 && enemyUnit.models.Count > 0)
                {

                    List<Damage> personalDmg = thisUnit.simulateAttackSequence(random, enemyUnit.minusHit, enemyUnit.minusWound, enemyUnit.minusAtk);
                    List<Damage> enemyDMG = enemyUnit.simulateAttackSequence(random, thisUnit.minusHit, thisUnit.minusWound, thisUnit.minusAtk);

                    thisUnit.processDmg(random, enemyDMG);
                    enemyUnit.processDmg(random, personalDmg);
                }
                thisCount += thisUnit.pointsPerModel* thisUnit.models.Count;
                enemyCount += enemyUnit.pointsPerModel*enemyUnit.models.Count;
            }

            thisCount = thisCount / (rounds*points);
            enemyCount= enemyCount / (rounds*points);

            return new Tuple<string, double, string, double>(this.name, thisCount, enemy.name,enemyCount);
        }

    }
}
