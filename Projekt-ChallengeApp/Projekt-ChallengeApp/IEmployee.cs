using static Projekt_ChallengeApp.EmployeeBase;

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

        event ScoreAddedDelegate ScoreAdded;

        Statistics GetStatistics();
    }
}
