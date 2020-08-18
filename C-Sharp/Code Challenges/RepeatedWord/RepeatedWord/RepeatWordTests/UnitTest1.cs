using System;
using Xunit;
using static RepeatedWord.RepeatWords;

namespace RepeatWordTests
{
    public class UnitTest1
    {
        [Fact]
        public void CheckRepeatsWorks()
        {
            // Assign
            string test1 = "Once upon a time, there was a brave princess who...";
            string test2 = "It was the best of times, it was the worst of times, it was the age of wisdom, it was the age of foolishness, it was the epoch of belief, it was the epoch of incredulity, it was the season of Light, it was the season of Darkness, it was the spring of hope, it was the winter of despair, we had everything before us, we had nothing before us, we were all going direct to Heaven, we were all going direct the other way – in short, the period was so far like the present period, that some of its noisiest authorities insisted on its being received, for good or for evil, in the superlative degree of comparison only...";
            string test3 = "It was a queer, sultry summer, the summer they electrocuted the Rosenbergs, and I didn’t know what I was doing in New York...";
            string expected1 = "a";
            string expected2 = "it";
            string expected3 = "summer";
            // Act
            string actual1 = CheckRepeat(test1);
            string actual2 = CheckRepeat(test2);
            string actual3 = CheckRepeat(test3);
            // Assert
            Assert.Equal(expected1, actual1);
            Assert.Equal(expected2, actual2);
            Assert.Equal(expected3, actual3);
        }

        [Fact]
        public void CheckRepeatsWorksWithNoRepeats()
        {
            // Assign
            string test1 = "This sentence has no repeats at all.";
            string expected1 = "no repeats";
            // Act
            string actual1 = CheckRepeat(test1);
            // Assert
            Assert.Equal(expected1, actual1);
        }

        [Fact]
        public void CheckRepeatsWorksWithEmptyStrings()
        {
            // Assign
            string test1 = "";
            string expected1 = "no repeats";
            // Act
            string actual1 = CheckRepeat(test1);
            // Assert
            Assert.Equal(expected1, actual1);
        }
    }

}
