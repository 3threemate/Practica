using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        try
        {
            string filePath = "C:/Test/textfile.txt";

            File.WriteAllLines(filePath, new string[]
            {
                "текст",
                "код",
                "программирование",
                "слово",
                "разработка"
            });

            var lines = File.ReadAllLines(filePath);


            int sameStartEndCount = lines.Count(line => line.Length > 0 && line.First() == line.Last());

            var longestLine = lines.OrderByDescending(line => line.Length).First();
            int longestLineLength = longestLine.Length;

            var shortestLine = lines.OrderBy(line => line.Length).First();
            int shortestLineLength = shortestLine.Length;

            int longestLineIndex = Array.IndexOf(lines, longestLine) + 1;

            char givenLetter = 'п'; 
            var foundLine = lines.FirstOrDefault(line => line.StartsWith(givenLetter.ToString(), StringComparison.OrdinalIgnoreCase));

            // Вывод результатов
            Console.WriteLine($"Количество строк, начинающихся и заканчивающихся одной буквой: {sameStartEndCount}");
            Console.WriteLine($"Самая длинная строка: \"{longestLine}\" (длина: {longestLineLength})");
            Console.WriteLine($"Самая короткая строка: \"{shortestLine}\" (длина: {shortestLineLength})");
            Console.WriteLine($"Номер самой длинной строки: {longestLineIndex}");

            if (foundLine != null)
                Console.WriteLine($"Строка, начинающаяся с '{givenLetter}': \"{foundLine}\"");
            else
                Console.WriteLine($"Нет строк, начинающихся с '{givenLetter}'.");

        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}
