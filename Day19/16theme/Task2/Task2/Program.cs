using System;
using System.IO;

/// <summary>
/// Главный класс программы, выполняющий создание папки.
/// </summary>
class Program
{
    /// <summary>
    /// Точка входа в программу.
    /// Создает папку по заданному пути и обрабатывает возможные ошибки.
    /// </summary>
    static void Main()
    {
        try
        {
            /// <summary>
            /// Путь к создаваемой папке.
            /// </summary>
            string folderPath = "C:/Test/New_folder";

            /// <summary>
            /// Создание папки по указанному пути.
            /// </summary>
            Directory.CreateDirectory(folderPath);

            Console.WriteLine($"Папка '{folderPath}' успешно создана!");
        }
        catch (Exception ex)
        {
            /// <summary>
            /// Обрабатывает возможные ошибки при создании папки и выводит сообщение.
            /// </summary>
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}
