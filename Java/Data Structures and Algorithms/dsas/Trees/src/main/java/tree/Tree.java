package tree;

import java.util.ArrayList;
import java.util.List;

public class Tree {
    public Node root;
    public Tree() { }
    public Tree(int value) {
        Node node = new Node(value);
        root = node;
    }

    public Node getRoot() { return root; }
    public void setRoot(Node root) { this.root = root; }

    public Object[] PreOrder(Node root) {
        List<Integer> list = new ArrayList<>();
        PreOrder(list, root);
        return list.toArray();
    }

    public Object[] PreOrder() {
        Node root = this.root;
        List<Integer> list = new ArrayList<>();
        PreOrder(list, root);
        return list.toArray();
    }

    private void PreOrder(List<Integer> list, Node node) {
        list.add(node.value);
        if (node.leftChild != null)
            PreOrder(list, node.leftChild);
        if (node.rightChild != null)
            PreOrder(list, node.rightChild);
    }

    public Object[] InOrder(Node root) {
        List<Integer> list = new ArrayList<>();
        InOrder(list, root);
        return list.toArray();
    }

    public Object[] InOrder() {
        Node root = this.root;
        List<Integer> list = new ArrayList<>();
        InOrder(list, root);
        return list.toArray();
    }

    private void InOrder(List<Integer> list, Node node) {
        if (node.leftChild != null)
            InOrder(list, node.leftChild);
        list.add(node.value);
        if (node.rightChild != null)
            InOrder(list, node.rightChild);
    }

    public Object[] PostOrder(Node root) {
        List<Integer> list = new ArrayList<>();
        PostOrder(list, root);
        return list.toArray();
    }

    public Object[] PostOrder() {
        Node root = this.root;
        List<Integer> list = new ArrayList<>();
        PostOrder(list, root);
        return list.toArray();
    }

    private void PostOrder(List<Integer> list, Node node) {
        if (node.leftChild != null)
            PostOrder(list, node.leftChild);
        if (node.rightChild != null)
            PostOrder(list, node.rightChild);
        list.add(node.value);
    }

    public int findMax() {
        if (root == null) throw new NullPointerException();
        return findMax(this.root, this.root.value);
    }

    private int findMax(Node node, int max) {
        if (node.value > max) {
            max = node.value;
        if (node.leftChild != null)
            max = findMax(node.leftChild, max);
        if (node.rightChild != null)
            max = findMax(node.rightChild, max);
        }
        return max;
    }

}
