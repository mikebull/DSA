using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos
{
    public static class BinarySearch
    {
        public static bool Run(int[] arr, int target)
        {
            int floor = arr.First();
            int ceiling = arr.Length;
                
            while (true && floor <= ceiling)
            {
                int guess = (floor + ceiling) / 2;
                if (guess == target) return true;
                else if (guess < target) floor = guess + 1;
                else ceiling = guess - 1;
            }
            return false;
        }
    }
}
