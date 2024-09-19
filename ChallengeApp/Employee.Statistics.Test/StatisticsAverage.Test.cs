using ChallengeApp;

namespace Statistics.Test
{
    public class AverageTests
    {
   
        [Test]
        public void WhenStatistics_ShouldAverageMaxMinCorrect()
        {
            //arrange
            var worker = new Employee("Mike", "Gol");
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