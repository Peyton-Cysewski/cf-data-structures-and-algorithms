using System;
using Xunit;
using StacksAndQueues;

namespace StacksAndQueuesTests
{
    public class QueueTests
    {
        [Fact]
        public void EnqueueWorks()
        {
            // Assign
            Queue queue = new Queue();
            // Act
            queue.Enqueue(4);
            int expected = 4;
            int actual = queue.Rear.Value;
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void EnqueueWorksWithMultipleItems()
        {
            // Assign
            Queue queue = new Queue();
            // Act
            queue.Enqueue(4);
            queue.Enqueue(6);
            queue.Enqueue(9);
            int expectedFront = 4;
            int actualFront = queue.Front.Value;
            int expectedRear = 4;
            int actualRear = queue.Rear.Value;
            // Assert
            Assert.Equal(expectedFront, actualFront);
            Assert.Equal(expectedRear, actualRear);
        }

        [Fact]
        public void DequeueWorks()
        {
            // Assign
            Queue queue = new Queue();
            // Act
            queue.Enqueue(4);
            queue.Enqueue(6);
            queue.Enqueue(8);
            int expected = 4;
            int actual = queue.Dequeue();
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PeekWorks()
        {
            // Assign
            Queue queue = new Queue();
            // Act
            queue.Enqueue(4);
            queue.Enqueue(6);
            queue.Enqueue(8);
            int expected = 4;
            int actual = queue.Peek();
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void IsEmptyWorksAndCanInstantiateAnEmptyQueue()
        {
            // Assign
            Queue queue = new Queue();
            // Act
            bool result = queue.IsEmpty();
            // Assert
            Assert.True(result);
        }

        [Fact]
        public void ThrowsExceptionWithPeekOnEmptyArray()
        {
            // Assign
            Queue queue = new Queue();
            // Act
            bool result = queue.IsEmpty();
            // Assert
            Assert.True(result);
        }

    }
}
