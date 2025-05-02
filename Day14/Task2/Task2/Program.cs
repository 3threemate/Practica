using System;
using System.Diagnostics;
using System.Threading;

class Program
{
    static void Main()
    {
        Thread thread1 = new Thread(SumNumbers);
        Thread thread2 = new Thread(SumNumbers);

        thread1.Start();
        thread2.Start();

        thread1.Join();
        thread2.Join();

        Console.WriteLine("Оба потока завершены.");
    }

    static void SumNumbers()
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        int sum = 0;
        for (int i = 1; i <= 10; i++)
        {
            sum += i;
            Thread.Sleep(100);
        }

        stopwatch.Stop();

        Console.WriteLine($"Поток {Thread.CurrentThread.ManagedThreadId}: Сумма = {sum}, Время выполнения = {stopwatch.ElapsedMilliseconds} мс");
    }
}
