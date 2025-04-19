using System;

class Program
{
    static double Factorial(int n)
    {
        if (n <= 1)
            return 1; 
        else
            return n * Factorial(n - 1); 
    }

    static double ComputeF(int n)
    {
        return 1 / Factorial(n + 1);
    }

    static void Main()
    {
        Console.WriteLine("Введите значение n:");
        int n = int.Parse(Console.ReadLine());

        double result = ComputeF(n);

        Console.WriteLine($"f({n}) = {result}");
    }
}
