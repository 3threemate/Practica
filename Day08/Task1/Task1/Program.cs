using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = "У рамы было помытое окно";
        string pattern = @"\b\w*[аеёиоуыэюя]{2,}\b";

        MatchCollection matches = Regex.Matches(text, pattern);

        Console.WriteLine("Найденные слова:");
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}
