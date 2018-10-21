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

            var pivot = 8;

            var nums = partition.Part(pivot, new List<int> { 7, 9, 4, 8, 10, 15, 13, 12, 6 });

            var result = nums.SkipWhile(n => n < pivot)
                             .All(n => n >= pivot);

            Assert.IsTrue(result);
        }

    }
}
