using System;

/// <summary>
/// Главный класс программы, содержащий точку входа.
/// </summary>
class Program
{
    /// <summary>
    /// Точка входа в программу.
    /// Вычисляет и выводит параметры равносторонних треугольников для заданных сторон.
    /// </summary>
    static void Main(string[] args)
    {
        /// <summary>
        /// Массив длин сторон равносторонних треугольников.
        /// </summary>
        double[] sides = { 3.0, 5.0, 7.0 };

        Console.WriteLine("Равносторонние треугольники:");
        Console.WriteLine("   Сторона     Периметр     Площадь   ");

        foreach (double a in sides)
        {
            double P = 0, S = 0;
            TrianglePS(a, ref P, ref S);

            // Вывод результатов
            Console.WriteLine($" {a,10:N3}  {P,10:N3}  {S,10:N3} ");
        }
    }

    /// <summary>
    /// Вычисляет периметр и площадь равностороннего треугольника.
    /// </summary>
    /// <param name="a">Длина стороны треугольника.</param>
    /// <param name="P">Периметр треугольника (вычисляется).</param>
    /// <param name="S">Площадь треугольника (вычисляется).</param>
    static void TrianglePS(double a, ref double P, ref double S)
    {
        P = 3 * a;
        S = (Math.Sqrt(3) / 4) * a * a;
    }
}
