using System;
using StacksAndQueues;

namespace MultiBracketValidation
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] tests = new string[]
            {
                "{}",
                "{}(){}",
                "()[[Extra Characters]]",
                "(){}[[]]",
                "{}{Code}[Fellows](())",
                "[({}]",
                "(](",
                "{(})"
            };
            foreach (string line in tests)
            {
                Console.WriteLine($"{ValidateMultiBrackets(line)}");
            }
        }

        public static bool ValidateMultiBrackets(string input)
        {
            try
            {
                Stack<char> stack = new Stack<char>();
                foreach (char c in input)
                {
                    if (c == '(' || c == '[' || c == '{')
                    {
                        stack.Push(c);
                    }
                    else if (c == ')' || c == ']' || c == '}')
                    {
                        char popChar = stack.Pop();
                        if ((int)popChar - (int)c > 2)
                        {
                            return false;
                        }
                    }
                }
                return stack.IsEmpty();
            }
            catch
            {
                return false;
            }
        }
    }
}
