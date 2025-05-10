using System;
using System.IO;
using System.Linq;

/// <summary>
/// Главный класс программы, выполняющий обработку чисел из файла.
/// </summary>
class Program
{
    /// <summary>
    /// Точка входа в программу.
    /// Читает числа из файла, выполняет математические операции и выводит результаты.
    /// </summary>
    static void Main()
    {
        try
        {
            /// <summary>
            /// Путь к файлу с числами.
            /// </summary>
            string filePath = "C:/Test/file.txt";

            /// <summary>
            /// Чтение строк из файла и преобразование их в массив чисел.
            /// </summary>
            var numbers = File.ReadAllLines(filePath)
                              .Select(double.Parse)
                              .ToArray();

            /// <summary>
            /// Вычисляет модуль суммы всех чисел.
            /// </summary>
            double sumAbs = Math.Abs(numbers.Sum());

            /// <summary>
            /// Вычисляет квадрат произведения всех чисел.
            /// </summary>
            double prodSquare = Math.Pow(numbers.Aggregate(1.0, (acc, num) => acc * num), 2);

            Console.WriteLine($"Модуль суммы: {sumAbs}");
            Console.WriteLine($"Квадрат произведения: {prodSquare}");
        }
        catch (Exception ex)
        {
            /// <summary>
            /// Обрабатывает возможные ошибки при работе с файлом и выводит сообщение.
            /// </summary>
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}
