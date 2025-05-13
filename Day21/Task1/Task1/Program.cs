using System;

interface IState
{
    void InsertCoin();
    void TurnHandle();
}

class NoCoinState : IState
{
    private VendingMachine machine;

    public NoCoinState(VendingMachine m) => machine = m;

    public void InsertCoin()
    {
        Console.WriteLine("Монета вставлена");
        machine.SetState(machine.HasCoinState);
    }

    public void TurnHandle() => Console.WriteLine("Сначала вставьте монету");
}

class HasCoinState : IState
{
    private VendingMachine machine;

    public HasCoinState(VendingMachine m) => machine = m;

    public void InsertCoin() => Console.WriteLine("Монета уже вставлена");

    public void TurnHandle()
    {
        Console.WriteLine("Выдал конфету");
        machine.ReleaseItem();
        if (machine.Count > 0)
            machine.SetState(machine.NoCoinState);
        else
            machine.SetState(machine.SoldOutState);
    }
}

class SoldOutState : IState
{
    public void InsertCoin() => Console.WriteLine("Автомат пуст");
    public void TurnHandle() => Console.WriteLine("Нечего выдавать");
}

class VendingMachine
{
    public IState NoCoinState { get; }
    public IState HasCoinState { get; }
    public IState SoldOutState { get; }

    private IState currentState;
    public int Count { get; private set; }

    public VendingMachine(int count)
    {
        NoCoinState = new NoCoinState(this);
        HasCoinState = new HasCoinState(this);
        SoldOutState = new SoldOutState();

        Count = count;
        currentState = count > 0 ? NoCoinState : SoldOutState;
    }

    public void InsertCoin() => currentState.InsertCoin();
    public void TurnHandle() => currentState.TurnHandle();
    public void SetState(IState state) => currentState = state;
    public void ReleaseItem()
    {
        if (Count > 0)
        {
            Count--;
            Console.WriteLine($"Осталось конфет: {Count}");
        }
    }
}

class Program
{
    static void Main()
    {
        var machine = new VendingMachine(2);

        machine.InsertCoin();
        machine.TurnHandle();

        machine.InsertCoin();
        machine.TurnHandle();

        machine.InsertCoin();
        machine.TurnHandle();
    }
}
