package tree;

public class Node<T>
{
    public Node<T> leftChild;
    public Node<T> rightChild;
    public T value;

    public Node(T value)
    {
        this.value = value;
    }

    public Node<T> getLeftChild() { return leftChild;}
    public void setLeftChild(Node<T> leftChild) { this.leftChild = leftChild; }

    public Node<T> getRightChild() { return rightChild; }
    public void setRightChild(Node<T> rightChild) { this.rightChild = rightChild; }

    public T getValue() { return value; }
    public void setValue(T value) { this.value = value; }
}
