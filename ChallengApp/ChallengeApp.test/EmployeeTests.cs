using ChallengApp;

namespace ChallengeApp.test
{
    public class Tests2
    {

        [Test]
        public void WhenEmployeeCollectTwoScores_ShouldReturnCorrectResult()
        {
            // arrange
            var employee = new Employee("Jacek", "Nowak", 55);
            employee.AddScore(5);
            employee.AddScore(6);
            employee.AddScore(-21);

            // act
            var result = employee.Result;

            // assert
            Assert.AreEqual(-10, result);

        }
    }
}