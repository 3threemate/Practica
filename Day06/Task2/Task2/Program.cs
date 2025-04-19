using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int[] array = new int[100];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(-50, 51); 
        }

        Console.WriteLine("Отрицательные числа:");
        foreach (int number in array)
        {
            if (number < 0) 
            {
                Console.Write(number + " ");
            }
        }

        Console.WriteLine("\nОстальные числа:");
        foreach (int number in array)
        {
            if (number >= 0) 
            {
                Console.Write(number + " ");
            }
        }
    }
}
