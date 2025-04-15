using System;

class Program
{
    static void Main()
    {
        double A = Math.PI / 3; 
        double B = 2 * Math.PI / 3;  
        int M = 20; 

        double H = (B - A) / M;

        Console.WriteLine("Таблица значений функции cos(x):");
        Console.WriteLine("X\tF(x)");

        for (int i = 0; i <= M; i++)
        {
            double x = A + i * H; 
            double Fx = Math.Cos(x); 
            Console.WriteLine($"{x:F3}\t{Fx:F3}");
        }
    }
}
