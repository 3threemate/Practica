using System;
using System.Collections.Generic;

class MyList<T>
{
    private T[] items;
    private int count;

    public MyList()
    {
        items = new T[4];
        count = 0;
    }

    public void Add(T item)
    {
        if (count == items.Length)
        {
            Array.Resize(ref items, items.Length * 2); 
        }
        items[count] = item;
        count++;
    }

    public T this[int index]
    {
        get
        {
            if (index < 0 || index >= count)
                throw new IndexOutOfRangeException("Индекс вне допустимого диапазона");
            return items[index];
        }
    }

    public int Count
    {
        get { return count; }
    }
}

class Program
{
    static void Main()
    {
        MyList<int> myList = new MyList<int>();

        myList.Add(10);
        myList.Add(20);
        myList.Add(30);

        Console.WriteLine($"Элемент по индексу 1: {myList[1]}");
        Console.WriteLine($"Общее количество элементов: {myList.Count}");
    }
}
