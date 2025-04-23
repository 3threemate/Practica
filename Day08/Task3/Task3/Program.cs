using System;

class Program
{
    static void Main()
    {
        string text = "короткое предложение. это уже длиннее. Здесь больше слов, чем в предыдущем";

        int n = 4; 

        string[] sentences = text.Split(new[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

        Console.WriteLine($"Предложения с {n} или более словами:");
        foreach (string sentence in sentences)
        {
            int wordCount = sentence.Split(new[] { ' ', ',', ';' }, StringSplitOptions.RemoveEmptyEntries).Length;

            if (wordCount >= n)
            {
                Console.WriteLine(sentence.Trim() + ".");
            }
        }
    }
}
