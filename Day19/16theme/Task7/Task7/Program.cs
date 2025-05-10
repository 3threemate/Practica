using System;
using System.IO;

/// <summary>
/// Главный класс программы, выполняющий операции с файлами и каталогами.
/// </summary>
class Program
{
    /// <summary>
    /// Точка входа в программу.
    /// Сканирует локальные диски, создает каталог, копирует файлы, делает их скрытыми и создает ссылки.
    /// </summary>
    static void Main()
    {
        try
        {
            /// <summary>
            /// Вывод списка файлов на всех локальных дисках.
            /// </summary>
            Console.WriteLine("Файлы на всех локальных дисках:");
            foreach (var drive in DriveInfo.GetDrives())
            {
                if (drive.IsReady)
                {
                    Console.WriteLine($"Диск {drive.Name}");
                    foreach (var file in Directory.GetFiles(drive.Name, "*.*", SearchOption.AllDirectories))
                    {
                        Console.WriteLine(file);
                    }
                }
            }

            /// <summary>
            /// Путь к создаваемому каталогу.
            /// </summary>
            string targetDir = "C:/Test/Example_38tp";

            /// <summary>
            /// Создание нового каталога.
            /// </summary>
            Directory.CreateDirectory(targetDir);
            Console.WriteLine($"\nКаталог {targetDir} успешно создан!");

            /// <summary>
            /// Путь к источнику файлов для копирования.
            /// </summary>
            string sourceDir = "C:/Test/SourceFolder";
            string[] filesToCopy = Directory.GetFiles(sourceDir).Take(3).ToArray();

            /// <summary>
            /// Копирование первых трех файлов в новый каталог.
            /// </summary>
            foreach (var file in filesToCopy)
            {
                string destFile = Path.Combine(targetDir, Path.GetFileName(file));
                File.Copy(file, destFile);
            }
            Console.WriteLine($"Скопированы файлы: {string.Join(", ", filesToCopy)}");

            /// <summary>
            /// Установка атрибута "Скрытый" для всех файлов в новом каталоге.
            /// </summary>
            foreach (var file in Directory.GetFiles(targetDir))
            {
                File.SetAttributes(file, FileAttributes.Hidden);
            }
            Console.WriteLine("Файлы теперь скрытые.");

            /// <summary>
            /// Создание файлов-ссылок вместо оригиналов.
            /// </summary>
            foreach (var file in Directory.GetFiles(targetDir))
            {
                string shortcutPath = file + ".lnk";
                using (StreamWriter writer = new StreamWriter(shortcutPath))
                {
                    writer.WriteLine($"Ссылка на файл: {file}");
                }
            }
            Console.WriteLine("Созданы файлы-ссылки вместо оригиналов.");
        }
        catch (Exception ex)
        {
            /// <summary>
            /// Обрабатывает возможные ошибки при работе с файлами.
            /// </summary>
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}
