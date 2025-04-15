using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Таблица соответствия фунтов и килограммов (цикл while):");
        int pounds = 1;
        while (pounds <= 100)
        {
            double kilograms = pounds * 0.453;
            Console.WriteLine($"{pounds} фунтов = {kilograms:F3} кг");
            pounds++;
        }

        Console.WriteLine("\nТаблица соответствия фунтов и килограммов (цикл do while):");
        pounds = 1;
        do
        {
            double kilograms = pounds * 0.453;
            Console.WriteLine($"{pounds} фунтов = {kilograms:F3} кг");
            pounds++;
        } while (pounds <= 100);

        Console.WriteLine("\nТаблица соответствия фунтов и килограммов (цикл for):");
        for (pounds = 1; pounds <= 100; pounds++)
        {
            double kilograms = pounds * 0.453;
            Console.WriteLine($"{pounds} фунтов = {kilograms:F3} кг");
        }
    }
}
