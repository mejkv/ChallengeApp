﻿namespace Projekt_ChallengeApp
{
    public abstract class EmployeeBase : IEmployee
    {
        public EmployeeBase(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
        public string Name { get; private set; }

        public string Surname { get; private set; }

        public abstract void AddScore(float score);

        public abstract void AddScore(double score);


        public abstract void AddScore(int score);

        public abstract void AddScore(char score);

        public abstract void AddScore(string score);

        public abstract Statistics GetStatistics();
    }
}
