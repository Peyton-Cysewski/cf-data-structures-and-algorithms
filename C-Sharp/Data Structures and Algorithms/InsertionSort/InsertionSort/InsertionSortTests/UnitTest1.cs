using System;
using Xunit;
using static InsertionSort.ArrayInsertionSort;

namespace InsertionSortTests
{
    public class UnitTest1
    {
        [Fact]
        public void InsertionSortWorks()
        {
            // Assign
            int[] array = { 8, 4, 23, 42, 15, 16 };
            // Act
            Sort(array);
            int[] expected = { 4, 8, 15, 16, 23, 42 };
            // Assert
            Assert.Equal(expected, array);
        }

        [Fact]
        public void InsertionSortWorksWithEmptyArray()
        {
            // Assign
            int[] array = { };
            // Act
            Sort(array);
            int[] expected = { };
            // Assert
            Assert.Equal(expected, array);
        }

        [Fact]
        public void InsertionSortWorksWithRepeats()
        {
            // Assign
            int[] array = { 8, 5, 5, 8, 9, 5 };
            // Act
            Sort(array);
            int[] expected = { 5, 5, 5, 8, 8, 9 };
            // Assert
            Assert.Equal(expected, array);
        }

        [Fact]
        public void InsertionSortWorksWithAnInvertedArray()
        {
            // Assign
            int[] array = { 6, 5, 4, 3, 2, 1 };
            // Act
            Sort(array);
            int[] expected = { 1, 2, 3, 4, 5, 6 };
            // Assert
            Assert.Equal(expected, array);
        }

        [Fact]
        public void InsertionSortWorksWithAPreSortedArray()
        {
            // Assign
            int[] array = { 2, 5, 6, 9, 12, 42 };
            // Act
            Sort(array);
            int[] expected = { 2, 5, 6, 9, 12, 42 };
            // Assert
            Assert.Equal(expected, array);
        }

        [Fact]
        public void InsertionSortReferencesTheSameArray()
        {
            // Assign
            int[] array = { 2, 5, 6, 9, 12, 42 };
            var reference = array;
            // Act
            Sort(array);
            // Assert
            Assert.Same(reference, array);
        }
    }
}
