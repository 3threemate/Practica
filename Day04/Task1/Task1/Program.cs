using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите параметр a:");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите параметр b (конечное значение):");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите шаг h:");
        double h = Convert.ToDouble(Console.ReadLine());

       
        Console.WriteLine("     x         f(x)    ");
   

        for (double x = a; x <= b; x += h)
        {
            double fx = CalculateFunction(x, a);
            Console.WriteLine($" {x,9:N3}  {fx,10:N3} ");
        }

    }

    static double CalculateFunction(double x, double a)
    {
        if (x < a)
        {
            return 0;
        }
        else if (x > a)
        {
            return (x - a) / (x + a);
        }
        else
        {
            return 1; // x == a
        }
    }
}
