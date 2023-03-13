
namespace Projekt_ChallengeApp.Tests
{
    public class EmployeeTests
    {

        [Test]
        public void TestOfEmployeeStatistics()
        {
            var employee = new Employee("Jan", "Kowalski");
            employee.AddScore(10);
            employee.AddScore(9);
            employee.AddScore(8);
            var statistics = employee.GetStatistics();

            // assert - sprawdzenie warunków
            Assert.IsNotNull(statistics);
            Assert.That(statistics.Average, Is.Positive);
        }
    }
}