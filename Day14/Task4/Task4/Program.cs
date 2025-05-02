using System;
using System.Linq;
using System.Threading;

class Program
{
    static int[] numbers;
    static int totalSum = 0;
    static object locker = new object();

    static void Main()
    {
        Console.Write("Введите количество элементов массива: ");
        int size = int.Parse(Console.ReadLine());
        numbers = new int[size];

        Random random = new Random();
        for (int i = 0; i < size; i++)
        {
            numbers[i] = random.Next(1, 100); 
        }

        Console.Write("Введите количество потоков: ");
        int threadCount = int.Parse(Console.ReadLine());

        Thread[] threads = new Thread[threadCount];
        int chunkSize = size / threadCount;

        for (int i = 0; i < threadCount; i++)
        {
            int start = i * chunkSize;
            int end = (i == threadCount - 1) ? size : (start + chunkSize);
            threads[i] = new Thread(() => ComputePartialSum(start, end));
            threads[i].Start();
        }

        foreach (Thread thread in threads)
        {
            thread.Join();
        }

        Console.WriteLine($"Общая сумма четных чисел: {totalSum}");
    }

    static void ComputePartialSum(int start, int end)
    {
        int partialSum = 0;
        for (int i = start; i < end; i++)
        {
            if (numbers[i] % 2 == 0)
            {
                partialSum += numbers[i];
            }
        }

        lock (locker)
        {
            totalSum += partialSum;
        }
    }
}
