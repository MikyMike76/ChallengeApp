using ChallengeApp;

namespace StatisticsMin.Test
{
    public class MinTests
    {
   
        [Test]
        public void WhenStatistics_ShouldMinCorrect()
        {
            //arrange
            var worker = new Employee("Mike", "Gol");
            worker.AddGrade(5.5f);
            worker.AddGrade(3.5f);
            worker.AddGrade(2.5f);

            //act

            var result = worker.GetStatistics();

            //assert
         
            Assert.AreEqual(2.5f, result.Min);

        }

    }
}