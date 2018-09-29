/// <summary>
/// <para>
/// Bubble sort is a simple sorting algorithm, slow (O(N^2) time), and not 
/// often used. But it is a common introducion to sorting algorithms in 
/// general, because it's both relatively easy to understand and simple to 
/// implement.
/// </para>
/// <para>
/// It works by making continual passes over an array, comparing values, and 
/// always advancing the largest value. This guarantees the righthand side
/// always contains at least the N largest values in the array where N is the
/// number of passes through the array.
/// </para>
/// <para>
/// Bubble sort has a nested loop. The outer loop keeps track of the number
/// of passes through the array, always making sure that the iteration stops
/// at the appropriate index, i.e., the index corresponding the number of
/// passes made, since that is also the number of already-sorted values
/// at the righthand side of the array.
/// </para>
/// <para>
/// The inner loop handles the comparisons and swaps, continually iterating and
/// advancing over the sort space controlled by the outerloop, carrying out
/// the folllowing steps each iteration:
/// </para>
/// <para>
///   (0) Compare value j and j + 1
///   (1) If the j is larger, swap values
///   (2) increment j
/// </para>
///   
/// </summary>

namespace DSA.Algorithms
{
    public static class BubbleSort
    {
        public static int[] Sort(int[] arr)
        {
            for (int i = arr.Length - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            return arr;
        }
    }
}
