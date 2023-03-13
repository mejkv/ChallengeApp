namespace Projekt_ChallengeApp
{
    public class TypeTest
    {
        [Test]
        public void WhenReference_ShouldReturnFalse()
        {
            // arrange - przygotowanie 
            var user1 = GetEmployee("Adam");
            var user2 = GetEmployee("Michał");

            // acc - uruchomienie


            // asset - sprawdzenie warunków
            Assert.AreNotEqual(user1, user2);
        }

        [Test]
        public void WhenFloatValues_ShouldReturnEqual()
        {
            // arrange - przygotowanie 
            float num1 = 3.14f;
            float num2 = 3.14f;

            // acc - uruchomienie


            // asset - sprawdzenie warunków
            Assert.AreEqual(num1, num2);
        }

        [Test]
        public void WhenIntValues_ShouldReturnNotEqual()
        {
            // arrange - przygotowanie 
            int num1 = 21;
            int num2 = 23;

            // acc - uruchomienie


            // asset - sprawdzenie warunków
            Assert.AreNotEqual(num1, num2);
        }

        private Employee GetEmployee(string name)
        {
            return new Employee(name);
        }
    }
}