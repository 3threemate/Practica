using System;

class Program
{
    static void Main()
    {
        int size = 7; 
        int[,] array = new int[size, size];
        int value = 1; 

        int top = 0, bottom = size - 1, left = 0, right = size - 1;

        while (value <= size * size)
        {
            for (int i = left; i <= right; i++)
            {
                array[top, i] = value++;
            }
            top++;

            for (int i = top; i <= bottom; i++) 
            {
                array[i, right] = value++;
            }
            right--;

            for (int i = right; i >= left; i--) 
            {
                array[bottom, i] = value++;
            }
            bottom--;

            for (int i = bottom; i >= top; i--) 
            {
                array[i, left] = value++;
            }
            left++;
        }

        Console.WriteLine("Массив 7x7, заполненный по спирали:");
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
