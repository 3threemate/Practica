using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Двузначные числа, сумма квадратов цифр которых кратна 13:");

        for (int number = 10; number <= 99; number++)
        {
            int tens = number / 10; 
            int units = number % 10;

            int sumOfSquares = (tens * tens) + (units * units); 

            if (sumOfSquares % 13 == 0)
            {
                Console.WriteLine(number);
            }
        }
    }
}
