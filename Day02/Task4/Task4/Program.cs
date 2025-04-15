using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите значение x (x<=1.3):");
        double x = double.Parse(Console.ReadLine());

        double y;

        if (x < 1.3)
        {
            y = Math.PI * Math.Pow(x, 2) - 7 / Math.Sqrt(Math.Abs(x));
        }
        else if (x == 1.3)
        {
            y = 3 * x - Math.Pow(Math.Cos(x), 2);
        }
        else
        {
            Console.WriteLine("Ошибка: функция определена только для x <= 1.3.");
            return;
        }

        Console.WriteLine($"Значение функции y: {y}");
    }
}
