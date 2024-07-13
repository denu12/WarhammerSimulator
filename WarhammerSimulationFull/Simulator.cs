using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarhammerSimulationFull
{
    internal class Simulator
    {
        public static Boolean SIMULTANEOUS = true;

        public void Tournament(List<Unit> first, List<Unit> second)
        {
            foreach (Unit u in first)
                foreach (Unit v in second)
                {
                    if (u.name != v.name)
                    {
                        var outcome = u.simulateFight(v, 100, 1000);

                        if (outcome.Item2 >= outcome.Item4)
                            u.victoryscore++;
                        else
                            v.victoryscore++;
                    }
                }

            first = first.OrderByDescending(x => x.victoryscore).ToList();
            second = second.OrderByDescending(x => x.victoryscore).ToList();

            foreach (Unit u in first)
            {
              
                   



                u.victoryscore = 0;
                u.secondaryVictoryScore = 0;

                double N = 2* second.Count / 3;
                for (int i = 0; i < N; i++)
                {
                    var tester = second[i];
                    var outcome = u.simulateFight(second[i], 100, 2000);

                    u.secondaryVictoryScore += outcome.Item2 - outcome.Item4;
                    second[i].secondaryVictoryScore += outcome.Item4 - outcome.Item2;
                
                    if (outcome.Item2 - outcome.Item4 > 0.2)
                        u.victoryscore++;
                    else if (outcome.Item4 - outcome.Item2 < 0.2)
                    {
                        u.victoryscore += 0.5;
                    }
                    else
                    {
                        int k = 0;
                    }
                }


                u.secondaryVictoryScore = u.secondaryVictoryScore / N;

                u.victoryscore = u.victoryscore / (N) * 100 ;
            }


            var output = first.OrderByDescending(x => (double) (x.victoryscore)).ToList();

            for(int t = 0; t < output.Count; t++)
                Console.WriteLine("{0,-5} {1,-45}, {2, 10}", t + 1, output[t].name, (int) output[t].victoryscore);

        }
    }
}
