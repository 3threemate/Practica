using System;

/// <summary>
/// Главный класс программы, содержащий точку входа.
/// </summary>
class Program
{
    /// <summary>
    /// Определяет максимальное из двух целых чисел.
    /// </summary>
    /// <param name="a">Первое число.</param>
    /// <param name="b">Второе число.</param>
    /// <returns>Наибольшее из двух чисел.</returns>
    static int Max(int a, int b)
    {
        return (a > b) ? a : b;
    }

    /// <summary>
    /// Определяет максимальное из трех целых чисел.
    /// </summary>
    /// <param name="a">Первое число.</param>
    /// <param name="b">Второе число.</param>
    /// <param name="c">Третье число.</param>
    /// <returns>Наибольшее из трех чисел.</returns>
    static int Max(int a, int b, int c)
    {
        return Max(Max(a, b), c);
    }

    /// <summary>
    /// Точка входа в программу.
    /// Запрашивает у пользователя входные значения и вычисляет разность максимальных значений.
    /// </summary>
    static void Main()
    {
        Console.Write("Введите a1: ");
        int a1 = int.Parse(Console.ReadLine());

        Console.Write("Введите b1: ");
        int b1 = int.Parse(Console.ReadLine());

        Console.Write("Введите a2: ");
        int a2 = int.Parse(Console.ReadLine());

        Console.Write("Введите b2: ");
        int b2 = int.Parse(Console.ReadLine());

        Console.Write("Введите c2: ");
        int c2 = int.Parse(Console.ReadLine());

        /// <summary>
        /// Вычисляет разность двух максимальных значений.
        /// </summary>
        int result = Max(a1, b1) - Max(a2, b2, c2);

        Console.WriteLine($"\nРезультат: Max({a1}, {b1}) - Max({a2}, {b2}, {c2}) = {result}");
    }
}
