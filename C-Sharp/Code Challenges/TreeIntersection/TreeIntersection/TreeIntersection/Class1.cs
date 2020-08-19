using System;
using System.Collections.Generic;
using System.Collections;
using Trees;

namespace TreeIntersectionChallenge
{
    public static class TreeIntersection
    {
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

        private static List<int> Traverse(Node<int> node)
        {
            List<int> values = new List<int>();
            TraverseHelper(node, values);
            return values;
        }

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
