using System;

enum Post
{
    Manager = 160,
    Engineer = 150,
    Technician = 140,
    Clerk = 130,
    Director = 170
}

class Accauntant
{
    public bool AskForBonus(Post worker, int hoursWorked)
    {
        int requiredHours = (int)worker;
        if (hoursWorked > requiredHours)
        {
            return true;
        }
        return false;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Accauntant accauntant = new Accauntant();

        Console.WriteLine("Введите профессию (Manager, Engineer, Technician, Clerk, Director):");
        Post worker = (Post)Enum.Parse(typeof(Post), Console.ReadLine()!);

        Console.WriteLine("Введите количество отработанных часов:");
        int hoursWorked = int.Parse(Console.ReadLine()!);

        bool bonus = accauntant.AskForBonus(worker, hoursWorked);
        Console.WriteLine($"Положена ли премия {worker}: {bonus}");
    }
}
