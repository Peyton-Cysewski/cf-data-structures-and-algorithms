using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues
{
    public class Stack
    {
        public Node Top { get; set; }

        /// <summary>
        /// Takes in a value then adds a new Node with that value to the top of the stack.
        /// </summary>
        /// <param name="value">Value stored in Node.</param>
        public void Push(int value)
        {
            Node temp = new Node(value);
            temp.Next = Top;
            Top = temp;
        }

        /// <summary>
        /// Removes the Top value off of the stack and returns it value.
        /// </summary>
        /// <returns>Value of top Node of the stack that is removed.</returns>
        public int Pop()
        {
            if (Top == null)
                throw new NullReferenceException();
            int temp = Top.Value;
            Top = Top.Next;
            return temp;
        }

        /// <summary>
        /// Looks to the Top of the stack and returns its value.
        /// </summary>
        /// <returns>Value of the Top of the stack.</returns>
        public int Peek()
        {
            if (Top == null)
                throw new NullReferenceException();
            return Top.Value;
        }

        /// <summary>
        /// Checks whether or not a stack has anything in it.
        /// </summary>
        /// <returns>True if empty. False if not empty.</returns>
        public bool IsEmpty()
        {
            if (Top == null) return true;
            else return false;
        }
    }
}
