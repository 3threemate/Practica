using System;

class Program
{
    static void Main(string[] args)
    {
        double[] sides = { 3.0, 5.0, 7.0 };

        Console.WriteLine("Равносторонние треугольники:");
        
        Console.WriteLine("   Сторона     Периметр     Площадь   ");
        

        foreach (double a in sides)
        {
            double P = 0, S = 0;
            TrianglePS(a, ref P, ref S);

            // Вывод результатов
            Console.WriteLine($" {a,10:N3}  {P,10:N3}  {S,10:N3} ");
        }


    }
дж
  
    static void TrianglePS(double a, ref double P, ref double S)
    {
        P = 3 * a;

        S = (Math.Sqrt(3) / 4) * a * a;
    }
}
