
using System.Threading.Tasks.Sources;

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
        public void GetStatisticsMin_ShouldReturnMinValue()
        {
            var employee = new Employee("Jan", "Kowalski");
            employee.AddScore(10);
            employee.AddScore(9);
            employee.AddScore(8);

            var statistics = employee.GetStatistics();

            Assert.AreEqual(8, statistics.Min);
        }

        [Test]
        public void GetStatisticsMax_ShouldReturnMaxValue()
        {
            var employee = new Employee("Jan", "Kowalski");
            employee.AddScore(10);
            employee.AddScore(9);
            employee.AddScore(8);

            var result = employee.GetStatistics();

            Assert.AreEqual(10, result.Max);
        }

        [Test]
        public void GetStatisticsAverage_ShouldReturnAverageValue()
        {
            var employee = new Employee("Jan", "Kowalski");
            employee.AddScore(10);
            employee.AddScore(9);
            employee.AddScore(8);

            var result = employee.GetStatistics();

            Assert.AreEqual(9, result.Average);
        }

        [Test]
        public void GetStatisticsWithStringOrChar_ShouldReturnScore()
        {
            var employee = new Employee("Jan", "Kowalski");
            employee.AddScore('a');
            employee.AddScore('B');
            employee.AddScore('c');

            var result = employee.GetStatistics();

            Assert.AreEqual(80, result.Average);
        }

        [Test]
        public void GetStatisticsSum_ShouldReturnCorrectSum()
        {
            var employee = new Employee("Jan", "Kowalski");
            employee.AddScore("a");
            employee.AddScore("B");
            employee.AddScore("c");
            employee.AddScore("27");
            employee.AddScore("6.2f");
            employee.AddScore("5.3f");
            employee.AddScore("13.77");

            var result = employee.GetStatistics();

            Assert.AreEqual(40.77f, result.Sum);
        }

        [Test]
        public void GetStatisticsAveverageLetter_ShouldReturnLetterForCorrectAverage()
        {
            var employee = new Employee("Jan", "Kowalski");
            employee.AddScore('a');
            employee.AddScore('B');
            employee.AddScore('c');
            employee.AddScore("27");
            employee.AddScore("6.2f");
            employee.AddScore("5.3f");
            employee.AddScore("13.77");

            var result = employee.GetStatistics();

            Assert.AreEqual('C', result.AverageLetter);
        }
    }
}