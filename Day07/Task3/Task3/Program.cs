using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите предложение:");
        string input = Console.ReadLine();

        string[] words = input.Split(' ');

        if (words.Length < 4)
        {
            Console.WriteLine("Предложение должно содержать как минимум четыре слова для выполнения всех действий.");
            return;
        }

        string temp = words[0];
        words[0] = words[words.Length - 1];
        words[words.Length - 1] = temp;

        Console.WriteLine("После замены первого и последнего слова:");
        Console.WriteLine(string.Join(" ", words));

        string combined = words[1] + words[2];
        Console.WriteLine("Склеенные второе и третье слова:");
        Console.WriteLine(combined);

        char[] thirdWordArray = words[2].ToCharArray();
        Array.Reverse(thirdWordArray);
        string reversedThirdWord = new string(thirdWordArray);
        Console.WriteLine("Третье слово в обратном порядке:");
        Console.WriteLine(reversedThirdWord);

        if (words[0].Length > 2)
        {
            string firstWordModified = words[0].Substring(2);
            Console.WriteLine("Первое слово без первых двух букв:");
            Console.WriteLine(firstWordModified);
        }
        else
        {
            Console.WriteLine("Первое слово слишком короткое, чтобы вырезать первые две буквы.");
        }
    }
}
