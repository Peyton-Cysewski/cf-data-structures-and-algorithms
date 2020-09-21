/*
 * This Java source file was generated by the Gradle 'init' task.
 */
package linkedList;

import org.junit.Test;
import static org.junit.Assert.*;

public class LinkedListTest {
    @Test public void testCanInstantiateLinkedList() {
        LinkedList<Integer> ll = new LinkedList<>();
        assertNotNull(ll);
    }

    @Test public void testCanInsert() {
        LinkedList<Integer> ll = new LinkedList<>();
        ll.insert(42);
        int actual = ll.head.value;
        assertEquals(42, actual);
    }

    @Test public void testHeadNotNull() {
        LinkedList<Integer> ll = new LinkedList<>();
        ll.insert(42);
        assertNotNull(ll.head);    }

    @Test public void testInsertMultipleNodes() {
        LinkedList<Integer> ll = new LinkedList<>();
        ll.insert(42);
        ll.insert(100);
        ll.insert(3);
        int val1 = ll.head.value;
        int val2 = ll.head.next.value;
        int val3 = ll.head.next.next.value;
        assertEquals(3, val1);
        assertEquals(100, val2);
        assertEquals(42, val3);
    }

    @Test public void testValueExists() {
        LinkedList<Integer> ll = new LinkedList<>();
        ll.insert(42);
        ll.insert(100);
        ll.insert(3);
        assertTrue(ll.includes(3));
    }

    @Test public void testValueDoesNotExist() {
        LinkedList<Integer> ll = new LinkedList<>();
        ll.insert(42);
        ll.insert(100);
        ll.insert(3);
        assertFalse(ll.includes(12));
    }

    @Test public void testToString() {
        LinkedList<Integer> ll = new LinkedList<>();
        ll.insert(42);
        ll.insert(100);
        ll.insert(3);
        String expected = "{3} -> {100} -> {42} -> null";
        assertEquals(expected, ll.toString());
    }
}