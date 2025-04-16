using System;

namespace Geometry
{
    public class Triangle
    {
        private (double x, double y) A;
        private (double x, double y) B;
        private (double x, double y) C;

        public Triangle((double x, double y) a, (double x, double y) b, (double x, double y) c)
        {
            A = a;
            B = b;
            C = c;
        }

        public void Move(double dx, double dy)
        {
            A = (A.x + dx, A.y + dy);
            B = (B.x + dx, B.y + dy);
            C = (C.x + dx, C.y + dy);
        }

        public void Scale(double factor)
        {
            // Центр треугольника
            var center = GetCentroid();
            A = ScalePoint(A, center, factor);
            B = ScalePoint(B, center, factor);
            C = ScalePoint(C, center, factor);
        }

        private (double x, double y) ScalePoint((double x, double y) p, (double x, double y) center, double factor)
        {
            double x = center.x + (p.x - center.x) * factor;
            double y = center.y + (p.y - center.y) * factor;
            return (x, y);
        }

        public void Rotate(double angleDegrees)
        {
            double angleRad = angleDegrees * Math.PI / 180.0;
            var center = GetCentroid();
            A = RotatePoint(A, center, angleRad);
            B = RotatePoint(B, center, angleRad);
            C = RotatePoint(C, center, angleRad);
        }

        private (double x, double y) RotatePoint((double x, double y) p, (double x, double y) center, double angle)
        {
            double dx = p.x - center.x;
            double dy = p.y - center.y;
            double cos = Math.Cos(angle);
            double sin = Math.Sin(angle);
            double xNew = center.x + dx * cos - dy * sin;
            double yNew = center.y + dx * sin + dy * cos;
            return (xNew, yNew);
        }

        public (double x, double y)[] GetVertices()
        {
            return new[] { A, B, C };
        }

        public override string ToString()
        {
            return $"A({A.x:F2}, {A.y:F2}), B({B.x:F2}, {B.y:F2}), C({C.x:F2}, {C.y:F2})";
        }

        private (double x, double y) GetCentroid()
        {
            return ((A.x + B.x + C.x) / 3, (A.y + B.y + C.y) / 3);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Создание треугольника
            Triangle triangle = new Triangle((0, 0), (4, 0), (2, 3));
            Console.WriteLine("Исходный треугольник:");
            Console.WriteLine(triangle);

            // Перемещение
            triangle.Move(2, 1);
            Console.WriteLine("\nПосле перемещения на (2, 1):");
            Console.WriteLine(triangle);

            // Масштабирование
            triangle.Scale(1.5);
            Console.WriteLine("\nПосле масштабирования (увеличение в 1.5 раза):");
            Console.WriteLine(triangle);

            // Вращение
            triangle.Rotate(45);
            Console.WriteLine("\nПосле вращения на 45 градусов:");
            Console.WriteLine(triangle);

            Console.WriteLine("\nКоординаты вершин:");
            foreach (var vertex in triangle.GetVertices())
            {
                Console.WriteLine($"({vertex.x:F2}, {vertex.y:F2})");
            }
        }
    }
}
