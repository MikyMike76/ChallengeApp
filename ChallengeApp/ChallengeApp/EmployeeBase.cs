namespace ChallengeApp
{
    public abstract class EmployeeBase : IEmployee
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }

        protected EmployeeBase(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
        public abstract void AddGrade(string grade);

        public abstract void AddGrade(float grade);
        public abstract Statistics GetStatistics();
    }
}
