namespace Projekt_ChallengeApp
{
    internal class Supervisor : IEmployee
    {
        private List<float> scores = new List<float>();

        public string Name => "Michał";

        public string Surname => "";

        public void AddScore(float score)
        {
            if (score >= 0 && score <= 100)
            {
                this.scores.Add(score);
            }
            else
            {
                throw new Exception("Invalid score value");
            }
        }

        public void AddScore(double score)
        {
            var result = (float)score;
            this.AddScore(result);
        }

        public void AddScore(int score)
        {
            float result = score;
            this.AddScore(result);
        }

        public void AddScore(char score)
        {
            switch (score)
            {
                case 'A':
                case 'a':
                    this.scores.Add(100);
                    break;
                case 'B':
                case 'b':
                    this.scores.Add(80);
                    break;
                case 'C':
                case 'c':
                    this.scores.Add(60);
                    break;
                case 'D':
                case 'd':
                    this.scores.Add(40);
                    break;
                case 'E':
                case 'e':
                    this.scores.Add(20);
                    break;
                default:
                    throw new Exception("Invalid score value");
            }
        }

        public void AddScore(string score)
        {
            var input = score switch
            {
                "1" => 0,
                "+1" or "1+" => 5,
                "-2" or "2-" => 15,
                "2" => 20,
                "+2" or "2+" => 25,
                "-3" or "3-" => 35,
                "3" => 40,
                "+3" or "3+" => 45,
                "-4" or "4-" => 55,
                "4" => 60,
                "+4" or "4+" => 65,
                "-5" or "5-" => 75,
                "5" => 80,
                "+5" or "5+" => 85,
                "-6" or "6-" => 95,
                "6" => 100,
                _ when float.TryParse(score, out var value) => value,
                _ => throw new Exception("Wrong value")
            };
            {
                this.AddScore(input);
            }
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            statistics.Average = 0;
            statistics.Sum = 0;

            foreach (var score in this.scores)
            {
                statistics.Min = Math.Min(statistics.Min, score);
                statistics.Max = Math.Max(statistics.Max, score);
                statistics.Average += score;
                statistics.Sum += score;
            }

            statistics.Average /= this.scores.Count;

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
