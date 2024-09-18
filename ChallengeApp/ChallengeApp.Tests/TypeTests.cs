

using System.Reflection.Metadata;

namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        public void WhenTypeValueableShouldEqual()
        {
            //arrange
            int number1 = 4;
            int number2 = 4;
            int number3 = 4;

            //act

            //assert
            Assert.AreEqual(number1, number2);
            Assert.AreEqual(number1, number3);
            Assert.AreEqual(number2, number3);
        }
        public void WhenTypeReferenceShouldNotEqual()
        {
            //arrange
            var user1 = GetUser("Adam");
            var user2 = GetUser("Michał");
            var user3 = GetUser("Ania");

            //act

            //assert
            Assert.AreNotEqual(user1, user2);
            Assert.AreNotEqual(user2, user3);
            Assert.AreNotEqual(user3, user1);

        }

        private Employee GetUser(string name)
        {
            return new Employee(name);
        }
    }
}
