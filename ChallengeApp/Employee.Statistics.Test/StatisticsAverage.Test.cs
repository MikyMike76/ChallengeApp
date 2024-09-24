using ChallengeApp;

namespace StatisticsAverage.Test
{
    public class AverageTests
    {
   
        [Test]
        public void WhenStatistics_ShouldAverageCorrect()
        {
            //arrange
            var worker = new EmployeeInMemory("Mike", "Gol");
            worker.AddGrade(5.5f);
            worker.AddGrade(3.5f);
            worker.AddGrade(2.5f);

            //act

            var result = worker.GetStatistics();

            //assert
         
            Assert.AreEqual((5.5f+3.5f+2.5f)/3, result.Average);
            

        }

    }
}