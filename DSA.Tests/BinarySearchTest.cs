using DSA.Algorithms;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Tests
{
    [TestFixture]
    public class BinarySearchTest
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
            bool result = BinarySearch.Run(orderedArray, target);
            Assert.AreEqual(expected, result);
        }
    }
}
