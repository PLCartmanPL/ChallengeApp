
using ChallengApp;

namespace ChallengeApp.test
{
    public class TypeTests
    {
        [Test]
        public void GetUserShouldReturnDifferentObects()
        {
            // arrange
            var user1 = GetUser("Paweł");
            var user2 = GetUser("Paweł");

            // assert
            Assert.AreNotEqual(user1, user2); 
        }
        private User GetUser(string name)
        {
            return new User(name);
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
       
    }
}

