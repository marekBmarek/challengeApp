
namespace ChallengeApp.Tests
{
    public class Tests
    {

        [Test]
        public void WhenWorkeraddpoint_ShouldreturnResult()
        {
            // arrange
            var worker = new Worker("Marek", "123abc");
            worker.Addscore(5);
            worker.Addscore(5);
            // act
            var result = worker.Result;
            // assert
            Assert.AreEqual(10, result);
        }
        [Test]
        public void WhenWorkergetscore_shouldreturnsum()
        {
            // arrange
            var worker2 = new Worker("Jozef", "XxXx3");
            worker2.Addscore(5);
            worker2.Addscore(5);
            worker2.Addscore(10);

            // act
            var result = worker2.Result;
            // assert
            Assert.AreEqual(20, result);
        }


        [Test]
        public void WhenWorkercomplitpoint_shouldreturnallscore()
        {
            // arrange
            var worker3 = new Worker("Franek", "abba789");
            worker3.Addscore(5);
            worker3.Addscore(6);
            worker3.Addscore(7);
            worker3.Addscore(-11);
            // act
            var result = worker3.Result;
            // assert
            Assert.AreEqual(7, result);
        }

    }

}