package BinarySearch;

import org.junit.Test;
import static org.junit.Assert.*;

public class BinarySearchTest {
    @Test public void testBinarySearch() {
        BinarySearch lib = new BinarySearch();
        int[] arr = {1, 2, 3, 4, 5, 6, 7, 23, 25, 72, 11442};
        int m = 3;
        int n = 9;
        int z = arr.length - 1;
        assertEquals("testBinarySearch should return -1", -1, lib.binarySearch(arr, 0, z, n));
        assertEquals("testBinarySearch should return 2", 2, lib.binarySearch(arr, 0, z, m));
    }
}