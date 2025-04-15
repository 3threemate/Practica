using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите массу в килограммах:");
        int Kg = int.Parse(Console.ReadLine());

        int Tons = Kg / 1000;

        Console.WriteLine($"Число полных тонн: {Tons}");
    }
}
