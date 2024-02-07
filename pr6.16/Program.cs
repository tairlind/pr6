//Дан файл, содержащий текст, записанный строчными русскими буквами. Получить в другом 
//файле тот же текст, записанный заглавными буквами.

using System;
using System.IO;

class Program
{
    static void Main()
    {
        try
        {
            // Читаем текст из файла
            string inputText = File.ReadAllText("input.txt");

            // Преобразуем текст в заглавные буквы
            string outputText = inputText.ToUpper();

            // Записываем текст в другой файл
            File.WriteAllText("output.txt", outputText);

            Console.WriteLine("Текст успешно записан в файл output.txt");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Произошла ошибка: " + ex.Message);
        }
    }
}