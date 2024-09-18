

namespace ChallengeApp
{
    public class Employee
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }
        public int Score { get; private set; }

        public Employee (string name)
        {
            this.Name = name;
        }
        public Employee (string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
            this.Score = 0;
        }

        public void AddScore (int score)
        {
            this.Score += score;
        }

        


        


    }
}
