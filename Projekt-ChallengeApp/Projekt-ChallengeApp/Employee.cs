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
                throw new Exception("Invalid score value");
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
                throw new Exception("Invalid score value");
            }
        }

        public void AddScore(char score)
        {
            switch (score)
            {
                case 'A':
                case 'a':
                    this.AddScore(100);
                    break;
                case 'B':
                case 'b':
                    this.AddScore(80);
                    break;
                case 'C':
                case 'c':
                    this.AddScore(60);
                    break;
                case 'D':
                case 'd':
                    this.AddScore(40);
                    break;
                case 'E':
                case 'e':
                    this.AddScore(20);
                    break;
                default:
                    throw new Exception("Invalid score value");
            }
        }

        public void AddScore(double score)
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
            statistics.Sum = 0;

            foreach (var score in this.score)
            {
                statistics.Min = Math.Min(statistics.Min, score);
                statistics.Max = Math.Max(statistics.Max, score);
                statistics.Average += score;
                statistics.Sum += score;
            }

            statistics.Average /= this.score.Count;

            switch (statistics.Average)
            {
                case var average when average >= 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;
            }

            return statistics;
        }
    }
}
