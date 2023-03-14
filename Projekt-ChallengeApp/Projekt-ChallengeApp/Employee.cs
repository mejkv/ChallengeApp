using System.Runtime.CompilerServices;
using System.Threading.Tasks.Sources;
using static System.Formats.Asn1.AsnWriter;

namespace Projekt_ChallengeApp
{
    public class Employee
    {
        private List<float> score = new List<float>();
        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }
        
        public void AddScore(float score)
        {
            if (score >= 0 && score <= 100) 
            {
                this.score.Add(score);
            }
            else 
            {
                Console.WriteLine("Invalid score value");
            }
        }

        public void AddScore(string score)
        {
            if(float.TryParse(score, out float result))
            {
                this.AddScore(result);
            }
            else
            {
                Console.WriteLine("String in not float");
            }
        }

        public void AddScore(char score)
        {
            if (char.IsDigit(score))
            {
                this.AddScore(score);
            }
            else
            {
                Console.WriteLine($"Char {score} is not a digit");
            }
        }

        public void AddScore(double score)
        {
            var result = (float)score;
            this.AddScore(result);
        }

        public void AddScore(decimal score)
        {
            var result = (float)score;
            this.AddScore(result);
        }
        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            statistics.Average = 0;
            foreach (var score in this.score)
            {
                statistics.Min = Math.Min(statistics.Min, score);
                statistics.Max = Math.Max(statistics.Max, score);
                statistics.Average += score;
            }
            statistics.Average /= this.score.Count;
            return statistics;
        }
    }
}
