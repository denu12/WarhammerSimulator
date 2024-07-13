using WarhammerSimulationFull;

Console.WriteLine("Starting Tournament");


Random random = new Random();

Simulator sim = new Simulator();

Order order = new Order();
Chaos chaos = new Chaos();
Death death = new Death();
Destruction destruction = new Destruction();
Unit unit = order.Treelord();
Unit unit2 = order.Steelhelms();



Console.WriteLine(unit.simulateAverageDMG(random, 1000, 0));

Console.WriteLine(unit.simulateAverageDMG(random, 1000, 1, true));

Console.WriteLine(unit.simulateFight(unit2, 100, 1000));

//Console.WriteLine(unit2.simulateAverageDMG(random, 5000));


List<List<Unit>> orderUnits = order.OrderList();
List<List<Unit>> chaosUnits = chaos.ChaosList();
List<List<Unit>> deathUnits = death.DeathList();
List<List<Unit>> destructionUnits = destruction.DestructionList();

List<Unit> allUnits = new List<Unit>();
foreach (List<Unit> units in orderUnits)
     allUnits.AddRange(units);

foreach (List<Unit> units in chaosUnits)
      allUnits.AddRange(units);

foreach (List<Unit> units in deathUnits)
     allUnits.AddRange(units);


foreach (List<Unit> units in destructionUnits)
     allUnits.AddRange(units);

Console.WriteLine(" ");

unit.name = "Treelord (only 150 pts)";
unit.points = 150;


sim.computeVictoryScore(allUnits, unit, allUnits.Count());

Console.WriteLine(unit.name + " score against everyone: " + (int) unit.victoryscore);

Console.WriteLine(" ");

Console.WriteLine(" ");

sim.Tournament(allUnits, allUnits);


Console.WriteLine(" ");

Console.WriteLine(" ");

Console.WriteLine(" ");



PrintResults(orderUnits);

PrintResults(chaosUnits);

PrintResults(deathUnits);

PrintResults(destructionUnits);



Console.ReadLine();

static void PrintResults(List<List<Unit>> unitList)
{
    Console.WriteLine(" ");
    foreach (List<Unit> units in unitList)
    {
        Console.WriteLine(units[0].faction + ":");
        Console.WriteLine("---------------------------------------------------------");
        

        var output = units.OrderByDescending(x => x.victoryscore).ToList();
        foreach (Unit u in output)
            Console.WriteLine("{0,-35} {1,15}", u.name, (int)u.victoryscore);
        Console.WriteLine(" ");
    }
}