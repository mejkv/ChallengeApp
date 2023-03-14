//Program 
using Projekt_ChallengeApp;

var employee = new Employee("Michał", "Miszczyszyn");
employee.AddScore("a");
employee.AddScore("3333");
employee.AddScore(5);
employee.AddScore(9);
var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min:N2}");
Console.WriteLine($"Max: {statistics.Max:N2}");