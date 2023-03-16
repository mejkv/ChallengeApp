//Program 
using Projekt_ChallengeApp;
using System;
using System.Threading.Channels;

Console.WriteLine("Witamy w Programie XYZ do oceny Pracowników");
Console.WriteLine("============================================");
Console.WriteLine("1. Dodaj pracownika");
Console.WriteLine("2. Dodaj Ocenę");
Console.WriteLine("3. Pokaż statystyki pracownika");
Console.WriteLine("4. Wyjście");
Console.WriteLine("============================================");

var employee = new EmployeeInFile("Michał", "");

void EmployeeGradeAdded(object sender, EventArgs  args)
{
    Console.WriteLine("Dodano nową ocenę");
}

while (true)
{
    Console.WriteLine("(Wybierz opcje(1/2/3/4))");
    int opcja = int.Parse(Console.ReadLine());
    switch (opcja)
    {
        case 1:
            AddingEmployee();
            break; 
        case 2:
            AddingScore();
            break;
        case 3:
            ShowStats();
            break;
        case 4:
            Environment.Exit(0);
            break;
    }
    
}
void AddingScore()
{
    Console.WriteLine("Podaj ocenę pracownika");
    var input = Console.ReadLine();
    try
    {
        employee.AddScore(input);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception catched: {e.Message}");
    }
}

void AddingEmployee()
{
    Console.Write("Name: ");
    string empName = Console.ReadLine();
    Console.Write("Surname: ");
    string empSurname = Console.ReadLine();
    var employee = new EmployeeInMemory(empName, empSurname);
}

void ShowStats()
{
    var statistics = employee.GetStatistics();
    Console.WriteLine($"\nName and Surname: {employee.Name} {employee.Surname}");
    Console.WriteLine($"Average: {statistics.Average}");
    Console.WriteLine($"Letter: {statistics.AverageLetter}");
    Console.WriteLine($"Min: {statistics.Min}");
    Console.WriteLine($"Max: {statistics.Max}");
}


