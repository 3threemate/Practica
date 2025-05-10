using System;

namespace AnonymousMethodExample
{
    /// <summary>
    /// Делегат, представляющий метод для генерации случайного значения.
    /// </summary>
    delegate int RandomValueDelegate();

    /// <summary>
    /// Главный класс программы, реализующий использование анонимных методов.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Точка входа в программу.
        /// Создает массив делегатов, использующих анонимные методы для генерации случайных значений.
        /// </summary>
        static void Main(string[] args)
        {
            /// <summary>
            /// Массив делегатов, каждый из которых генерирует случайное число.
            /// </summary>
            RandomValueDelegate[] delegatesArray = new RandomValueDelegate[5];

            Random random = new Random();

            // Заполняем массив делегатов анонимными методами
            for (int i = 0; i < delegatesArray.Length; i++)
            {
                delegatesArray[i] = delegate
                {
                    return random.Next(1, 101);
                };
            }

            /// <summary>
            /// Анонимный метод для вычисления среднего арифметического значений, возвращаемых делегатами.
            /// </summary>
            /// <param name="delegates">Массив делегатов.</param>
            /// <returns>Среднее арифметическое значений.</returns>
            Func<RandomValueDelegate[], double> calculateAverage = delegate (RandomValueDelegate[] delegates)
            {
                double sum = 0;
                foreach (var del in delegates)
                {
                    sum += del();
                }
                return sum / delegates.Length;
            };

            // Вычисляем среднее арифметическое
            double average = calculateAverage(delegatesArray);
            Console.WriteLine($"Среднее арифметическое случайных значений: {average}");
        }
    }
}
