using System;

class Program
{
    static int Max(int a, int b)
    {
        return (a > b) ? a : b;
    }

    static int Max(int a, int b, int c)
    {
        return Max(Max(a, b), c); 
    }

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

        int result = Max(a1, b1) - Max(a2, b2, c2);

        Console.WriteLine($"\nРезультат: Max({a1}, {b1}) - Max({a2}, {b2}, {c2}) = {result}");
    }
}
