using System;
using System.Collections.Generic;
using System.Text;
using StacksAndQueues;

namespace QueueWithStacks
{
    public class PseudoQueue
    {
        public Stack stack { get; set; }
        public PseudoQueue()
        {
            stack = new Stack();
        }

        public void Enqueue(int value)
        {
            stack.Push(value);
        }

        public int Dequeue()
        {
            Stack flipped = new Stack();
            while (stack.Top != null)
            {
                flipped.Push(stack.Pop());
            }
            int value = flipped.Pop();
            while (flipped.Top != null)
            {
                stack.Push(flipped.Pop());
            }
            return value;
        }
    }
}

