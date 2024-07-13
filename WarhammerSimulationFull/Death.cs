using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarhammerSimulationFull
{
    internal class Death
    {
        public Unit MortekGuard()
        {
            List<string> weapons = new List<string> { "2;3;4;0;1;hit;anticharge" };
            var u = new Unit("Mortek Guard;10;130;1;4;6;", weapons);
            return u;
        }

        public Unit MortekGuardEtherial()
        {
            List<string> weapons = new List<string> { "2;3;4;0;1;hit;anticharge" };
            var u = new Unit("Mortek Guard (etherial);10;130;1;4;6;", weapons);
            u.Etherial = true;
            return u;
        }


        public Unit ImmortisGuard()
        {
            List<string> weapons = new List<string> { "3;3;3;1;2;hit" };
            var u = new Unit("Immortis Guard;3;200;4;3;6;", weapons);
            return u;
        }

        public Unit NecropolisStalkers()
        {
            List<string> weapons = new List<string> { "4;3;3;3;1;hit" };
            var u = new Unit("Necropolis Stalkers (-1 hit);3;180;4;4;6;", weapons);
            u.minusHit = 1;
            return u;
        }

        public Unit KavalosDeathriders()
        {
            List<string> weapons = new List<string> { "3;3;4;1;1;hit;charge", "2;5;3;0;1" };
            var u = new Unit("Kavalos Deathriders;5;180;3;4;6;", weapons);
            return u;
        }

        public Unit GothizzarHarvester()
        {
            List<string> weapons = new List<string> { "6;4;2;2;2;hit", "4;4;3;1;2" };
            var u = new Unit("Gothizzar Harvester;1;230;10;4;6;", weapons);
            return u;
        }

        public Unit MorghastArchai()
        {
            List<string> weapons = new List<string> { "3;3;2;2;3;hit" };
            var u = new Unit("Morghast Archai;2;270;6;3;6;", weapons);
            return u;
        }

        public Unit MorghastHarbingers()
        {
            List<string> weapons = new List<string> { "3;3;2;2;3;hit" };
            var u = new Unit("Morghast Harbingers;2;270;6;4;6;", weapons);
            return u;
        }

        public Unit Vargskyr()
        {
            List<string> weapons = new List<string> { "4;4;2;1;2", "2;4;2;2;3" };
            var u = new Unit("Vargskyr;1;180;8;5;6;", weapons);
            return u;
        }


        public Unit KosargiNightguard()
        {
            List<string> weapons = new List<string> { "2;4;2;2;3" };
            var u = new Unit("Kosargi Nightguard (5+ ward);2;120;4;5;5;", weapons);
            return u;
        }


        public Unit BloodKnights()
        {
            List<string> weapons = new List<string> { "3;3;3;2;1;charge", "3;5;3;0;1" };
            var u = new Unit("Blood Knights;5;230;3;3;6;", weapons);
            return u;
        }

        public Unit Vargheists()
        {
            List<string> weapons = new List<string> { "3;4;3;1;2;hit" };
            var u = new Unit("Vargheists;3;160;4;5;6;", weapons);
            return u;
        }

        public Unit BlackKnights()
        {
            List<string> weapons = new List<string> { "3;4;3;1;1;charge;chargeMortal", "2;5;3;0;1" };
            var u = new Unit("Black Knights;5;160;3;4;6;", weapons);
            return u;
        }


        public Unit GraveGuard()
        {
            List<string> weapons = new List<string> { "2;3;3;1;1;mortal", };
            var u = new Unit("Grave Guard;10;150;1;4;6;", weapons);
            return u;
        }
        public Unit GraveGuardWard()
        {
            List<string> weapons = new List<string> { "2;3;3;1;1;mortal", };
            var u = new Unit("Grave Guard (5+ ward);10;150;1;4;5;", weapons);
            return u;
        }


        public Unit Direwolves()
        {
            List<string> weapons = new List<string> { "2;4;3;0;1", };
            var u = new Unit("Direwolves;10;140;2;5;6;", weapons);
            return u;
        }

        public Unit DeadwalkerZombies()
        {
            List<string> weapons = new List<string> { "1;5;4;0;1", };
            var u = new Unit("Deadwalker Zombies;20;150;1;6;6;", weapons);
            return u;
        }

        public Unit FellBats()
        {
            List<string> weapons = new List<string> { "2;4;4;0;2", };
            var u = new Unit("Fellbats;3;90;3;6;6;", weapons);
            return u;
        }

        public Unit DeathrattleSkeletons()
        {
            List<string> weapons = new List<string> { "2;4;4;0;1", };
            var u = new Unit("Deathrattle Skeletons (no recusion);10;100;1;5;6;", weapons);
            return u;
        }

        public Unit Chainrasps()
        {
            List<string> weapons = new List<string> { "2;4;5;0;1;wound", };
            var u = new Unit("Chainrasps;10;100;1;5;6;", weapons);
            u.Etherial = true;
            return u;
        }

        public Unit BlackCoach()
        {
            List<string> weapons = new List<string> { "5;3;3;2;2;wound", "6;4;4;0;1;wound", "8;5;3;0;1" };
            var u = new Unit("Black Coach;1;260;12;4;6;", weapons);
            u.Etherial = true;
            return u;
        }


        public Unit BladeGheistRevenants ()
        {
            List<string> weapons = new List<string> { "2;3;3;1;1;wound;chargeAtk", };
            var u = new Unit("Bladegheist Revenants;10;150;1;4;6;", weapons);
            u.Etherial = true;
            return u;
        }


        public Unit GlaveWraithStalkers()
        {
            List<string> weapons = new List<string> { "2;4;3;1;1;wound;charge", };
            var u = new Unit("Glavewraith Stalkers;4;80;1;4;6;", weapons);
            u.Etherial = true;
            return u;
        }
        public Unit MyrmournBanshees()
        {
            List<string> weapons = new List<string> { "2;4;3;2;2;wound", };
            var u = new Unit("Myrmourn Banshees;4;120;2;4;6;", weapons);
            u.Etherial = true;
            return u;
        }

        public Unit SpiritHosts()
        {
            List<string> weapons = new List<string> { "6;4;4;0;1;wound", };
            var u = new Unit("Spirit Hosts;3;130;3;4;6;", weapons);
            u.Etherial = true;
            return u;
        }


        public Unit DreadScytheHarridans()
        {
            List<string> weapons = new List<string> { "3;4;4;1;1;wound", };
            var u = new Unit("Dreadscythe Harridans;10;150;1;4;6;", weapons);
            u.Etherial = true;
            return u;
        }

        public Unit DreadScytheHarridansBuffed()
        {
            List<string> weapons = new List<string> { "3;3;3;1;1;wound", };
            var u = new Unit("Dreadscythe Harridans (+1 hit&wound);10;150;1;4;6;", weapons);
            u.Etherial = true;
            return u;
        }

        public Unit Hexwraiths()
        {
            List<string> weapons = new List<string> { "3;4;4;1;1;wound;charge", };
            var u = new Unit("Hexwraith;5;160;3;4;6;", weapons);
            u.Etherial = true;
            return u;
        }

        public Unit MorbhegKnights()
        {
            List<string> weapons = new List<string> { "2;3;4;1;1;charge", "3;4;3;1;2"};
            var u = new Unit("Morbheg Knights;3;170;4;4;6;", weapons);
            return u;
        }

        public Unit Cryptguard()
        {
            List<string> weapons = new List<string> { "3;4;4;1;1" };
            var u = new Unit("Cryptguard;10;120;1;6;6;", weapons);
            return u;
        }

        public Unit CryptguardWard()
        {
            List<string> weapons = new List<string> { "3;4;4;1;1" };
            var u = new Unit("Cryptguard (5+ ward);10;120;1;6;6;", weapons);
            return u;
        }

        public Unit VarghulfCourtier()
        {
            List<string> weapons = new List<string> { "7;4;3;2;2", "1;3;2;3;3" };
            var u = new Unit("Cryptguard (5+ ward);1;180;8;5;6;", weapons);
            return u;
        }

        public Unit CryptFlayers()
        {
            List<string> weapons = new List<string> { "4;4;3;1;1" };
            var u = new Unit("Crypt Flayers;3;170;4;5;6;", weapons);
            return u;
        }

        public Unit CryptHorrors()
        {
            List<string> weapons = new List<string> { "4;4;3;0;2;wound" };
            var u = new Unit("Crypt Horrors;3;150;4;5;6;", weapons);
            return u;
        }

        public Unit CryptHorrorsRend()
        {
            List<string> weapons = new List<string> { "4;4;3;1;2;wound" };
            var u = new Unit("Crypt Horrors (+1 rend);3;150;4;5;6;", weapons);
            return u;
        }
        public Unit CryptGhouls()
        {
            List<string> weapons = new List<string> { "2;4;4;0;1;wound" };
            var u = new Unit("Crypt Ghouls;20;170;1;6;6;", weapons);
            return u;
        }
        public Unit CryptGhoulsRend()
        {
            List<string> weapons = new List<string> { "2;4;4;1;1;wound" };
            var u = new Unit("Crypt Ghouls (+1 rend);20;170;1;6;6;", weapons);
            return u;
        }

        private List<Unit> FeC()
        {
            List<Unit> l = new List<Unit> { MorbhegKnights(), Cryptguard(), CryptguardWard(), VarghulfCourtier(), CryptFlayers(), CryptHorrors(), CryptHorrorsRend(), CryptGhouls(), CryptGhoulsRend()};
            foreach (Unit u in l)
                u.faction = "Flesh Eater Courts";

            return l;
        }

        private List<Unit> Nighthaunt()
        {
            List<Unit> l = new List<Unit> { Chainrasps(), BlackCoach(), BladeGheistRevenants(), GlaveWraithStalkers(), MyrmournBanshees(), SpiritHosts(), DreadScytheHarridans(), DreadScytheHarridansBuffed(), Hexwraiths() };
            foreach (Unit u in l)
                u.faction = "Nighthaunt";

            return l;
        }

        private List<Unit> Soulblight()
        {
            List<Unit> l = new List<Unit> { Vargskyr(), KosargiNightguard(), BloodKnights(), BlackKnights(), Vargheists(), GraveGuard(), GraveGuardWard(), Direwolves(), DeadwalkerZombies(), FellBats(), DeathrattleSkeletons()};
            foreach (Unit u in l)
                u.faction = "Soulblight Gravelords";

            return l;
        }

        private List<Unit> Bonereapers()
        {
            List<Unit> l = new List<Unit> { MortekGuard(), MortekGuardEtherial(), ImmortisGuard(), NecropolisStalkers(), KavalosDeathriders(), GothizzarHarvester(), MorghastArchai(), MorghastHarbingers()};
            foreach (Unit u in l)
                u.faction = "Ossiarch Bonereapers";

            return l;
        }


        public List<List<Unit>> DeathList()
        {
            List<List<Unit>> l = new List<List<Unit>>();
            l.Add(Bonereapers());
            l.Add(Soulblight());
            l.Add(Nighthaunt());
            l.Add(FeC());
            return l;
        }


    }
}
