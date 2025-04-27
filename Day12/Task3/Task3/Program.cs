using System;

namespace StringDelegateExample
{
    delegate string StringOperation(string input);

    class Program
    {
        public static string ToUpperCase(string input)
        {
            return input.ToUpper();
        }

        public static string ToLowerCase(string input)
        {
            return input.ToLower();
        }

        public static string GetLength(string input)
        {
            return $"Длина строки: {input.Length}";
        }

        static void Main(string[] args)
        {
            StringOperation stringOperation;

            Console.WriteLine("Введите строку:");
            string userInput = Console.ReadLine();

            stringOperation = ToUpperCase;
            Console.WriteLine($"Верхний регистр: {stringOperation(userInput)}");

            stringOperation = ToLowerCase;
            Console.WriteLine($"Нижний регистр: {stringOperation(userInput)}");

            stringOperation = GetLength;
            Console.WriteLine(stringOperation(userInput));
        }
    }
}
