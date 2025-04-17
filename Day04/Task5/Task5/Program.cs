using System;
using System.Collections.Generic;
using System.Linq;

class Contact
{
    private string lastName;
    private string firstName;
    private string phoneNumber;
    private DateTime birthDate;

    // Свойства
    public string LastName { get => lastName; set => lastName = value; }
    public string FirstName { get => firstName; set => firstName = value; }
    public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
    public DateTime BirthDate { get => birthDate; set => birthDate = value; }

    public Contact() : this("Неизвестно", "Неизвестно", "0000000000", DateTime.MinValue) { }

    public Contact(string lastName, string firstName, string phone, DateTime birthDate)
    {
        this.lastName = lastName;
        this.firstName = firstName;
        this.phoneNumber = phone;
        this.birthDate = birthDate;
    }

    public void Print()
    {
        Console.WriteLine($"{lastName} {firstName}, Телефон: {phoneNumber}, Дата рождения: {birthDate.ToShortDateString()}");
    }
}
class Program
{
    static void Main()
    {
        Notebook notebook = new Notebook();

        notebook.Add(new Contact("Иванов", "Иван", "1234567890", new DateTime(1990, 5, 1)));
        notebook.Add(new Contact("Петров", "Петр", "9876543210", new DateTime(1985, 12, 15)));
        notebook.Add(new Contact("Сидорова", "Анна", "5556667777", new DateTime(1995, 7, 20)));

        Console.WriteLine("Все записи:");
        notebook.ShowAll();

        Console.WriteLine("\nПоиск по фамилии 'Иванов':");
        var found = notebook.SearchByLastName("Иванов");
        foreach (var c in found) c.Print();

        Console.WriteLine("\nПоиск по номеру '5556667777':");
        var phoneFound = notebook.SearchByPhone("5556667777");
        phoneFound?.Print();

        Console.WriteLine("\nПоиск по дате рождения 01.05.1990:");
        var dateFound = notebook.SearchByBirthDate(new DateTime(1990, 5, 1));
        foreach (var c in dateFound) c.Print();

        Console.WriteLine("\nСортировка по фамилии:");
        notebook.SortByLastName();
        notebook.ShowAll();

        Console.WriteLine("\nУдаление записи №2:");
        notebook.RemoveAt(1);
        notebook.ShowAll();

        Console.WriteLine("\nДоступ по индексу notebook[0]:");
        notebook[0].Print();
    }
}

class Notebook
{
    private List<Contact> contacts = new List<Contact>();

    public void Add(Contact c) => contacts.Add(c);

    public void RemoveAt(int index)
    {
        if (index >= 0 && index < contacts.Count)
            contacts.RemoveAt(index);
    }

    public List<Contact> SearchByLastName(string lastName)
    {
        return contacts.Where(c => c.LastName.Equals(lastName, StringComparison.OrdinalIgnoreCase)).ToList();
    }

    public Contact SearchByPhone(string phone)
    {
        return contacts.FirstOrDefault(c => c.PhoneNumber == phone);
    }

    public List<Contact> SearchByBirthDate(DateTime date)
    {
        return contacts.Where(c => c.BirthDate.Date == date.Date).ToList();
    }

    public void SortByLastName()
    {
        contacts = contacts.OrderBy(c => c.LastName).ThenBy(c => c.FirstName).ToList();
    }

    public Contact this[int index]
    {
        get => contacts[index];
        set => contacts[index] = value;
    }

    public void ShowAll()
    {
        if (contacts.Count == 0)
        {
            Console.WriteLine("Записная книжка пуста.");
            return;
        }

        for (int i = 0; i < contacts.Count; i++)
        {
            Console.Write($"{i + 1}. ");
            contacts[i].Print();
        }
    }
}
