using System;

class Int2DArray
{
    private int[,] data;
    private int rows;
    private int cols;

    public Int2DArray(int rows, int cols)
    {
        this.rows = rows;
        this.cols = cols;
        data = new int[rows, cols];
    }

    public int this[int row, int col]
    {
        get
        {
            if (IsValid(row, col))
                return data[row, col];
            throw new IndexOutOfRangeException();
        }
        set
        {
            if (IsValid(row, col))
                data[row, col] = value;
            else
                throw new IndexOutOfRangeException();
        }
    }
    private bool IsValid(int row, int col)
    {
        return row >= 0 && row < rows && col >= 0 && col < cols;
    }

    public static Int2DArray operator %(Int2DArray array, int divisor)
    {
        Int2DArray result = new Int2DArray(array.rows, array.cols);
        for (int i = 0; i < array.rows; i++)
        {
            for (int j = 0; j < array.cols; j++)
            {
                result[i, j] = array[i, j] % divisor;
            }
        }
        return result;
    }

    public void Print()
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"{data[i, j],4}");
            }
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main()
    {
        Int2DArray array = new Int2DArray(2, 3);

        int value = 1;
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                array[i, j] = value++;
            }
        }

        Console.WriteLine("Исходный массив:");
        array.Print();

        Int2DArray result = array % 3;

        Console.WriteLine("\nОстатки от деления на 3:");
        result.Print();
    }
}
