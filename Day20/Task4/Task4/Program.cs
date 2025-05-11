using System;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int A = -7;
        int B = 3;

        Console.WriteLine("Параллельное вычисление значений cos(x):");

        Parallel.For(A, B + 1, x =>
        {
            double result = Math.Cos(x);
            Console.WriteLine($"cos({x}) = {result}");
        });

        Console.WriteLine("Вычисления завершены!");
    }
}
