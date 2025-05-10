using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Класс, представляющий контакт.
/// </summary>
class Contact
{
    private string lastName;
    private string firstName;
    private string phoneNumber;
    private DateTime birthDate;

    /// <summary>
    /// Свойство для фамилии контакта.
    /// </summary>
    public string LastName { get => lastName; set => lastName = value; }

    /// <summary>
    /// Свойство для имени контакта.
    /// </summary>
    public string FirstName { get => firstName; set => firstName = value; }

    /// <summary>
    /// Свойство для телефонного номера контакта.
    /// </summary>
    public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }

    /// <summary>
    /// Свойство для даты рождения контакта.
    /// </summary>
    public DateTime BirthDate { get => birthDate; set => birthDate = value; }

    /// <summary>
    /// Конструктор по умолчанию, создающий контакт с неизвестными данными.
    /// </summary>
    public Contact() : this("Неизвестно", "Неизвестно", "0000000000", DateTime.MinValue) { }

    /// <summary>
    /// Конструктор для создания контакта с заданными параметрами.
    /// </summary>
    /// <param name="lastName">Фамилия контакта.</param>
    /// <param name="firstName">Имя контакта.</param>
    /// <param name="phone">Телефонный номер контакта.</param>
    /// <param name="birthDate">Дата рождения контакта.</param>
    public Contact(string lastName, string firstName, string phone, DateTime birthDate)
    {
        this.lastName = lastName;
        this.firstName = firstName;
        this.phoneNumber = phone;
        this.birthDate = birthDate;
    }

    /// <summary>
    /// Выводит информацию о контакте в консоль.
    /// </summary>
    public void Print()
    {
        Console.WriteLine($"{lastName} {firstName}, Телефон: {phoneNumber}, Дата рождения: {birthDate.ToShortDateString()}");
    }
}

/// <summary>
/// Класс записной книжки для хранения контактов.
/// </summary>
class Notebook
{
    private List<Contact> contacts = new List<Contact>();

    /// <summary>
    /// Добавляет новый контакт в записную книжку.
    /// </summary>
    /// <param name="c">Контакт для добавления.</param>
    public void Add(Contact c) => contacts.Add(c);

    /// <summary>
    /// Удаляет контакт по индексу.
    /// </summary>
    /// <param name="index">Индекс удаляемого контакта.</param>
    public void RemoveAt(int index)
    {
        if (index >= 0 && index < contacts.Count)
            contacts.RemoveAt(index);
    }

    /// <summary>
    /// Поиск контактов по фамилии.
    /// </summary>
    /// <param name="lastName">Фамилия для поиска.</param>
    /// <returns>Список найденных контактов.</returns>
    public List<Contact> SearchByLastName(string lastName)
    {
        return contacts.Where(c => c.LastName.Equals(lastName, StringComparison.OrdinalIgnoreCase)).ToList();
    }

    /// <summary>
    /// Поиск контакта по телефонному номеру.
    /// </summary>
    /// <param name="phone">Номер телефона для поиска.</param>
    /// <returns>Найденный контакт или null.</returns>
    public Contact SearchByPhone(string phone)
    {
        return contacts.FirstOrDefault(c => c.PhoneNumber == phone);
    }

    /// <summary>
    /// Поиск контактов по дате рождения.
    /// </summary>
    /// <param name="date">Дата рождения для поиска.</param>
    /// <returns>Список найденных контактов.</returns>
    public List<Contact> SearchByBirthDate(DateTime date)
    {
        return contacts.Where(c => c.BirthDate.Date == date.Date).ToList();
    }

    /// <summary>
    /// Сортирует контакты по фамилии и имени.
    /// </summary>
    public void SortByLastName()
    {
        contacts = contacts.OrderBy(c => c.LastName).ThenBy(c => c.FirstName).ToList();
    }

    /// <summary>
    /// Индексатор для доступа к контактам по индексу.
    /// </summary>
    /// <param name="index">Индекс контакта.</param>
    /// <returns>Контакт по заданному индексу.</returns>
    public Contact this[int index]
    {
        get => contacts[index];
        set => contacts[index] = value;
    }

    /// <summary>
    /// Выводит все контакты в консоль.
    /// </summary>
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

/// <summary>
/// Главный класс программы, содержащий точку входа.
/// </summary>
class Program
{
    /// <summary>
    /// Точка входа в программу. Управляет работой записной книжки.
    /// </summary>
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
