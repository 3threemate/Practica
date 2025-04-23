using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = "Мам помоги мне решить задачу";

        string pattern = @"\b(\w)\w*\1\b";

        MatchCollection matches = Regex.Matches(text, pattern, RegexOptions.IgnoreCase);

        Console.WriteLine("Слова, начинающиеся и заканчивающиеся одной буквой:");
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}
