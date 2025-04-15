using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите целое число:");
        int number = int.Parse(Console.ReadLine());

        if (number % 2 != 0)
        {
            Console.WriteLine("Число является нечетным.");
        }
        else
        {
            Console.WriteLine("Число является четным.");
        }
    }
}
