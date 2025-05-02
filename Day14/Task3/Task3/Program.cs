using System;
using System.Threading;

class Program
{
    static int A, N;
    static object locker = new object();

    static void Main()
    {
        Console.Write("Введите значение A: ");
        A = int.Parse(Console.ReadLine());

        Console.Write("Введите значение N: ");
        N = int.Parse(Console.ReadLine());

        Thread thread1 = new Thread(SumNumbers);
        Thread thread2 = new Thread(SumNumbers);
        Thread thread3 = new Thread(MultiplyNumbers);

        thread1.Start();
        thread2.Start();
        thread3.Start();

        thread1.Join();
        thread2.Join();
        thread3.Join();

        Console.WriteLine("Все потоки завершены.");
    }

    static void SumNumbers()
    {
        int sum = 0;
        for (int i = 1; i <= N; i++)
        {
            lock (locker) 
            {
                sum += A + i;
                Console.WriteLine($"Поток {Thread.CurrentThread.ManagedThreadId}: Сумма = {sum}");
                Thread.Sleep(100); 
            }
        }
    }

    static void MultiplyNumbers()
    {
        int product = 1;
        for (int i = 1; i <= N; i++)
        {
            product *= A * i;
            Console.WriteLine($"Поток {Thread.CurrentThread.ManagedThreadId}: Произведение = {product}");
            Thread.Sleep(200); 
        }
    }
}
