using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        try
        {
            string inputFile = "C:/Test/numbers.txt";
            string outputFile = "C:/Test/processed_numbers.txt";

            File.WriteAllLines(inputFile, new string[] { "20 10 4 -1 -2 0 0 0 -10 41 62" });


            var numbers = File.ReadAllText(inputFile)
                              .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                              .Select(int.Parse)
                              .ToArray();

            List<int> processedNumbers = new List<int>();

            int sum = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if ((numbers[i] > 0 && sum > 0) || (numbers[i] < 0 && sum < 0))
                {
                    sum += numbers[i]; 
                }
                else if (numbers[i] == 0)
                {
                    if (processedNumbers.Count == 0 || processedNumbers[^1] != 0)
                        processedNumbers.Add(0); 
                    sum = 0;
                }
                else
                {
                    processedNumbers.Add(sum); 
                    sum = numbers[i]; 
                }
            }
            processedNumbers.Add(sum);

            File.WriteAllLines(outputFile, new string[] { string.Join(" ", processedNumbers) });

            Console.WriteLine($"Обработанные данные записаны в файл {outputFile}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}
