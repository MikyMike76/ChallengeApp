using ChallengeApp;

namespace StatisticsAverageLetter.Test
{
    public class AverageLetterTests
    {
   
        [Test]
        public void WhenStatistics_ShouldAverageLetterCorrect()
        {
            //arrange
            var worker = new Employee("Mike", "Gol");
            worker.AddGrade(55.5f);
            worker.AddGrade('a');
            worker.AddGrade('B');
            worker.AddGrade("22");

            //act

            var result = worker.GetStatistics();

            //assert
         
            Assert.AreEqual('C', result.AverageLetter);
            

        }

    }
}