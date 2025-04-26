using System;

class Program
{
    class Settlement
    {
        public string Name { get; set; }

        public Settlement(string name)
        {
            Name = name;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Населенный пункт: {Name}");
        }

        public virtual double CalculateDensity()
        {
            return 0; 
        }
    }

    class Village : Settlement
    {
        public int Houses { get; set; }
        public int ResidentsPerHouse { get; set; }
        public double Area { get; set; }

        public Village(string name, int houses, int residentsPerHouse, double area)
            : base(name)
        {
            Houses = houses;
            ResidentsPerHouse = residentsPerHouse;
            Area = area;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Село: {Name}");
            Console.WriteLine($"Количество домов: {Houses}");
            Console.WriteLine($"Жителей на дом: {ResidentsPerHouse}");
            Console.WriteLine($"Площадь: {Area}");
            Console.WriteLine($"Плотность населения: {CalculateDensity():F2}");
        }

        public override double CalculateDensity()
        {
            return (Houses * ResidentsPerHouse) / Area;
        }
    }

    class City : Settlement
    {
        public int Residents { get; set; }
        public double Area { get; set; }

        public City(string name, int residents, double area)
            : base(name)
        {
            Residents = residents;
            Area = area;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Город: {Name}");
            Console.WriteLine($"Количество жителей: {Residents}");
            Console.WriteLine($"Площадь: {Area}");
            Console.WriteLine($"Плотность населения: {CalculateDensity():F2}");
        }

        public override double CalculateDensity()
        {
            return Residents / Area;
        }
    }

    static void Main(string[] args)
    {
        Settlement[] settlements = new Settlement[]
        {
            new Village("Деревня 1", 20, 5, 10),
            new Village("Деревня 2", 30, 4, 15),
            new City("Город 1", 1000, 50),
            new City("Город 2", 2000, 80),
            new Settlement("Общий пункт"),
        };

        foreach (var settlement in settlements)
        {
            settlement.DisplayInfo();
            Console.WriteLine("--------------------");
        }
    }
}
