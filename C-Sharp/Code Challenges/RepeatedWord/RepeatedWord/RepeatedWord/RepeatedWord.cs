using System;
using System.Collections;

namespace RepeatedWord
{
    public class RepeatWords
    {
        /// <summary>
        /// Takes a string and finds the first word to be repeated.
        /// </summary>
        /// <param name="language">A string containing space or punctuation separated words.</param>
        /// <returns>First repeated word.</returns>
        public static string CheckRepeat(string language)
        {
            string[] words = language.Split(',', ' ', '-', '.');
            Hashtable exists = new Hashtable();
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] != "")
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
            }
            return "no repeats";
        }
    }
}
