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
    }
}
