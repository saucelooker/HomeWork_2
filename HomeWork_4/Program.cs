using System;

namespace HomeWork_4
{
    class Program
    {
        //Написать метод GetFullName(string firstName, string lastName, string patronymic), 
        //принимающий на вход ФИО в разных аргументах и возвращающий объединённую 
        //cтроку с ФИО.Используя метод, написать программу, выводящую в консоль 3–4 разных ФИО.
        static void GetFullName(string firstName, string lastName, string patronymic)
        {
            Console.WriteLine($"{lastName} {firstName} {patronymic}");
        }


        //Написать программу, принимающую на вход строку — набор чисел, разделенных пробелом, 
        //и возвращающую число — сумму всех чисел в строке.Ввести данные с клавиатуры и вывести результат на экран.
        static int AdditionOfNumbers(string inputData)
        {
            int sumOfNumbers = 0;
            string[] tempArray = inputData.Split(' ');
            for (int i = 0; i < tempArray.Length; i++)
            {
                sumOfNumbers += int.Parse(tempArray[i]); 
            }
            return sumOfNumbers;
        }


        //Написать метод по определению времени года. На вход подаётся число – порядковый номер месяца.
        //На выходе — значение из перечисления(enum) — Winter, Spring, Summer, Autumn.Написать метод, 
        //принимающий на вход значение из этого перечисления и возвращающий название времени года(зима, весна, лето, осень). 
        //Используя эти методы, ввести с клавиатуры номер месяца и вывести название времени года.
        //Если введено некорректное число, вывести в консоль текст «Ошибка: введите число от 1 до 12».
        static int SeasonStepOne(int numberOfSeason)
        {
            int tempData=0;
            if (numberOfSeason == 12 || numberOfSeason == 1 || numberOfSeason == 2)
            {
                tempData = (int)season.Winter;
            }
            else if (numberOfSeason == 3 || numberOfSeason == 4 || numberOfSeason == 5)
            {
                tempData = (int)season.Spring;
            }
            else if (numberOfSeason == 6 || numberOfSeason == 7 || numberOfSeason == 8)
            {
                tempData = (int)season.Summer;
            }
            else 
            {
                tempData = (int)season.Autumn;
            }
            return tempData;
        }

        static string SeasonStepTwo(int numberOfSeason)
        {
            string resultSeason = "";
            if (numberOfSeason ==0)
                resultSeason = "зима";
            if (numberOfSeason == 1)
                resultSeason = "весна";
            if (numberOfSeason == 2)
                resultSeason = "лето";
            if (numberOfSeason == 3)
                resultSeason = "осень";
            return resultSeason;
        }
        enum season
        {
            Winter,
            Spring,
            Summer,
            Autumn
        }

        //Написать программу, вычисляющую число Фибоначчи для заданного значения
        //рекурсивным способом.

        static decimal MethodFibonachy(int n, decimal F0, decimal F1)
        {

            decimal F2 = F0 + F1;
            decimal f0 = F1;
            decimal f1 = F2;
            if (n==1)
            {
                return f0;
            }

            return  MethodFibonachy(n-1,f0,f1);
        }

        static string FibonachySequence(int n, decimal F0, decimal F1, string result)
        {
            decimal F2 = F0 + F1;
            decimal f0 = F1;
            decimal f1 = F2;
            if (n==1)
                result += $"{f0}";
            else 
                result += $"{f0}, ";
            if (n == 1)
            {
                return result;
            }

            return FibonachySequence(n - 1, f0, f1, result);
        }

        static void Main(string[] args)
        {
            #region Первое задание.
            string _firstName = "Иван";
            string _lastName = "Ивановов";
            string _patronymic = "Иванович";
            GetFullName(_firstName, _lastName, _patronymic);

            _firstName = "Василий";
            _lastName = "Васильев";
            _patronymic = "Васильевич";
            GetFullName(_firstName, _lastName, _patronymic);

            _firstName = "Мария";
            _lastName = "Машина";
            _patronymic = "Мариевна";
            GetFullName(_firstName, _lastName, _patronymic);

            _firstName = "Федот";
            _lastName = "Федотов";
            _patronymic = "Мариин";
            GetFullName(_firstName, _lastName, _patronymic);
            Console.WriteLine();
            #endregion

            #region Второе задание.
            Console.Write("Введите через пробел любые числа и нажмите Entet: ");
            string inputData = Console.ReadLine();
            Console.WriteLine($"Сумма введенных чисел равна {AdditionOfNumbers(inputData)}");
            Console.WriteLine();
            #endregion

            #region Третье задание.
            int numberOfSeason;
            do
            {
                Console.Write("Введите число времени года от 1 до 12: ");
                numberOfSeason = int.Parse(Console.ReadLine());
                if (numberOfSeason < 1 || numberOfSeason > 12)
                {
                    Console.WriteLine($"Ошибка:введите число от 1 до 12. Вы ввели {numberOfSeason}");
                }
            }
            while (numberOfSeason < 1 || numberOfSeason > 12);
            Console.WriteLine($"Текущее время года - {SeasonStepTwo(SeasonStepOne(numberOfSeason))}");
            Console.WriteLine();
            #endregion

            #region Четвертое задание.
            int n;
            do
            {
                Console.Write("Введите n (максимальное 138): ");
                n = int.Parse(Console.ReadLine());
                if (n < 1 || n > 138)
                {
                    Console.WriteLine("Введите n меньше 139");
                }
            } while (n<1||n>138);
            int F0 = 0;
            int F1 = 1;
            Console.WriteLine($"Число Финобаччи при n равном {n} - { MethodFibonachy(n, F0, F1)}");
            string result = "0, ";
            Console.WriteLine($"А последовательность имеед вид - {FibonachySequence(n, F0, F1, result)}");
            #endregion
        }
    }
}
