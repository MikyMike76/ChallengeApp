using ChallengeApp;

namespace Input.Test
{
    public class InputTests
    {
   
        [Test]
        public void WhenABCDstringInput_ShouldCorrectGradeAdd()
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
        public void When_abcd_StringInput_ShouldCorrectGradeAdd()
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

        [Test]
        public void WhenMoreThenOneLetterStringInput_ShouldCorrectGradeAdd()
        {
            //arrange
            var worker = new EmployeeInMemory("Mike", "Gol");
            worker.AddGrade("rt");
            worker.AddGrade("b");
            worker.AddGrade("c");

            //act

            var result = worker.GetStatistics();

            //assert

            Assert.AreEqual(70, result.Average);


        }

        [Test]
        public void WhenOutOfRangeABCDStringInput_ShouldCorrectGradeAdd()
        {
            //arrange
            var worker = new EmployeeInMemory("Mike", "Gol");
            worker.AddGrade("L");
            worker.AddGrade("b");
            worker.AddGrade("c");

            //act

            var result = worker.GetStatistics();

            //assert

            Assert.AreEqual(70, result.Average);


        }

    }
}