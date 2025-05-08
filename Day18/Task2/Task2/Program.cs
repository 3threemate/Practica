using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void ProcessFile(string filePath)
    {
        Queue<char> lettersQueue = new Queue<char>();
        Queue<char> digitsQueue = new Queue<char>();

        foreach (char c in File.ReadAllText(filePath))
        {
            if (char.IsDigit(c))
                digitsQueue.Enqueue(c);
            else
                lettersQueue.Enqueue(c);
        }

        while (lettersQueue.Count > 0)
            Console.Write(lettersQueue.Dequeue());

        Console.WriteLine();

        // Затем все цифры
        while (digitsQueue.Count > 0)
            Console.Write(digitsQueue.Dequeue());

        Console.WriteLine();
    }

    static void Main()
    {
        string filePath = "example.txt";
        ProcessFile(filePath);
    }
}
