using System.Collections;
using System.Collections.Generic;

namespace LeftJoin
{
    public static class LeftJoin
    {
        /// <summary>
        /// Takes two hashtable in the form of Dictionary objects and returns a jagged array wherein each inner array contains the shared keys and all values.
        /// </summary>
        /// <param name="table1">Left Dictionary.</param>
        /// <param name="table2">Right Dictionary.</param>
        /// <returns>LeftJoined jagged array.</returns>
        public static string[][] Join(Dictionary<string, string> table1, Dictionary<string, string> table2)
        {
            string[][] joined = new string[table1.Count][];
            int i;
            for (i = 0; i < joined.Length;i++)
            {
                joined[i] = new string[3];
            }
            var keys1 = table1.Keys;
            i = 0;
            foreach (var key in keys1)
            {
                joined[i][0] = key.ToString();
                joined[i][1] = table1.TryGetValue(key, out string value) ? value : "null";
                i++;
            }
            for (i = 0; i < joined.Length; i++)
            {
                    joined[i][2] = table2.TryGetValue(joined[i][0], out string value) ? value : "null";
            }
            return joined;
        }
    }
}
