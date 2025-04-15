using System;

namespace ReverseThreeDigitNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите трехзначное число: ");
            int number = Convert.ToInt32(Console.ReadLine());

                int hundreds = number / 100;      
                int tens = (number / 10) % 10;   
                int ones = number % 10;         

                int reversedNumber = ones * 100 + tens * 10 + hundreds;

                Console.WriteLine($"Число справа налево: {reversedNumber}");
            }

    }
}
