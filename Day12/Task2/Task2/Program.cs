using System;

namespace LambdaArithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<double, double, double> Add = (x, y) => x + y;
            Func<double, double, double> Sub = (x, y) => x - y;
            Func<double, double, double> Mul = (x, y) => x * y;
            Func<double, double, double> Div = (x, y) =>
            {
                if (y == 0)
                {
                    Console.WriteLine("Ошибка: деление на ноль.");
                    return double.NaN;
                }
                return x / y;
            };

            Console.WriteLine("Выберите арифметическое действие (Add, Sub, Mul, Div):");
            string operation = Console.ReadLine();

            Console.WriteLine("Введите первое число:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = 0;

            switch (operation.ToLower())
            {
                case "add":
                    result = Add(num1, num2);
                    break;
                case "sub":
                    result = Sub(num1, num2);
                    break;
                case "mul":
                    result = Mul(num1, num2);
                    break;
                case "div":
                    result = Div(num1, num2);
                    break;
                default:
                    Console.WriteLine("Неверное арифметическое действие.");
                    return;
            }

            Console.WriteLine($"Результат: {result}");
        }
    }
}
