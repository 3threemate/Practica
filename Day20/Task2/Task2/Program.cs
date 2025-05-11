using System;
using System.Threading;
using System.Threading.Tasks;

class TaskExample
{
    private double alpha;

    public TaskExample(double alpha)
    {
        this.alpha = alpha;
    }

    public async Task<double> ComputeZ1Async()
    {
        Console.WriteLine("Вычисление z1...");
        await Task.Delay(new Random().Next(1000, 3000)); 
        return (1 - 2 * Math.Pow(Math.Sin(alpha), 2)) / (1 + Math.Sin(2 * alpha));
    }

    public async Task<double> ComputeZ2Async()
    {
        Console.WriteLine("Вычисление z2...");
        await Task.Delay(new Random().Next(1000, 3000)); 
        return (1 - Math.Tan(alpha)) / (1 + Math.Tan(alpha));
    }
}

class Program
{
    static async Task Main()
    {
        double alpha = Math.PI / 4;

        TaskExample task1 = new TaskExample(alpha);
        TaskExample task2 = new TaskExample(alpha);

        Task<double> t1 = task1.ComputeZ1Async();
        Task<double> t2 = task2.ComputeZ2Async();

        Console.WriteLine("Ожидание завершения всех задач...");
        double[] results = await Task.WhenAll(t1, t2);
        Console.WriteLine($"Все задачи выполнены! z1 = {results[0]}, z2 = {results[1]}");

        Console.WriteLine("Ожидание завершения хотя бы одной задачи...");
        Task<double> completedTask = await Task.WhenAny(t1, t2);
        Console.WriteLine($"Одна из задач завершена! Результат: {await completedTask}");
    }
}
