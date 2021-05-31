using System;
using System.IO;

namespace HomeWork_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Ввести с клавиатуры произвольный набор данных и сохранить его в текстовый файл.
            Console.WriteLine("Введите произвольные данные для записи их в файл: ");
            string textToWrite = Console.ReadLine();
            File.WriteAllText("textFile.txt", $"{textToWrite}\n");

            //2.Написать программу, которая при старте дописывает текущее время в файл «startup.txt».
            File.AppendAllLines("startup.txt", new[] {DateTime.Now.ToShortTimeString()});

            //3.Ввести с клавиатуры произвольный набор чисел(0...255) и записать их в бинарный файл.

        }
    }
}
