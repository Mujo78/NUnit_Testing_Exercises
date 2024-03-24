using NUnit.Framework;

namespace NUnit_E1
{
    [TestFixture]
    public class NumberCheckerTests
    {
 
        [Test]
        public void IsEven_ReturnsTrue_ForEvenNumber()
        {
            NumberChecker numCheck = new();
            int numToTest = 4;
            Console.WriteLine("This method returns true for even numbers: " + numCheck.IsEven(numToTest));
        }

        [Test]
        public void IsEven_ReturnsFalse_ForOddNumber()
        {
            NumberChecker numCheck = new();
            int numToTest = 5;
            Console.WriteLine("This method returns false for odd numbers: " + numCheck.IsEven(numToTest));
        }
    }
}
