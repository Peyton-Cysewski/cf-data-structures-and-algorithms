using System;
using System.Collections.Generic;

namespace Trees
{
    public class Tree<T>
    {
        public Node<T> Root { get; set; }
        public Tree() { }
        public Tree(T value)
        {
            Node<T> node = new Node<T>(value);
            Root = node;
        }
        /// PreOrder
        #region
        /// <summary>
        /// Returns an array of the values contained in the tree ordered by the recursive pattern: root, right child, left child
        /// </summary>
        /// <param name="root">The node that will act as the upper root for the tree traversal</param>
        /// <returns>Ordered array of the tree's values starting from the given root</returns>
        public T[] PreOrder(Node<T> root)
        {
            List<T> list = new List<T>();
            PreOrder(list, root);
            return list.ToArray();
        }

        /// <summary>
        /// Indirect recursive method associated with its overload counterpart
        /// </summary>
        /// <param name="list">List of ordered values that is added to with each recursion</param>
        /// <param name="node">Current root node</param>
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
        #endregion

        /// InOrder
        #region
        /// <summary>
        /// Returns an array of the values contained in the tree ordered by the recursive pattern: right child, root, left child
        /// </summary>
        /// <param name="root">The node that will act as the upper root for the tree traversal</param>
        /// <returns>Ordered array of the tree's values starting from the given root</returns>
        public T[] InOrder(Node<T> root)
        {
            List<T> list = new List<T>();
            InOrder(list, root);
            return list.ToArray();
        }

        /// <summary>
        /// Indirect recursive method associated with its overload counterpart
        /// </summary>
        /// <param name="list">List of ordered values that is added to with each recursion</param>
        /// <param name="node">Current root node</param>
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
        #endregion

        /// PostOrder
        #region
        /// <summary>
        /// Returns an array of the values contained in the tree ordered by the recursive pattern: right child, left child, root
        /// </summary>
        /// <param name="root">The node that will act as the upper root for the tree traversal</param>
        /// <returns>Ordered array of the tree's values starting from the given root</returns>
        public T[] PostOrder(Node<T> root)
        {
            List<T> list = new List<T>();
            PostOrder(list, root);
            return list.ToArray();
        }

        /// <summary>
        /// Indirect recursive method associated with its overload counterpart
        /// </summary>
        /// <param name="list">List of ordered values that is added to with each recursion</param>
        /// <param name="node">Current root node</param>
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
        #endregion
    }
}
