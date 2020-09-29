package stacksandqueues;

public class PseudoQueue<T> {
    public Stack<T> stack = new Stack();

    public void enqueue(T value) {
        stack.push(value);
    }

    public T dequeue() {
        Stack<T> flipped = new Stack();
        while (stack.peek() != null) {
            flipped.push(stack.pop());
        }
        T value = flipped.pop();
        while (flipped.peek() != null) {
            stack.push(flipped.pop());
        }
        return value;
    }
}
