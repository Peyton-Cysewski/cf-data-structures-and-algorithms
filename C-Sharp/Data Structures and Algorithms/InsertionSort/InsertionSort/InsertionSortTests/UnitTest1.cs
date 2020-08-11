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
    }
}
