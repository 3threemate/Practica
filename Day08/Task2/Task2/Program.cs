using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = "тестовое предложение. предложение содержит содержит повторяющиеся слова";

        string pattern = @"(?i)\b(\w+)\b(?:.*?\b\1\b)+";

        Regex regex = new Regex(pattern);
        string[] sentences = text.Split(new[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

        Console.WriteLine("Предложения с повторяющимися словами:");
        foreach (string sentence in sentences)
        {
            if (regex.IsMatch(sentence))
            {
                Console.WriteLine(sentence.Trim());
            }
        }
    }
}
