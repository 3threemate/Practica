using System;

/// <summary>
/// Главный класс программы, содержащий точку входа.
/// </summary>
class Program
{
    /// <summary>
    /// Точка входа в программу.
    /// Запрашивает ввод параметров и вычисляет значения функции в заданном диапазоне.
    /// </summary>
    static void Main(string[] args)
    {
        Console.WriteLine("Введите параметр a:");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите параметр b (конечное значение):");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите шаг h:");
        double h = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("     x         f(x)    ");

        for (double x = a; x <= b; x += h)
        {
            double fx = CalculateFunction(x, a);
            Console.WriteLine($" {x,9:N3}  {fx,10:N3} ");
        }
    }

    /// <summary>
    /// Вычисляет значение функции f(x) в зависимости от переданных параметров.
    /// </summary>
    /// <param name="x">Текущее значение x.</param>
    /// <param name="a">Параметр a, определяющий условия вычисления.</param>
    /// <returns>Значение функции f(x).</returns>
    static double CalculateFunction(double x, double a)
    {
        if (x < a)
        {
            return 0;
        }
        else if (x > a)
        {
            return (x - a) / (x + a);
        }
        else
        {
            return 1; // x == a
        }
    }
}
