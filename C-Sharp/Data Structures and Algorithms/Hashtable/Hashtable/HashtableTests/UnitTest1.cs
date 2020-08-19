using System;
using Xunit;
using HashtableLibrary;

namespace HashtableTests
{
    public class UnitTest1
    {
        [Fact]
        public void HashtableAddAndGetWorks()
        {
            // Assign
            Hashtable<int> hashtable = new Hashtable<int>(16);
            // Act
            hashtable.Add("Test", 10);
            int actual = hashtable.Get("Test");
            int expected = 10;
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void HashtableWorksWithCollisions()
        {
            // Assign
            Hashtable<int> hashtable = new Hashtable<int>(1);
            // Act
            hashtable.Add("Test", 10);
            hashtable.Add("Test2", 11);
            hashtable.Add("Test3", 12);
            int actual = hashtable.Get("Test3");
            int expected = 12;
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void HashtableContainsWorks()
        {
            // Assign
            Hashtable<int> hashtable = new Hashtable<int>(16);
            // Act
            hashtable.Add("Test", 10);
            bool result = hashtable.Contains("Test");
            // Assert
            Assert.True(result);
        }

        [Fact]
        public void HashtableContainsReturnsFalse()
        {
            // Assign
            Hashtable<int> hashtable = new Hashtable<int>(16);
            // Act
            hashtable.Add("Test", 10);
            bool result = hashtable.Contains("Not Test");
            // Assert
            Assert.False(result);
        }
    }
}
