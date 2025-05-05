using System;
using System.IO;

class Program
{
    static void Main()
    {
        try
        {
            string folderPath = "C:/Test/New_folder";

            Directory.CreateDirectory(folderPath);

            Console.WriteLine($"Папка '{folderPath}' успешно создана!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}
