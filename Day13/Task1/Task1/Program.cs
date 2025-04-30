using System;

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

    static void Main(string[] args)
    {
        try
        {
            GetColorDelegate colorDelegate = new GetColorDelegate(GetRedColor);
            colorDelegate += GetBlueColor;
            colorDelegate += GetGreenColor;

            foreach (GetColorDelegate method in colorDelegate.GetInvocationList())
            {
                Console.WriteLine(method());
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }
    }
}
