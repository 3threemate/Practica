using System;

class Program
{
    static void Main()
    {
        int[] array = { 10, 15, 3, 8, 7, 20, 5 };

        Console.WriteLine("Порядковые номера нечётных элементов:");

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 != 0) 
            {
                Console.WriteLine(i + 1); 
            }
        }
    }
}
