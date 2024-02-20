namespace ChallengApp
{
    internal class EmployeeInMemory : EmployeeBase // IEmployee
    {
        private List<float> grades = new List<float>();
        public EmployeeInMemory(string name, string surname, char gender)
            : base(name, surname, gender)
        {

        }
        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new Exception("Invaid grade value");
            }
        }
        public float Result
        {
            get
            {
                return this.grades.Sum();
            }
        }
        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();

            statistics.NumberOfGrades = this.grades.Count;
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (float grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }

            statistics.Average = statistics.Average / this.grades.Count;

            switch (statistics.Average)
            {
                case var average when average >= 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;
            }
            return statistics;
        }
    }
}

