namespace ChallengeApp
{
    internal class EmployeeInFile : EmployeeBase
    {
        public override event GradeAddedDelegate GradeAdded;
        private List<float> grades = new List<float>();

        public EmployeeInFile(string name, string surname)
            : base(name, surname)
        {
        }

        private const string fileName = "grades.txt";

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
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(grade);
                }
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
            if (File.Exists($"{fileName}"))
            {
                using (var reader = File.OpenText($"{fileName}"))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var grade = float.Parse(line);
                        grades.Add(grade);
                        line = reader.ReadLine();
                    }
                }
                foreach (var grade in this.grades)
                {
                    statistics.AddGrade(grade);
                }
            }
            return statistics;
        }
    }
}
