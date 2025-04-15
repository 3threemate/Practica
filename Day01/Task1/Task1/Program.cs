using System;

namespace SumOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое целое число: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите второе целое число: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите третье целое число: ");
            int c = Convert.ToInt32(Console.ReadLine());

            int sum = a + b + c;

            Console.WriteLine($"Сумма {a} + {b} + {c}= {sum}");
        }
    }
}
