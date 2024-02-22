
using ChallengApp;

namespace ChallengeApp.test
{
    public class EmployeeTests
    {


        [Test]
        public void GetStatisticsReturnsValueMax()
        {
            // arrange
            var employee1 = new EmployeeInMemory("Paweł", "Naglik", 'M');
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
            var employee1 = new EmployeeInFile("Paweł", "Naglik", 'M');
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
            var employee1 = new EmployeeInMemory("Paweł", "Naglik", 'M');
            employee1.AddGrade(2);
            employee1.AddGrade(2);
            employee1.AddGrade(6);

            //act
            var statistics = employee1.GetStatistics();


            // assert
            Assert.AreEqual(Math.Round(3.33, 2), Math.Round(statistics.Average, 2));
        }
        [Test]
        public void GradeInLetterReturnsNumber()
        {
            // arrange
            var employee1 = new EmployeeInMemory("Paweł", "Naglik", 'M');
            employee1.AddGrade("a");
            employee1.AddGrade('A');

            //act
            var statistics = employee1.GetStatistics();


            // assert
            Assert.AreEqual(100, statistics.Average);
        }

        [Test]
        public void GradeInNumerReturnsLetter()
        {
            string filePath = "grades.txt";

                using (var fileStream = new FileStream(filePath, FileMode.OpenOrCreate))
                {
                    fileStream.SetLength(0);
                }
            
    // arrange
    var employee1 = new EmployeeInFile("Paweł", "Naglik", 'M');
            employee1.AddGrade("100");
            employee1.AddGrade(50);

            //act
            var statistics = employee1.GetStatistics();


            // assert
            Assert.AreEqual('B', statistics.AverageLetter);
        }

    }
}


