using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


namespace HomeWork_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Ввести с клавиатуры произвольный набор данных и сохранить его в текстовый файл.
            Console.Write("Введите произвольные данные для записи их в файл: ");
            string textToWrite = Console.ReadLine();
            File.WriteAllText("textFile.txt", $"{textToWrite}\n");

            //2.Написать программу, которая при старте дописывает текущее время в файл «startup.txt».
            File.AppendAllLines("startup.txt", new[] {DateTime.Now.ToShortTimeString()});

            //3.Ввести с клавиатуры произвольный набор чисел(0...255) и записать их в бинарный файл.
            Console.Write("Введите произвольные числа от 0 до 255: ");
            string numbers = Console.ReadLine();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(new FileStream("randomNumbers.bin", FileMode.OpenOrCreate), numbers);

            //4.
            Person[] persArray = new Person[5];
            persArray[0] = new Person("Ivanov Ivan Ivanovich", "Engineer", "ivivan@mailbox.com", "89231231255", 30000, 30);
            persArray[1] = new Person("Sergeev Sergey Sergeevich", "Manager", "sergey@mail.com", "89205777342", 70000, 40);
            persArray[2] = new Person("Evgenina Evgeniya", "Bayer", "shenya@mailbox.com", "89057748935", 43000, 70);
            persArray[3] = new Person("Kolotilov Vasiliy Vasilévich", "Programmer", "vasya@mailbox.com", "89614005968", 12000, 24);
            persArray[4] = new Person("Bayan Stepan", "Engineer", "bayan@mailbox.com", "89283440012", 100000, 42);

            foreach (var item in persArray)
            {
                if (item._age >40)
                {
                    item.PrintPerson();
                }
            }
        }
    }
}
