namespace Projekt_ChallengeApp
{
    public abstract class Person
    {
        protected Person(string name, string surname)
            :this(name, surname, "  ")
        {
            this.Name = name;
            this.Surname = surname;
        }
        protected Person(string name, string surname, string sex)
        {
            this.Name = name;
            this.Surname = surname;
            this.Sex = sex;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Sex { get; private set; }
    }
}

