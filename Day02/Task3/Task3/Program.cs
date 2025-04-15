using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите число A (1 <= A):");
        int A = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите число B (A < B <= 100):");
        int B = int.Parse(Console.ReadLine());

        if (A < 1 || B > 100 || A >= B)
        {
            Console.WriteLine("Некорректный ввод. Убедитесь, что 1 <= A < B <= 100.");
            return;
        }

        int count = 0;
        Console.WriteLine("Числа в порядке убывания:");
        for (int i = B - 1; i > A; i--)
        {
            Console.WriteLine(i);
            count++;
        }

        Console.WriteLine($"Количество чисел: {count}");
    }
}
