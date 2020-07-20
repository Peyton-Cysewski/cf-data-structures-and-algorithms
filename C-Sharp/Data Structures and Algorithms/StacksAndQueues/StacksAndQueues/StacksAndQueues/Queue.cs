using System;
using System.Text;

namespace StacksAndQueues
{
    public class Queue
    {
        public Node Front { get; set; }
        public Node Rear { get; set; }

        public Queue()
        {
            Rear = Front;
        }

        public void Enqueue(int value)
        {
            Node temp = new Node(value);
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

        public int Dequeue()
        {
            if (Front == null)
                throw new NullReferenceException();
            else if (Front.Next == null)
            {
                int temp = Front.Value;
                Front = null;
                Rear = Front;
                return temp;
            }
            else
            {
                int temp = Front.Value;
                Front = Front.Next;
                return temp;
            }
        }

        public int Peek()
        {
            return Front.Value;
        }

        public bool IsEmpty()
        {
            if (Front == null) return true;
            else return false;
        }
    }
}
