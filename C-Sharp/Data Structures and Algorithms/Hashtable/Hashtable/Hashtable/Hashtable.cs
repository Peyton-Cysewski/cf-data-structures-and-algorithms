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

        /// <summary>
        /// Takes a key and hashes it into an index for a hashtable.
        /// </summary>
        /// <param name="key">Key that will be hashed.</param>
        /// <param name="arraySize">The length of the underlying hashtable array.</param>
        /// <returns></returns>
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

        /// <summary>
        /// Takes a Key and  Value and adds them to the hashtable.
        /// </summary>
        /// <param name="key">The name of the Key.</param>
        /// <param name="value">The Value associated with the Key.</param>
        public void Add(string key, T value)
        {
            int index = Hash(key, Map.Length);
            Pair<T> pair = new Pair<T>(key, value);
            LinkedListNode<Pair<T>> node = new LinkedListNode<Pair<T>>(pair);
            if (Map[index] is null)
            {
                Map[index] = new LinkedList<LinkedListNode<Pair<T>>>();
            }
            Map[index].AddLast(node);
        }

        /// <summary>
        /// Takes in a Key and returns the assocaited Value.
        /// </summary>
        /// <param name="key">The target Key.</param>
        /// <returns>The Value associated with the Key.</returns>
        public T Get(string key)
        {
            int index = Hash(key, Map.Length);
            if (Map[index] != null)
            {
                var current = Map[index].First;
                while (current != null)
                {
                    if (current.Value.Value.Key == key)
                    {
                        return current.Value.Value.Value;
                    }
                    current = current.Next;
                }
            }
            return default;
        }

        /// <summary>
        /// Checks whether the hashtable contains a tergeted Key.
        /// </summary>
        /// <param name="key">Target Key.</param>
        /// <returns>True if the target Key exists, false if it doesn't.</returns>
        public bool Contains(string key)
        {
            int index = Hash(key, Map.Length);
            var current = Map[index].First;
            while (current != null)
            {
                if (current.Value.Value.Key == key)
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }
    }
}
