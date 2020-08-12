using System;

namespace InsertionSort
{
    public class ArrayInsertionSort
    {
        /// <summary>
        /// Takes in an array and sorts it according to the insertion sort algorithm.
        /// </summary>
        /// <param name="array">Array to be sorted.</param>
        public void Sort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int j = i - 1;
                int temp = array[i];
                while (j >= 0 && temp < array[j])
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = temp;
            }
        }
    }
}
