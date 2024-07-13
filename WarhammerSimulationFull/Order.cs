using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WarhammerSimulationFull
{
    internal class Order
    {
        public Order() { }
        public Unit Steelhelms() {
            List<string> weapons = new List<string> { "2;4;4;0;1"} ;
            var u = new Unit("Steelhelms;10;100;1;4;7;", weapons);
            return u;
        }

        public Unit FreeguildCavaliers()
        {
            List<string> weapons = new List<string> { "3;4;4;1;1;charge", "2;5;3;0;1" };
            var u = new Unit("Freeguild Cavaliers;5;170;3;3;7;", weapons);
            return u;
        }

        public Unit DrakespawnChariot()
        {
            List<string> weapons = new List<string> { "3;3;4;1;1;charge", "6;3;3;1;1" };
            var u = new Unit("Drakespawn Chariot;1;120;8;4;7;", weapons);
            return u;
        }

        public Unit DrakespawnKnights()
        {
            List<string> weapons = new List<string> { "2;3;4;1;1;charge", "4;4;3;1;1" };
            var u = new Unit("Drakespawn Knights;5;180;3;3;7;", weapons);
            return u;
        }

        public Unit Longbeards()
        {
            List<string> weapons = new List<string> { "2;3;4;1;1" };
            var u = new Unit("Longbeards;10;120;1;3;7;", weapons);
            return u;
        }

        public Unit Dreadspears()
        {
            List<string> weapons = new List<string> { "2;3;4;0;1;anticharge" };
            var u = new Unit("Dreadspears;10;110;1;4;7;", weapons);
            return u;
        }

        public Unit Hammerers()
        {
            List<string> weapons = new List<string> { "2;4;3;1;2" };
            var u = new Unit("Hammerers;10;150;1;3;7;", weapons);
            return u;
        }

        public Unit HammerersWithWard()
        {
            List<string> weapons = new List<string> { "2;4;3;1;2" };
            var u = new Unit("Hammerers (5+ward);10;150;1;3;5;", weapons);
            return u;
        }

        public Unit Ironbreakers()
        {
            List<string> weapons = new List<string> { "2;4;3;0;1" };
            var u = new Unit("Ironbreakers;10;130;1;3;7;", weapons);
            return u;
        }


        public Unit IronbreakersWithWard()
        {
            List<string> weapons = new List<string> { "2;4;3;0;1" };
            var u = new Unit("Ironbreakers (4+ward);10;130;1;3;4;", weapons);
            return u;
        }


        public Unit Liberators()
        {
            List<string> weapons = new List<string> { "2;3;3;1;1;mortal" };
            var u = new Unit("Liberators;5;120;2;3;7;", weapons);
            return u;
        }

        public Unit Vanquishers()
        {
            List<string> weapons = new List<string> { "2;3;3;2;2" };
            var u = new Unit("Vanquishers;5;110;2;3;7;", weapons);
            return u;
        }

        public Unit Vindictors()
        {
            List<string> weapons = new List<string> { "2;3;3;2;1;anticharge" };
            var u = new Unit("Vindictors;5;110;2;3;7;", weapons);
            return u;
        }

        public Unit Annihilators()
        {
            List<string> weapons = new List<string> { "3;3;3;1;2" };
            var u = new Unit("Annihilators (shields);3;180;3;2;7;", weapons);
            return u;
        }


        public Unit AnnihilatorsHammers()
        {
            List<string> weapons = new List<string> { "3;3;2;2;3" };
            var u = new Unit("Annihilators (hammers);3;220;3;3;7;", weapons);
            return u;
        }

        public Unit Grypthounds()
        {
            List<string> weapons = new List<string> { "4;4;4;0;1" };
            var u = new Unit("Gryph-hounds;6;80;2;6;7;", weapons);
            return u;
        }

        public Unit Concussors()
        {
            List<string> weapons = new List<string> { "3;3;2;1;2;mortal", "3;4;2;2;2" };
            var u = new Unit("Concussors;2;250;5;3;7;", weapons);
            u.MortalKickback = true;
            return u;
        }

        public Unit Desolators()
        {
            List<string> weapons = new List<string> { "4;3;3;2;2;", "3;4;2;2;2" };
            var u = new Unit("Desolators;2;230;5;3;7;", weapons);
            u.MortalKickback = true;
            return u;
        }

        public Unit Fulminators()
        {
            List<string> weapons = new List<string> { "3;3;3;1;2;charge", "3;4;2;2;2" };
            var u = new Unit("Fulminators;2;230;5;3;7;", weapons);
            u.MortalKickback = true;
            return u;
        }

        public Unit StormdrakeGuardLance()
        {
            List<string> weapons = new List<string> { "3;3;3;2;1;charge", "4;4;2;2;2" };
            var u = new Unit("Stormdrake Guard (lances);2;360;9;3;7;", weapons);
            u.MortalKickback = true;
            return u;
        }


        public Unit StormdrakeGuardSword()
        {
            List<string> weapons = new List<string> { "6;3;3;1;1", "4;4;2;2;2" };
            var u = new Unit("Stormdrake Guard (swords);2;360;9;3;7;", weapons);
            u.MortalKickback = true;
            return u;
        }


        public Unit StormstrikeChariot()
        {
            List<string> weapons = new List<string> { "3;3;3;1;1;charge", "2;3;2;2;1", "6;4;3;1;1" };
            var u = new Unit("Stormstrike Chariot;1;170;10;3;7;", weapons);
            return u;
        }

        public Unit Prosecutors()
        {
            List<string> weapons = new List<string> { "3;3;3;1;1;charge" };
            var u = new Unit("Prosecutors;3;140;2;3;7;", weapons);
            return u;
        }

        public Unit Praetors()
        {
            List<string> weapons = new List<string> { "3;3;3;1;2" };
            var u = new Unit("Praetors (5+ward);3;150;3;3;5;", weapons);
            return u;
        }

        public Unit Reclusians()
        {
            List<string> weapons = new List<string> { "3;3;3;1;2" };
            var u = new Unit("Reclusians;3;150;3;3;7;", weapons);
            return u;
        }

        public Unit Bleakswords()
        {
            List<string> weapons = new List<string> { "2;3;4;0;1;hit" };
            var u = new Unit("Bleakswords;10;100;1;4;7;", weapons);
            return u;
        }

        public Unit BlackGuard()
        {
            List<string> weapons = new List<string> { "2;3;4;1;1" };
            var u = new Unit("BlackGuard (ward);10;130;1;4;5;", weapons);
            return u;
        }


        public Unit Executioners()
        {
            List<string> weapons = new List<string> { "2;3;4;1;1;mortal" };
            var u = new Unit("Executioners;10;140;1;4;7;", weapons);
            return u;
        }


        public Unit Endrinriggers()
        {
            List<string> weapons = new List<string> { "3;4;3;2;2" };
            var u = new Unit("Endrinriggers;3;130;2;4;7;", weapons);
            return u;
        }

        public Unit Skywardens()
        {
            List<string> weapons = new List<string> { "2;3;3;1;2;mortal" };
            var u = new Unit("Skywardens;3;150;2;4;7;", weapons);
            return u;
        }

        public Unit RevenantSeekers()
        {
            List<string> weapons = new List<string> { "3;3;4;1;1;mortal", "3;4;3;1;1;charge" };
            var u = new Unit("Revenant Seekers (no healing);3;200;5;4;7;", weapons);
            return u;
        }

        public Unit SpiteriderLancers()
        {
            List<string> weapons = new List<string> { "3;3;4;1;1;charge", "3;4;3;1;1;charge" };
            var u = new Unit("Spiterider Lancers (no healing);3;210;5;4;7;", weapons);
            return u;
        }

        public Unit KurnothSwords()
        {
            List<string> weapons = new List<string> { "4;3;3;1;2;mortal" };
            var u = new Unit("Kurnoth Swords;3;220;5;4;7;", weapons);
            return u;
        }

        public Unit KurnothSwordsWard()
        {
            List<string> weapons = new List<string> { "4;3;3;1;2;mortal" };
            var u = new Unit("Kurnoth Swords (ward);3;220;5;4;6;", weapons);
            return u;
        }

        public Unit KurnothScythes()
        {
            List<string> weapons = new List<string> { "3;3;3;1;3;anticharge" };
            var u = new Unit("Kurnoth Scythes;3;200;5;4;7;", weapons);
            return u;
        }

        public Unit KurnothScythesWard()
        {
            List<string> weapons = new List<string> { "3;3;3;1;3;anticharge" };
            var u = new Unit("Kurnoth Scythes (ward);3;200;5;4;6;", weapons);
            return u;
        }


        public Unit Dryads()
        {
            List<string> weapons = new List<string> { "2;4;4;0;1" };
            Unit u = new Unit("Dryads;10;110;1;4;7;", weapons);
            return u;
        }

        public Unit DryadsWyldwood()
        {
            List<string> weapons = new List<string> { "2;4;4;0;1" };
            Unit u = new Unit("Dryads (wyldwood);10;110;1;4;7;", weapons);
            u.minusWound = 1;
            u.minusHit = 1;
            return u;
        }

        public Unit Treelord()
        {
            List<string> weapons = new List<string> { "5;4;2;1;2;anticharge", "2;4;2;2;3;mortal" };
            Unit u = new Unit("Treelord (-1 wound);1;260;14;3;7;", weapons);
            u.minusWound = 1;
            return u;
        }


        public Unit Durthu()
        {
            List<string> weapons = new List<string> { "4;2;2;2;5", "2;3;2;2;3;mortal" };
            Unit u = new Unit("Durthu (wyldwood);1;330;14;3;7;", weapons);
            return u;
        }


        public Unit TreeRevenants()
        {
            List<string> weapons = new List<string> { "2;3;4;1;1" };
            var u = new Unit("Tree Revenants;5;110;2;5;7;", weapons);
            return u;
        }

   

        public Unit SpiteRevenants()
        {
            List<string> weapons = new List<string> { "3;3;4;0;1;mortal" };
            var u = new Unit("Spite Revenants;5;110;2;5;7;", weapons);
            return u;
        }


        public Unit SistersOfSlaughter()
        {
            List<string> weapons = new List<string> { "3;3;4;1;1" };
            var u = new Unit("Sisters Of Slaughter (knives);10;130;1;6;6;", weapons);
            return u;
        }

        public Unit SistersOfSlaughterBuckler()
        {
            List<string> weapons = new List<string> { "2;3;4;1;1" };
            var u = new Unit("Sisters Of Slaughter (buckler);10;110;1;5;6;", weapons);
            u.minusHit = 1;
            u.MortalKickback = true;
            return u;
        }



        public Unit WitchElves()
        {
            List<string> weapons = new List<string> { "3;3;4;0;1;wound;chargeAtk" };
            var u = new Unit("Witch Aelves (pair);10;110;1;6;6;", weapons);
            u.MortalKickback = true;
            return u;
        }

        public Unit WitchElvesBuckler()
        {
            List<string> weapons = new List<string> { "2;3;4;0;1;wound" };
            var u = new Unit("Witch Aelves (buckler);10;110;1;5;6;", weapons);
            return u;
        }


        public Unit KhineraiLifetakers()
        {
            List<string> weapons = new List<string> { "2;3;4;1;1;wound" };
            var u = new Unit("Khinerai Lifetakers;5;100;2;5;6;", weapons);
            return u;
        }

        public Unit BloodSisters()
        {
            List<string> weapons = new List<string> { "2;3;4;1;2;mortal" };
            var u = new Unit("Blood Sisters;5;140;2;5;6;", weapons);
            return u;
        }

        public Unit BloodSistersPlusOne()
        {
            List<string> weapons = new List<string> { "3;3;4;1;2;mortal" };
            var u = new Unit("Blood Sisters (+1 atk);5;140;2;5;6;", weapons);
            return u;
        }

        public Unit NamartiThralls()
        {
            List<string> weapons = new List<string> { "2;3;4;2;1;" };
            var u = new Unit("Namarti Thralls;10;120;1;5;7;", weapons);
            return u;
        }

        public Unit MorsarrGuard()
        {
            List<string> weapons = new List<string> { "2;3;4;2;1;charge", "3;4;3;1;2" };
            var u = new Unit("Morsarr Guard;3;170;4;4;7;", weapons);
            return u;
        }

        public Unit IshlaenGuard()
        {
            List<string> weapons = new List<string> { "2;3;4;2;1", "3;4;3;1;2" };
            var u = new Unit("Ishlaen Guard (-1 atk);3;170;4;4;7;", weapons);
            u.wardFirstTurn = 5;
            u.minusAtk = 1;
            return u;
        }


        public Unit VanariWardens()
        {
            List<string> weapons = new List<string> { "2;3;4;0;1;mortal;anticharge" };
            var u = new Unit("Vanari Wardens (-1 hit);10;140;1;4;7;", weapons);
            u.minusHit = 1;
            return u;
        }

        public Unit VanariBladelords()
        {
            List<string> weapons = new List<string> { "3;3;4;2;1;mortal" };
            var u = new Unit("Vanari Bladelords (-1 hit);5;140;2;4;7;", weapons);
            u.minusHit = 1;
            return u;
        }

        public Unit VanariDawnriders()
        {
            List<string> weapons = new List<string> { "2;3;4;1;1;mortal;charge" };
            var u = new Unit("Vanari Dawnriders (-1 hit);5;210;3;3;7;", weapons);
            u.minusHit = 1;
            return u;
        }


        public Unit AlarithStoneGuard ()
        {
            List<string> weapons = new List<string> { "2;3;3;1;2;" };
            var u = new Unit("Alarith StoneGuard;5;130;2;4;7;", weapons);
            return u;
        }

        public Unit AlarithStoneGuardWared()
        {
            List<string> weapons = new List<string> { "2;3;3;1;2;" };
            var u = new Unit("Alarith StoneGuard (ward);5;130;2;4;5;", weapons);
            return u;
        }

        public Unit VulkiteBerzerkers()
        {
            List<string> weapons = new List<string> { "2;4;3;1;1;chargeAtk" };
            var u = new Unit("Vulkite Berzerkers;10;140;2;6;6;", weapons);
            return u;   
        }

        public Unit HearthguardBerzerkers()
        {
            List<string> weapons = new List<string> { "2;3;3;1;2;mortal" };
            var u = new Unit("Hearthguard Berzerkers (poleaxe);5;140;2;6;5;", weapons);
            return u;
        }

        public Unit HearthguardBerzerkersAxe()
        {
            List<string> weapons = new List<string> { "3;3;3;1;2" };
            var u = new Unit("Hearthguard Berzerkers (axe);5;120;2;6;5;", weapons);
            return u;
        }


        public Unit Saurus()
        {
            List<string> weapons = new List<string> { "2;3;3;1;1" };
            var u = new Unit("Saurus Warriors;10;170;2;4;7;", weapons);
            return u;
        }

        public Unit AggradonLancers()
        {
            List<string> weapons = new List<string> { "3;3;3;1;1;charge", "3;4;3;2;2" };
            var u = new Unit("Aggradon Lancers;3;210;5;4;7;", weapons);
            return u;
        }

        public Unit AggradonLancersPlusOne()
        {
            List<string> weapons = new List<string> { "3;3;3;1;1;charge", "4;4;3;2;2" };
            var u = new Unit("Aggradon Lancers (+1 rage);3;210;5;4;7;", weapons);
            return u;
        }

        public Unit AggradonLancersPlusTwo()
        {
            List<string> weapons = new List<string> { "3;3;3;1;1;charge", "5;4;3;2;2" };
            var u = new Unit("Aggradon Lancers (+2 rage);3;210;5;4;7;", weapons);
            return u;
        }


        public Unit BastilladonSotek()
        {
            List<string> weapons = new List<string> { "20;4;5;0;1;mortal", "3;3;3;1;2" };
            var u = new Unit("Bastiladon (ark);1;270;12;2;7;", weapons);
            return u;
        }

        public Unit BastilladonSotekHalf()
        {
            List<string> weapons = new List<string> { "20;4;5;0;1;mortal", "3;3;3;1;2" };
            var u = new Unit("Bastiladon (half);1;135;12;2;7;", weapons);
            return u;
        }

        public Unit Terrawings()
        {
            List<string> weapons = new List<string> { "3;4;4;0;1" };
            var u = new Unit("Terrawings;3;100;4;5;7;", weapons);
            return u;
        }


        public Unit RaptadonChargers()
        {
            List<string> weapons = new List<string> { "3;4;4;1;1;charge", "3;4;3;1;1" };
            var u = new Unit("Raptadon Chargers;5;140;3;5;7;", weapons);
            return u;
        }

        public Unit RaptadonChargersPlusOne()
        {
            List<string> weapons = new List<string> { "3;3;4;1;1;charge", "3;4;3;1;1" };
            var u = new Unit("Raptadon Chargers (+1 hit);5;140;3;5;7;", weapons);
            return u;
        }
        public Unit SaurusPlusSave()
        {
            List<string> weapons = new List<string> { "2;3;3;1;1" };
            var u = new Unit("Saurus Warriors (+1 save);10;170;2;3;7;", weapons);
            return u;
        }
        public Unit SaurusGuard()
        {
            List<string> weapons = new List<string> { "3;3;3;1;1" };
            var u = new Unit("Saurus Guard;5;110;2;3;7;", weapons);
            return u;
        }

        public Unit SaurusGuardWard()
        {
            List<string> weapons = new List<string> { "3;3;3;1;1" };
            var u = new Unit("Saurus Guard (5+ward);5;110;2;3;5;", weapons);
            return u;
        }

        public Unit Skinks()
        {
            List<string> weapons = new List<string> { "1;4;5;0;1" };
            var u = new Unit("Skinks;10;100;1;6;7;", weapons);

            return u;
        }


        public Unit Kroxigor()
        {
            List<string> weapons = new List<string> { "4;4;2;2;3" };
            var u = new Unit("Kroxigor;3;220;6;4;7;", weapons);
            return u;
        }


        private List<Unit> Cities()
        {
            List<Unit> l = new List<Unit> { Steelhelms(), Dreadspears(), FreeguildCavaliers(), DrakespawnChariot(), DrakespawnKnights(), Longbeards(), BlackGuard(), Hammerers(), HammerersWithWard(), Ironbreakers(), IronbreakersWithWard(), Bleakswords(), Executioners() };
            foreach (Unit u in l)
                u.faction = "Cities";

            return l;
        }

        private List<Unit> KO()
        {
            List<Unit> l = new List<Unit> { Endrinriggers(), Skywardens() };
            foreach (Unit u in l)
                u.faction = "KO";

            return l;
        }

        private List<Unit> Sylvaneth()
        {
            List<Unit> l = new List<Unit> { KurnothScythes(), KurnothSwords(), KurnothScythesWard(), KurnothSwordsWard(), Dryads(), SpiteRevenants(), RevenantSeekers(), SpiteriderLancers(), Treelord(), Durthu(), TreeRevenants(), DryadsWyldwood() };
            foreach (Unit u in l)
                u.faction = "Sylvaneth";

            return l;
        }


        private List<Unit> DoK()
        {
            List<Unit> l = new List<Unit> { SistersOfSlaughter(), WitchElves(), WitchElvesBuckler(), BloodSisters(), BloodSistersPlusOne(), KhineraiLifetakers(), SistersOfSlaughterBuckler() };
            foreach (Unit u in l)
                u.faction = "DoK";

            return l;
        }

        private List<Unit> Idoneth()
        {
            List<Unit> l = new List<Unit> { NamartiThralls(), MorsarrGuard(), IshlaenGuard() };
            foreach (Unit u in l)
                u.faction = "Idoneth";

            return l;
        }

        private List<Unit> Lumineth()
        {
            List<Unit> l = new List<Unit> { VanariWardens(), VanariBladelords(), VanariDawnriders(), AlarithStoneGuard(), AlarithStoneGuardWared() };
            foreach (Unit u in l)
                u.faction = "Lumineth";

            return l;
        }


        private List<Unit> Stormcast()
        {
            List<Unit> l = new List<Unit> { Vanquishers(), Vindictors(), Annihilators(), AnnihilatorsHammers(), StormdrakeGuardLance(), StormdrakeGuardSword(), StormstrikeChariot(),  Fulminators(), Prosecutors(), Grypthounds(), Concussors(), Desolators(), Praetors(), Reclusians(), Liberators() };
            foreach (Unit u in l)
                u.faction = "Stormcast";

            return l;
        }

        private List<Unit> Fyreslayers()
        {
            List<Unit> l = new List<Unit> { VulkiteBerzerkers(), HearthguardBerzerkers(), HearthguardBerzerkersAxe() };
            foreach (Unit u in l)
                u.faction = "Fyreslayers";

            return l;
        }

        private List<Unit> Seraphon()
        {
            List<Unit> l = new List<Unit> { Saurus(), SaurusGuard(), Skinks(),Kroxigor(), SaurusPlusSave(), SaurusGuardWard(), AggradonLancers(), AggradonLancersPlusOne(), AggradonLancersPlusTwo(), RaptadonChargers(), RaptadonChargersPlusOne(), BastilladonSotek(), Terrawings() };
            foreach (Unit u in l)
                u.faction = "Seraphon";

            return l;
        }



        public List<List<Unit>> OrderList()
        {
            List<List<Unit>> l = new List<List<Unit>>();
            l.Add(Cities());
            l.Add(KO());
            l.Add(Sylvaneth());
            l.Add(DoK());
            l.Add(Idoneth());
            l.Add(Lumineth());
            l.Add(Stormcast());
            l.Add(Fyreslayers());
            l.Add(Seraphon());
            return l;
        }
       
    }
    
}
