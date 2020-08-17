using System;
using System.Collections;
using System.Collections.Generic;

namespace HashtableLibrary
{
    public class Hashtable<T>
    {
        public LinkedList<LinkedListNode<Pair<T>>>[] Map { get; set; }
        public Hashtable(int size)
        {
            Map = new LinkedList<LinkedListNode<Pair<T>>>[size];
        }

        private int Hash(string key, int arraySize)
        {
            int val = 0;
            for (int i = 0; i < key.Length; i++)
            {
                val += (key[i] + 1) * i;
            }
            int index = (val * 4999) % arraySize;
            return index;
        }

        public void Add(string key, T value)
        {
            int index = Hash(key, Map.Length);
            Pair<T> pair = new Pair<T>(key, value);
            LinkedListNode<Pair<T>> node = new LinkedListNode<Pair<T>>(pair);
            if (Map[index] is null)
            {
                Map[index] = new LinkedList<LinkedListNode<Pair<T>>>;
            }
            Map[index].AddLast(node);
        }

        public T Get(string key)
        {
            int index = Hash(key, Map.Length);
            var current = Map[index].First;
            while (current != null)
            {
                if (current.Value.Value.Key == key)
                {
                    return current.Value.Value.Value;
                }
                current = current.Next;
            }
            return default;
        }
    }
}
