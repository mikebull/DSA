using DSA.ToyExamples;
using NUnit.Framework;

namespace DSA.Tests
{
    [TestFixture]
    public class DelimiterMatcherTests
    {
        [Test]
        public void AcceptsString()
        {
            DelimiterMatcher DelimiterMatcher = new DelimiterMatcher();
            DelimiterMatcher.IsBalanced("a");
        }

        [Test]
        public void ReturnsTrueForSingleNonDelimiter()
        {
            DelimiterMatcher DelimiterMatcher = new DelimiterMatcher();
            bool result = DelimiterMatcher.IsBalanced("a");
            Assert.IsTrue(result);
        }

        [Test]
        public void ReturnsFalseForSingleDelimiter()
        {
            DelimiterMatcher DelimiterMatcher = new DelimiterMatcher();
            bool result = DelimiterMatcher.IsBalanced("(");
            Assert.IsFalse(result);
        }

        [Test]
        public void ReturnsTrueForSinglePairOfBalancedDelimiters()
        {
            DelimiterMatcher DelimiterMatcher = new DelimiterMatcher();
            bool result = DelimiterMatcher.IsBalanced("()");
            Assert.IsFalse(result);
        }

        [Test]
        public void ReturnsFalseForUnbalancedString()
        {
            DelimiterMatcher DelimiterMatcher = new DelimiterMatcher();
            bool result = DelimiterMatcher.IsBalanced("This(Is)An[UnbalancedString[");
            Assert.IsFalse(result);
        }

        [Test]
        public void ReturnsTrueForBalancedString()
        {
            DelimiterMatcher DelimiterMatcher = new DelimiterMatcher();
            bool result = DelimiterMatcher.IsBalanced("<This(Is[A]balanced)String>");
            Assert.IsFalse(result);
        }
    }
}
