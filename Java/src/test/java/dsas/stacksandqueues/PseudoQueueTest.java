package dsas.stacksandqueues;

import org.junit.Test;
import static org.junit.Assert.*;

public class PseudoQueueTest {
    @Test public void testCanInstantiate() {
        PseudoQueue<Integer> pseudoQueue = new PseudoQueue();
        assertNotNull(pseudoQueue);
    }

    @Test public void testCanEnqueue() {
        PseudoQueue<Integer> pseudoQueue = new PseudoQueue();
        pseudoQueue.enqueue(1);
        assertEquals(1, (int)pseudoQueue.stack.peek());
    }

    @Test public void testCanEnqueueMultiple() {
        PseudoQueue<Integer> pseudoQueue = new PseudoQueue();
        pseudoQueue.enqueue(1);
        pseudoQueue.enqueue(2);
        pseudoQueue.enqueue(3);
        assertEquals(3, (int)pseudoQueue.stack.peek());
    }

    @Test public void testCanDequeue() {
        PseudoQueue<Integer> pseudoQueue = new PseudoQueue();
        pseudoQueue.enqueue(1);
        assertEquals(1, (int)pseudoQueue.dequeue());
        assertNull(pseudoQueue.stack.peek());
    }

    @Test public void testCanDequeueMultiple() {
        PseudoQueue<Integer> pseudoQueue = new PseudoQueue();
        pseudoQueue.enqueue(1);
        pseudoQueue.enqueue(2);
        pseudoQueue.enqueue(3);
        pseudoQueue.dequeue();
        pseudoQueue.dequeue();
        assertEquals(3, (int)pseudoQueue.dequeue());
        assertNull(pseudoQueue.stack.peek());
    }
}
