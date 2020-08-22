using System;
using System.Collections.Generic;

namespace HashtableLibrary
{
    public class Hashtable<T>
    {
        private LinkedList<LinkedListNode<Pair<T>>>[] Map { get; set; }
        public Hashtable(int size)
        {
            Map = new LinkedList<LinkedListNode<Pair<T>>>[size];
        }

        /// <summary>
        /// Uses the given Key and hashes an index for the Hashtable.
        /// </summary>
        /// <param name="key">Key to be hashed.</param>
        /// <param name="arraySize">Size of the Hashtable.</param>
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
        /// Adds a Key Value pair to the Hashtable.
        /// </summary>
        /// <param name="key">Pair Key.</param>
        /// <param name="value">Pair Value.</param>
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
        /// Takes in a Key and returns the associated Value.
        /// </summary>
        /// <param name="key">Target Key.</param>
        /// <returns>Value associated with Key. If no Value exists, then default value is returned.</returns>
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

        /// <summary>
        /// Checks whether a Key Value pair exists in the Hashtable.
        /// </summary>
        /// <param name="key">Target Key.</param>
        /// <returns>True if it exists in the the Hashtable, false if it does not.</returns>
        public bool Contains(string key)
        {
            int index = Hash(key, Map.Length);
            if (Map[index] != null)
            {
                var current = Map[index].First;
                while (current != null)
                {
                    if (current.Value.Value.Key == key)
                    {
                        return true;
                    }
                    current = current.Next;
                }
            }
            return false;
        }
    }
}
