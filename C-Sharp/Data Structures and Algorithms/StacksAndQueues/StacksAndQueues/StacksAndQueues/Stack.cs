using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues
{
    public class Stack<Type>
    {
        public Node<Type> Top { get; set; }

        /// <summary>
        /// Takes in a value then adds a new Node with that value to the top of the stack.
        /// </summary>
        /// <param name="value">Value stored in Node.</param>
        public void Push(Type value)
        {
            Node<Type> temp = new Node<Type>(value);
            temp.Next = Top;
            Top = temp;
        }

        /// <summary>
        /// Removes the Top node off of the stack and returns its Value.
        /// </summary>
        /// <returns>Value of the Top Node of the stack that is removed.</returns>
        public Type Pop()
        {
            if (Top == null)
                throw new NullReferenceException();
            Type temp = Top.Value;
            Top = Top.Next;
            return temp;
        }

        /// <summary>
        /// Looks to the Top of the stack and returns its value.
        /// </summary>
        /// <returns>Value of the Top of the stack.</returns>
        public Type Peek()
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
