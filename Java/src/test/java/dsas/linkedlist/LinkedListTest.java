package dsas.linkedlist;

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

    @Test public void testAppend() {
        LinkedList<Integer> ll = new LinkedList<>();
        ll.insert(42);
        ll.insert(100);
        ll.insert(3);
        ll.append(87);
        String expected = "{3} -> {100} -> {42} -> {87} -> null";
        assertEquals(expected, ll.toString());
    }

    @Test public void testAppendMultiple() {
        LinkedList<Integer> ll = new LinkedList<>();
        ll.insert(42);
        ll.insert(100);
        ll.insert(3);
        ll.append(87);
        ll.append(89);
        String expected = "{3} -> {100} -> {42} -> {87} -> {89} -> null";
        assertEquals(expected, ll.toString());
    }

    @Test public void testInsertBefore() {
        LinkedList<Integer> ll = new LinkedList<>();
        ll.insert(42);
        ll.insert(100);
        ll.insert(3);
        ll.insertBefore(100, 16);
        String expected = "{3} -> {16} -> {100} -> {42} -> null";
        assertEquals(expected, ll.toString());
    }

    @Test public void testInsertBeforeStart() {
        LinkedList<Integer> ll = new LinkedList<>();
        ll.insert(42);
        ll.insert(100);
        ll.insert(3);
        ll.insertBefore(3, 45);
        String expected = "{45} -> {3} -> {100} -> {42} -> null";
        assertEquals(expected, ll.toString());
    }

    @Test public void testInsertAfter() {
        LinkedList<Integer> ll = new LinkedList<>();
        ll.insert(42);
        ll.insert(100);
        ll.insert(3);
        ll.insertAfter(100, 77);
        String expected = "{3} -> {100} -> {77} -> {42} -> null";
        assertEquals(expected, ll.toString());
    }

    @Test public void testInsertAfterEnd() {
        LinkedList<Integer> ll = new LinkedList<>();
        ll.insert(42);
        ll.insert(100);
        ll.insert(3);
        ll.insertAfter(42, 1);
        String expected = "{3} -> {100} -> {42} -> {1} -> null";
        assertEquals(expected, ll.toString());
    }

    @Test public void testZipListWorks() {
        LinkedList<Integer> ll1 = new LinkedList<>();
        ll1.append(1);
        ll1.append(3);
        ll1.append(5);

        LinkedList<Integer> ll2 = new LinkedList<>();
        ll2.append(2);
        ll2.append(4);
        ll2.append(6);

        LinkedList<Integer> ll3 = LinkedList.zipLists(ll1, ll2);
        String ll3String = ll3.toString();
        String expected1 = "{1} -> {2} -> {3} -> {4} -> {5} -> {6} -> null";
        assertNotNull(ll3);
        assertEquals(expected1, ll3String);


        LinkedList<Integer> ll4 = new LinkedList<>();
        ll4.append(1);
        ll4.append(3);
        ll4.append(5);

        LinkedList<String> ll5 = new LinkedList<>();
        ll5.append("two");
        ll5.append("four");
        ll5.append("six");

        LinkedList<Integer> ll6 = LinkedList.zipLists(ll4, ll5);
        assertNull(ll6);
    }

    @Test public void testKthFromEnd() {
        try {
            LinkedList<Integer> ll = new LinkedList<>();
            ll.insert(42);
            ll.insert(100);
            ll.insert(3);
            // 3 -> 100 -> 42
            int actual1 = ll.kthFromEnd(1);
            int negative = ll.kthFromEnd(-3);
            int equalLength = ll.kthFromEnd(2);
            assertEquals(100, actual1);
            assertEquals(42, negative);
            assertEquals(3, equalLength);

            LinkedList<Integer> ll2 = new LinkedList<>();
            ll2.insert(4);
            int actual2 = ll2.kthFromEnd(0);
            assertEquals(4, actual2);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
    }
}
