package dsas.mergesort;

import java.util.Arrays;

public class MergeSort {
    public static void Sort(int[] array)
    {
        if (array != null)
        {
            if (array.length > 1)
            {
                int mid = array.length / 2;
                int[] left = Arrays.copyOfRange(array, 0, mid);
                int[] right = Arrays.copyOfRange(array, mid, array.length);
                Sort(left);
                Sort(right);
                Merge(left, right, array);
            }
        }
    }

    private static void Merge(int[] left, int[] right, int[] array)
    {
        int i = 0, j = 0, k = 0;
        while (i < left.length && j < right.length)
        {
            if (left[i] <= right[j])
                array[k] = left[i++];
            else
                array[k] = right[j++];
            k++;
        }
        if (i == left.length)
            while (j < right.length)
                array[k++] = right[j++];
        else
            while (i < left.length)
                array[k++] = left[i++];
    }
}
