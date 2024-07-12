using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarhammerSimulationFull
{
    internal class Chaos
    {

        public Unit SeekerChariot()
        {
            List<string> weapons = new List<string> { "4;3;4;1;1", "4;3;4;0;1"};
            var u =  new Unit("Seeker Chaoriot;1;120;6;4;6;", weapons);
            return u;
        }

        public Unit Hellstriders()
        {
            List<string> weapons = new List<string> { "3;3;4;1;1;charge", "2;3;4;0;1" };
            var u = new Unit("Hellstriders;5;150;3;5;7;", weapons);
            return u;
        }

        public Unit SlickbladeSeekers()
        {
            List<string> weapons = new List<string> { "3;3;4;1;1;charge", "3;3;4;0;1" };
            var u = new Unit("Slickblade Seekers;5;180;4;5;7;", weapons);
            return u;
        }



        public Unit Hellflayer()
        {
            List<string> weapons = new List<string> { "6;3;4;1;1", "4;3;4;0;1", "4;4;2;3;2" };
            var u = new Unit("Hellflayer;1;180;7;4;6;", weapons);
            return u;
        }

        public Unit Daemonettes()
        {
            List<string> weapons = new List<string> { "2;3;4;1;1;chargeAtk" };
            var u = new Unit("Daemonettes;10;110;1;6;6;", weapons);
            return u;
        }

        public Unit Fiends()
        {
            List<string> weapons = new List<string> { "4;4;3;1;2" };
            var u = new Unit("Fiends;3;150;4;5;6;", weapons);
            return u;
        }

        public Unit Seekers()
        {
            List<string> weapons = new List<string> { "3;3;4;1;1", "2;3;4;0;1" };
            var u = new Unit("Seekers;5;140;3;5;6;", weapons);
            return u;
        }

        public Unit SlaangorFiendbloods()
        {
            List<string> weapons = new List<string> { "4;4;3;1;2" };
            var u = new Unit("Slaangor Fiendbloods;3;140;3;5;7;", weapons);
            return u;
        }

        public Unit Painbringers()
        {
            List<string> weapons = new List<string> { "3;3;3;2;1" };
            var u = new Unit("Painbringers (rend);5;130;2;3;7;", weapons);
            return u;
        }

        public Unit Twinsouls()
        {
            List<string> weapons = new List<string> { "4;3;4;1;1" };
            var u = new Unit("Twinsouls (no charge);5;130;2;4;5;", weapons);
            u.minusAtk = 1;
            return u;
        }

        public Unit TwinsoulsCharge()
        {
            List<string> weapons = new List<string> { "4;3;4;1;1" };
            var u = new Unit("Twinsouls (charge);5;130;2;4;7;", weapons);
            return u;
        }

        public Unit Nurglings()
        {
            List<string> weapons = new List<string> { "5;5;5;0;1;wound" };
            var u = new Unit("Nurglings;3;110;4;6;5;", weapons);
            return u;
        }

        public Unit BeastsOfNurgle()
        {
            List<string> weapons = new List<string> { "5;4;3;1;2" };
            var u = new Unit("Beasts of Nurgle;1;150;8;5;5;", weapons);
            return u;
        }

        public Unit PlagueDrones()
        {
            List<string> weapons = new List<string> { "2;4;3;0;1;mortal", "6;4;3;0;1" };
            var u = new Unit("Plague Drones;3;180;5;5;5;", weapons);
            return u;
        }

        public Unit PlagueBearers()
        {
            List<string> weapons = new List<string> { "1;4;3;0;1;mortal"};
            var u = new Unit("Plague Bearers;10;140;2;6;5;", weapons);
            return u;
        }

        public Unit PlagueBearersMinusOne()
        {
            List<string> weapons = new List<string> { "1;4;3;0;1;mortal" };
            var u = new Unit("Plague Bearers (-1 toHit);10;140;2;6;5;", weapons);
            u.minusHit = 1;
            return u;
        }

        public Unit BlightKings()
        {
            List<string> weapons = new List<string> { "4;3;3;1;1" };
            var u = new Unit("Blightkings;5;200;3;3;5;", weapons);
            return u;
        }

        public Unit PusgoyleBlightlords()
        {
            List<string> weapons = new List<string> { "4;3;3;1;1;charge", "6;4;3;0;1"};
            var u = new Unit("Pusgoyle Blightlords;2;250;8;4;5;", weapons);
            return u;
        }

        public Unit PusgoyleBlightlordsRend()
        {
            List<string> weapons = new List<string> { "4;3;3;2;1;charge", "6;4;3;0;1" };
            var u = new Unit("Pusgoyle Blightlords (+1 rend);2;250;8;4;5;", weapons);
            return u;
        }

        public Unit BlightKingsExtraAtk()
        {
            List<string> weapons = new List<string> { "5;3;3;1;1" };
            var u = new Unit("Blightkings (+1 atk);5;200;3;3;5;", weapons);
            return u;
        }


        public Unit Screamers()
        {
            List<string> weapons = new List<string> { "3;4;3;1;1" };
            var u = new Unit("Screamers;3;100;3;5;6;", weapons);
            return u;
        }

        public Unit Tzaangors()
        {
            List<string> weapons = new List<string> { "2;4;3;1;1.5" };
            var u = new Unit("Tzaangors;10;150;2;5;7;", weapons);
            return u;
        }

        public Unit TzaangorEnlightened()
        {
            List<string> weapons = new List<string> { "2;4;3;1;2" };
            var u = new Unit("Tzaangor Enlightened;3;90;3;4;7;", weapons);
            return u;
        }

        public Unit TzaangorEnlightenedOnDisk()
        {
            List<string> weapons = new List<string> { "2;4;3;1;2", "2;4;3;1;2" };
            var u = new Unit("Tzaangor Enlightened on Disk;3;170;4;4;7;", weapons);
            return u;
        }

        public Unit FleshHounds()
        {
            List<string> weapons = new List<string> { "4;4;3;0;1" };
            var u = new Unit("Flesh Hounds;5;110;2;5;6;", weapons);
            return u;
        }

        public Unit BloodthirsterRage()
        {
            List<string> weapons = new List<string> { "5;3;2;3;5" };
            var u = new Unit("Bloodthirster (rage);1;470;16;4;5;", weapons);
            return u;
        }

        public Unit Bloodletters()
        {
            List<string> weapons = new List<string> { "2;3;3;1;1;mortal" };
            var u = new Unit("Bloodletters;10;200;2;5;6;", weapons);
            return u;
        }

        public Unit Bloodcrushers()
        {
            List<string> weapons = new List<string> { "2;3;3;2;1;mortal", "2;4;3;1;2" };
            var u = new Unit("Bloodcrushers;3;200;5;4;6;", weapons);
            return u;
        }


        public Unit MightySkullcrushers()
        {
            List<string> weapons = new List<string> { "3;3;3;1;1;charge", "2;4;3;1;2" };
            var u = new Unit("Mighty Skullcrushers;3;260;5;2;6;", weapons);
            return u;
        }


        public Unit Bloodreavers()
        {
            List<string> weapons = new List<string> { "2;4;3;0;1;anticharge"};
            var u = new Unit("Bloodreavers;10;100;1;6;7;", weapons);
            return u;
        }


        public Unit Skullreapers()
        {
            List<string> weapons = new List<string> { "4;4;3;1;2;mortal" };
            var u = new Unit("Skullreapers;5;220;3;4;7;", weapons);
            return u;
        }

        public Unit Wrathmongers()
        {
            List<string> weapons = new List<string> { "4;4;3;1;1;hit" };
            var u = new Unit("Wrathmongers;5;150;3;5;7;", weapons);
            return u;
        }


        public Unit Bloodwarriors()
        {
            List<string> weapons = new List<string> { "3;4;3;1;1" };
            var u = new Unit("Bloodwarriors;10;210;2;3;7;", weapons);
            return u;
        }


        public Unit Varanguard()
        {
            List<string> weapons = new List<string> { "3;3;3;2;2;mortal;charge", "3;4;3;1;1" };
            var u = new Unit("Varanguard (nurgle);3;310;5;3;7;", weapons);
            u.minusHit = 1;
            return u;
        }

        public Unit OgroidTheridons()
        {
            List<string> weapons = new List<string> { "4;4;2;2;2"};
            var u = new Unit("Ogroid Theridons (nurgle);3;200;5;4;7;", weapons);
            u.minusHit = 1;
            return u;
        }

        public Unit ChaosChariot()
        {
            List<string> weapons = new List<string> { "3;4;3;1;2", "2;4;4;0;1", "4;5;3;0;1" };
            var u = new Unit("Chaos Chariot (nurgle);1;110;7;4;7;", weapons);
            u.minusHit = 1;
            return u;
        }

        public Unit Chosen()
        {
            List<string> weapons = new List<string> { "3;3;3;1;2;mortal" };
            var u = new Unit("Chosen (nurgle);5;250;3;3;7;", weapons);
            u.minusHit = 1;
            return u;
        }

        public Unit ChosenWard()
        {
            List<string> weapons = new List<string> { "3;3;3;1;2;mortal" };
            var u = new Unit("Chosen (nurgle, 5+ward);5;250;3;3;5;", weapons);
            u.minusHit = 1;
            return u;
        }


        public Unit ChaosWarriors()
        {
            List<string> weapons = new List<string> { "2;3;3;1;1;wound" };
            var u = new Unit("Chaos Warriors (nurgle);10;200;2;3;7;", weapons);
            u.minusHit = 1;
            return u;
        }

        public Unit ChaosKnights()
        {
            List<string> weapons = new List<string> { "3;3;3;1;1;charge", "2;5;3;0;1" };
            var u = new Unit("Chaos Knights (nurgle);5;250;4;3;7;", weapons);
            u.minusHit = 1;
            return u;
        }

        public Unit ChaosKnightsWard()
        {
            List<string> weapons = new List<string> { "3;3;3;1;1;charge", "2;5;3;0;1" };
            var u = new Unit("Chaos Knights (nurgle, 5+ward);5;250;4;3;5;", weapons);
            u.minusHit = 1;
            return u;
        }

        public Unit ChaosWarriorsWard()
        {
            List<string> weapons = new List<string> { "2;3;3;1;1;wound" };
            var u = new Unit("Chaos Warriors (nurgle, 5+ward);10;200;2;3;5;", weapons);
            u.minusHit = 1;
            return u;
        }

        public Unit DarkOathMarauders()
        {
            List<string> weapons = new List<string> { "2;4;3;0;1" };
            var u = new Unit("Darkoath Marauders;10;100;1;5;7;", weapons);
            return u;
        }



        public Unit DarkOathSavages()
        {
            List<string> weapons = new List<string> { "2;4;3;0;1;mortal" };
            var u = new Unit("Darkoath Savages;10;130;1;5;7;", weapons);
            return u;
        }

        public Unit PlagueMonks()
        {
            List<string> weapons = new List<string> { "2;4;5;0;1" };
            var u = new Unit("Plague Monks;20;140;1;6;7;", weapons);
            return u;
        }

        public Unit Clanrats()
        {
            List<string> weapons = new List<string> { "2;4;5;0;1;wound" };
            var u = new Unit("Clanrats;20;160;1;5;7;", weapons);
            return u;
        }
        public Unit Stormvermin()
        {
            List<string> weapons = new List<string> { "3;3;4;1;1" };
            var u = new Unit("Stormvermin;10;140;1;4;7;", weapons);
            return u;
        }

        public Unit RatOgors()
        {
            List<string> weapons = new List<string> { "6;4;3;1;2" };
            var u = new Unit("Rat Ogors (+1 atk);3;170;4;5;7;", weapons);
            return u;
        }



        private List<Unit> Slaanesh()
        {
            List<Unit> l = new List<Unit> { SeekerChariot(), Hellflayer(), Daemonettes(), Fiends(), Seekers(), SlickbladeSeekers(), Hellstriders(), SlaangorFiendbloods(), Painbringers(), Twinsouls(), TwinsoulsCharge() };
            foreach (Unit u in l)
                u.faction = "Slaanesh";

            return l;
        }

        private List<Unit> Nurgle()
        {
            List<Unit> l = new List<Unit> { Nurglings(), BeastsOfNurgle(),PlagueDrones(), PlagueBearers(), PlagueBearersMinusOne(), BlightKings(), BlightKingsExtraAtk(), PusgoyleBlightlords(), PusgoyleBlightlordsRend() };
            foreach (Unit u in l)
                u.faction = "Nurgle";

            return l;
        }

        private List<Unit> Tzeentch()
        {
            List<Unit> l = new List<Unit> { Screamers(), Tzaangors(), TzaangorEnlightened(), TzaangorEnlightenedOnDisk() };
            foreach (Unit u in l)
                u.faction = "Tzeentch";

            return l;
        }
        private List<Unit> Khorne()
        {
            List<Unit> l = new List<Unit> { FleshHounds(), BloodthirsterRage(), Bloodcrushers(), Bloodletters(), Bloodreavers(), Skullreapers(), Wrathmongers(), Bloodwarriors(), MightySkullcrushers() };
            foreach (Unit u in l)
                u.faction = "Khorne";

            return l;
        }

        private List<Unit> Slaves()
        {
            List<Unit> l = new List<Unit> { Varanguard(), ChaosKnights(), ChaosKnightsWard(), OgroidTheridons(), ChaosChariot(), Chosen(), ChosenWard(), ChaosWarriors(), ChaosWarriorsWard(), DarkOathMarauders(), DarkOathSavages() };
            foreach (Unit u in l)
                u.faction = "Slaves to Darkness";

            return l;
        }

        private List<Unit> Skaven()
        {
            List<Unit> l = new List<Unit> { PlagueMonks(), Clanrats(), Stormvermin(), RatOgors() };
            foreach (Unit u in l)
                u.faction = "Skaven";

            return l;
        }

        public List<List<Unit>> ChaosList()
        {
            List<List<Unit>> l = new List<List<Unit>>();
            l.Add(Slaanesh());
            l.Add(Nurgle());
            l.Add(Tzeentch());
            l.Add(Khorne());
            l.Add(Slaves());
            l.Add(Skaven());
            return l;
        }
    }
}
