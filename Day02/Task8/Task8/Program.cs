using System;

class Program
{
    static void Main()
    {
        // Ввод числа N
        Console.WriteLine("Введите целое число N (1 <= N <= 10):");
        int N = int.Parse(Console.ReadLine());

        if (N < 1 || N > 10)
        {
            Console.WriteLine("Ошибка: число N должно быть в диапазоне от 1 до 10.");
            return;
        }

        Console.WriteLine("Вывод квадратов всех целых чисел от 1 до N:");

        for (int i = 1; i <= N; i++)
        {
            int sum = 0;
            for (int j = 1; j <= i; j++)
            {
                sum += 2 * j - 1; 
            }
            Console.WriteLine($"Квадрат числа {i}: {sum}");
        }
    }
}
