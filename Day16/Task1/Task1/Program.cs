using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        try
        {
            
            string filePath = "C:/Test/file.txt"; 
            var numbers = File.ReadAllLines(filePath)
                              .Select(double.Parse)
                              .ToArray();

            double sumAbs = Math.Abs(numbers.Sum());
            double prodSquare = Math.Pow(numbers.Aggregate(1.0, (acc, num) => acc * num), 2);

            Console.WriteLine($"Модуль суммы: {sumAbs}");
            Console.WriteLine($"Квадрат произведения: {prodSquare}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}
