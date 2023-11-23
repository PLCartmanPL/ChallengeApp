namespace ChallengApp
{
    public class Employee
    {

        private List<float> grades = new List<float>();
        public Employee(string name)
        {
            this.Name = name;
        }

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
                return this.grades.Sum(); //wewnętrzna logika
            }
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();

            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            int start = -9999;
            int makswynik = 0;
            int minwynik = 0;
            float sum = 0;
            foreach (int maks in this.grades)
            {
                if (maks > start)
                {
                    start = maks;
                    makswynik = maks;

                }


                //statistics.Max = Math.Max(statistics.Max, grade);
                //statistics.Min = Math.Min(statistics.Min, grade);
                //statistics.Average += grade;
            }
            foreach (int min in this.grades)
            {
                if (min < start)
                {
                    start = min;
                    minwynik = min;

                }


                //statistics.Max = Math.Max(statistics.Max, grade);
                //statistics.Min = Math.Min(statistics.Min, grade);
                //statistics.Average += grade;
            }

            foreach (int suma in this.grades)
            {
                sum += suma;

                //statistics.Max = Math.Max(statistics.Max, grade);
                //statistics.Min = Math.Min(statistics.Min, grade);
                //statistics.Average += grade;
            }
            float srednia = sum / this.grades.Count;
            Console.WriteLine(makswynik.ToString());
            Console.WriteLine(minwynik.ToString());
            Console.WriteLine(sum.ToString());
            Console.WriteLine($"Średnia {srednia:N2}");

            //foreach (var grade in this.grades)
            //{
            //  statistics.Max = Math.Max(statistics.Max, grade);
            //statistics.Min = Math.Min(statistics.Min, grade);
            //statistics.Average += grade;
            //}

            statistics.Average = statistics.Average / this.grades.Count;

            return statistics;
        }
    }

}
