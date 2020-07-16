using System;
using Xunit;
using LinkedListLibrary;
using static LLZip.Program;

namespace Lab08Tests
{
    public class UnitTest1
    {
        [Fact]
        public void ZipsTwoEqualLengthLists()
        {
            // Assign
            LinkedList list1 = new LinkedList();
            LinkedList list2 = new LinkedList();
            LinkedList list3 = new LinkedList();
            list1.Insert(1);
            list1.Append(3);
            list1.Append(5);
            list2.Insert(2);
            list2.Append(4);
            list2.Append(6);
            list3.Head = zipLists(list1, list2);
            // Act
            string expected = "1 -> 2 -> 3 -> 4 -> 5 -> 6 -> NULL";
            string actual = list3.ToString();
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ZipsTwoUnequalLengthListsFirstIsLonger()
        {
            // Assign
            LinkedList list1 = new LinkedList();
            LinkedList list2 = new LinkedList();
            LinkedList list3 = new LinkedList();
            list1.Insert(1);
            list1.Append(3);
            list1.Append(5);
            list1.Append(7);
            list2.Insert(2);
            list2.Append(4);
            list2.Append(6);
            list3.Head = zipLists(list1, list2);
            // Act
            string expected = "1 -> 2 -> 3 -> 4 -> 5 -> 6 -> 7 -> NULL";
            string actual = list3.ToString();
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ZipsTwoUnequalLengthListsSecondIsLonger()
        {
            // Assign
            LinkedList list1 = new LinkedList();
            LinkedList list2 = new LinkedList();
            LinkedList list3 = new LinkedList();
            list1.Insert(1);
            list1.Append(3);
            list1.Append(5);
            list2.Insert(2);
            list2.Append(4);
            list2.Append(6);
            list2.Append(8);
            list3.Head = zipLists(list1, list2);
            // Act
            string expected = "1 -> 2 -> 3 -> 4 -> 5 -> 6 -> 8 -> NULL";
            string actual = list3.ToString();
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ZipsTwoUnequalLengthListsFirstIsWayLonger()
        {
            // Assign
            LinkedList list1 = new LinkedList();
            LinkedList list2 = new LinkedList();
            LinkedList list3 = new LinkedList();
            list1.Insert(1);
            list1.Append(3);
            list1.Append(5);
            list1.Append(7);
            list1.Append(9);
            list1.Append(11);
            list2.Insert(2);
            list2.Append(4);
            list2.Append(6);
            list3.Head = zipLists(list1, list2);
            // Act
            string expected = "1 -> 2 -> 3 -> 4 -> 5 -> 6 -> 7 -> 9 -> 11 -> NULL";
            string actual = list3.ToString();
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ZipsTwoUnequalLengthListsSecondWayIsLonger()
        {
            // Assign
            LinkedList list1 = new LinkedList();
            LinkedList list2 = new LinkedList();
            LinkedList list3 = new LinkedList();
            list1.Insert(1);
            list1.Append(3);
            list1.Append(5);
            list2.Insert(2);
            list2.Append(4);
            list2.Append(6);
            list2.Append(8);
            list2.Append(10);
            list2.Append(12);
            list3.Head = zipLists(list1, list2);
            // Act
            string expected = "1 -> 2 -> 3 -> 4 -> 5 -> 6 -> 8 -> 10 -> 12 -> NULL";
            string actual = list3.ToString();
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ZipsTwoListsFirstOneIsEmpty()
        {
            // Assign
            LinkedList list1 = new LinkedList();
            LinkedList list2 = new LinkedList();
            LinkedList list3 = new LinkedList();
            list2.Insert(2);
            list2.Append(4);
            list2.Append(6);
            list3.Head = zipLists(list1, list2);
            // Act
            string expected = "2 -> 4 -> 6 -> NULL";
            string actual = list3.ToString();
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ZipsTwoListsSecondOneIsEmpty()
        {
            // Assign
            LinkedList list1 = new LinkedList();
            LinkedList list2 = new LinkedList();
            LinkedList list3 = new LinkedList();
            list1.Insert(1);
            list1.Append(3);
            list1.Append(5);
            list3.Head = zipLists(list1, list2);
            // Act
            string expected = "1 -> 3 -> 5 -> NULL";
            string actual = list3.ToString();
            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
