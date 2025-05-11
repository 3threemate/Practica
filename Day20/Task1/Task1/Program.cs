using System;

class Task
{
    private int number;

    public Task()
    {
        number = 0;
    }

    public Task(int num)
    {
        number = num;
    }

    public Task(string input)
    {
        number = int.Parse(input);
    }

    public int ReverseNumber()
    {
        int reversed = 0, temp = number;
        while (temp > 0)
        {
            reversed = reversed * 10 + temp % 10;
            temp /= 10;
        }
        return reversed;
    }

    public void ShowResult()
    {
        Console.WriteLine($"Исходное число: {number}");
        Console.WriteLine($"Перевернутое число: {ReverseNumber()}");
    }
}

class Program
{
    static void Main()
    {
        Task task1 = new Task();
        task1.ShowResult();

        Task task2 = new Task(123);
        task2.ShowResult();

        Console.WriteLine("Введите трехзначное число:");
        string input = Console.ReadLine();
        Task task3 = new Task(input);
        task3.ShowResult();
    }
}
