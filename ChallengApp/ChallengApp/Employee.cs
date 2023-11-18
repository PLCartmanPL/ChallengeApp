namespace ChallengApp
{
    public class Employee
    {
        private List<int> rating = new List<int>();
        public string Name { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }
        public int Result
        {
            get
            {
                return this.rating.Sum();
            }
        }
        public Employee(string name, string lastname, int age)
        {
            this.Name = name;
            this.LastName = lastname;
            this.Age = age;
        }

        public void AddScore(int number)
        {
            this.rating.Add(number);
        }

    }
}
