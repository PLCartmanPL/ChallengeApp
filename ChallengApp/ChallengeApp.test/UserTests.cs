using ChallengApp;

namespace ChallengeApp.test
{
    public class Tests1
    {

        [Test]
        public void WhenUserCollectTwoScores_ShouldReturnCorrectResult()
        {
            // arrange
            var user = new User("Jacek", "jnfi34rt");
            user.AddScore(5);
            user.AddScore(6);
            // act
            var result = user.Result;

            // assert
            Assert.AreEqual(11, result);

        }
    }
}