using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_ChallengeApp
{
    internal class EmployeeInFile : EmployeeBase
    {
        private const string fileName = "scores.txt";
        public EmployeeInFile(string name, string surname) 
            : base(name, surname)
        {
        }

        public override void AddScore(float score)
        {
            using (var writer = File.AppendText(fileName))
            {
                writer.WriteLine(score);
            }
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
            var result = new Statistics();

            if (File.Exists(fileName))
            {
                using (var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = float.Parse(line);
                        result.
    
                }
                }
            }
        }
    }
}
