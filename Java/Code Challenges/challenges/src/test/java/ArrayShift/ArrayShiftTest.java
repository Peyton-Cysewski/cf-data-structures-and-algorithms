package ArrayShift;

import org.junit.Test;
import static org.junit.Assert.*;

public class ArrayShiftTest {
    @Test public void testEvenArray() {
        ArrayShift arrayShift = new ArrayShift();
        int[] input = {1, 2, 4, 5};
        int value = 3;
        int[] expecteds = {1, 2, 3, 4, 5};
        assertArrayEquals(expecteds, arrayShift.insertShiftArray(input, value));
    }

    @Test public void testOddArray() {
        ArrayShift arrayShift = new ArrayShift();
        int[] input = {1, 2, 3, 5, 6};
        int value = 4;
        int[] expecteds = {1, 2, 3, 4, 5, 6};
        assertArrayEquals(expecteds, arrayShift.insertShiftArray(input, value));
    }

    @Test public void testEmptyArray() {
        ArrayShift arrayShift = new ArrayShift();
        int[] input = new int[0];
        int value = 1;
        int[] expecteds = {1};
        assertArrayEquals(expecteds, arrayShift.insertShiftArray(input, value));
    }
}
