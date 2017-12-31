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
    public class SortTests
    {
        public static IEnumerable<TestCaseData> UnorderedToOrderedTestCases()
        {
            yield return new TestCaseData(new int[] { 0 }).Returns(new int[] { 0 });
            yield return new TestCaseData(new int[] { 1, 0 }).Returns(new int[] { 0, 1 });
            yield return new TestCaseData(new int[] { 1, 0, 2 }).Returns(new int[] { 0, 1, 2 });
            yield return new TestCaseData(new int[] { 5, 2, 1, 0 }).Returns(new int[] { 0, 1, 2, 5 });
        }

        [Test, TestCaseSource("UnorderedToOrderedTestCases")]
        public int[] InsertionSortReturnsSortedArray(int[] arr) => InsertionSort.Run(arr);

        [Test, TestCaseSource("UnorderedToOrderedTestCases")]
        public int[] SelectionSortReturnsSortedArray(int[] arr) => SelectionSort.Run(arr);

        [Test, TestCaseSource("UnorderedToOrderedTestCases")]
        public int[] BubbleSortReturnsSortedArray(int[] arr) => BubbleSort.Run(arr);
    }
}
