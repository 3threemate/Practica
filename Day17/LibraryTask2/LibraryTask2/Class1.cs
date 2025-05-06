using System;
using System.Collections.Generic;

namespace LibraryTask2
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Name}: {Price} руб.";
        }
    }

    public class Cart
    {
        private List<Product> products = new List<Product>();

        public void AddProduct(Product product)
        {
            products.Add(product);
            Console.WriteLine($"{product.Name} добавлен в корзину.");
        }

        public void RemoveProduct(Product product)
        {
            if (products.Remove(product))
                Console.WriteLine($"{product.Name} удален из корзины.");
            else
                Console.WriteLine($"{product.Name} не найден в корзине.");
        }

        public double GetTotalPrice()
        {
            double total = 0;
            foreach (var product in products)
            {
                total += product.Price;
            }
            return total;
        }

        public void ShowCart()
        {
            Console.WriteLine("Содержимое корзины:");
            foreach (var product in products)
            {
                Console.WriteLine(product);
            }
            Console.WriteLine($"Итоговая стоимость: {GetTotalPrice()} руб.");
        }
    }
}
