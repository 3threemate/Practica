using System;

class Program
{
    static void Main()
    {
        int[,] salaries = new int[18, 12];

        Random random = new Random();
        for (int i = 0; i < 18; i++)
        {
            for (int j = 0; j < 12; j++)
            {
                salaries[i, j] = random.Next(1000, 5001);
            }
        }

        Console.WriteLine("Зарплаты первого человека за каждый месяц:");
        for (int j = 0; j < 12; j++)
        {
            Console.Write(salaries[0, j] + " ");
        }
        Console.WriteLine();

        int annualIncomeFirstPerson = 0;
        for (int j = 0; j < 12; j++)
        {
            annualIncomeFirstPerson += salaries[0, j];
        }

        Console.WriteLine($"\nГодовой доход первого человека: {annualIncomeFirstPerson}");

        Console.WriteLine("Введите заданное число:");
        int threshold = int.Parse(Console.ReadLine());

        if (annualIncomeFirstPerson > threshold)
        {
            Console.WriteLine("Годовой доход первого человека больше заданного числа.");
        }
        else
        {
            Console.WriteLine("Годовой доход первого человека не больше заданного числа.");
        }
    }
}
