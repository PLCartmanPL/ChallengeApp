
using ChallengApp;

namespace ChallengeApp.test
{
    public class EmployeeTests
    {


        [Test]
        public void GetStatisticsReturnsValueMax()
        {
            // arrange
            var employee1 = new Employee("Paweł", "Naglik");
            employee1.AddGrade(12);
            employee1.AddGrade(10);
            employee1.AddGrade(22);

            //act
            var statistics = employee1.GetStatistics();


            // assert
            Assert.AreEqual(22, statistics.Max);
        }
        [Test]
        public void GetStatisticsReturnsValueMin()
        {
            // arrange
            var employee1 = new Employee("Paweł", "Naglik");
            employee1.AddGrade(12);
            employee1.AddGrade(10);
            employee1.AddGrade(22);

            //act
            var statistics = employee1.GetStatistics();


            // assert
            Assert.AreEqual(10, statistics.Min);
        }
        [Test]
        public void GetStatisticsReturnsValueAverage()
        {
            // arrange
            var employee1 = new Employee("Paweł", "Naglik");
            employee1.AddGrade(15);
            employee1.AddGrade(25);
            employee1.AddGrade(23);

            //act
            var statistics = employee1.GetStatistics();


            // assert
            Assert.AreEqual(21, statistics.Average);
        }
    }
}


