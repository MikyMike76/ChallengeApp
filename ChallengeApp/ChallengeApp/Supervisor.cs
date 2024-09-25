
//using System.ComponentModel;

//namespace ChallengeApp
//{
//    public class Supervisor : IEmployee
//    {
//        public string Name { get; private set; }
//        public string Surname { get; private set; }

//        private List<float> grades = new List<float>();
//        public Supervisor(string name, string surname)
//        {
//            this.Name = name;
//            this.Surname = surname;
//        }
//        public void AddGrade(float grade)
//        {
//            if (grade >= 0 && grade <= 100)
//            {
//                this.grades.Add(grade);
//            }
//            else
//            {
//                throw new Exception("Invalid grade value");
//            }
//        }
//        public void AddGrade(string grade)
//        {
//            if (float.TryParse(grade, out float floatResult))
//            {
//                this.AddGrade(floatResult);
//            }
//            else
//            {
//                switch (grade)
//                {
//                    case "F":
//                    case "f":
//                        this.AddGrade(0f);
//                        break;

//                    case "F+":
//                    case "f+":
//                    case "+F":
//                    case "+f":
//                        this.AddGrade(5f);
//                        break;

//                    case "E-":
//                    case "e-":
//                    case "-E":
//                    case "-e":
//                        this.AddGrade(15f);
//                        break;

//                    case "E":
//                    case "e":
//                        this.AddGrade(20f);
//                        break;

//                    case "E+":
//                    case "e+":
//                    case "+E":
//                    case "+e":
//                        this.AddGrade(25f);
//                        break;

//                    case "D-":
//                    case "d-":
//                    case "-D":
//                    case "-d":
//                        this.AddGrade(35f);
//                        break;

//                    case "D":
//                    case "d":
//                        this.AddGrade(40f);
//                        break;

//                    case "D+":
//                    case "d+":
//                    case "+D":
//                    case "+d":
//                        this.AddGrade(45f);
//                        break;

//                    case "C-":
//                    case "c-":
//                    case "-C":
//                    case "-c":
//                        this.AddGrade(55f);
//                        break;

//                    case "C":
//                    case "c":
//                        this.AddGrade(60f);
//                        break;

//                    case "C+":
//                    case "c+":
//                    case "+C":
//                    case "+c":
//                        this.AddGrade(65f);
//                        break;

//                    case "B-":
//                    case "b-":
//                    case "-B":
//                    case "-b":
//                        this.AddGrade(75f);
//                        break;

//                    case "B":
//                    case "b":
//                        this.AddGrade(80f);
//                        break;

//                    case "B+":
//                    case "b+":
//                    case "+B":
//                    case "+b":
//                        this.AddGrade(85f);
//                        break;

//                    case "A-":
//                    case "a-":
//                    case "-A":
//                    case "-a":
//                        this.AddGrade(95f);
//                        break;

//                    case "A":
//                    case "a":
//                        this.AddGrade(100f);
//                        break;

//                    default:
//                        throw new Exception("Wrong grade name: use ABCDEF system");
//                }
//            }
//        }
//        public Statistics GetStatistics()
//        {
//            var statistics = new Statistics();

//            statistics.Average = 0;
//            statistics.Max = float.MinValue;
//            statistics.Min = float.MaxValue;

//            foreach (var grade in this.grades)
//            {
//                statistics.Average += grade;
//                statistics.Max = Math.Max(statistics.Max, grade);
//                statistics.Min = Math.Min(statistics.Min, grade);
//            }

//            statistics.Average /= this.grades.Count;

//            switch (statistics.Average)
//            {
//                case var A when statistics.Average == 100:
//                    statistics.AverageLetter = 'A';
//                    break;
//                case var B when statistics.Average > 80:
//                    statistics.AverageLetter = 'B';
//                    break;
//                case var C when statistics.Average > 60:
//                    statistics.AverageLetter = 'C';
//                    break;
//                case var D when statistics.Average > 40:
//                    statistics.AverageLetter = 'D';
//                    break;
//                case var E when statistics.Average > 20:
//                    statistics.AverageLetter = 'E';
//                    break;
//                default:
//                    statistics.AverageLetter = 'F';
//                    break;
//            }
//            return statistics;
//        }
//    }
//}
