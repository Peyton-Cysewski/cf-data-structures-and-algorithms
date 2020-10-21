package dsas.stacksandqueues;

import org.junit.Test;
import static org.junit.Assert.*;

public class QueueTest {
    @Test public void testCanInstantiate() {
        Queue<Integer> queue = new Queue();
        assertNotNull(queue);
    }

    @Test public void testCanPeek() {
        Queue<Integer> queue = new Queue();
        assertNull(queue.peek());
    }

    @Test public void testCanEnqueue() {
        Queue<Integer> queue = new Queue();
        queue.enqueue(1);
        assertEquals(1, (int)queue.peek());
    }

    @Test public void testCanEnqueueMultiple() {
        Queue<Integer> queue = new Queue();
        queue.enqueue(1);
        queue.enqueue(2);
        queue.enqueue(3);
        assertEquals(1, (int)queue.peek());
    }

    @Test public void testCanDequeue() {
        Queue<Integer> queue = new Queue();
        queue.enqueue(1);
        assertEquals(1, (int)queue.dequeue());
        assertNull(queue.peek());
    }

    @Test public void testCanDequeueMultiple() {
        Queue<Integer> queue = new Queue();
        queue.enqueue(1);
        queue.enqueue(2);
        queue.enqueue(3);
        queue.dequeue();
        queue.dequeue();
        assertEquals(3, (int)queue.dequeue());
        assertNull(queue.peek());
    }
}
