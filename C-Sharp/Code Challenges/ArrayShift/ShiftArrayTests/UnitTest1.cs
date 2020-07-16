using System;
using Xunit;
using static ArrayShift.Program;

namespace ShiftArrayTests
{
    public class UnitTest1
    {
        [Fact]
        public void WorksForEvenLengthArrays()
        {
            // Arrange
            int[] inArray = new int[] { 2, 4, 6, 8 };
            int num = 5;

            int[] outArray = new int[] { 2, 4, 5, 6, 8 };
            // Act
            int[] outcome = insertShiftArray(inArray, num);

            // Assert
            Assert.Equal(outArray, outcome);
        }

        [Fact]
        public void WorksForOddLengthArrays()
        {
            // Arrange
            int[] inArray = new int[] { 4, 8, 15, 23, 42 };
            int num = 16;

            int[] outArray = new int[] { 4, 8, 15, 16, 23, 42 };
            // Act
            int[] outcome = insertShiftArray(inArray, num);

            // Assert
            Assert.Equal(outArray, outcome);
        }

        [Fact]
        public void WorksForZeroLengthArrays()
        {
            // Arrange
            int[] inArray = new int[0] {};
            int num = 1;

            int[] outArray = new int[] {1};
            // Act
            int[] outcome = insertShiftArray(inArray, num);

            // Assert
            Assert.Equal(outArray, outcome);
        }

        [Fact]
        public void CheckingAgainstImproperOutcome()
        {
            // Arrange
            int[] inArray = new int[] { 1, 2, 3, 4 };
            int num = 5;

            int[] outArray = new int[] { 1, 2, 3, 4, 5 };
            // Act
            int[] outcome = insertShiftArray(inArray, num);

            // Assert
            Assert.NotEqual(outArray, outcome);
        }

    }
}
