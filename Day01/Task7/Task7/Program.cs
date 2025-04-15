using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите угол (в радианах): ");
        double alpha = Convert.ToDouble(Console.ReadLine());

        double z1 = (Math.Sin(4 * alpha) / (1 + Math.Cos(4 * alpha))) *
                    (Math.Cos(2 * alpha) / (1 + Math.Cos(2 * alpha)));

        double z2 = 1 / Math.Tan((3 * Math.PI / 2) - alpha);

        Console.WriteLine($"Результат z1: {z1}");
        Console.WriteLine($"Результат z2: {z2}");

        if (Math.Abs(z1 - z2) < 1e-6)
        {
            Console.WriteLine("Результаты совпадают");
        }
        else
        {
            Console.WriteLine("Результаты отличаются");
        }
    }
}
