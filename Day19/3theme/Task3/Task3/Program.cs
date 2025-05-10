using System;

/// <summary>
/// Класс для работы с двумерным массивом целых чисел.
/// </summary>
class Int2DArray
{
    private int[,] data;
    private int rows;
    private int cols;

    /// <summary>
    /// Создает новый экземпляр двумерного массива.
    /// </summary>
    /// <param name="rows">Количество строк.</param>
    /// <param name="cols">Количество столбцов.</param>
    public Int2DArray(int rows, int cols)
    {
        this.rows = rows;
        this.cols = cols;
        data = new int[rows, cols];
    }

    /// <summary>
    /// Индексатор для доступа к элементам массива.
    /// </summary>
    /// <param name="row">Индекс строки.</param>
    /// <param name="col">Индекс столбца.</param>
    /// <returns>Значение элемента массива.</returns>
    /// <exception cref="IndexOutOfRangeException">Выбрасывается, если индексы выходят за границы массива.</exception>
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

    /// <summary>
    /// Проверяет, находятся ли индексы в допустимых границах массива.
    /// </summary>
    /// <param name="row">Индекс строки.</param>
    /// <param name="col">Индекс столбца.</param>
    /// <returns>True, если индексы допустимы, иначе false.</returns>
    private bool IsValid(int row, int col)
    {
        return row >= 0 && row < rows && col >= 0 && col < cols;
    }

    /// <summary>
    /// Переопределенный оператор %, применяемый к каждому элементу массива.
    /// </summary>
    /// <param name="array">Исходный массив.</param>
    /// <param name="divisor">Делитель.</param>
    /// <returns>Новый массив с остатками от деления.</returns>
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

    /// <summary>
    /// Выводит массив на консоль.
    /// </summary>
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

/// <summary>
/// Главный класс программы, содержащий точку входа.
/// </summary>
class Program
{
    /// <summary>
    /// Точка входа в программу.
    /// Создает массив, заполняет его значениями и применяет операцию %.
    /// </summary>
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
