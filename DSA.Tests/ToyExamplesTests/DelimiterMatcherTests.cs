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
            DelimiterMatcher delimiterMatcher = new DelimiterMatcher();
            delimiterMatcher.IsBalanced("a");
        }

        [Test]
        public void ReturnsTrueForSingleNonDelimiter()
        {
            DelimiterMatcher delimiterMatcher = new DelimiterMatcher();
            bool result = delimiterMatcher.IsBalanced("a");
            Assert.IsTrue(result);
        }

        [Test]
        public void ReturnsFalseForSingleDelimiter()
        {
            DelimiterMatcher delimiterMatcher = new DelimiterMatcher();
            bool result = delimiterMatcher.IsBalanced("(");
            Assert.IsFalse(result);
        }

        [Test]
        public void ReturnsTrueForSinglePairOfBalancedDelimiters()
        {
            DelimiterMatcher delimiterMatcher = new DelimiterMatcher();
            bool result = delimiterMatcher.IsBalanced("()");
            Assert.IsFalse(result);
        }

        [Test]
        public void ReturnsFalseForUnbalancedString()
        {
            DelimiterMatcher delimiterMatcher = new DelimiterMatcher();
            bool result = delimiterMatcher.IsBalanced("This(Is)An[UnbalancedString[");
            Assert.IsFalse(result);
        }

        [Test]
        public void ReturnsTrueForBalancedString()
        {
            DelimiterMatcher delimiterMatcher = new DelimiterMatcher();
            bool result = delimiterMatcher.IsBalanced("<This(Is[A]balanced)String>");
            Assert.IsFalse(result);
        }
    }
}
