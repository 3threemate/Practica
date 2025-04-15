using System;

class Program
{
    static void Main()
    {
        double x = 0.7;

        double numerator = 20 * Math.Log(Math.Cos(Math.Exp(x)));
        double denominator = 2 / Math.Sqrt(Math.Pow(Math.Sin(Math.PI), 3) + Math.Abs(1 - Math.Pow(x, 2)));
        double result = numerator - denominator;

        Console.WriteLine($"Значение функции для x = {x}: {result}");
    }
}
