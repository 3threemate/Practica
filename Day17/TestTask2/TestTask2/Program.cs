using System;
using StoreLibrary;

class Program
{
    static void Main()
    {
        Product product1 = new Product("Молоко", 2.5);
        Product product2 = new Product("Хлеб", 1.2);
        Product product3 = new Product("Яблоки", 3.8);

        Cart cart = new Cart();
        cart.AddProduct(product1);
        cart.AddProduct(product2);
        cart.AddProduct(product3);

        cart.ShowCart();

        cart.RemoveProduct(product2);
        cart.ShowCart();
    }
}
