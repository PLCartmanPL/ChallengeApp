namespace ChallengApp
{
    public class Employee
    {

        private List<float> grades = new List<float>();

        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }

        public void AddGrade(float grade)
        {
            this.grades.Add(grade);
        }
        public float Result
        {
            get
            {
                return this.grades.Sum(); 
            }
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();

            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            //int start = -9999;
            //int makswynik = 0;
            //int minwynik = 0;
            //float sum = 0;
            foreach (int grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }


            statistics.Average = statistics.Average / this.grades.Count;

            return statistics;
        }
    }

}
