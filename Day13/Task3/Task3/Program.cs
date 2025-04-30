using System;

class MyInfo
{
    private string name;

    public event EventHandler<string> NameChanged;

    public string Name
    {
        get { return name; }
        set
        {
            if (name != value) 
            {
                name = value;
                OnNameChanged(name);
            }
        }
    }

    protected virtual void OnNameChanged(string newName)
    {
        NameChanged?.Invoke(this, newName);
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyInfo myInfo = new MyInfo();

        myInfo.NameChanged += (sender, newName) =>
        {
            Console.WriteLine($"Имя изменено на: {newName}");
        };

        myInfo.Name = "Кирилл";
        myInfo.Name = "Александр";
    }
}
