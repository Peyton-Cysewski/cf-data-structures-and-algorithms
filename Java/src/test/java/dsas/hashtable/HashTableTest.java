package dsas.hashtable;

import org.junit.Test;
import static org.junit.Assert.*;

public class HashTableTest {
    @Test public void testHashtableContains() {
        HashTable<String> hashtable = new HashTable<>(10);
        hashtable.add("test1", "result1");
        hashtable.add("test2", "result2");
        hashtable.add("test3", "result3");
        assertTrue(hashtable.contains("test2"));
        assertFalse(hashtable.contains("test4"));
    }

    @Test public void testHashtableAddAndGet() {
        HashTable<String> hashtable = new HashTable<>(10);
        hashtable.add("test1", "result1");
        hashtable.add("test2", "result2");
        hashtable.add("test3", "result3");
        String expected = "result1";
        assertEquals(expected, hashtable.get("test1"));
    }

    @Test public void testHashtableCollisions() {
        HashTable<String> hashtable = new HashTable<>(1);
        hashtable.add("test1", "result1");
        hashtable.add("test2", "result2");
        hashtable.add("test3", "result3");
        String expected = "result3";
        assertEquals(expected, hashtable.get("test3"));
    }
}
