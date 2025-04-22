using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите текст:");
        string input = Console.ReadLine();

        char[] punctuationMarks = { '.', ',', '!', '?', ';', ':' };
        int errorCount = 0;

        for (int i = 0; i < input.Length - 1; i++)
        {
            if (Array.Exists(punctuationMarks, mark => mark == input[i]) && input[i + 1] != ' ')
            {
                errorCount++;
            }
        }

        Console.WriteLine($"Количество ошибок в тексте: {errorCount}");
    }
}
