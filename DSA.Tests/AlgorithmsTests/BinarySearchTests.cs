using DSA.Algorithms;
using NUnit.Framework;
using System.Linq;

namespace DSA.Tests
{
    [TestFixture]
    public class BinarySearchTests
    {
        [Test]
        [TestCase(51, true)]
        [TestCase(41, true)]
        [TestCase(1, true)]
        [TestCase(100, true)]
        [TestCase(0, false)]
        [TestCase(101, false)]
        public void BinarySearchReturnsTargetValue(int target, bool expected)
        {
            int[] orderedArray = Enumerable.Range(1, 100).ToArray();
            bool result = MyBinarySearch.BinarySearch(orderedArray, target);
            Assert.AreEqual(expected, result);
        }
    }
}
