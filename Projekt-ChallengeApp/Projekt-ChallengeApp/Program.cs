//Program 
using Projekt_ChallengeApp;
using System;

Console.WriteLine("Witamy w Programie XYZ do oceny Pracowników");
Console.WriteLine("============================================");
Console.WriteLine();

var employee = new EmployeeInMemory("Michał", "");
var supervisor = new Supervisor();

while (true)
{

    Console.WriteLine("Podaj ocenę pracownika");
    var input = Console.ReadLine();
    Console.WriteLine("Podaj ocenę supervisora");
    var input1 = Console.ReadLine();
    if (input == "Q")
    {
        break;
    }

    try
    {
        employee.AddScore(input);
        supervisor.AddScore(input1);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception catched: {e.Message}");
    }
}

var statistics = employee.GetStatistics();
var statistics1 = supervisor.GetStatistics();
Console.WriteLine($"Average: {statistics.Average}");
Console.WriteLine($"Letter: {statistics.AverageLetter}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");

Console.WriteLine($"\nAverage: {statistics1.Average}");
Console.WriteLine($"Letter: {statistics1.AverageLetter}");
Console.WriteLine($"Min: {statistics1.Min}");
Console.WriteLine($"Max: {statistics1.Max}");