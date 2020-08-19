using System;
using System.Collections.Generic;
using System.Collections;
using Trees;

namespace TreeIntersectionChallenge
{
    public static class TreeIntersection
    {
        /// <summary>
        /// Takes in two trees and returns a list of any values that are shared between the two.
        /// </summary>
        /// <param name="tree1">Tree 1 object.</param>
        /// <param name="tree2">Tree 2 object.</param>
        /// <returns>List of shared values.</returns>
        public static List<int> FindIntersections(Tree<int> tree1, Tree<int> tree2)
        {
            HashSet<int> hashset = new HashSet<int>();
            List<int> intersections = new List<int>();
            List<int> treeList1 = Traverse(tree1.Root);
            foreach (int num in treeList1)
            {
                if (!hashset.Contains(num))
                {
                    hashset.Add(num);
                }
            }
            List<int> treeList2 = Traverse(tree2.Root);
            foreach (int num in treeList2)
            {
                if (hashset.Contains(num))
                {
                    if (!intersections.Contains(num))
                    {
                        intersections.Add(num);
                    }
                }
            }
            return intersections;
        }

        /// <summary>
        /// Traverses an tree in-order and returns a list of all the tree's values.
        /// </summary>
        /// <param name="node">Root tree node.</param>
        /// <returns>List of values.</returns>
        private static List<int> Traverse(Node<int> node)
        {
            List<int> values = new List<int>();
            TraverseHelper(node, values);
            return values;
        }

        /// <summary>
        /// Recurssive elper function for the Traversal method to sort in-order.
        /// </summary>
        /// <param name="node">Input node, starts as the root.</param>
        /// <param name="list">List that keeps track of all tree values.</param>
        private static void TraverseHelper(Node<int> node, List<int> list)
        {
            if (node.LeftChild != null)
            {
                TraverseHelper(node.LeftChild, list);
            }
            list.Add(node.Value);

            if (node.RightChild != null)
            {
                TraverseHelper(node.RightChild, list);
            }
        }
    }
}
