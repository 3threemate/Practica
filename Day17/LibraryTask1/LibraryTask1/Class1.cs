using System;

namespace LibraryTask1
{
    public abstract class Shape
    {
        public abstract double GetPerimeter();
        public abstract double GetArea();
    }

    public class Triangle : Shape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public Triangle(double a, double b, double c)
        {
            SideA = a;
            SideB = b;
            SideC = c;
        }

        public bool IsValid()
        {
            return (SideA + SideB > SideC) && (SideA + SideC > SideB) && (SideB + SideC > SideA);
        }

        public override double GetPerimeter()
        {
            return SideA + SideB + SideC;
        }

        public override double GetArea()
        {
            double s = GetPerimeter() / 2;
            return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
        }

        public string GetTriangleType()
        {
            if (SideA == SideB && SideB == SideC)
                return "Равносторонний";
            else if (SideA == SideB || SideA == SideC || SideB == SideC)
                return "Равнобедренный";
            else
                return "Разносторонний";
        }
    }

    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double GetPerimeter()
        {
            return 2 * (Width + Height);
        }

        public override double GetArea()
        {
            return Width * Height;
        }
    }
}
