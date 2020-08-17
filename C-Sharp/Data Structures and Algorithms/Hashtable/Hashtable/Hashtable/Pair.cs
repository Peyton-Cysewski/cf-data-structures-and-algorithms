using System;
using System.Collections.Generic;
using System.Text;

namespace HashtableLibrary
{
    public class Pair<T>
    {
        public string Key { get; set; }
        public T Value { get; set; }
        public Pair(string key, T value)
        {
            Key = key;
            Value = value;
        }
    }
}
