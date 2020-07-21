using System;
using Xunit;
using QueueWithStacks;

namespace PseudoQueueTests
{
    public class UnitTest1
    {
        [Fact]
        public void EnqueueAndDequeueWork()
        {
            // Assign
            PseudoQueue pseudo = new PseudoQueue();
            // Act
            pseudo.Enqueue(10);
            pseudo.Enqueue(15);
            pseudo.Enqueue(25);
            int expected = 10;
            int actual = pseudo.Dequeue();
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CanEnqueueAndDequeueMultipleItems()
        {
            // Assign
            PseudoQueue pseudo = new PseudoQueue();
            // Act
            pseudo.Enqueue(10);
            pseudo.Enqueue(15);
            pseudo.Enqueue(25);
            pseudo.Dequeue();
            pseudo.Dequeue();
            int expected = 25;
            int actual = pseudo.Dequeue();
            // Assert
            Assert.Equal(expected, actual);
        }


    }
}
