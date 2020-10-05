package tree;

import java.util.ArrayList;
import java.util.List;

public class Tree<T>
{
    public Node<T> root;
    public Tree() { }
    public Tree(T value)
    {
        Node<T> node = new Node<T>(value);
        root = node;
    }

    public T[] PreOrder(Node<T> root)
    {
        List<T> list = new ArrayList<>();
        PreOrder(list, root);
        return (T[])list.toArray();
    }

    private void PreOrder(List<T> list, Node<T> node)
    {
        list.Add(node.Value);
        if (node.LeftChild != null)
        {
            PreOrder(list, node.LeftChild);
        }
        if (node.RightChild != null)
        {
            PreOrder(list, node.RightChild);
        }
    }

    public T[] InOrder(Node<T> root)
    {
        List<T> list = new List<T>();
        InOrder(list, root);
        return list.ToArray();
    }

    private void InOrder(List<T> list, Node<T> node)
    {
        if (node.LeftChild != null)
        {
            InOrder(list, node.LeftChild);
        }
        list.Add(node.Value);
        if (node.RightChild != null)
        {
            InOrder(list, node.RightChild);
        }
    }

    public T[] PostOrder(Node<T> root)
    {
        List<T> list = new List<T>();
        PostOrder(list, root);
        return list.ToArray();
    }

    private void PostOrder(List<T> list, Node<T> node)
    {
        if (node.LeftChild != null)
        {
            PostOrder(list, node.LeftChild);
        }
        if (node.RightChild != null)
        {
            PostOrder(list, node.RightChild);
        }
        list.Add(node.Value);
    }

}
