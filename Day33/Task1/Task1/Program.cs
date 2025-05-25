using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;

namespace MyDatabaseDAL
{
    [Table(Name = "Turisty")]
    public class Turist
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }

        [Column]
        public string Name { get; set; }

        [Column]
        public string Country { get; set; }
    }

    public class TuristyDBContext : DataContext
    {
        public Table<Turist> Turisty;

        public TuristyDBContext(string connection) : base(connection) { }
    }

    class Program
    {
        static string connectionString = "Data Source=.;Initial Catalog=BDTur_firmSQL;Integrated Security=True;";

        static void Main(string[] args)
        {
            Console.WriteLine("LINQ to SQL");

            ViewTourists();
            AddTourist("John Doe", "USA");
            UpdateTourist(1, "Canada");
            DeleteTourist(1);

            Console.WriteLine("Готово!");
            Console.ReadLine();
        }

        static void ViewTourists()
        {
            using (var db = new TuristyDBContext(connectionString))
            {
                var tourists = from t in db.Turisty select t;
                Console.WriteLine("Список туристов:");
                foreach (var t in tourists)
                {
                    Console.WriteLine($"{t.Id}: {t.Name}, {t.Country}");
                }
            }
        }

        static void AddTourist(string name, string country)
        {
            using (var db = new TuristyDBContext(connectionString))
            {
                var newTourist = new Turist { Name = name, Country = country };
                db.Turisty.InsertOnSubmit(newTourist);
                db.SubmitChanges();
                Console.WriteLine($"Добавлен турист: {name}, {country}");
            }
        }

        static void UpdateTourist(int id, string newCountry)
        {
            using (var db = new TuristyDBContext(connectionString))
            {
                var tourist = db.Turisty.FirstOrDefault(t => t.Id == id);
                if (tourist != null)
                {
                    tourist.Country = newCountry;
                    db.SubmitChanges();
                    Console.WriteLine($"Изменён турист с ID={id}, новая страна: {newCountry}");
                }
            }
        }

        static void DeleteTourist(int id)
        {
            using (var db = new TuristyDBContext(connectionString))
            {
                var tourist = db.Turisty.FirstOrDefault(t => t.Id == id);
                if (tourist != null)
                {
                    db.Turisty.DeleteOnSubmit(tourist);
                    db.SubmitChanges();
                    Console.WriteLine($"Удалён турист с ID={id}");
                }
            }
        }
    }
}
