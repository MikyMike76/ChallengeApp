using ChallengeApp;

namespace Input.Test
{
    public class InputTests
    {
   
        [Test]
        public void WhenABCDstringInput_ShouldAddCorrectGrade()
        {
            //arrange
            var worker = new EmployeeInMemory("Mike", "Gol");
            worker.AddGrade("A");
            worker.AddGrade("B");
            worker.AddGrade("C");

            //act

            var result = worker.GetStatistics();

            //assert
         
            Assert.AreEqual(80, result.Average);
            

        }

        [Test]
        public void When_abcd_StringInput_ShouldAddCorrectGrade()
        {
            //arrange
            var worker = new EmployeeInMemory("Mike", "Gol");
            worker.AddGrade("a");
            worker.AddGrade("b");
            worker.AddGrade("c");

            //act

            var result = worker.GetStatistics();

            //assert

            Assert.AreEqual(80, result.Average);


        }
    }
}