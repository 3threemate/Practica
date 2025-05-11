using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int[] numbers = { 54, 17, 25, 66 };
        int sumLimit = 535;
        int productLimit = 535;
        int sum = 0;
        long product = 1;
        bool stopProcessing = false;

        ConcurrentBag<int> sums = new ConcurrentBag<int>();
        ConcurrentBag<long> products = new ConcurrentBag<long>();

        Parallel.ForEach(numbers, (n, state) =>
        {
            if (stopProcessing)
            {
                state.Stop(); 
                return;
            }

            int localSum = Enumerable.Range(0, n + 1).Sum();
            long localProduct = Enumerable.Range(1, n + 1).Aggregate(1L, (a, b) => a * b);

            sums.Add(localSum);
            products.Add(localProduct);

            Console.WriteLine($"N = {n}, Сумма: {localSum}, Произведение: {localProduct}");

            if (localSum > sumLimit || localProduct > productLimit)
            {
                Console.WriteLine($"Превышен лимит! Прерывание вычислений...");
                stopProcessing = true;
                state.Stop();
            }
        });

        Console.WriteLine("Вычисления завершены!");
    }
}
