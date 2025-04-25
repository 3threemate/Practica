using System;

interface Ix
{
    void IxF0(int w);
    void IxF1(int w);
}

interface Iy
{
    void F0(int w);
    void F1(int w);
}

interface Iz
{
    void F0(int w);
    void F1(int w);
}

class TestClass : Ix, Iy, Iz
{
    public void IxF0(int w)
    {
        Console.WriteLine($"IxF0: {w + 5}");
    }

    public void IxF1(int w)
    {
        Console.WriteLine($"IxF1: {w + 5}");
    }

    public void F0(int w)
    {
        Console.WriteLine($"Iy.F0 (неявная): {Math.Pow(w, 3)}");
    }

    public void F1(int w)
    {
        Console.WriteLine($"Iy.F1 (неявная): {Math.Pow(w, 3)}");
    }

    void Iz.F0(int w)
    {
        Console.WriteLine($"Iz.F0 (явная): {7 * w - 2}");
    }

    void Iz.F1(int w)
    {
        Console.WriteLine($"Iz.F1 (явная): {7 * w - 2}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        TestClass test = new TestClass();

        test.F0(3);
        test.F1(3);

        Iz izRef = test;
        izRef.F0(3);
        izRef.F1(3);

        Iy iyRef = test;
        iyRef.F0(3);
        iyRef.F1(3);
    }
}
