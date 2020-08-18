using System;
using System.Collections;

namespace RepeatedWord
{
    public class RepeatedWord
    {
        public static string CheckRepeat(string language)
        {
            string[] words = language.Split('.', ' ', '-', '.');
            Hashtable exists = new Hashtable();
            for (int i = 0; i < words.Length; i++)
            {
                if (exists.ContainsKey(words[i].ToLower()))
                {
                    return words[i];
                }
                else
                {
                    exists.Add(words[i].ToLower(), null);
                }
            }
            return "no repeats";
        }
    }
}
