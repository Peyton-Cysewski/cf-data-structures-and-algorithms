package tree;

public class BinarySearchTree {
    public Node Root;
    public BinarySearchTree(){}
    public BinarySearchTree(int value) {
        Node node = new Node(value);
        Root = node;
    }

    public void Add(int value) {
        Node node = new Node(value);
        var temp = Root;
        while (temp.leftChild != null && temp.rightChild != null) {
            if (node.value <= temp.value && temp.leftChild != null)
                temp = temp.leftChild;
            else if (node.value > temp.value && temp.rightChild != null)
                temp = temp.rightChild;
        }
        if (node.value <= temp.value)
            temp.leftChild = node;
        else if (node.value > temp.value)
            temp.rightChild = node;
    }

    public boolean Contains(int value) {
        var temp = Root;
        while (temp != null) {
            if (value < temp.value)
                temp = temp.leftChild;
            else if (value > temp.value)
                temp = temp.rightChild;
            else
                return true;
        }
        return false;
    }
}
