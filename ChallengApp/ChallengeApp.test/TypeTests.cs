
using ChallengApp;

namespace ChallengeApp.test
{
    public class TypeTests
    {
        [Test]
        public void GetEmployeeShouldReturnDifferentObects()
        {
            // arrange
            var employee1 = GetEmployee("Paweł");
            var employee2 = GetEmployee("Paweł");

            // assert
            Assert.AreNotEqual(employee1, employee2);
        }

        [Test]
        public void SameIntAreTheSameObjects()
        {
            // arrange
            int number1 = 2;
            int number2 = 2;

            // assert
            Assert.AreEqual(number1, number2);
        }

        [Test]
        public void SamefloatAreTheSameObjects()
        {
            // arrange
            float float1 = 2.345f;
            float float2 = 2.345f;

            // assert
            Assert.AreEqual(float1, float2);
        }
        [Test]
        public void SameStringAreTheSameObjects()
        {
            // arrange
            string text1 = "Paweł";
            string text2 = "Paweł";

            // assert
            Assert.AreEqual(text1, text2);
        }
        private Employee GetEmployee(string name)
        {
            return new Employee(name);
        }
    }
}

