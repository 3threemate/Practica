using System;

namespace StringDelegateExample
{
    /// <summary>
    /// Делегат для выполнения операций со строками.
    /// </summary>
    delegate string StringOperation(string input);

    /// <summary>
    /// Главный класс программы, реализующий строковые операции с использованием делегатов.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Преобразует строку в верхний регистр.
        /// </summary>
        /// <param name="input">Входная строка.</param>
        /// <returns>Строка в верхнем регистре.</returns>
        public static string ToUpperCase(string input)
        {
            return input.ToUpper();
        }

        /// <summary>
        /// Преобразует строку в нижний регистр.
        /// </summary>
        /// <param name="input">Входная строка.</param>
        /// <returns>Строка в нижнем регистре.</returns>
        public static string ToLowerCase(string input)
        {
            return input.ToLower();
        }

        /// <summary>
        /// Возвращает длину строки.
        /// </summary>
        /// <param name="input">Входная строка.</param>
        /// <returns>Длина строки в текстовом формате.</returns>
        public static string GetLength(string input)
        {
            return $"Длина строки: {input.Length}";
        }

        /// <summary>
        /// Точка входа в программу.
        /// Запрашивает у пользователя строку и выполняет выбранные операции над ней.
        /// </summary>
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
