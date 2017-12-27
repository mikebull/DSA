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

        public static IEnumerable<TestCaseData> UnorderedToOrderedTestCases()
        {
            yield return new TestCaseData(new int[] { 0 }).Returns(new int[] { 0 });
            yield return new TestCaseData(new int[] { 1, 0 }).Returns(new int[] { 0, 1 });
            yield return new TestCaseData(new int[] { 1, 0, 2 }).Returns(new int[] { 0, 1, 2 });
            yield return new TestCaseData(new int[] { 5, 2, 1, 0 }).Returns(new int[] { 0, 1, 2, 5 });
        }

        [Test, TestCaseSource("UnorderedToOrderedTestCases")]
        public int[] SelectionSortReturnsSortedArray(int[] arr) => SelectionSort.Run(arr);

        [Test, TestCaseSource("UnorderedToOrderedTestCases")]
        public int[] BubbleSortReturnsSortedArray(int[] arr) => BubbleSort.Run(arr);

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

        [Test]
        public void PassingTest()
        {
            Assert.Pass("This test should pass");
        }
    }
}
