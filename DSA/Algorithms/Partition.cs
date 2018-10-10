using System.Collections.Generic;

namespace DSA.Algorithms
{
    public class Partition
    {
        public int Part(int pivot, List<int> nums)
        {
            var leftPtr = 0;
            var rghtPtr = nums.Count - 1;

            while (true)
            {

            }

            return 1;
        }

        private static List<int> Swap(List<int> nums, int j, int i)
        {
            var tmp = nums[i];
            nums[i] = nums[j];
            nums[j] = tmp;
            return nums;
        }
    }
}