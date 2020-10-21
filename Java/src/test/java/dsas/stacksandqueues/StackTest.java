package dsas.stacksandqueues;

import org.junit.Test;
import static org.junit.Assert.*;

public class StackTest {
    @Test public void testCanInstantiate() {
        Stack<Integer> stack = new Stack();
        assertNotNull(stack);
    }

    @Test public void testCanPeek() {
        Stack<Integer> stack = new Stack();
        assertNull(stack.peek());
    }

    @Test public void testCanPush() {
        Stack<Integer> stack = new Stack();
        stack.push(1);
        assertEquals(1, (int)stack.peek());
    }

    @Test public void testCanPushMultiple() {
        Stack<Integer> stack = new Stack();
        stack.push(1);
        stack.push(2);
        stack.push(3);
        assertEquals(3, (int)stack.peek());
    }

    @Test public void testCanPop() {
        Stack<Integer> stack = new Stack();
        stack.push(1);
        assertEquals(1, (int)stack.pop());
        assertNull(stack.peek());
    }

    @Test public void testCanPopMultiple() {
        Stack<Integer> stack = new Stack();
        stack.push(1);
        stack.push(2);
        stack.push(3);
        stack.pop();
        stack.pop();
        assertEquals(1, (int)stack.pop());
        assertNull(stack.peek());
    }
}
