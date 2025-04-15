using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите возраст:");
        int age = int.Parse(Console.ReadLine());

        string category;

        if (age < 1)
        {
            category = "младенец";
        }
        else if (age >= 1 && age <= 11)
        {
            category = "ребенок";
        }
        else if (age >= 12 && age <= 15)
        {
            category = "подросток";
        }
        else if (age >= 16 && age <= 25)
        {
            category = "юноша";
        }
        else if (age >= 26 && age <= 70)
        {
            category = "мужчина";
        }
        else
        {
            category = "старик";
        }

        Console.WriteLine($"Возрастная категория: {category}");
    }
}
