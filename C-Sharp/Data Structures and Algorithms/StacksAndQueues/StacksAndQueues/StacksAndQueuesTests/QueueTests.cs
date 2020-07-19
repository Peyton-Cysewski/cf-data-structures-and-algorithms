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
    }
}
