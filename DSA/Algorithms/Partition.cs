using System.Collections.Generic;

namespace DSA.Algorithms
{
    public class Partition
    {
        public List<int> Part(int pivot, List<int> nums)
        {
            var lPtr = -1;
            var rPtr = nums.Count;

            while (true)
            {
                while (lPtr < nums.Count - 1
                       && nums[++lPtr] < pivot)
                {
                }

                while (rPtr > 0
                       && nums[--rPtr] > pivot)
                {
                }

                if (lPtr >= rPtr)
                {
                    break;
                }
                else
                {
                    Swap(ref nums, lPtr, rPtr);
                }
            }

            return nums;
        }

        private static List<T> Swap<T>(ref List<T> n, int j, int i)
        {
            var tmp = n[i];
            n[i] = n[j];
            n[j] = tmp;
            return n;
        }
    }
}