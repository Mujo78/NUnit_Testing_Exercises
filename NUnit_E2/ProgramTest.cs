
namespace NUnitTest
{
    [TestFixture]
    public class ProgramTest
    {

        // GetAverage tests
        [Test]
        public void GetAverageForPositiveNumbers()
        {
            int[] numbers = [1,2,3,4,5];
            Program program = new();
            double result = program.GetAverage(numbers);
            Assert.AreEqual(3, result);
        }

        [Test]
        public void GetAverageForNegativeNumbers()
        {
            int[] negativenumbers = [ -1, -2, -3, -4, -5 ];
            Program program = new();
            double result = program.GetAverage(negativenumbers);
            Assert.AreEqual(-3, result);
        }

        [Test]
        public void GetAverageEmptyArray()
        {
            int[] emptyarray = [];
            Program program = new();
            double result = program.GetAverage(emptyarray);
            Assert.AreEqual(0, result);
        }

        // IsPrime tests

        [Test]
        public void TwoIsPrime()
        {
            int number = 2;
            Program program = new();
            Assert.IsTrue(program.IsPrime(number));
        }

        [Test]
        public void ThreeIsPrime()
        {
            int number = 3;
            Program program = new();
            Assert.IsTrue(program.IsPrime(number));
        }

        [Test]
        public void FourIsNotPrime()
        {
            int number = 4;
            Program program = new();
            Assert.IsFalse(program.IsPrime(number));
        }

        // GetLarget tests

        [Test]
        public void GetLargestPositiveNumbers()
        {
            int[] positivenumbers = [ 1, 2,19, 3, 4, 5 ];
            Program program = new();
            Console.WriteLine(program.GetLargest(positivenumbers));
            Assert.AreEqual(19, program.GetLargest(positivenumbers));
        }

        [Test]
        public void GetLargestNegativeNumbers()
        {
            int[] negativenumbers = [ -1, -2, -19, -3, -4, -5 ];
            Program program = new();
            Console.WriteLine(program.GetLargest(negativenumbers));
            Assert.AreEqual(-1, program.GetLargest(negativenumbers));
        }

        [Test]
        public void GetLargestEmptyArray()
        {
            int[] emptyarray = [];
            Program program = new();
            Console.WriteLine(program.GetLargest(emptyarray));
            Assert.AreEqual(-1, program.GetLargest(emptyarray));
        }

    }
}
