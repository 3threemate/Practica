using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите координату x:");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите координату y:");
        int y = int.Parse(Console.ReadLine());

        bool Quarter = (x > 0 && y > 0) || (x < 0 && y < 0);

        if (Quarter)
        {
            Console.WriteLine("Точка лежит в первой или третьей координатной четверти.");
        }
        else
        {
            Console.WriteLine("Точка не лежит в первой или третьей координатной четверти.");
        }
    }
}
