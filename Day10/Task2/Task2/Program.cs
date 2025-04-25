using System;
using System.Linq;
class Car : IComparable<Car>
{
    public string LicensePlate { get; set; }
    public string Color { get; set; }
    public string OwnerLastName { get; set; }
    public bool IsPresent { get; set; }
    public int CompareTo(Car other)
    {
        return string.Compare(this.LicensePlate, other.LicensePlate, StringComparison.Ordinal);
    }
    public static bool operator <(Car c1, Car c2) => c1.LicensePlate.CompareTo(c2.LicensePlate) < 0;
    public static bool operator >(Car c1, Car c2) => c1.LicensePlate.CompareTo(c2.LicensePlate) > 0;

    public override string ToString()
    {
        return $"Госномер: {LicensePlate}, Цвет: {Color}, Владелец: {OwnerLastName}, На стоянке: {IsPresent}";
    }
}

class ParkingLot
{
    private Car[] cars;

    public ParkingLot(int capacity)
    {
        cars = new Car[capacity];
    }
    public void AddCar(int spot, Car car)
    {
        if (spot < 0 || spot >= cars.Length)
        {
            Console.WriteLine("Неправильный номер места.");
            return;
        }
        cars[spot] = car;
    }
    public Car GetCarBySpot(int spot)
    {
        if (spot < 0 || spot >= cars.Length)
        {
            Console.WriteLine("Неправильный номер места.");
            return null;
        }
        return cars[spot];
    }
    public Car[] SearchByOwnerLastName(string lastName)
    {
        return cars.Where(car => car != null && car.OwnerLastName == lastName).ToArray();
    }
    public void PrintPresentCars()
    {
        foreach (var car in cars.Where(car => car != null && car.IsPresent))
        {
            Console.WriteLine(car);
        }
    }
    public void PrintAbsentCars()
    {
        foreach (var car in cars.Where(car => car != null && !car.IsPresent))
        {
            Console.WriteLine(car);
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        var parkingLot = new ParkingLot(5);
        parkingLot.AddCar(0, new Car { LicensePlate = "123ABC", Color = "Красный", OwnerLastName = "Иванов", IsPresent = true });
        parkingLot.AddCar(1, new Car { LicensePlate = "456DEF", Color = "Синий", OwnerLastName = "Петров", IsPresent = false });
        parkingLot.AddCar(2, new Car { LicensePlate = "789GHI", Color = "Белый", OwnerLastName = "Сидоров", IsPresent = true });
        Console.WriteLine("Машины, присутствующие на стоянке:");
        parkingLot.PrintPresentCars();
        Console.WriteLine("\nМашины, отсутствующие на стоянке:");
        parkingLot.PrintAbsentCars();
        Console.WriteLine("\nПоиск машины по фамилии владельца:");
        var foundCars = parkingLot.SearchByOwnerLastName("Иванов");
        foreach (var car in foundCars)
        {
            Console.WriteLine(car);
        }
        Console.WriteLine("\nИнформация о машине по номеру места:");
        var carAtSpot = parkingLot.GetCarBySpot(1);
        Console.WriteLine(carAtSpot != null ? carAtSpot.ToString() : "Место пустое.");
    }
}
