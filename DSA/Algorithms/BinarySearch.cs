namespace DSA.Algorithms
{
    public static class MyBinarySearch
    {
        public static bool BinarySearch(int[] arr, int target)
        {
            int floor = arr[0];
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
