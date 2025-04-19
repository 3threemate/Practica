using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Введите значение x:");
            double x = Convert.ToDouble(Console.ReadLine());

            if (x == -10)
                throw new DivideByZeroException("Деление на ноль недопустимо (x + 10 = 0).");

            double y1 = (Math.Pow(x, 3) - 2) / (x + 10) + 4 * x;
            Console.WriteLine($"Результат первого выражения: y1 = {y1}");

            if (x <= 0)
                throw new ArgumentException("Логарифм определён только для положительных x.");

            double y2 = Math.Log(x) + (Math.Cos(x) / (x + 6));
            Console.WriteLine($"Результат второго выражения: y2 = {y2}");
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine($"Ошибка: {e.Message}");
        }
        
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: введено некорректное значение. Пожалуйста, введите число.");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Неизвестная ошибка: {e.Message}");
        }
    }
}
