using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Введите значение x (вещественное число):");
            double x = Convert.ToDouble(Console.ReadLine());

            if (x <= 0 || x > 100) 
                throw new ArgumentOutOfRangeException("Значение x выходит за допустимый диапазон (0 < x ≤ 100).");

            double f;

            if (x > 0 && x < 1)
            {
                f = 3 * Math.Pow(x, 2); 
            }
            else if (x >= 1)
            {
                if (x == 1)
                    throw new DivideByZeroException("Недопустимо деление на ноль (x - 1 = 0).");

                f = x / (x - 1); 
            }
            else
            {
                throw new Exception("Неизвестный случай.");
            }

            Console.WriteLine($"Значение функции f(x): {f}");
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine($"Ошибка: {e.Message}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: введено некорректное значение. Пожалуйста, введите вещественное число.");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Неизвестная ошибка: {e.Message}");
        }
    }
}
