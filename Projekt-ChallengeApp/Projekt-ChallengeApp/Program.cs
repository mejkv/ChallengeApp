//Program 
using Projekt_ChallengeApp;

Employee user1 = new Employee("michał","1234", 23);
Employee user2 = new Employee("mikołaj", "1234", 18);
Employee user3 = new Employee("marek", "1234", 22);

List<Employee> employees = new List<Employee>() { user1, user2, user3 };

for (int i = 0; i < 5; i++)
{
    user1.AddScore(i+5);
	user2.AddScore(i+2);
	user3.AddScore(i+4);
}

int bestresultd = 0;
Employee best = null;	

foreach (Employee employee in employees)
{
	if (employee.Result > bestresultd)
	{
		best = employee;
		bestresultd = employee.Result;
	}
}

Console.WriteLine("Najlepszy wynik ma: {0} i wynosi: {1}", best.Login, bestresultd);