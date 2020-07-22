using System;
using Xunit;
using StacksAndQueues;

namespace StacksAndQueuesTests
{
    public class StackTests
    {
        [Fact]
        public void CanInstantiateEmptyStack()
        {
            // Assign
            Stack<int> stack = new Stack<int>();
            // Act
            // Assert
            Assert.Throws<NullReferenceException>(() => stack.Top.Value);
        }

        [Fact]
        public void PushWorks()
        {
            // Assign
            Stack<int> stack = new Stack<int>();
            // Act
            stack.Push(5);
            int expected = 5;
            int actual = stack.Top.Value;
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CanPushMultipleItemsToAStack()
        {
            // Assign
            Stack<int> stack = new Stack<int>();
            // Act
            stack.Push(5);
            stack.Push(6);
            stack.Push(34);
            int expected = 34;
            int actual = stack.Top.Value;
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PopReturnCorrectValue()
        {
            // Assign
            Stack<int> stack = new Stack<int>();
            // Act
            stack.Push(9);
            stack.Push(4);
            stack.Push(81);
            int expected = 81;
            int actual = stack.Pop();
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TopIsCorrectAfterPop()
        {
            // Assign
            Stack<int> stack = new Stack<int>();
            // Act
            stack.Push(9);
            stack.Push(4);
            stack.Push(81);
            stack.Pop();
            int expected = 4;
            int actual = stack.Top.Value;
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CanDoMultiplePops()
        {
            // Assign
            Stack<int> stack = new Stack<int>();
            // Act
            stack.Push(9);
            stack.Push(4);
            stack.Push(81);
            stack.Pop();
            stack.Pop();
            int expected = 9;
            int actual = stack.Pop();
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PopThrowsExceptionOnEmptyStack()
        {
            // Assign
            Stack<int> stack = new Stack<int>();
            // Act
            stack.Push(9);
            stack.Push(4);
            stack.Push(81);
            stack.Pop();
            stack.Pop();
            stack.Pop();
            // Assert
            Assert.Throws<NullReferenceException>(() => stack.Pop());
        }

        [Fact]
        public void PeekWorks()
        {
            // Assign
            Stack<int> stack = new Stack<int>();
            // Act
            stack.Push(7);
            stack.Push(98);
            stack.Push(123);
            int expected = 123;
            int actual = stack.Peek();
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PeekThrowsWxceptionWithAnEmptyStack()
        {
            // Assign
            Stack<int> stack = new Stack<int>();
            // Act
            // Assert
            Assert.Throws<NullReferenceException>(() => stack.Peek());
        }
        [Fact]
        public void IsEmptyWorksWithEmptyStack()
        {
            // Assign
            Stack<int> stack = new Stack<int>();
            // Act
            bool result = stack.IsEmpty();
            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsEmptyWorksWithFilledStack()
        {
            // Assign
            Stack<int> stack = new Stack<int>();
            // Act
            stack.Push(1);
            bool result = stack.IsEmpty();
            // Assert
            Assert.False(result);
        }
    }
}
