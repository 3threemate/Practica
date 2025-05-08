using System;
using System.Collections.Generic;

public class MenuPrototype<T> where T : class, ICloneable
{
    private List<T> menuItems = new List<T>();
    private Dictionary<int, T?> menuDictionary = new Dictionary<int, T?>();

    public void AddMenuItem(int id, T item)
    {
        menuItems.Add(item);
        menuDictionary[id] = item;
    }

    public void RemoveMenuItem(int id)
    {
        if (menuDictionary.ContainsKey(id))
        {
            menuItems.Remove(menuDictionary[id]);
            menuDictionary[id] = null;
        }
    }

    public T CloneMenuItem(T item)
    {
        return (T)item.Clone();
    }

    public void PrintMenu()
    {
        Console.WriteLine("Список меню:");
        foreach (var item in menuItems)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("\nМеню в словаре:");
        foreach (var kvp in menuDictionary)
        {
            Console.WriteLine($"ID {kvp.Key}: {(kvp.Value == null ? "null" : kvp.Value.ToString())}");
        }
    }
}

public class MenuItem : ICloneable
{
    public string Name { get; set; }
    public decimal Price { get; set; }

    public MenuItem(string name, decimal price)
    {
        Name = name;
        Price = price;
    }

    public object Clone()
    {
        return new MenuItem(Name, Price);
    }

    public override string ToString()
    {
        return $"{Name} - {Price:C}";
    }
}

class Program
{
    static void Main()
    {
        MenuPrototype<MenuItem> menu = new MenuPrototype<MenuItem>();

        menu.AddMenuItem(1, new MenuItem("Бургер", 5m));
        menu.AddMenuItem(2, new MenuItem("Пицца", 8m));

        MenuItem clonedItem = menu.CloneMenuItem(new MenuItem("Салат", 4m));
        menu.AddMenuItem(3, clonedItem);

        menu.RemoveMenuItem(2);

        menu.PrintMenu();
    }
}
