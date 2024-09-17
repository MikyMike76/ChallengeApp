namespace ChallengeApp.Tests
{
    public class Tests
    {
  
        [Test]
        public void WhenAddScore_ShouldCorrectResult()
        {
            //Arrange
            var employee = new Employee("Michal", "Golub", 22);
            employee.AddScore(3);
            employee.AddScore(5);
            employee.AddScore(-11);

            //Act
            var result = employee.Score;

            //Assert
            Assert.AreEqual(-3, result);
        }
    }
}