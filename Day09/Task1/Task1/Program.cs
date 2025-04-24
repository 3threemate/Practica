using System;
using System.Linq;

namespace StudentInfo
{
    class Program
    {
        struct STUDENT
        {
            public string surnameInitials;
            public int groupNumber;
            public int[] grades;
        }

        static void Main(string[] args)
        {
            STUDENT[] students = new STUDENT[10];

            for (int i = 0; i < students.Length; i++)
            {я
                Console.WriteLine($"STUDENT {i + 1}:");
                Console.Write("Введите фамилию и инициалы: ");
                students[i].surnameInitials = Console.ReadLine();

                Console.Write("Введите номер группы: ");
                students[i].groupNumber = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите пять оценок через пробел:");
                students[i].grades = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            }

            SortStudentsByGroup(students);

            Console.WriteLine("\nСтуденты с средним баллом > 4.0:");
            bool hasHighAchievers = false;

            foreach (var student in students)
            {
                double average = student.grades.Average();
                if (average > 4.0)
                {
                    Console.WriteLine($"Фамилия: {student.surnameInitials}, Номер группы: {student.groupNumber}");
                    hasHighAchievers = true;
                }
            }

            if (!hasHighAchievers)
            {
                Console.WriteLine("Нет студентов со средним баллом больше 4.0.");
            }

            Console.ReadKey();
        }

        static void SortStudentsByGroup(STUDENT[] students)
        {
            STUDENT temp;

            for (int i = 0; i < students.Length; i++)
            {
                for (int j = i + 1; j < students.Length; j++)
                {
                    if (students[i].groupNumber > students[j].groupNumber)
                    {
                        temp = students[i];
                        students[i] = students[j];
                        students[j] = temp;
                    }
                }
            }
        }
    }
}
