using System;
using Xunit;
using static QuickSort.ArrayQuickSort;

namespace QuickSortTests
{
    public class UnitTest1
    {
        [Fact]
        public void QuickSortWorks()
        {
            // Assign
            int[] array = { 8, 4, 23, 42, 15, 16 };
            // Act
            Sort(array, 0, 5);
            int[] expected = { 4, 8, 15, 16, 23, 42 };
            // Assert
            Assert.Equal(expected, array);
        }

        [Fact]
        public void QuickSortWorksWithAnArrayOfLengthOne()
        {
            // Assign
            int[] array = { 1 };
            // Act
            Sort(array, 0, 0);
            int[] expected = { 1 };
            // Assert
            Assert.Equal(expected, array);
        }

        [Fact]
        public void QuickSortWorksWithAReversedArray()
        {
            // Assign
            int[] array = { 6, 5, 4, 3, 2, 1 };
            // Act
            Sort(array, 0, 5);
            int[] expected = { 1, 2, 3, 4, 5, 6 };
            // Assert
            Assert.Equal(expected, array);
        }

        [Fact]
        public void QuickSortWorksWithAnEmptyArray()
        {
            // Assign
            int[] array = null;
            // Act
            Sort(array, 0, 5);
            // Assert
            Assert.Null(array);
        }

        [Fact]
        public void QuickSortWorksWithRepeatValues()
        {
            // Assign
            int[] array = { 4, 7, 3, 7, 3, 7 };
            // Act
            Sort(array, 0, 5);
            int[] expected = { 3, 3, 4, 7, 7, 7 };
            // Assert
            Assert.Equal(expected, array);
        }
    }
}
