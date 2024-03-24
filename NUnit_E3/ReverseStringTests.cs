using System;

namespace NUnit_E3
{
    [TestFixture]
    public class ReverseStringTests
    {
        [Test]
        public void ReverseStringForString()
        {
            string text = "Sarajevo";
            ReverseString reverseString = new();

            Console.WriteLine(reverseString.ReverseStringMethod(text));
            Assert.AreEqual("ovejaraS", reverseString.ReverseStringMethod(text));
        }

        [Test]
        public void ReverseString_ReturnsEmptyString_ForEmptyString()
        {
            string text = "";
            ReverseString reverseString = new();
            Console.WriteLine(reverseString.ReverseStringMethod(text));
            Assert.AreEqual("", reverseString.ReverseStringMethod(text));
        }
    }
}
