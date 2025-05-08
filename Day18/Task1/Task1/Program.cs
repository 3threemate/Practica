using System;
using System.Collections.Generic;

class Program
{
    static string ProcessString(string input)
    {
        Stack<char> stack = new Stack<char>();

        foreach (char c in input)
        {
            if (c == '#')
            {
                if (stack.Count > 0)
                {
                    stack.Pop();
                }
            }
            else
            {
                stack.Push(c);
            }
        }

        return new string(stack.ToArray());
    }

    static void Main()
    {
        string input = "abbbc#d##c";
        string result = ProcessString(input);

        char[] arr = result.ToCharArray();
        Array.Reverse(arr);
        Console.WriteLine(new string(arr));
    }
}
