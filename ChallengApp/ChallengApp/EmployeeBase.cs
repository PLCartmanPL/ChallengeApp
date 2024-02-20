namespace ChallengApp
{
    public abstract class EmployeeBase : IEmployee
    {
        public EmployeeBase(string name, string surname, char gender)
        {
            this.Name = name;
            this.Surname = surname;
            this.Gender = gender;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }
        public char Gender { get; private set; }

        public abstract void AddGrade(float grade);

        public void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.AddGrade(100);
                    break;
                case 'B':
                case 'b':
                    this.AddGrade(80);
                    break;
                case 'C':
                case 'c':
                    this.AddGrade(60);
                    break;
                case 'D':
                case 'd':
                    this.AddGrade(40);
                    break;
                case 'E':
                case 'e':
                    this.AddGrade(20);
                    break;
                default:
                    throw new Exception("Wrong Letter");
            }
        }

        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }

            else if (char.TryParse(grade, out char resultChar))
            {
                this.AddGrade(resultChar);
            }
            else
            {
                throw new Exception("Grade is not a numer");
            }
        }

        public void AddGrade(double grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }
        public void AddGrade(int grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }

        public abstract Statistics GetStatistics();

    }
}
