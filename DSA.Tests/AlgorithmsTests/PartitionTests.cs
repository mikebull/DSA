using DSA.Algorithms;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Tests.AlgorithmsTests
{
    [TestFixture]
    public class PartitionTests
    {

        [TestCase]
        public void Part_Correctly_Partitions_Arbitrary_List()
        {
            var partition = new Partition();

            var nums = partition.Part(new List<int> { 3, 1, 10, 5, 6, 9, 8, 1, 5, 8, 4 });

            var firstHalf = nums.Take(nums.Count / 2);
            var partVal = nums[nums.Count / 2];
            var lastHalf = nums.Skip(nums.Count / 2);

            var allLess = firstHalf.All(num => num <= partVal);
            var allMore = lastHalf.All(num => num >= partVal);

            Assert.IsTrue(allLess && allMore);
        }

    }
}
