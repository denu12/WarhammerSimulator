﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarhammerSimulationFull
{
    internal class Simulator
    {

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

                for (int i = 0; i < 3* second.Count /   4; i++)
                {
                    var tester = second[i];
                    var outcome = u.simulateFight(second[i], 100, 2000);

                    u.secondaryVictoryScore += outcome.Item2 - outcome.Item4;
                    second[i].secondaryVictoryScore += outcome.Item4 - outcome.Item2;
                
                    if (outcome.Item2 - outcome.Item4 > 0.1)
                        u.victoryscore++;
                    else if (outcome.Item4 - outcome.Item2 < 0.1)
                    {
                        u.victoryscore += 0.5;
                    }
                    else
                    {
                        int k = 0;
                    }
                }


                u.secondaryVictoryScore = u.secondaryVictoryScore / ((double) second.Count);

                if (u.secondaryVictoryScore > 1)
                    Console.WriteLine("how");

                u.victoryscore = u.victoryscore / ((double) 3* second.Count / 4) * 100 ;
            }


            var output = first.OrderByDescending(x => (double) (x.victoryscore) + x.secondaryVictoryScore).ToList();

            for(int t = 0; t < output.Count; t++)
                Console.WriteLine("{0,-5} {1,-30}", t + 1, output[t].name);

        }
    }
}
