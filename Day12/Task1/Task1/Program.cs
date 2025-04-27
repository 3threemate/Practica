using System;

namespace DelegateExample
{
    delegate double CalcFigure(double radius);

    class Program
    {
        public static double Get_Length(double radius)
        {
            return 2 * Math.PI * radius;
        }

        public static double Get_Area(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public static double Get_Volume(double radius)
        {
            return (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
        }

        static void Main(string[] args)
        {
            CalcFigure CF;

            Console.WriteLine("Введите радиус:");
            double radius = Convert.ToDouble(Console.ReadLine());

            CF = Get_Length;
            Console.WriteLine($"Длина окружности: {CF(radius)}");

            CF = Get_Area;
            Console.WriteLine($"Площадь круга: {CF(radius)}");

            CF = Get_Volume;
            Console.WriteLine($"Объем шара: {CF(radius)}");
        }
    }
}
