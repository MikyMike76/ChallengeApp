using ChallengeApp;

namespace StatisticsMax.Test
{
    public class MaxTests
    {
   
        [Test]
        public void WhenStatistics_ShouldMaxCorrect()
        {
            //arrange
            var worker = new EmployeeInMemory("Mike", "Gol");
            worker.AddGrade(5.5f);
            worker.AddGrade(3.5f);
            worker.AddGrade(2.5f);

            //act

            var result = worker.GetStatistics();

            //assert
         
            Assert.AreEqual(5.5f, result.Max);

        }

    }
}