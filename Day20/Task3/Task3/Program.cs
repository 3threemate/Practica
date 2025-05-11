using System;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int number = 789; 

        Task<(int firstDigit, int lastDigit)> firstTask = Task.Run(() =>
        {
            int firstDigit = number / 100; 
            int lastDigit = number % 10;  
            return (firstDigit, lastDigit);
        });

        Task continuationTask = firstTask.ContinueWith(task =>
        {
            Console.WriteLine($"Исходное число: {number}");
            Console.WriteLine($"Первая цифра: {task.Result.firstDigit}");
            Console.WriteLine($"Последняя цифра: {task.Result.lastDigit}");
        });

        continuationTask.Wait();
    }
}
