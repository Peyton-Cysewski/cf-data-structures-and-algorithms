using System;
using Trees;
using Xunit;

namespace TreeTests
{
    public class Trees
    {
        [Fact]
        public void CanInstantiateEmptyTree()
        {
            // Assign
            Tree<int> tree = new Tree<int>();
            // Act
            var result = tree.Root;
            // Assert
            Assert.Null(result);
        }

        [Fact]
        public void CanInstantiateTreeWithOneRoot()
        {
            // Assign
            Tree<int> tree = new Tree<int>();
            Node<int> root = new Node<int>(1);
            tree.Root = root;
            // Act
            int expected = 1;
            int actual = tree.Root.Value;
            // Assert
            Assert.NotNull(tree.Root);
            Assert.IsType<Node<int>>(tree.Root);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CanAddChildrenToARoot()
        {
            // Assign
            Tree<int> tree = new Tree<int>(1);
            Node<int> left = new Node<int>(2);
            Node<int> right = new Node<int>(3);
            tree.Root.LeftChild = left;
            tree.Root.RightChild = right;
            // Act
            int leftExpected = 2;
            int leftActual = tree.Root.LeftChild.Value;
            int rightExpected = 3;
            int rightActual = tree.Root.RightChild.Value;
            // Assert
            Assert.Equal(leftExpected, leftActual);
            Assert.Equal(rightExpected, rightActual);
            Assert.NotNull(tree.Root.LeftChild);
            Assert.NotNull(tree.Root.RightChild);
        }

        [Fact]
        public void PreOrderWorks()
        {
            // Assign
            Tree<int> tree = new Tree<int>();
            Node<int> root = new Node<int>(1);
            Node<int> left = new Node<int>(2);
            Node<int> right = new Node<int>(3);
            Node<int> leftLeft = new Node<int>(4);
            Node<int> leftRight = new Node<int>(5);
            Node<int> rightLeft = new Node<int>(6);
            Node<int> rightRight = new Node<int>(7);
            left.LeftChild = leftLeft;
            left.RightChild = leftRight;
            right.LeftChild = rightLeft;
            right.RightChild = rightRight;
            root.LeftChild = left;
            root.RightChild = right;
            tree.Root = root;
            // Act
            int[] expected = new int[] { 1, 2, 4, 5, 3, 6, 7 };
            int[] actual = tree.PreOrder(tree.Root);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void InOrderWorks()
        {
            // Assign
            Tree<int> tree = new Tree<int>();
            Node<int> root = new Node<int>(1);
            Node<int> left = new Node<int>(2);
            Node<int> right = new Node<int>(3);
            Node<int> leftLeft = new Node<int>(4);
            Node<int> leftRight = new Node<int>(5);
            Node<int> rightLeft = new Node<int>(6);
            Node<int> rightRight = new Node<int>(7);
            left.LeftChild = leftLeft;
            left.RightChild = leftRight;
            right.LeftChild = rightLeft;
            right.RightChild = rightRight;
            root.LeftChild = left;
            root.RightChild = right;
            tree.Root = root;
            // Act
            int[] expected = new int[] { 4, 2, 5, 1, 6, 3, 7 };
            int[] actual = tree.InOrder(tree.Root);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PostOrderWorks()
        {
            // Assign
            Tree<int> tree = new Tree<int>();
            Node<int> root = new Node<int>(1);
            Node<int> left = new Node<int>(2);
            Node<int> right = new Node<int>(3);
            Node<int> leftLeft = new Node<int>(4);
            Node<int> leftRight = new Node<int>(5);
            Node<int> rightLeft = new Node<int>(6);
            Node<int> rightRight = new Node<int>(7);
            left.LeftChild = leftLeft;
            left.RightChild = leftRight;
            right.LeftChild = rightLeft;
            right.RightChild = rightRight;
            root.LeftChild = left;
            root.RightChild = right;
            tree.Root = root;
            // Act
            int[] expected = new int[] { 4, 5, 2, 6, 7, 3, 1 };
            int[] actual = tree.PostOrder(tree.Root);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FindMaximumValueWorks()
        {
            // Assign
            Tree<int> tree = new Tree<int>();
            Node<int> root = new Node<int>(1);
            Node<int> left = new Node<int>(2);
            Node<int> right = new Node<int>(3);
            Node<int> leftLeft = new Node<int>(4);
            Node<int> leftRight = new Node<int>(5);
            Node<int> rightLeft = new Node<int>(6);
            Node<int> rightRight = new Node<int>(7);
            left.LeftChild = leftLeft;
            left.RightChild = leftRight;
            right.LeftChild = rightLeft;
            right.RightChild = rightRight;
            root.LeftChild = left;
            root.RightChild = right;
            tree.Root = root;
            // Act
            int expected = 7;
            int actual = tree.FindMaximumValue();
            // Assert
            Assert.Equal(expected, actual);
        }

    }
    public class BinarySearchTrees
    {
        [Fact]
        public void CanAddToBinarySearchTree()
        {
            // Assign
            BinarySearchTree bst = new BinarySearchTree();
            Node<int> root = new Node<int>(4);
            Node<int> left = new Node<int>(2);
            Node<int> right = new Node<int>(6);
            Node<int> leftLeft = new Node<int>(1);
            Node<int> leftRight = new Node<int>(3);
            Node<int> rightLeft = new Node<int>(5);
            Node<int> rightRight = new Node<int>(7);
            left.LeftChild = leftLeft;
            left.RightChild = leftRight;
            right.LeftChild = rightLeft;
            right.RightChild = rightRight;
            root.LeftChild = left;
            root.RightChild = right;
            bst.Root = root;
            // Act
            bst.Add(5);
            int expected = 5;
            int actual = bst.Root.RightChild.LeftChild.LeftChild.Value;
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CanSearchBinarySearchTree()
        {
            // Assign
            BinarySearchTree bst = new BinarySearchTree();
            Node<int> root = new Node<int>(4);
            Node<int> left = new Node<int>(2);
            Node<int> right = new Node<int>(6);
            Node<int> leftLeft = new Node<int>(1);
            Node<int> leftRight = new Node<int>(3);
            Node<int> rightLeft = new Node<int>(5);
            Node<int> rightRight = new Node<int>(7);
            left.LeftChild = leftLeft;
            left.RightChild = leftRight;
            right.LeftChild = rightLeft;
            right.RightChild = rightRight;
            root.LeftChild = left;
            root.RightChild = right;
            bst.Root = root;
            // Act
            bool result = bst.Contains(6);
            bool falseResult = bst.Contains(8);
            // Assert
            Assert.True(result);
            Assert.False(falseResult);
        }
    }
}
