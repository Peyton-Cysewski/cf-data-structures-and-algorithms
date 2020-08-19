using System;
using Xunit;
using static TreeIntersectionChallenge.TreeIntersection;
using Trees;
using System.Collections.Generic;

namespace TreeIntersectionTesting
{
    public class UnitTest1
    {
        [Fact]
        public void IntersectionsAreDetectedProperly()
        {
            // Assign
            Tree<int> tree1 = new Tree<int>();
            Node<int> node1 = new Node<int>(5);
            tree1.Root = node1;
            Tree<int> tree2 = new Tree<int>();
            Node<int> node2 = new Node<int>(5);
            tree2.Root = node2;
            // Act
            List<int> actual = FindIntersections(tree1, tree2);
            List<int> expected = new List<int>() { 5 };
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void WorksWithNoIntersections()
        {
            // Assign
            Tree<int> tree1 = new Tree<int>();
            Node<int> node1 = new Node<int>(5);
            tree1.Root = node1;
            Tree<int> tree2 = new Tree<int>();
            Node<int> node2 = new Node<int>(7);
            tree2.Root = node2;
            // Act
            List<int> actual = FindIntersections(tree1, tree2);
            List<int> expected = new List<int>() { };
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void WorksWithAnEmptyTree()
        {
            // Assign
            Tree<int> tree1 = new Tree<int>();
            Tree<int> tree2 = new Tree<int>();
            Node<int> node2 = new Node<int>(5);
            tree2.Root = node2;
            // Act
            List<int> actual = FindIntersections(tree1, tree2);
            List<int> expected = new List<int>() { };
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MultipleIntersectionsAreDetectedProperly()
        {
            // Assign
            Tree<int> tree1 = new Tree<int>();
            Node<int> node1 = new Node<int>(1);
            Node<int> node2 = new Node<int>(2);
            Node<int> node3 = new Node<int>(3);
            Node<int> node4 = new Node<int>(4);
            Node<int> node5 = new Node<int>(5);
            Node<int> node6 = new Node<int>(6);
            Node<int> node7 = new Node<int>(7);

            node2.LeftChild = node4;
            node2.RightChild = node5;
            node3.LeftChild = node6;
            node3.RightChild = node7;
            node1.LeftChild = node2;
            node1.RightChild = node3;
            tree1.Root = node1;

            Tree<int> tree2 = new Tree<int>();
            Node<int> node8 = new Node<int>(8);
            Node<int> node9 = new Node<int>(9);
            Node<int> node10 = new Node<int>(3);
            Node<int> node11 = new Node<int>(10);
            Node<int> node12 = new Node<int>(11);
            Node<int> node13 = new Node<int>(1);
            Node<int> node14 = new Node<int>(2);

            node9.LeftChild = node11;
            node9.RightChild = node12;
            node10.LeftChild = node13;
            node10.RightChild = node14;
            node8.LeftChild = node9;
            node8.RightChild = node10;
            tree2.Root = node8;
            // Act
            List<int> actual = FindIntersections(tree1, tree2);
            List<int> expected = new List<int>() { 1, 3, 2 };
            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
