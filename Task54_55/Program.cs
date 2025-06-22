using System;
using System.IO;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        string filePath = @"..\..\numbers.txt";

        // Создание файла и запись чисел
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            for (int i = 1; i <= 500; i++)
            {
                writer.Write(i);
                if (i < 500)
                {
                    writer.Write(","); // добавляем запятую между числами
                }
            }
        }

        Console.WriteLine("Файл numbers.txt успешно создан и заполнен числами от 1 до 500.");

        // Чтение из файла
        using (StreamReader reader = new StreamReader(filePath))
        {
            string content = reader.ReadToEnd();
            Console.WriteLine("Содержимое файла numbers.txt:");
            Console.WriteLine(content);
        }
    }
}
