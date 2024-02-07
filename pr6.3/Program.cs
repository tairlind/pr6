//Занести в файл F 10 символов. Напечатать только цифры из этого файла.

using System;
using System.IO;

class Program
{
    static void Main()
    {
        // получаем текст от пользователя
        Console.WriteLine("Введите текст:");
        string text = Console.ReadLine();

        // записываем текст в файл
        string fileName = "file.txt";
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            writer.WriteLine(text);
        }

        // читаем символы из файла и выводим только цифры
        using (StreamReader reader = new StreamReader(fileName))
        {
            string line = reader.ReadLine();
            foreach (char c in line)
            {
                if (char.IsDigit(c))
                {
                    Console.WriteLine(c);
                }
            }
        }
    }
}
