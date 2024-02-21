namespace ChallengApp
{
    public class EmployeeInFile : EmployeeBase
    {
        private List<float> grades = new List<float>();

        private const string FileName = "grades.txt";
        public EmployeeInFile(string name, string surname, char gender)
            : base(name, surname, gender)
        {
        }
        public override event GradeAddedDelegate GradeAdded;
        public override void AddGrade(float grade)
        {
            using (var writer = File.AppendText(FileName))
            {
                if (grade >= 0 && grade <= 100)
                {
                    writer.WriteLine(grade);
                    if (GradeAdded != null)
                    {
                        GradeAdded(this, new EventArgs());
                    }
                }
                else
                {
                    throw new Exception("Invaid grade value");
                }
            }
        }
        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();
            if (File.Exists(FileName))
            {
                using (var reader = File.OpenText(FileName))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = float.Parse(line);
                        this.grades.Add(number);
                        line = reader.ReadLine();
                    }
                }
            }
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
