using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите радиус основания цилиндра (см): ");
        double radius = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите высоту цилиндра (см): ");
        double height = Convert.ToDouble(Console.ReadLine());

        double lateralSurfaceArea = 2 * Math.PI * radius * height; 
        double baseArea = 2 * Math.PI * radius * radius;   
        double SurfaceArea = lateralSurfaceArea + baseArea;

        Console.WriteLine($"Площадь поверхности цилиндра: {SurfaceArea} кв. см.");
    }
}
