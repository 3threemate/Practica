using System;
using System.IO;

/// <summary>
/// Главный класс программы, выполняющий обмен строками между двумя файлами.
/// </summary>
class Program
{
    /// <summary>
    /// Точка входа в программу.
    /// Выполняет чтение двух файлов, проверяет их на соответствие по количеству строк и выполняет обмен содержимого.
    /// </summary>
    static void Main()
    {
        try
        {
            /// <summary>
            /// Пути к файлам, между которыми будет выполняться обмен строками.
            /// </summary>
            string file1 = "C:/Test/file1.txt";
            string file2 = "C:/Test/file2.txt";

            /// <summary>
            /// Временный файл для хранения данных одного из файлов.
            /// </summary>
            string tempFile = "C:/Test/temp.txt";

            /// <summary>
            /// Чтение содержимого первого файла.
            /// </summary>
            var lines1 = File.ReadAllLines(file1);

            /// <summary>
            /// Чтение содержимого второго файла.
            /// </summary>
            var lines2 = File.ReadAllLines(file2);

            /// <summary>
            /// Проверка на равное количество строк в обоих файлах.
            /// </summary>
            if (lines1.Length != lines2.Length)
            {
                Console.WriteLine("Файлы содержат разное количество строк!");
                return;
            }

            /// <summary>
            /// Запись содержимого первого файла во временный файл.
            /// </summary>
            File.WriteAllLines(tempFile, lines1);

            /// <summary>
            /// Запись содержимого второго файла в первый файл.
            /// </summary>
            File.WriteAllLines(file1, lines2);

            /// <summary>
            /// Запись данных из временного файла во второй файл.
            /// </summary>
            File.WriteAllLines(file2, File.ReadAllLines(tempFile));

            Console.WriteLine("Обмен строками успешно выполнен!");
        }
        catch (Exception ex)
        {
            /// <summary>
            /// Обработка возможных ошибок и вывод сообщения об ошибке.
            /// </summary>
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}
