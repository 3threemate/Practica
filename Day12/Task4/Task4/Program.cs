using System;

namespace AnonymousMethodExample
{
    delegate int RandomValueDelegate();

    class Program
    {
        static void Main(string[] args)
        {
            RandomValueDelegate[] delegatesArray = new RandomValueDelegate[5];

            Random random = new Random();
            for (int i = 0; i < delegatesArray.Length; i++)
            {
                delegatesArray[i] = delegate
                {
                    return random.Next(1, 101);
                };
            }

            Func<RandomValueDelegate[], double> calculateAverage = delegate (RandomValueDelegate[] delegates)
            {
                double sum = 0;
                foreach (var del in delegates)
                {
                    sum += del(); 
                }
                return sum / delegates.Length; 
            };

            double average = calculateAverage(delegatesArray);
            Console.WriteLine($"Среднее арифметическое случайных значений: {average}");
        }
    }
}
