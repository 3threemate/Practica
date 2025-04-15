using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите трёхзначное число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int lastDigit = number % 10;     
        int firstDigit = number / 100;  

        Console.WriteLine($"Первая цифра: {firstDigit}");
        Console.WriteLine($"Последняя цифра: {lastDigit}");
    }
}
