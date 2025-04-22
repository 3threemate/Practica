using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите текст:");
        string input = Console.ReadLine();

        int index = input.IndexOf('*');
        if (index != -1 && index < input.Length - 1)
        {
            string beforeСaps = input.Substring(0, index + 1);
            string afterСaps = input.Substring(index + 1);
            afterСaps = afterСaps.ToLower();

            string result = beforeСaps + afterСaps;
            Console.WriteLine("Результат:");
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("Символ '*' не найден или находится в конце строки.");
        }
    }
}
