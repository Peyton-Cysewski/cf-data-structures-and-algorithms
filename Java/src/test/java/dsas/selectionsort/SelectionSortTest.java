package dsas.selectionsort;

import org.junit.Test;
import static org.junit.Assert.*;

import java.util.Arrays;

public class SelectionSortTest {
    @Test public void testCanSortArray1() {
        int[] input = {8,4,23,42,16,15};
        int[] output = SelectionSort.sort1(input);
        int[] expected = {4,8,15,16,23,42};
        assertArrayEquals(expected, output);
    }

    @Test public void testCanSortArray2() {
        int[] input = {8,4,23,42,16,15};
        int[] output = SelectionSort.sort2(input);
        int[] expected = {4,8,15,16,23,42};
        assertArrayEquals(expected, output);
    }

    @Test public void testBothMethodsSortReversedArrays() {
        int[] input1 = {20,18,12,8,5,-2};
        int[] input2 = {20,18,12,8,5,-2};
        int[] output1 = SelectionSort.sort1(input1);
        int[] output2 = SelectionSort.sort2(input2);
        int[] expected = {-2,5,8,12,18,20};
        boolean result = Arrays.equals(expected, output1) && Arrays.equals(expected, output2);
        assertTrue(result);
    }

    @Test public void testBothMethodsSortRepeatValueArrays() {
        int[] input1 = {5,12,7,5,5,7};
        int[] input2 = {5,12,7,5,5,7};
        int[] output1 = SelectionSort.sort1(input1);
        int[] output2 = SelectionSort.sort2(input2);
        int[] expected = {5,5,5,7,7,12};
        boolean result = Arrays.equals(expected, output1) && Arrays.equals(expected, output2);
        assertTrue(result);
    }

    @Test public void testBothMethodsSortNearlySortedArrays() {
        int[] input1 = {2,3,5,7,13,11};
        int[] input2 = {2,3,5,7,13,11};
        int[] output1 = SelectionSort.sort1(input1);
        int[] output2 = SelectionSort.sort2(input2);
        int[] expected = {2,3,5,7,11,13};
        boolean result = Arrays.equals(expected, output1) && Arrays.equals(expected, output2);
        assertTrue(result);
    }
}
