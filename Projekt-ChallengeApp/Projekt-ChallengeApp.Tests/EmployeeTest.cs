
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

            // assert
            Assert.IsNotNull(statistics);
            Assert.That(statistics.Average, Is.Positive);
        }

        [Test]
        public void WhenGetStatisticsCalled_ShouldReturnCorrectMax()
        {
            var employee = new Employee("Jan", "Kowalski");
            employee.AddScore(10);
            employee.AddScore(9);
            employee.AddScore(8);
            var statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual(10, statistics.Max);
        }

        [Test]
        public void WhenGetStatisticsCalled_ShouldReturnCorrectMin()

        {
            var employee = new Employee("Jan", "Kowalski");
            employee.AddScore(10);
            employee.AddScore(9);
            employee.AddScore(8);
            var statistics = employee.GetStatistics();

            // assert
            
            Assert.AreEqual(8, statistics.Min);
        }

        [Test]
        public void WhenGetStatisticsCalled_ShouldReturnCorrectAverage()
        {
            var employee = new Employee("Jan", "Kowalski");
            employee.AddScore(10);
            employee.AddScore(9);
            employee.AddScore(8);
            var statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual(Math.Round(3.33, 2), Math.Round(statistics.Average, 2));
        }
    }
}