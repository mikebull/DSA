using DSA.ToyExamples;
using NUnit.Framework;

namespace DSA.Tests
{
    [TestFixture]
    public class StringReverserTests
    {
        [Test]
        public void ReturnsSingleCharacter()
        {
            MyStringReverser stringReverser = new MyStringReverser();

            string result = stringReverser.Reverse("a");
            string expectedResult = "a";

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void ReversesTwoCharacters()
        {
            MyStringReverser stringReverser = new MyStringReverser();

            string result = stringReverser.Reverse("ab");
            string expectedResult = "ba";

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void ReversesFiveCharacters()
        {
            MyStringReverser stringReverser = new MyStringReverser();

            string result = stringReverser.Reverse("abcde");
            string expectedResult = "edcba";

            Assert.AreEqual(expectedResult, result);
        }
    }
}
