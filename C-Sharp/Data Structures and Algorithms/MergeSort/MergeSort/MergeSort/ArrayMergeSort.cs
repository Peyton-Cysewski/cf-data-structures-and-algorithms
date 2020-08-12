using System;

namespace MergeSort
{
    public class ArrayMergeSort
    {
        /// <summary>
        /// Sorts an integer array using the merge sort algorithm.
        /// </summary>
        /// <param name="array">Array to be sorted.</param>
        public static void Sort(int[] array)
        {
            int n = array.Length;
            if (n > 1)
            {
                int mid = n / 2;
                int[] left = array[..mid];
                int[] right = array[mid..];
                Sort(left);
                Sort(right);
                Merge(left, right, array);
            }
        }
        /// <summary>
        /// Helper function for the merge sort function Sort.
        /// </summary>
        /// <param name="left">The left division of an input array.</param>
        /// <param name="right">The right division of an input array.</param>
        /// <param name="array">The original array reference passed into Sort.</param>
        private static void Merge(int[] left, int[] right, int[] array)
        {
            int i = 0, j = 0, k = 0;
            while (i < left.Length && j < right.Length)
            {
                if (left[i] <= right[j])
                    array[k] = left[i++];
                else
                    array[k] = right[j++];
                k++;
            }
            if (i == left.Length)
                while (j < right.Length)
                    array[k++] = right[j++];
            else
                while (i < left.Length)
                    array[k++] = left[i++];
        }
    }
}
