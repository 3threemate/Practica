using System;

namespace DelegateExample
{
    /// <summary>
    /// Делегат для вычисления параметров фигуры по радиусу.
    /// </summary>
    delegate double CalcFigure(double radius);

    /// <summary>
    /// Главный класс программы, содержащий методы для вычислений.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Вычисляет длину окружности по заданному радиусу.
        /// </summary>
        /// <param name="radius">Радиус окружности.</param>
        /// <returns>Длина окружности.</returns>
        public static double Get_Length(double radius)
        {
            return 2 * Math.PI * radius;
        }

        /// <summary>
        /// Вычисляет площадь круга по заданному радиусу.
        /// </summary>
        /// <param name="radius">Радиус круга.</param>
        /// <returns>Площадь круга.</returns>
        public static double Get_Area(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        /// <summary>
        /// Вычисляет объем шара по заданному радиусу.
        /// </summary>
        /// <param name="radius">Радиус шара.</param>
        /// <returns>Объем шара.</returns>
        public static double Get_Volume(double radius)
        {
            return (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
        }

        /// <summary>
        /// Точка входа в программу.
        /// Запрашивает у пользователя радиус и выполняет вычисления.
        /// </summary>
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
