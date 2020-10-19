package dsas.selectionsort;

public class SelectionSort {
    public static int[] sort1(int[] input) {
        for (int i = 1; i < input.length; i++) {
            int j = i - 1;
            int temp = input[i];
            while (j >= 0 && temp < input[j]) {
                input[j + 1] = input[j];
                j--;
            }
            input[j + 1] = temp;
        }
        return input;
    }

    public static int[] sort2(int[] input) {
        for (int i = 0; i < input.length; i++) {
            int index = i;
            for (int j = i + 1; j < input.length; j++) {
                if (input[j] < input[index])
                    index = j;
            }
            int temp = input[i];
            input[i] = input[index];
            input[index] = temp;
        }
        return input;
    }
}
