namespace DSA.Algorithms
{
    /// Binary search is a fast, simple, and intuitive algorithm that searches for a 
    /// value over a sorted array. The way it works is as follows:
    ///
    ///   (0) Set floor to first index of array, and ceiling to last
    ///   (1) Guess the midpoint of floor and ceiling
    ///   (2) If the guess is low, raise the floor to index of guess + 1
    ///   (3) If the guess is high, lower the ceiling to index of guess - 1
    ///   (4) Repeat step 1 to 3 until guess is correct or floor > ceiling (nothing left to guess)
    ///
    /// The most important thing to note is that this algorithm reduces 
    /// the search space by half every iteration (at step 2 or 3). This makes
    /// it very fast, running in O(log n) time.

    public static class MyBinarySearch
    {
        public static bool BinarySearch(int[] arr, int target)
        {
            int floor = arr[0]; 
            int ceiling = arr.Length - 1;
         
            while (true) 
            {
                int guessIndex = (floor + ceiling) / 2; 
                if (arr[guessIndex] == target) return true;
                else if (floor > ceiling) return false; 
                else
                {
                    if (arr[guessIndex] < target) floor = guessIndex + 1;
                    else ceiling = guessIndex - 1; 
                }
            }
        }
    }
}
