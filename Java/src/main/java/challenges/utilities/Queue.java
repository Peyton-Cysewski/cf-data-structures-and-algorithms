package challenges.utilities;

public class Queue<T> {
    private Node<T> front = null;
    private Node<T> rear = null;

    public boolean isEmpty() { return front == null; }

    public T peek() { return isEmpty() ? null : front.value; }

    public void enqueue(T value) {
        Node<T> node = new Node(value);
        if (isEmpty())
            front = node;
        else
            rear.next = node;
        rear = node;
    }

    public T dequeue() {
        if (isEmpty()) { return null; }
        Node<T> node = front;
        front = front.next;
        return node.value;
    }
}
