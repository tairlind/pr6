//Занести в файл 10 целых чисел, не превышающих 255. Найти сумму минимального и 
//максимального элементов данного файла.

using System;
using System.IO;

class Program
{
    static void Main()
    {
        int[] numbers = new int[10];

        Random random = new Random();
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(0, 256);
        }

        string fileName = "numbers.txt";
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (int num in numbers)
            {
                writer.WriteLine(num);
            }
        }

        // читаем числа из файла и находим минимальное и максимальное значение.
        int min = int.MaxValue;
        int max = int.MinValue;
        using (StreamReader reader = new StreamReader(fileName))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                int num = int.Parse(line);
                if (num < min)
                {
                    min = num;
                }
                if (num > max)
                {
                    max = num;
                }
            }
        }

        int sum = min + max;

        Console.WriteLine("Минимальное значение: " + min);
        Console.WriteLine("Максимальное значение: " + max);
        Console.WriteLine("Сумма минимального и максимального элементов: " + sum);
    }
}
