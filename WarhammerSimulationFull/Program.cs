﻿// See https://aka.ms/new-console-template for more information
using WarhammerSimulationFull;

Console.WriteLine("Starting Tournament");


Random random = new Random();

Simulator sim = new Simulator();

Order order = new Order();
Chaos chaos = new Chaos();
Unit unit = chaos.Twinsouls();
Unit unit2 = order.Vanquishers();



Console.WriteLine(unit.simulateFight(unit2, 100, 1000));

//Console.WriteLine(unit2.simulateAverageDMG(random, 5000));


List<List<Unit>> orderUnits = order.OrderList();
List<List<Unit>> chaosUnits = chaos.ChaosList();

List<Unit> allUnits = new List<Unit>();
foreach (List<Unit> units in orderUnits)
    allUnits.AddRange(units);

foreach (List<Unit> units in chaosUnits)
    allUnits.AddRange(units);



Console.WriteLine(" ");

Console.WriteLine(" ");

Console.WriteLine(" ");

sim.Tournament(allUnits, allUnits);


Console.WriteLine(" ");

Console.WriteLine(" ");

Console.WriteLine(" ");



PrintResults(orderUnits);

PrintResults(chaosUnits);



Console.ReadLine();

static void PrintResults(List<List<Unit>> unitList)
{
    foreach (List<Unit> units in unitList)
    {
        Console.WriteLine(units[0].faction + ":");
        var output = units.OrderByDescending(x => x.victoryscore + x.secondaryVictoryScore).ToList();
        foreach (Unit u in output)
            Console.WriteLine("{0,-40} {1,30}", u.name + ";", (int)u.victoryscore);
        Console.WriteLine(" ");
    }
}