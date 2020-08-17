using System;
using Xunit;
using HashtableLibrary;

namespace HashtableTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanAddToHashtable()
        {
            // Assign
            var table = new Hashtable<int>(4);
            // Act
            table.Add("Number", 10);
            // Assert
            Assert.NotNull(table);
        }

        [Fact]
        public void CanGetvalue()
        {
            // Assign
            var table = new Hashtable<int>(16);
            // Act
            table.Add("Number", 10);
            int actual = table.Get("Number");
            int expected = 10;
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ContainsWorks()
        {
            // Assign
            var table = new Hashtable<int>(16);
            // Act
            table.Add("Number", 10);
            bool actual = table.Contains("Number");
            // Assert
            Assert.True(actual);
        }

        [Fact]
        public void CanHandleCollisionsAndGetValue()
        {
            // Assign
            var table = new Hashtable<int>(1);
            // Act
            table.Add("Number", 10);
            table.Add("Age", 5);
            table.Add("Weight", 1);
            int actual = table.Get("Age");
            int expected = 5;
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void WorksWithAKeyThatDoesNotExist()
        {
            // Assign
            var table = new Hashtable<int>(16);
            // Act
            table.Add("Number", 10);
            table.Add("Age", 5);
            table.Add("Weight", 1);
            var actual = table.Get(@"Doesn't Exist");
            var expected = default(int);
            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
