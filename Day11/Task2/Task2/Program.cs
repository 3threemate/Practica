using System;

class A
{
    private int a;
    private int b;

    public int C
    {
        get
        {
            int sum = 0;
            for (int i = a; i <= b; i++)
            {
                sum += i;
            }
            return sum;
        }
    }

    public A()
    {
        a = 1;
        b = 10;
    }
        
    public void Display()
    {
        Console.WriteLine($"Класс A: a = {a}, b = {b}, C = {C}");
    }
}

class B : A
{
    private int d;

    public int C2
    {
        get
        {
            int product = 1;
            for (int i = 1; i <= d; i++)
            {
                product *= i;
            }
            return product + C;
        }
    }

    public B(int d)
    {
        this.d = d;
    }

    public void Display()
    {
        Console.WriteLine($"Класс B: d = {d}, C2 = {C2}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        A objA = new A();
        Console.WriteLine("Объект класса A:");
        objA.Display();

        B objB = new B(5);
        Console.WriteLine("\nОбъект класса B:");
        objB.Display();
    }
}
