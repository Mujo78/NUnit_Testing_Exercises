using System;

namespace NUnit_E1
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void WordIpsum()
        {
            Assert.IsTrue(WordCheck.methodWithString().Contains("ipsum"));
        }

        [Test]
        public void WordReturn()
        {
            Assert.IsTrue(WordCheck.methodWithString().EndsWith("return"));
        }

        [Test]
        public void WordLorem()
        {
            Assert.IsTrue(WordCheck.methodWithString().StartsWith("Lorem"));
        }

        [Test]
        public void WordFull()
        {
            Assert.IsTrue(WordCheck.methodWithString().Equals("Lorem ipsum string return"));
        }


        [Test]
        public void WordNotEqual()
        {
            Assert.IsFalse(WordCheck.methodWithString().Equals("String return: \"Lorem ipsum\""));
        }

    }

}
