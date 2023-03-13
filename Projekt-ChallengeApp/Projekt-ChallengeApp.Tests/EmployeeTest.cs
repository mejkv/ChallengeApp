
namespace Projekt_ChallengeApp.Tests
{
    public class EmployeeTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void WhenUserCollectScores_ShouldCorrectResult()
        {
            // arrange - przygotowanie 
            var user= new Employee("Adam", "asdqwe", 23);
            user.AddScore(1);
            user.AddScore(2);

            // acc - uruchomienie
            var result = user.Result;
            
            // asset - sprawdzenie warunków
            Assert.AreEqual(3, result);
        }
    }
}