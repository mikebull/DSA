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
            StringReverser stringReverser = new StringReverser();

            string result = stringReverser.Reverse("a");
            string expectedResult = "a";

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void ReversesTwoCharacters()
        {
            StringReverser stringReverser = new StringReverser();

            string result = stringReverser.Reverse("ab");
            string expectedResult = "ba";

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void ReversesFiveCharacters()
        {
            StringReverser stringReverser = new StringReverser();

            string result = stringReverser.Reverse("abcde");
            string expectedResult = "edcba";

            Assert.AreEqual(expectedResult, result);
        }
    }
}
