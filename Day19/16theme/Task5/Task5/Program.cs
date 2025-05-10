using System;
using System.IO;
using System.Collections.Generic;

/// <summary>
/// Главный класс программы, выполняющий обработку чисел из файла.
/// </summary>
class Program
{
    /// <summary>
    /// Точка входа в программу.
    /// Читает числа из файла, выполняет обработку и записывает результаты в новый файл.
    /// </summary>
    static void Main()
    {
        try
        {
            /// <summary>
            /// Путь к входному файлу с числами.
            /// </summary>
            string inputFile = "C:/Test/numbers.txt";

            /// <summary>
            /// Путь к выходному файлу с обработанными числами.
            /// </summary>
            string outputFile = "C:/Test/processed_numbers.txt";

            /// <summary>
            /// Записывает тестовые данные в входной файл.
            /// </summary>
            File.WriteAllLines(inputFile, new string[] { "20 10 4 -1 -2 0 0 0 -10 41 62" });

            /// <summary>
            /// Чтение и преобразование строк в массив чисел.
            /// </summary>
            var numbers = File.ReadAllText(inputFile)
                              .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                              .Select(int.Parse)
                              .ToArray();

            /// <summary>
            /// Список для хранения обработанных чисел.
            /// </summary>
            List<int> processedNumbers = new List<int>();

            int sum = numbers[0];

            /// <summary>
            /// Обработка чисел согласно заданной логике.
            /// </summary>
            for (int i = 1; i < numbers.Length; i++)
            {
                if ((numbers[i] > 0 && sum > 0) || (numbers[i] < 0 && sum < 0))
                {
                    sum += numbers[i];
                }
                else if (numbers[i] == 0)
                {
                    if (processedNumbers.Count == 0 || processedNumbers[^1] != 0)
                        processedNumbers.Add(0);
                    sum = 0;
                }
                else
                {
                    processedNumbers.Add(sum);
                    sum = numbers[i];
                }
            }

            processedNumbers.Add(sum);

            /// <summary>
            /// Запись обработанных данных в выходной файл.
            /// </summary>
            File.WriteAllLines(outputFile, new string[] { string.Join(" ", processedNumbers) });

            Console.WriteLine($"Обработанные данные записаны в файл {outputFile}");
        }
        catch (Exception ex)
        {
            /// <summary>
            /// Обработка возможных ошибок.
            /// </summary>
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}
