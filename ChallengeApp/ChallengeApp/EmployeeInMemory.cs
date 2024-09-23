namespace ChallengeApp
{
    public class EmployeeInMemory : EmployeeBase
    {
        private List<float> grades = new List<float>();
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
            }
            else
            {
                throw new Exception("Invalid grade value");
            }
        }

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            foreach (var grade in this.grades)
            {
                statistics.Average += grade;
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
            }
            statistics.Average /= this.grades.Count;
            switch (statistics.Average)
            {
                case var A when statistics.Average == 100:
                    statistics.AverageLetter = 'A';
                    break;
                case var B when statistics.Average > 80:
                    statistics.AverageLetter = 'B';
                    break;
                case var C when statistics.Average > 60:
                    statistics.AverageLetter = 'C';
                    break;
                case var D when statistics.Average > 40:
                    statistics.AverageLetter = 'D';
                    break;
                case var E when statistics.Average > 20:
                    statistics.AverageLetter = 'E';
                    break;
                default:
                    statistics.AverageLetter = 'F';
                    break;
            }
            return statistics;
        }
    }
}
