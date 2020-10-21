package dsas.stacksandqueues;

public class Stack<T> {
    private Node<T> top = null;

    public boolean isEmpty () { return top == null; }

    public T peek() { return isEmpty() ? null : top.value; }

    public void push(T value) {
        Node<T> node = new Node(value);
        if (!isEmpty())
            node.next = top;
        top = node;
    }

    public T pop() {
        if (isEmpty()) { return null; }
        Node<T> node = top;
        top = top.next;
        return node.value;
    }
}
