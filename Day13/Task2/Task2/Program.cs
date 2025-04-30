using System;

// Определяем делегат
delegate string GetColorDelegate();

class Program
{
    static string GetRedColor()
    {
        return "Красный";
    }

    static string GetBlueColor()
    {
        return "Синий";
    }

    static string GetGreenColor()
    {
        return "Зелёный";
    }

    static void ExecuteDelegate(GetColorDelegate colorDelegate)
    {
        try
        {
            Console.WriteLine(colorDelegate());
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка при выполнении делегата: {ex.Message}");
        }
    }

    static void Main(string[] args)
    {
        try
        {
            GetColorDelegate redDelegate = new GetColorDelegate(GetRedColor);
            GetColorDelegate blueDelegate = new GetColorDelegate(GetBlueColor);
            GetColorDelegate greenDelegate = new GetColorDelegate(GetGreenColor);

            ExecuteDelegate(redDelegate);
            ExecuteDelegate(blueDelegate);
            ExecuteDelegate(greenDelegate);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Общая ошибка программы: {ex.Message}");
        }
    }
}
