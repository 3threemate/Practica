using System;
using System.IO;

class Program
{
    static void Main()
    {
        try
        {
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

            string targetDir = "C:/Test/Example_38tp"; 
            Directory.CreateDirectory(targetDir);
            Console.WriteLine($"\nКаталог {targetDir} успешно создан!");

            string sourceDir = "C:/Test/SourceFolder"; 
            string[] filesToCopy = Directory.GetFiles(sourceDir).Take(3).ToArray();

            foreach (var file in filesToCopy)
            {
                string destFile = Path.Combine(targetDir, Path.GetFileName(file));
                File.Copy(file, destFile);
            }
            Console.WriteLine($"Скопированы файлы: {string.Join(", ", filesToCopy)}");

            foreach (var file in Directory.GetFiles(targetDir))
            {
                File.SetAttributes(file, FileAttributes.Hidden);
            }
            Console.WriteLine("Файлы теперь скрытые.");

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
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}
