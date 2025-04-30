using System;

public class EventPublisher
{
    public delegate void NotifyDelegate(string message);

    public event NotifyDelegate NotifyEvent;

    public void TriggerEvent(string message)
    {
        NotifyEvent?.Invoke(message);
    }
}

public class Observer1
{
    public void Reaction1(string message)
    {
        Console.WriteLine($"Observer1 получил сообщение: {message}");
    }

    public void Reaction2(string message)
    {
        Console.WriteLine($"Observer1 второй обработчик: {message}");
    }
}

public class Observer2
{
    public void Reaction(string message)
    {
        Console.WriteLine($"Observer2 получил сообщение: {message}");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        EventPublisher publisher = new EventPublisher();
        Observer1 observer1 = new Observer1();
        Observer2 observer2 = new Observer2();

        publisher.NotifyEvent += observer1.Reaction1;
        publisher.NotifyEvent += observer1.Reaction2;
        publisher.NotifyEvent += observer2.Reaction;

        Console.WriteLine("Событие запускается с тремя обработчиками:");
        publisher.TriggerEvent("Привет, мир!");

        publisher.NotifyEvent -= observer1.Reaction2;

        Console.WriteLine("\nСобытие запускается после удаления одного обработчика:");
        publisher.TriggerEvent("Второй запуск события!");
    }
}
