namespace ChallengApp
{
    public class EmployeeInMemory : EmployeeBase // IEmployee
    {
        private List<float> grades = new List<float>();
        public EmployeeInMemory(string name, string surname, char gender)
            : base(name, surname, gender)
        {
        }
        public override event  GradeAddedDelegate GradeAdded;
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
                throw new Exception("Invaid grade value");
            }
        }
        
        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();

            foreach (var grade in this.grades) 
            {
            statistics.AddGrade(grade);
            }
            
            return statistics;
        }
    }
}

