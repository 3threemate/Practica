using System;

class A
{
    public int a { get; set; }
    public int b { get; set; }

    public A(int a, int b)
    {
        this.a = a;
        this.b = b;
    }
    public int Multiply()
    {
        return a * b;
    }
    public string Calculate()
    {
        if (a != 0) 
        {
            return (Math.Sqrt(b) / (2 * a)).ToString();
        }
        else
        {
            return "Делить на ноль нельзя";
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        A obj = new A(4, 16); 
        Console.WriteLine("Произведение a и b: " + obj.Multiply());
        Console.WriteLine("Результат выражения √b / (2a): " + obj.Calculate());
    }
}
