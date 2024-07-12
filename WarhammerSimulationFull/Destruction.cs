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
            var u = new Unit("Marschcrawla Sloggoth;1;190;10;4;7;", weapons);
            return u;
        }

        public Unit HobgrotSlittaz()
        {
            List<string> weapons = new List<string> { "2;4;5;0;1" };
            var u = new Unit("Hobgrot Slittaz;10;100;1;6;7;", weapons);
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
            var u = new Unit("Gore Gruntaz;3;190;5;3;7;", weapons);
            return u;
        }

        public Unit GoreGruntazDMG()
        {
            List<string> weapons = new List<string> { "3;4;3;1;1", "4;4;2;0;2;charge" };
            var u = new Unit("Gore Gruntaz (+1 dmg);3;190;5;3;7;", weapons);
            return u;
        }

        public Unit WeirdBruteWrekkaz()
        {
            List<string> weapons = new List<string> { "6;4;3;1;1" };
            var u = new Unit("Weirdbrute Wrekkaz;3;130;3;5;7;", weapons);
            return u;
        }

        public Unit WeirdBruteWrekkazDMG()
        {
            List<string> weapons = new List<string> { "6;4;3;1;2" };
            var u = new Unit("Weirdbrute Wrekkaz (+1 dmg);3;130;3;5;7;", weapons);
            return u;
        }

        public Unit MawGruntaGougers()
        {
            List<string> weapons = new List<string> { "4;4;3;1;2", "5;4;2;2;2", "4;5;2;0;2" };
            var u = new Unit("Maw-Grunta Gougers;1;220;12;4;7;", weapons);
            return u;
        }

        public Unit MawGruntaGougersOne()
        {
            List<string> weapons = new List<string> { "4;4;3;1;2", "6;4;2;2;2", "4;5;2;0;2" };
            var u = new Unit("Maw-Grunta Gougers (1 momentum);1;220;12;4;7;", weapons);
            return u;
        }

        public Unit MawGruntaGougersTwo()
        {
            List<string> weapons = new List<string> { "4;4;3;1;2", "7;4;2;2;2", "4;5;2;0;2" };
            var u = new Unit("Maw-Grunta Gougers (2 momentum);1;220;12;4;7;", weapons);
            return u;
        }

        public Unit MawGruntaHakkinKrew()
        {
            List<string> weapons = new List<string> { "4;4;3;1;2", "4;4;3;1;1" ,"5;4;2;2;2", "4;5;2;0;2" };
            var u = new Unit("Maw-Grunta HakkinKrew;1;270;12;4;7;", weapons);
            return u;
        }

        public Unit MawGruntaHakkinKrewOne()
        {
            List<string> weapons = new List<string> { "4;4;3;1;2", "4;4;3;1;1", "6;4;2;2;2", "4;5;2;0;2" };
            var u = new Unit("Maw-Grunta HakkinKrew (1 momentum);1;270;12;4;7;", weapons);
            return u;
        }

        public Unit MawGruntaHakkinKrewTwo()
        {
            List<string> weapons = new List<string> { "4;4;3;1;2", "4;4;3;1;1", "7;4;2;2;2", "4;5;2;0;2" };
            var u = new Unit("Maw-Grunta HakkinKrew (2 momentum);1;270;12;4;7;", weapons);
            return u;
        }

     
        public Unit ManglerSquigs()
        {
            List<string> weapons = new List<string> { "4;4;5;0;1", "4;4;2;1;3.5", "4;4;4;0;2" };
            var u = new Unit("Mangler Squigs;1;220;14;5;7;", weapons);
            return u;
        }

        public Unit SneakySnufflers()
        {
            List<string> weapons = new List<string> { "3;4;4;0;1", "2;4;4;0;1" };
            var u = new Unit("Sneaky Snufflers;6;140;2;6;7;", weapons);
            return u;
        }

        public Unit SneakySnufflersWard()
        {
            List<string> weapons = new List<string> { "3;4;4;0;1", "2;4;4;0;1" };
            var u = new Unit("Sneaky Snufflers (5+ward);6;140;2;6;5;", weapons);
            return u;
        }

        public Unit SnarlfangRiders()
        {
            List<string> weapons = new List<string> { "2;4;5;0;1", "2;4;3;0;2" };
            var u = new Unit("Snarlfang Riders;5;130;2;5;7;", weapons);
            return u;
        }

        public Unit SporesplattaFanatics()
        {
            List<string> weapons = new List<string> { "2;3;4;1;2" };
            var u = new Unit("Sporesplatta Fanatics;5;120;1;6;7;", weapons);
            u.minusAtk = 1;
            return u;
        }

        public Unit MoonclanStabbas()
        {
            List<string> weapons = new List<string> { "2;4;5;0;1" };
            var u = new Unit("Moonclan Stabbas;20;140;1;5;7;", weapons);
            return u;
        }

        public Unit MoonclanStabbasMinusHit()
        {
            List<string> weapons = new List<string> { "2;4;5;0;1" };
            var u = new Unit("Moonclan Stabbas (-1 hit);20;140;1;5;7;", weapons);
            u.minusHit = 1;
            return u;
        }


        public Unit SquigHerd()
        {
            List<string> weapons = new List<string> { "2;4;3;0;1.2" };
            var u = new Unit("Squig Herd;12;100;1;6;7;", weapons);
            return u;
        }

        public Unit SquigHoppers()
        {
            List<string> weapons = new List<string> { "2;4;5;0;1", "3;4;3;1;1" };
            var u = new Unit("Squig Hoppers (no mortals);10;170;2;6;7;", weapons);
            return u;
        }

        public Unit BoingrotBounderz()
        {
            List<string> weapons = new  List<string> { "3;4;4;1;1;charge", "3;4;3;1;1" };
            var u = new Unit("Boingrot Bounderz;5;120;2;5;7;", weapons);
            return u;
        }

        public Unit DankholdTroggoth()
        {
            List<string> weapons = new List<string> { "4;4;2;2;5" };
            var u = new Unit("Dankhold Troggoth;1;180;10;4;7;", weapons);
            return u;
        }

        public Unit RockgutTroggoth()
        {
            List<string> weapons = new List<string> { "2;4;2;2;3" };
            var u = new Unit("Rockgut Troggoth;3;170;5;4;7;", weapons);
            return u;
        }

        public Unit SpiderRiders()
        {
            List<string> weapons = new List<string> { "2;4;5;0;1", "2;4;4;0;1;mortal" };
            var u = new Unit("Spider Riders;5;110;2;5;7;", weapons);
            return u;
        }

        public Unit ArachnarokSpider()
        {
            List<string> weapons = new List<string> { "10;4;5;0;1", "4;3;2;1;3;mortal", "8;4;2;1;1" };
            var u = new Unit("Arachnarok Spider (warparty);1;280;16;4;7;", weapons);
            return u;
        }

        public Unit SkitterstrandArachnarok()
        {
            List<string> weapons = new List<string> { "4;3;2;1;3;mortal", "8;4;2;1;1" };
            var u = new Unit("Skitterstrand Arachnarok;1;250;14;4;7;", weapons);
            return u;
        }

        public Unit BeastSmasher()
        {
            List<string> weapons = new List<string> { "4;4;2;2;5", "2;4;2;3;2", "1;4;2;2;3.5" };
            var u = new Unit("Beast Smasher;1;470;35;4;7;", weapons);
            return u;
        }

        public Unit BeastSmasherSave()
        {
            List<string> weapons = new List<string> { "4;4;2;2;5", "2;4;2;3;2", "1;4;2;2;3.5" };
            var u = new Unit("Beast Smasher (+1 save);1;470;35;3;7;", weapons);
            return u;
        }

        public Unit Gatebreaker()
        {
            List<string> weapons = new List<string> { "6;4;2;2;4", "2;4;2;3;2", "1;4;2;2;3.5", "1;4;1;6;14" };
            var u = new Unit("Gatebreaker;1;500;35;4;7;", weapons);
            return u;
        }

        public Unit GatebreakerSave()
        {
            List<string> weapons = new List<string> { "6;4;2;2;4", "2;4;2;3;2", "1;4;2;2;3.5", "1;4;1;6;14" };
            var u = new Unit("Gatebreaker (+1 save);1;500;35;3;7;", weapons);
            return u;
        }


        public Unit KrakenEater()
        {
            List<string> weapons = new List<string> { "4;4;2;2;4", "2;4;2;3;2", "1;4;2;2;3.5" };
            var u = new Unit("Kraken Eater (no stuff in bag);1;470;35;4;7;", weapons);
            return u;
        }

        public Unit KrakenEaterSave()
        {
            List<string> weapons = new List<string> { "4;4;2;2;4", "2;4;2;3;2", "1;4;2;2;3.5" };
            var u = new Unit("Kraken Eater (+1 save);1;470;35;3;7;", weapons);
            return u;
        }

        public Unit Warstomper()
        {
            List<string> weapons = new List<string> { "8;4;2;3;2", "2;4;2;3;2", "1;4;2;2;3.5"};
            var u = new Unit("Warstomper (+4 atk);1;460;35;4;7;", weapons);
            return u;
        }

        public Unit WarstomperSave()
        {
            List<string> weapons = new List<string> { "8;4;2;3;2", "2;4;2;3;2", "1;4;2;2;3.5" };
            var u = new Unit("Warstomper (+4 atk, +1 save);1;460;35;3;7;", weapons);
            return u;
        }

        public Unit MancrusherMob()
        {
            List<string> weapons = new List<string> { "4;4;2;1;2", "1;4;2;2;4", "1;4;2;2;2" };
            var u = new Unit("Mancrusher Mob;3;420;12;5;7;", weapons);
            return u;
        }

        public Unit OgorGluttons()
        {
            List<string> weapons = new List<string> { "4;4;2;1;2" };
            var u = new Unit("Ogor Gluttons;6;220;4;5;7;", weapons);
            return u;
        }

        public Unit Ironguts()
        {
            List<string> weapons = new List<string> { "3;4;2;2;3" };
            var u = new Unit("Ironguts;4;240;4;5;7;", weapons);
            return u;
        }

        public Unit IrongutsWard()
        {
            List<string> weapons = new List<string> { "3;4;2;2;3" };
            var u = new Unit("Ironguts (6+ward);4;240;4;5;6;", weapons);
            return u;
        }


        public Unit GorgerMawpack()
        {
            List<string> weapons = new List<string> { "5;4;2;2;2" };
            var u = new Unit("Gorger Mawpack;5;260;5;6;7;", weapons);
            return u;
        }

        public Unit Gnoblars()
        {
            List<string> weapons = new List<string> { "1;5;5;0;1" };
            var u = new Unit("Gnoblars;20;120;1;6;7;", weapons);
            return u;
        }

        public Unit FrostlordOnStonehorn()
        {
            List<string> weapons = new List<string> { "4;4;2;2;2;charge", "6;4;2;2;3;charge", "4;4;2;1;2" };
            var u = new Unit("Frostlord on Stonehorn (no wnd ign.);1;360;15;4;7;", weapons);
            return u;
        }


        public Unit FrostlordOnThundertusk()
        {
            List<string> weapons = new List<string> { "4;4;2;2;2;charge", "3;4;2;1;5" };
            var u = new Unit("Frostlord on Thundertusk;1;300;15;4;7;", weapons);
            return u;
        }


        public Unit FrostSabres()
        {
            List<string> weapons = new List<string> { "3;4;3;1;1" };
            var u = new Unit("Frost Sabres;2;70;3;6;7;", weapons);
            return u;
        }

        public Unit MournfangPack()
        {
            List<string> weapons = new List<string> { "3;4;2;1;2" , "4;4;2;1;2"};
            var u = new Unit("Mournfang Pack;2;200;6;4;7;", weapons);
            return u;
        }

        public Unit IcefallYhetees()
        {
            List<string> weapons = new List<string> { "3;4;3;1;2" };
            var u = new Unit("Icefall Yhetees;3;120;4;6;6;", weapons);
            return u;
        }


        private List<Unit> OgorMawtribes()
        {
            List<Unit> l = new List<Unit> { OgorGluttons(), Ironguts(), IrongutsWard(),GorgerMawpack(), Gnoblars(), FrostlordOnStonehorn(), FrostlordOnThundertusk(), FrostSabres(), MournfangPack(), IcefallYhetees() };
            foreach (Unit u in l)
                u.faction = "Ogor Mawtribes";

            return l;
        }


        private List<Unit> SonsOfBehemat()
        {
            List<Unit> l = new List<Unit> {  BeastSmasher(), Gatebreaker(), KrakenEater(), Warstomper(), MancrusherMob(), BeastSmasherSave(), GatebreakerSave(), KrakenEaterSave(), WarstomperSave()};
            foreach (Unit u in l)
                u.faction = "Sons of Behemat";

            return l;
        }

        private List<Unit> Gloomspite()
        {
            List<Unit> l = new List<Unit> { ManglerSquigs(), SneakySnufflers(), SneakySnufflersWard(), SnarlfangRiders(), MoonclanStabbas(), MoonclanStabbasMinusHit(), SquigHerd(), SquigHoppers(), BoingrotBounderz(), DankholdTroggoth(), RockgutTroggoth(), SpiderRiders(), ArachnarokSpider(), SkitterstrandArachnarok() };
            foreach (Unit u in l)
                u.faction = "Gloomspite";

            return l;
        }

        private List<Unit> Ironjawz()
        {
            List<Unit> l = new List<Unit> { Ardboyz(), GoreGruntaz(), WeirdBruteWrekkaz(), WeirdBruteWrekkazDMG(), MawGruntaGougers(), MawGruntaGougersOne(), MawGruntaGougersTwo(), MawGruntaHakkinKrew(), MawGruntaHakkinKrewOne(), MawGruntaHakkinKrewTwo()  };
            foreach (Unit u in l)
                u.faction = "Ironjawz";

            return l;
        }

        private List<Unit> Kruleboyz()
        {
            List<Unit> l = new List<Unit> { Gutrippaz(), GutrippazMinusHit(), MarschCrawlaSloggoth(), HobgrotSlittaz() };
            foreach (Unit u in l)
                u.faction = "Kruleboyz";

            return l;
        }


        public List<List<Unit>> DestructionList()
        {
            List<List<Unit>> l = new List<List<Unit>>();
            l.Add(Kruleboyz());
            l.Add(Ironjawz());
            l.Add(Gloomspite());
            l.Add(SonsOfBehemat());
            l.Add(OgorMawtribes());
            return l;
        }


    }
}
