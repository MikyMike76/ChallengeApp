

namespace ChallengeApp
{
    public class Statistics
    {
        public float Min { get; private set; }

        public float Max { get; private set; }

        public float Sum { get; private set; }

        public int Count { get; private set; }

        public float Average 
        { 
            get
            {
                return this.Sum / this.Count;
            }
        }

        public char AverageLetter { 
            get
            {
                switch (Average)
                {
                    case var A when Average == 100:
                        return 'A';
                    case var B when Average > 80:
                        return 'B';
                    case var C when Average > 60:
                        return 'C';
                    case var D when Average > 40:
                        return 'D';
                    case var E when Average > 20:
                        return 'E';
                    default:
                        return 'F';
                }
            }
        }

        public Statistics()
        {
            this.Count = 0;
            this.Sum = 0;
            this.Max = float.MinValue;
            this.Min = float.MaxValue;
        }

        public void AddGrade (float grade)
        {
            this.Count++;
            this.Sum += grade;
            this.Max = Math.Max(Max, grade);
            this.Min = Math.Min(Min, grade);
        }
}
}
