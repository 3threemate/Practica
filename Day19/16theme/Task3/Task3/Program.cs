using System;
using System.IO;
using System.Linq;

/// <summary>
/// Главный класс программы, выполняющий обработку строкового файла.
/// </summary>
class Program
{
    /// <summary>
    /// Точка входа в программу.
    /// Читает строки из файла, выполняет различные операции и записывает измененные данные.
    /// </summary>
    static void Main()
    {
        try
        {
            /// <summary>
            /// Путь к исходному файлу с текстом.
            /// </summary>
            string filePath = "C:/Test/textfile.txt";

            /// <summary>
            /// Путь к новому файлу, куда будут записаны измененные данные.
            /// </summary>
            string newFilePath = "C:/Test/new_textfile.txt";

            /// <summary>
            /// Записывает тестовые строки в файл.
            /// </summary>
            File.WriteAllLines(filePath, new string[]
            {
                "Первая строка",
                "Вторая строка",
                "Третья строка",
                "Четвертая строка",
                "Пятая строка"
            });

            /// <summary>
            /// Чтение строк из файла и их хранение в массиве.
            /// </summary>
            var lines = File.ReadAllLines(filePath);

            Console.WriteLine("Содержимое файла:");
            foreach (var line in lines)
                Console.WriteLine(line);

            /// <summary>
            /// Вывод количества строк в файле.
            /// </summary>
            Console.WriteLine($"\nКоличество строк: {lines.Length}");

            Console.WriteLine("\nКоличество символов в каждой строке:");
            foreach (var line in lines)
                Console.WriteLine($"{line} - {line.Length} символов");

            /// <summary>
            /// Запись всех строк кроме последней в новый файл.
            /// </summary>
            File.WriteAllLines(newFilePath, lines.Take(lines.Length - 1));
            Console.WriteLine("\nПоследняя строка удалена, результат записан в новый файл.");

            /// <summary>
            /// Определение диапазона строк для вывода.
            /// </summary>
            int s1 = 1, s2 = 3;
            Console.WriteLine("\nСтроки с s1 по s2:");
            for (int i = s1 - 1; i < s2; i++)
                Console.WriteLine(lines[i]);

            /// <summary>
            /// Нахождение самой длинной строки в файле.
            /// </summary>
            var longestLine = lines.OrderByDescending(l => l.Length).First();
            Console.WriteLine($"\nСамая длинная строка ({longestLine.Length} символов): {longestLine}");

            /// <summary>
            /// Фильтрация строк, начинающихся с заданного символа.
            /// </summary>
            char letter = 'П';
            Console.WriteLine($"\nСтроки, начинающиеся с '{letter}':");
            foreach (var line in lines.Where(l => l.StartsWith(letter)))
                Console.WriteLine(line);

            /// <summary>
            /// Запись строк в обратном порядке в новый файл.
            /// </summary>
            File.WriteAllLines("reversed_textfile.txt", lines.Reverse());
            Console.WriteLine("\nФайл с обратным порядком строк создан.");
        }
        catch (Exception ex)
        {
            /// <summary>
            /// Обработка возможных ошибок при работе с файлами.
            /// </summary>
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}
