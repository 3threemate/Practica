using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите Длину:");
        double C = Convert.ToDouble(Console.ReadLine()); 

        double S = Math.Pow(C, 2) / (4 * Math.PI);

        Console.WriteLine($"Площадь круга при длине окружности {C}: {S}");
    }
}
