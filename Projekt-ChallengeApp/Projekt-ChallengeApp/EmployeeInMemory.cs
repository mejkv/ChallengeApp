namespace Projekt_ChallengeApp
{
    internal class EmployeeInMemory : EmployeeBase
    {

        public override event ScoreAddedDelegate ScoreAdded;

        private List<float> score = new List<float>();

        public EmployeeInMemory(string name, string surname) 
            : base(name, surname)
        {
        }

        public override void AddScore(float score)
        {
            if (score >= 0 && score <= 100)
            {
                this.score.Add(score);

                if(ScoreAdded != null)
                {
                    ScoreAdded(this, new EventArgs());
                }

            }
            else
            {
                throw new Exception("Invalid score value");
            }
        }

        public override void AddScore(double score)
        {
            var result = (float)score;
            this.AddScore(result);
        }

        public override void AddScore(int score)
        {
            var result = (float)score;
            this.AddScore(result);
        }

        public override void AddScore(char score)
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

        public override void AddScore(string score)
        {
            if (float.TryParse(score, out float result))
            {
                this.AddScore(result);
            }
            else
            {
                switch (score)
                {
                    case "A":
                    case "a":
                        this.AddScore(100);
                        break;
                    case "B":
                    case "b":
                        this.AddScore(80);
                        break;
                    case "C":
                    case "c":
                        this.AddScore(60);
                        break;
                    case "D":
                    case "d":
                        this.AddScore(40);
                        break;
                    case "E":
                    case "e":
                        this.AddScore(20);
                        break;
                    default:
                        throw new Exception("Invalid score value");
                }
            }
        }

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();
            
            foreach (var score in this.score) 
            {
                statistics.AddScore(score);
            }

            return statistics;
        }
    }
}
