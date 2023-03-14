//Program 
using Projekt_ChallengeApp;

Console.WriteLine("Witamy w Programie XYZ do oceny Pracowników");
Console.WriteLine("============================================");
Console.WriteLine();

var employee = new Employee("", "");


while (true)
{

    Console.WriteLine("Podaj ocenę pracownika");
    var input = Console.ReadLine();
    if (input == "Q")
    {
        break;
    }

    try
    {
        employee.AddScore(input);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception catched: {e.Message}");
        //throw new Exception("invalid score value");
    }
}



var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");