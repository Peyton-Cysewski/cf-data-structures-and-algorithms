using System;
using System.Collections.Generic;
using System.Text;

namespace Trees
{
    public class BinarySearchTree
    {
        public Node<int> Root { get; set; }
        public BinarySearchTree() { }
        public BinarySearchTree(int value)
        {
            Node<int> node = new Node<int>(value);
            Root = node;
        }

        public void Add(int value)
        {
            Node<int> node = new Node<int>(value);
            var temp = Root;
            while (temp.LeftChild != null && temp.RightChild != null)
            {
                if (node.Value <= temp.Value && temp.LeftChild != null)
                {
                    temp = temp.LeftChild;
                }
                else if (node.Value > temp.Value && temp.RightChild != null)
                {
                    temp = temp.RightChild;
                }
            }
            if (node.Value <= temp.Value)
            {
                temp.LeftChild = node;
            }
            else if (node.Value > temp.Value)
            {
                temp.RightChild = node;
            }
        }

        public bool Contains(int value)
        {
            var temp = Root;
            while (temp != null)
            {
                if (value < temp.Value)
                {
                    temp = temp.LeftChild;
                }
                else if (value > temp.Value)
                {
                    temp = temp.RightChild;
                }
                else
                {
                    return true;
                }
            }
            return false;
        }
    }
}
