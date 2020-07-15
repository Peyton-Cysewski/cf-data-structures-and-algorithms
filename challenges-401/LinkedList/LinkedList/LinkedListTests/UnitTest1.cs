using System;
using Xunit;
using LinkedListLibrary;

namespace LinkedListTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanInstantiateEmptyLinkedList()
        {
            LinkedList list = new LinkedList();
            Assert.Null(list.Head);
        }

        [Fact]
        public void CanInsertIntoLinkedList()
        {
            // insert means add to the front
            //Arrange
            LinkedList list = new LinkedList();
            list.Insert(4);
            Assert.Equal(4, list.Head.Value);
        }

        [Fact]
        public void CanInsertMultipleNodesInLinkedList()
        {
            LinkedList list = new LinkedList();
            list.Insert(4);
            list.Insert(8);
            list.Insert(15);
            list.Insert(16);
            list.Insert(23);
            list.Insert(42);

            Assert.Equal(42, list.Head.Value);

        }

        [Fact]
        public void CanFindValueInList()
        {
            // arrange
            LinkedList list = new LinkedList();

            list.Insert(4);
            list.Insert(8);
            list.Insert(15);
            list.Insert(16);
            list.Insert(23);
            list.Insert(42);

            // Act 
            int searchForValue = 15;
            bool exists = list.Includes(searchForValue);

            // Assert
            Assert.True(exists);

        }

        [Fact]
        public void CannotFindValueInLinkedList()
        {
            // arrange
            LinkedList list = new LinkedList();

            list.Insert(4);
            list.Insert(8);
            list.Insert(15);
            list.Insert(16);
            list.Insert(23);
            list.Insert(42);

            // Act 
            int searchForValue = 100;
            bool exists = list.Includes(searchForValue);

            // Assert
            Assert.False(exists);

        }

        [Fact]
        public void CanReturnAllValuesInLinkedList()
        {
            // Arrange
            LinkedList list = new LinkedList();
            list.Insert(4);
            list.Insert(8);
            list.Insert(15);
            list.Insert(16);
            list.Insert(23);
            list.Insert(42);

            // Act
            string value = list.ToString();

            string expected = "42 -> 23 -> 16 -> 15 -> 8 -> 4 -> NULL";
            // Assert
            Assert.Equal(expected, value);

        }
    }

    public class UnitTestPart2
    {
        [Fact]
        public void AppendWorks()
        {
            // Assign
            LinkedList list = new LinkedList();
            list.Insert(4);
            list.Insert(8);
            list.Insert(15);
            list.Insert(16);
            list.Insert(23);
            list.Insert(42);
            // Act
            list.Append(10);
            string actual = list.ToString();
            string expected = "42 -> 23 -> 16 -> 15 -> 8 -> 4 -> 10 -> NULL";
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AppendWorksWithMultipleNodes()
        {
            // Assign
            LinkedList list = new LinkedList();
            list.Insert(4);
            list.Insert(8);
            list.Insert(15);
            list.Insert(16);
            list.Insert(23);
            list.Insert(42);
            // Act
            list.Append(10);
            list.Append(11);
            list.Append(12);
            string actual = list.ToString();
            string expected = "42 -> 23 -> 16 -> 15 -> 8 -> 4 -> 10 -> 11 -> 12 -> NULL";
            // Assert
            Assert.Equal(expected, actual);
        }

    }

    public class UnitTestPart3
    {
        [Fact]
        public void kthFromEndWorks()
        {
            // Assign
            LinkedList list = new LinkedList();
            list.Insert(5);
            list.Insert(4);
            list.Insert(3);
            list.Insert(2);
            list.Insert(1);
            //Act
            int actual = list.kthFromEnd(2);
            int expected = 3;
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void kthFromEndWorksWithListOfLengthOne()
        {
            // Assign
            LinkedList list = new LinkedList();
            list.Insert(1);
            //Act
            int actual = list.kthFromEnd(0);
            int expected = 1;
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void kthFromEndWorksWhenKIsTheLengthOfTheListZeroBased()
        {
            // Assign
            LinkedList list = new LinkedList();
            list.Insert(5);
            list.Insert(4);
            list.Insert(3);
            list.Insert(2);
            list.Insert(1);
            //Act
            int actual = list.kthFromEnd(4);
            int expected = 1;
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void kthFromEndWorksWhenKIsLessThanZeroByWrapping()
        {
            // Assign
            LinkedList list = new LinkedList();
            list.Insert(5);
            list.Insert(4);
            list.Insert(3);
            list.Insert(2);
            list.Insert(1);
            //Act
            int actual = list.kthFromEnd(-4);
            int expected = 4;
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void kthFromEndThrowsExceptionWhenKIsGreaterThanTheLengthOfTheListZeroBased()
        {
            // Assign
            LinkedList list = new LinkedList();
            list.Insert(5);
            list.Insert(4);
            list.Insert(3);
            list.Insert(2);
            list.Insert(1);
            //Act
            var ex = Assert.Throws<Exception>(() => list.kthFromEnd(5));
            string actual = "Reference is out of bounds of the length of the list.";
            string expected = ex.Message;
            // Assert
            Assert.Equal(expected, actual);
        }
    }
}