using System;

namespace StacksAndQueues
{
    public class Node<Type>
    {
        public Type Value { get; set; }
        public Node<Type> Next { get; set; }

        public Node(Type value)
        {
            Value = value;
        }
    }
}
