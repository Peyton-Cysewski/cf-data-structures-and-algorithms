using System;

namespace QuickSort
{
    public class ArrayQuickSort
    {
        /// <summary>
        /// Sorts an array using the quick sort algorithm
        /// </summary>
        /// <param name="array">Array to be sorted</param>
        /// <param name="left">Lowest index of section to be sorted</param>
        /// <param name="right">Highest index of section to be sorted</param>
        public static void Sort(int[] array, int left, int right)
        {
            if (array != null)
            {
                if (left < right)
                {
                    int position = Partition(array, left, right);
                    Sort(array, left, position - 1);
                    Sort(array, position + 1, right);
                }
            }
        }

        /// <summary>
        /// Part of the quick sort algorithm, arranges items of the specified section of an array according to a pivot
        /// </summary>
        /// <param name="array">Array being sorted</param>
        /// <param name="left">Lowest index of section to be partitioned</param>
        /// <param name="right">Highest index of section to be partitioned</param>
        /// <returns>Index of correctly sorted partition item</returns>
        private static int Partition(int[] array, int left, int right)
        {
            int pivot = array[right];
            int low = left - 1;
            for (int i = left; i < right; i++)
            {
                if (array[i] <= pivot)
                {
                    low++;
                    Swap(array, i, low);
                }
            }
            Swap(array, right, low + 1);
            return low + 1;
        }

        /// <summary>
        /// Part of the quick sort algorithm, swaps to values in an array, in place
        /// </summary>
        /// <param name="array">Array being manipulated</param>
        /// <param name="i">Index of pivot</param>
        /// <param name="low">Index of item being swapped with the pivot</param>
        private static void Swap(int[] array, int i, int low)
        {
            int temp = array[i];
            array[i] = array[low];
            array[low] = temp;
        }
    }
}
