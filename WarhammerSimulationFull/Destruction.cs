using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarhammerSimulationFull
{
    internal class Destruction
    {

        public Unit Gutrippaz()
        {
            List<string> weapons = new List<string> { "3;4;3;0;1;mortal" };
            var u = new Unit("Gutrippaz;10;170;2;5;7;", weapons);
            return u;
        }

        public Unit GutrippazMinusHit()
        {
            List<string> weapons = new List<string> { "3;4;3;0;1;mortal" };
            var u = new Unit("Gutrippaz (-1 hit);10;170;2;5;7;", weapons);
            u.minusHit = 1;
            return u;
        }

        public Unit MarschCrawlaSloggoth()
        {
            List<string> weapons = new List<string> { "4;4;5;0;1", "6;4;2;1;2" };
            var u = new Unit("MarschCrawlaSloggoth;1;190;10;4;7;", weapons);
            return u;
        }

        public Unit HobgrotSlittaz()
        {
            List<string> weapons = new List<string> { "2;4;5;0;1" };
            var u = new Unit("HobgrotSlittaz;10;100;1;6;7;", weapons);
            return u;
        }

        public Unit Brutes()
        {
            List<string> weapons = new List<string> { "3;4;3;2;2" };
            var u = new Unit("Brutes;5;200;3;3;7;", weapons);
            return u;
        }

        public Unit BrutesDmg()
        {
            List<string> weapons = new List<string> { "3;4;3;2;3" };
            var u = new Unit("Brutes (+1 dmg);5;200;3;3;7;", weapons);
            return u;
        }

        public Unit Ardboyz()
        {
            List<string> weapons = new List<string> { "2;4;3;1;1;anticharge", "1;7;7;0;1;mortal" };
            var u = new Unit("Ardboyz;10;180;2;3;7;", weapons);
            return u;
        }


        public Unit ArdboyzDMG()
        {
            List<string> weapons = new List<string> { "2;4;3;1;2;anticharge", "1;7;7;0;1;mortal" };
            var u = new Unit("Ardboyz (+1 dmg);10;180;2;3;7;", weapons);
            return u;
        }
        public Unit GoreGruntaz()
        {
            List<string> weapons = new List<string> { "3;4;3;1;1", "4;4;2;0;1;charge" };
            var u = new Unit("GoreGruntaz;3;190;5;3;7;", weapons);
            return u;
        }

        public Unit GoreGruntazDMG()
        {
            List<string> weapons = new List<string> { "3;4;3;1;1", "4;4;2;0;2;charge" };
            var u = new Unit("GoreGruntaz (+1 dmg);3;190;5;3;7;", weapons);
            return u;
        }

        public Unit WeirdBruteWrekkaz()
        {
            List<string> weapons = new List<string> { "6;4;3;1;1" };
            var u = new Unit("WeirdBruteWrekkaz;3;130;3;5;7;", weapons);
            return u;
        }

        public Unit WeirdBruteWrekkazDMG()
        {
            List<string> weapons = new List<string> { "6;4;3;1;2" };
            var u = new Unit("WeirdBruteWrekkaz (+1 dmg);3;130;3;5;7;", weapons);
            return u;
        }

        public Unit MawGruntaGougers()
        {
            List<string> weapons = new List<string> { "4;4;3;1;2", "5;4;2;2;2", "4;5;2;0;2" };
            var u = new Unit("MawGruntaGougers;1;220;12;4;7;", weapons);
            return u;
        }

        public Unit MawGruntaGougersOne()
        {
            List<string> weapons = new List<string> { "4;4;3;1;2", "6;4;2;2;2", "4;5;2;0;2" };
            var u = new Unit("MawGruntaGougers (1 momentum);1;220;12;4;7;", weapons);
            return u;
        }

        public Unit MawGruntaGougersTwo()
        {
            List<string> weapons = new List<string> { "4;4;3;1;2", "7;4;2;2;2", "4;5;2;0;2" };
            var u = new Unit("MawGruntaGougers (2 momentum);1;220;12;4;7;", weapons);
            return u;
        }

        public Unit MawGruntaHakkinKrew()
        {
            List<string> weapons = new List<string> { "4;4;3;1;2", "4;4;3;1;1" ,"5;4;2;2;2", "4;5;2;0;2" };
            var u = new Unit("MawGruntaHakkinKrew;1;270;12;4;7;", weapons);
            return u;
        }

        public Unit MawGruntaHakkinKrewOne()
        {
            List<string> weapons = new List<string> { "4;4;3;1;2", "4;4;3;1;1", "6;4;2;2;2", "4;5;2;0;2" };
            var u = new Unit("MawGruntaHakkinKrew (1 momentum);1;270;12;4;7;", weapons);
            return u;
        }

        public Unit MawGruntaHakkinKrewTwo()
        {
            List<string> weapons = new List<string> { "4;4;3;1;2", "4;4;3;1;1", "7;4;2;2;2", "4;5;2;0;2" };
            var u = new Unit("MawGruntaHakkinKrew (2 momentum);1;270;12;4;7;", weapons);
            return u;
        }

        private List<Unit> Kruleboyz()
        {
            List<Unit> l = new List<Unit> { Gutrippaz(), GutrippazMinusHit(), MarschCrawlaSloggoth(), HobgrotSlittaz() };
            foreach (Unit u in l)
                u.faction = "Kruleboyz";

            return l;
        }

        public Unit ManglerSquigs()
        {
            List<string> weapons = new List<string> { "4;4;5;0;1", "4;4;2;1;3.5", "4;4;4;0;2" };
            var u = new Unit("ManglerSquigs;1;220;14;5;7;", weapons);
            return u;
        }

        public Unit SneakySnufflers()
        {
            List<string> weapons = new List<string> { "3;4;4;0;1", "2;4;4;0;1" };
            var u = new Unit("SneakySnufflers;6;140;2;6;7;", weapons);
            return u;
        }

        public Unit SneakySnufflersWard()
        {
            List<string> weapons = new List<string> { "3;4;4;0;1", "2;4;4;0;1" };
            var u = new Unit("SneakySnufflers (5+ward);6;140;2;6;7;", weapons);
            return u;
        }




        private List<Unit> Ironjawz()
        {
            List<Unit> l = new List<Unit> { Ardboyz(), ArdboyzDMG(), GoreGruntaz(), GoreGruntazDMG(), WeirdBruteWrekkaz(), WeirdBruteWrekkazDMG(), MawGruntaGougers(), MawGruntaGougersOne(), MawGruntaGougersTwo(), MawGruntaHakkinKrew(), MawGruntaHakkinKrewOne(), MawGruntaHakkinKrewTwo()  };
            foreach (Unit u in l)
                u.faction = "Ironjawz";

            return l;
        }


        public List<List<Unit>> DestructionList()
        {
            List<List<Unit>> l = new List<List<Unit>>();
            l.Add(Kruleboyz());
            l.Add(Ironjawz());
            return l;
        }


    }
}
