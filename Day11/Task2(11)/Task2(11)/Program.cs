using System;

class Program
{
    abstract class Vehicle
    {
        public string Name { get; set; }
        public double FuelConsumption { get; set; } 

        public Vehicle(string name, double fuelConsumption)
        {
            Name = name;
            FuelConsumption = fuelConsumption;
        }

        public abstract void DisplayInfo();

        public virtual double CalculateFuel(double distance)
        {
            return FuelConsumption * distance;
        }
    }

    class Car : Vehicle
    {
        public int Passengers { get; set; }

        public Car(string name, double fuelConsumption, int passengers)
            : base(name, fuelConsumption)
        {
            Passengers = passengers;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Легковой автомобиль: {Name}");
            Console.WriteLine($"Расход топлива: {FuelConsumption} л/км");
            Console.WriteLine($"Количество пассажиров: {Passengers}");
        }
    }

    class Truck : Vehicle
    {
        public double CargoCapacity { get; set; } 

        public Truck(string name, double fuelConsumption, double cargoCapacity)
            : base(name, fuelConsumption)
        {
            CargoCapacity = cargoCapacity;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Грузовик: {Name}");
            Console.WriteLine($"Расход топлива: {FuelConsumption} л/км");
            Console.WriteLine($"Грузоподъемность: {CargoCapacity} т");
        }
    }

    static void Main(string[] args)
    {
        Vehicle[] vehicles = new Vehicle[]
        {
            new Car("Автомобиль 1", 0.08, 4),
            new Car("Автомобиль 2", 0.10, 5),
            new Truck("Грузовик 1", 0.25, 10),
            new Truck("Грузовик 2", 0.30, 15),
            new Car("Автомобиль 3", 0.09, 2)
        };

        double totalFuelConsumption = 0;
        double distance = 100;

        foreach (var vehicle in vehicles)
        {
            vehicle.DisplayInfo();
            double fuel = vehicle.CalculateFuel(distance);
            Console.WriteLine($"Расход топлива на {distance} км: {fuel:F2} л");
            Console.WriteLine("--------------------");
            totalFuelConsumption += fuel;
        }

        Console.WriteLine($"Суммарный расход топлива на {distance} км: {totalFuelConsumption:F2} л");
    }
}
