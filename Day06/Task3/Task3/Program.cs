using System;

class Program
{
    static void Main()
    {
        // Ввод N, a, b, C, D
        Console.WriteLine("Введите размер матрицы N (N < 10):");
        int N = int.Parse(Console.ReadLine());

        if (N >= 10)
        {
            Console.WriteLine("Размер матрицы должен быть меньше 10.");
            return;
        }

        Console.WriteLine("Введите нижнюю границу диапазона (a):");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите верхнюю границу диапазона (b):");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите нижнюю границу промежутка (C):");
        int C = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите верхнюю границу промежутка (D):");
        int D = int.Parse(Console.ReadLine());

        Random random = new Random();
        int[,] matrix = new int[N, N];

        Console.WriteLine("\nИсходная матрица:");
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                matrix[i, j] = random.Next(a, b + 1);
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }

        long product = 1;
        bool foundInRange = false;

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                if (matrix[i, j] >= C && matrix[i, j] <= D)
                {
                    product *= matrix[i, j];
                    foundInRange = true;
                }
            }
        }

        if (!foundInRange)
        {
            product = 0; 
        }

        Console.WriteLine($"\nПроизведение чисел, принадлежащих промежутку [{C}, {D}]: {product}");

        Console.WriteLine("\nСумма элементов каждого столбца:");
        for (int j = 0; j < N; j++)
        {
            int columnSum = 0;
            for (int i = 0; i < N; i++)
            {
                columnSum += matrix[i, j];
            }
            Console.WriteLine($"Сумма столбца {j + 1}: {columnSum}");
        }
    }
}
