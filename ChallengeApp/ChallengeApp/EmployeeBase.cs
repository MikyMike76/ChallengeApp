namespace ChallengeApp
{
    public abstract class EmployeeBase : IEmployee
    {
        public delegate void GradeAddedDelegate(object sender, EventArgs args);

        public abstract event GradeAddedDelegate GradeAdded;
        public string Name { get; private set; }
        public string Surname { get; private set; }
        void EmployeeGradeAdded(object sender, EventArgs args)
        {
            Console.WriteLine("Dodano nową ocenę!");
        }

        public EmployeeBase(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
            this.GradeAdded += EmployeeGradeAdded;
        }
        public abstract void AddGrade(string grade);

        public abstract void AddGrade(float grade);
        public abstract Statistics GetStatistics();
    }
}
