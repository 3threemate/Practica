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
            string newFilePath = "C:/Test/new_textfile.txt";

            File.WriteAllLines(filePath, new string[]
            {
                "Первая строка",
                "Вторая строка",
                "Третья строка",
                "Четвертая строка",
                "Пятая строка"
            });

            var lines = File.ReadAllLines(filePath);

            Console.WriteLine("Содержимое файла:");
            foreach (var line in lines)
                Console.WriteLine(line);

            Console.WriteLine($"\nКоличество строк: {lines.Length}");

            Console.WriteLine("\nКоличество символов в каждой строке:");
            foreach (var line in lines)
                Console.WriteLine($"{line} - {line.Length} символов");

            File.WriteAllLines(newFilePath, lines.Take(lines.Length - 1));
            Console.WriteLine("\nПоследняя строка удалена, результат записан в новый файл.");

            int s1 = 1, s2 = 3; 
            Console.WriteLine("\nСтроки с s1 по s2:");
            for (int i = s1 - 1; i < s2; i++)
                Console.WriteLine(lines[i]);

            var longestLine = lines.OrderByDescending(l => l.Length).First();
            Console.WriteLine($"\nСамая длинная строка ({longestLine.Length} символов): {longestLine}");

            char letter = 'П'; 
            Console.WriteLine($"\nСтроки, начинающиеся с '{letter}':");
            foreach (var line in lines.Where(l => l.StartsWith(letter)))
                Console.WriteLine(line);

            File.WriteAllLines("reversed_textfile.txt", lines.Reverse());
            Console.WriteLine("\nФайл с обратным порядком строк создан.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}
