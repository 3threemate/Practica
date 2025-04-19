using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Введите значения A, B, C, D через пробел:");
            string[] inputs = Console.ReadLine().Split(' ');
            if (inputs.Length != 4)
                throw new FormatException("Необходимо ввести ровно четыре числа.");

            double A = Convert.ToDouble(inputs[0]);
            double B = Convert.ToDouble(inputs[1]);
            double C = Convert.ToDouble(inputs[2]);
            double D = Convert.ToDouble(inputs[3]);

            if (A <= 0 || B <= 0 || C <= 0 || D <= 0)
                throw new ArgumentOutOfRangeException("Все числа должны быть положительными.");

            ComputeMean(A, B);
            ComputeMean(A, C);
            ComputeMean(A, D);
        }
        catch (FormatException e)
        {
            Console.WriteLine($"Ошибка: {e.Message}");
        }
        catch (ArgumentOutOfRangeException e)
        {
            Console.WriteLine($"Ошибка: {e.Message}");
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine($"Ошибка: {e.Message}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Неизвестная ошибка: {e.Message}");
        }
    }

    static void ComputeMean(double X, double Y)
    {
        try
        {
            if (X <= 0 || Y <= 0)
                throw new ArgumentOutOfRangeException("Числа должны быть положительными.");

            double AMean = (X + Y) / 2; 
            double GMean = Math.Sqrt(X * Y); 

            Console.WriteLine($"Для пары ({X}, {Y}):");
            Console.WriteLine($"Среднее арифметическое: {AMean}");
            Console.WriteLine($"Среднее геометрическое: {GMean}");
        }
        catch (ArgumentOutOfRangeException e)
        {
            Console.WriteLine($"Ошибка: {e.Message}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Неизвестная ошибка в методе ComputeMean: {e.Message}");
        }
    }
}
