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
    /// Читает строки из файла, выполняет анализ и выводит результаты.
    /// </summary>
    static void Main()
    {
        try
        {
            /// <summary>
            /// Путь к файлу с текстом.
            /// </summary>
            string filePath = "C:/Test/textfile.txt";

            /// <summary>
            /// Записывает тестовые строки в файл.
            /// </summary>
            File.WriteAllLines(filePath, new string[]
            {
                "текст",
                "код",
                "программирование",
                "слово",
                "разработка"
            });

            /// <summary>
            /// Чтение строк из файла и их хранение в массиве.
            /// </summary>
            var lines = File.ReadAllLines(filePath);

            /// <summary>
            /// Подсчет количества строк, начинающихся и заканчивающихся одной буквой.
            /// </summary>
            int sameStartEndCount = lines.Count(line => line.Length > 0 && line.First() == line.Last());

            /// <summary>
            /// Нахождение самой длинной строки и ее длины.
            /// </summary>
            var longestLine = lines.OrderByDescending(line => line.Length).First();
            int longestLineLength = longestLine.Length;

            /// <summary>
            /// Нахождение самой короткой строки и ее длины.
            /// </summary>
            var shortestLine = lines.OrderBy(line => line.Length).First();
            int shortestLineLength = shortestLine.Length;

            /// <summary>
            /// Определение номера самой длинной строки.
            /// </summary>
            int longestLineIndex = Array.IndexOf(lines, longestLine) + 1;

            /// <summary>
            /// Поиск первой строки, начинающейся с указанной буквы.
            /// </summary>
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
            /// <summary>
            /// Обрабатывает возможные ошибки при работе с файлом.
            /// </summary>
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}
