using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Student
{
    public string LastName { get; }
    public string FirstName { get; }
    public string MiddleName { get; }
    public string Group { get; }
    public int Score { get; }

    // Конструктор
    public Student(string lastName, string firstName, string middleName, string group, int score)
    {
        LastName = lastName;
        FirstName = firstName;
        MiddleName = middleName;
        Group = group;
        Score = score;
    }

    // Деструктор
    ~Student()
    {
        // Здесь можно освободить ресурсы, если это необходимо
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Student> students = new List<Student>();
        string inputFilePath = "../../../students.txt"; // Путь к файлу с данными
        string outputFilePath = "../../../output.txt"; // Путь к файлу для вывода результатов

        // Чтение данных из файла
        try
        {
            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var parts = line.Split(',');
                    if (parts.Length == 5)
                    {
                        string lastName = parts[0].Trim();
                        string firstName = parts[1].Trim();
                        string middleName = parts[2].Trim();
                        string group = parts[3].Trim();
                        int score = int.Parse(parts[4].Trim());

                        students.Add(new Student(lastName, firstName, middleName, group, score));
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при чтении файла: {ex.Message}");
            return;
        }

        // Подсчет количества студентов с одинаковыми фамилиями
        var lastNameCount = students.GroupBy(s => s.LastName)
                                     .Select(g => new { LastName = g.Key, Count = g.Count() })
                                     .ToList();

        // Вывод результатов на экран и в файл
        using (StreamWriter writer = new StreamWriter(outputFilePath))
        {
            foreach (var item in lastNameCount)
            {
                string output = $"{item.LastName}: {item.Count} студентов";
                Console.WriteLine(output);
                writer.WriteLine(output);
            }
        }
    }
}
