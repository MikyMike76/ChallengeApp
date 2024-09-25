namespace ChallengeApp
{
    public class EmployeeInMemory : EmployeeBase
    {
        public override event GradeAddedDelegate GradeAdded;

        public List<float> grades = new List<float>();
        public EmployeeInMemory(string name, string surname) 
            : base(name, surname)
        {
        }

        public override void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float resultFloat))
            {
                this.AddGrade(resultFloat);
            }
            else if (char.TryParse(grade, out char resultChar))
            {
                switch (resultChar)
                {
                    case 'a':
                    case 'A':
                        this.AddGrade(100f);
                        break;
                    case 'b':
                    case 'B':
                        this.AddGrade(80f);
                        break;
                    case 'c':
                    case 'C':
                        this.AddGrade(60f);
                        break;
                    case 'd':
                    case 'D':
                        this.AddGrade(40f);
                        break;
                    case 'e':
                    case 'E':
                        this.AddGrade(20f);
                        break;
                    default:
                        throw new Exception("Incorrect grade name");
                }
            }
            else
            {
                throw new Exception("Incorrect valuable: only number or ABCDE-grade");
            }
        }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception("Invalid grade value");
            }
        }

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();
            
            foreach(var grade in this.grades)
            {
                statistics.AddGrade(grade);
            }

            return statistics;
        }
    }
}
