namespace Projekt_ChallengeApp
{
    public interface IEmployee
    {
        string Name { get; }
        string Surname { get; }

        void AddScore(float score);

        void AddScore(double score);

        void AddScore(int score);

        void AddScore(char score);

        void AddScore(string score);

        Statistics GetStatistics();
    }
}
