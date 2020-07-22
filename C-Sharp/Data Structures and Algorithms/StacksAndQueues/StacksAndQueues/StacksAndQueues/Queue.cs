using System;
using System.Text;

namespace StacksAndQueues
{
    public class Queue<Type>
    {
        public Node<Type> Front { get; set; }
        public Node<Type> Rear { get; set; }

        public Queue()
        {
            Rear = Front;
        }

        /// <summary>
        /// Addes a Node to the Rear of the queue
        /// </summary>
        /// <param name="value">The value of the added Node</param>
        public void Enqueue(Type value)
        {
            Node<Type> temp = new Node<Type>(value);
            if (Rear == null)
            {
                Front = temp;
                Rear = temp;
            }
            else
            {
                Rear.Next = temp;
                Rear = temp;
            }
        }

        /// <summary>
        /// Removes a Node from the Front of the queue
        /// </summary>
        /// <returns>Value of the removed Node</returns>
        public Type Dequeue()
        {
            if (Front == null)
                throw new NullReferenceException();
            else if (Front.Next == null)
            {
                Type temp = Front.Value;
                Front = null;
                Rear = Front;
                return temp;
            }
            else
            {
                Type temp = Front.Value;
                Front = Front.Next;
                return temp;
            }
        }

        /// <summary>
        /// Looks at the value of the Front Node
        /// </summary>
        /// <returns>Value of the Front Node</returns>
        public Type Peek()
        {
            return Front.Value;
        }

        /// <summary>
        /// Checks whether or not a queue is empty
        /// </summary>
        /// <returns>True if empty, False if not empty</returns>
        public bool IsEmpty()
        {
            if (Front == null) return true;
            else return false;
        }
    }
}
