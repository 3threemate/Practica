using System;
using System.IO;

class Program
{
    static void Main()
    {
        try
        {
            string file1 = "C:/Test/file1.txt";
            string file2 = "C:/Test/file2.txt";
            string tempFile = "C:/Test/temp.txt";

            var lines1 = File.ReadAllLines(file1);
            var lines2 = File.ReadAllLines(file2);

            if (lines1.Length != lines2.Length)
            {
                Console.WriteLine("Файлы содержат разное количество строк!");
                return;
            }

            File.WriteAllLines(tempFile, lines1);

            File.WriteAllLines(file1, lines2);

            File.WriteAllLines(file2, File.ReadAllLines(tempFile));

            Console.WriteLine("Обмен строками успешно выполнен!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}
