using System;

namespace NUnit_E3
{
    [TestFixture]
    public class CalculatorTest
    {
        [Test]
        public void CalculateSumPositiveNumbers()
        {
            int[] positivenumbers = [ 1, 2, 3, 4, 5 ];
            Calculator calculator = new();

            int result = calculator.CalculateSum(positivenumbers);

            Assert.AreEqual(15, result);
        }

        [Test]
        public void CalculateSumNegativeNumbers()
        {
            int[] negativenumbers = [ -1, -2, -3, -4, -5 ];
            Calculator calculator = new();

            int result = calculator.CalculateSum(negativenumbers);

            Assert.AreEqual(-15, result);
        }

        [Test]
        public void CalculateSum_ReturnsZero_ForEmptyArray()
        {
            int[] empty = [];
            Calculator calculator = new();

            int result = calculator.CalculateSum(empty);

            Assert.AreEqual(0, result);
        }
    }
}
