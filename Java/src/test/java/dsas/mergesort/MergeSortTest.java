package dsas.mergesort;

import org.junit.Test;
import static org.junit.Assert.*;

public class MergeSortTest {
    @Test public void testCanSortArray() {
        int[] input = {8,4,23,42,16,15};
        MergeSort.Sort(input);
        int[] expected = {4,8,15,16,23,42};
        assertArrayEquals(expected, input);
    }

    @Test public void testCanSortReversedArrays() {
        int[] input = {20,18,12,8,5,-2};
        MergeSort.Sort(input);
        int[] expected = {-2,5,8,12,18,20};
        assertArrayEquals(expected, input);
    }

    @Test public void testCanSortRepeatValueArrays() {
        int[] input = {5,12,7,5,5,7};
        MergeSort.Sort(input);
        int[] expected = {5,5,5,7,7,12};
        assertArrayEquals(expected, input);
    }

    @Test public void testCanSortNearlySortedArrays() {
        int[] input = {2,3,5,7,13,11};
        MergeSort.Sort(input);
        int[] expected = {2,3,5,7,11,13};
        assertArrayEquals(expected, input);
    }
}

