using System;
using Xunit;
using static MergeSort.ArrayMergeSort;

namespace MergeSortTests
{
    public class UnitTest1
    {
        [Fact]
        public void MergeSortWorks()
        {
            // Assign
            int[] array = { 8, 4, 23, 42, 16, 15 };
            // Act
            Sort(array);
            int[] expected = { 4, 8, 15, 16, 23, 42 };
            // Assert
            Assert.Equal(expected, array);
        }

        [Fact]
        public void MergeSortWorksWithNullArray()
        {
            // Assign
            int[] array = null;
            // Act
            Sort(array);
            // Assert
            Assert.Null(array);
        }

        [Fact]
        public void MergeSortWorksWithInvertedArray()
        {
            // Assign
            int[] array = { 6,5,4,3,2,1 };
            // Act
            Sort(array);
            int[] expected = { 1,2,3,4,5,6 };
            // Assert
            Assert.Equal(expected, array);
        }
    }
}
