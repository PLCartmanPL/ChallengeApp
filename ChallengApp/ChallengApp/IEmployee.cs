namespace ChallengApp
{
    public interface IEmployee
    {
        public string Name { get; }
        public string Surname { get; }
        public char Gender { get; }
        void AddGrade(float grade);
        void AddGrade(char grade);
        void AddGrade(string grade);
        void AddGrade(double grade);
        void AddGrade(int grade);
        Statistics GetStatistics();
    }
}
