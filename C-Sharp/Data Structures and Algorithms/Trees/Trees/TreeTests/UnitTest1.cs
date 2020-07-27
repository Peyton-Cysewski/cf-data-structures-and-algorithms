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
            int rightActual = tree.Root.LeftChild.Value;
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
    }
}
