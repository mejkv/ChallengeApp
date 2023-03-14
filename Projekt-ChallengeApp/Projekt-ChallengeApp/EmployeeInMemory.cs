namespace Projekt_ChallengeApp
{
    internal class EmployeeInMemory : EmployeeBase
    {
        public EmployeeInMemory(string name, string surname) 
            : base(name, surname)
        {
        }

        public override void AddScore(float score)
        {
            throw new NotImplementedException();
        }

        public override void AddScore(double score)
        {
            throw new NotImplementedException();
        }

        public override void AddScore(int score)
        {
            throw new NotImplementedException();
        }

        public override void AddScore(char score)
        {
            throw new NotImplementedException();
        }

        public override void AddScore(string score)
        {
            throw new NotImplementedException();
        }

        public override Statistics GetStatistics()
        {
            throw new NotImplementedException();
        }
    }
}
