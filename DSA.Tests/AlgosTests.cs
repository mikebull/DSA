using Algos;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Tests
{
    [TestFixture]
    public class AlgosTests
    {

        private static IEnumerable<TestCaseData> OrderedArrays()
        {
            yield return new TestCaseData(Enumerable.Range(1, 100).ToArray(), 50, true);
            yield return new TestCaseData(Enumerable.Range(1, 100).ToArray(), 100, true);
            yield return new TestCaseData(Enumerable.Range(1, 100).ToArray(), 1, true);
            yield return new TestCaseData(Enumerable.Range(1, 100).ToArray(), 0, false);
            yield return new TestCaseData(Enumerable.Range(1, 100).ToArray(), 101, false);
        }

        [Test]
        [TestCase(new int[] { 0 }, new int[] { 0 })]
        [TestCase(new int[] { 1, 0 }, new int[] { 0, 1 })]
        [TestCase(new int[] { 1, 0, 2}, new int[] { 0, 1, 2 })]
        [TestCase(new int[] { 1, 0, 2, 5}, new int[] { 0, 1, 2, 5 })]
        public void BubbleSortReturnsSortedArray(int[] arr, int[] expected)
        {
            int[] result = BubbleSort.Run(arr);
            Assert.AreEqual(result, expected);
        }

        [Test, TestCaseSource( "OrderedArrays" )]
        public void BinarySearchReturnsTargetValue(int[] arr, int target, bool expected)
        {
            bool result = BinarySearch.Run(arr, target);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void PassingTest()
        {
            Assert.Pass("This test should pass");
        }
    }
}
