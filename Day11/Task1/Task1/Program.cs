using System;

class BaseClass
{
    private string name;
    private double cost;

    public BaseClass(string name, double cost)
    {
        this.name = name;
        this.cost = cost;
    }
    public string GetName()
    {
        return name;
    }
    public double GetCost()
    {
        return cost;
    }
    public void SetCost(double cost)
    {
        this.cost = cost;
    }
    public virtual void Display()
    {
        Console.WriteLine($"Название: {name}, Стоимость: {cost} р.");
    }
}

class DerivedClass : BaseClass
{
    private string coverMaterial;
    public DerivedClass(string name, double cost, string coverMaterial)
        : base(name, cost)
    {
        this.coverMaterial = coverMaterial;
    }
    public override void Display()
    {
        double adjustedCost = GetCost() + 50;
        Console.WriteLine($"Название: {GetName()}, Материал обложки: {coverMaterial}, Стоимость с надбавкой: {adjustedCost} р.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        BaseClass baseObject = new BaseClass("Книга", 300);
        Console.WriteLine("Объект базового типа:");
        baseObject.Display();

        DerivedClass derivedObject = new DerivedClass("Журнал", 200, "Кожа");
        Console.WriteLine("\nОбъект производного типа:");
        derivedObject.Display();

        Console.WriteLine("\nДемонстрация работы методов доступа:");
        Console.WriteLine($"Название: {derivedObject.GetName()}, Стоимость: {derivedObject.GetCost()} р.");
    }
}
