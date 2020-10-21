package dsas.quicksort;

class QuickSort  {
    public static void Sort(int[] array, int left, int right)  {
        if (array != null)  {
            if (left < right)  {
                int position = Partition(array, left, right);
                Sort(array, left, position - 1);
                Sort(array, position + 1, right);
            }
        }
    }

    private static int Partition(int[] array, int left, int right)  {
        int pivot = array[right];
        int low = left - 1;
        for (int i = left; i < right; i++)  {
            if (array[i] <= pivot)  {
                low++;
                Swap(array, i, low);
            }
        }
        Swap(array, right, low + 1);
        return low + 1;
    }

    private static void Swap(int[] array, int i, int low)  {
        int temp = array[i];
        array[i] = array[low];
        array[low] = temp;
    }
}
