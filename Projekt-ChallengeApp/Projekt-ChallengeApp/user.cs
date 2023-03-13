using System.Runtime.CompilerServices;
using System.Threading.Tasks.Sources;

namespace Projekt_ChallengeApp
{
    public class Employee
    {
        private List<int> score = new List<int>();
        public Employee(string login, string password, int age)
        {
            this.Login = login;
            this.Password = password;
            this.Age = age;
        }

        public string Login { get; private set; }
        public string Password { get; private set; }
        public int Age { get; private set; }
        public int Result
        {
            get
            {
                return this.score.Sum();
            }
        }

        public void AddScore(int score)
        {
            this.score.Add(score);
        }
    }
}
