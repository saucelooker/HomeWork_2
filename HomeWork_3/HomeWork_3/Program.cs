using System;

namespace HomeWork_3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1.Написать программу, выводящую элементы двумерного массива по диагонали.

            int[,] mass = new int[10,10 ];

            for (int i = 0; i < mass.GetLength(0); i++)
            {

                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        mass[i, j] = 1;
                    }
                    if ((mass.GetLength(1) - 1 - i) >= 0)
                    {
                        mass[i, mass.GetLength(1) - 1 - i] = 1;
                    }

                    Console.Write($"{mass[i, j]}".PadRight(2));
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            #endregion

            #region 2. Написать программу «Телефонный справочник»
            //создать двумерный массив 5х2, хранящий список
            //телефонных контактов: первый элемент хранит
            //имя контакта, второй — номер телефона/email.

            string[,] phonebook = new string[5, 2];
            phonebook[0, 0] = "Sergey ";
            phonebook[1, 0] = "Maks ";
            phonebook[2, 0] = "Mary ";
            phonebook[4, 0] = "Henry ";

            phonebook[0, 1] = "272-554";
            phonebook[1, 1] = "543-850";
            phonebook[2, 1] = "732-121";
            phonebook[3, 1] = "799-548";

            for (int i = 0; i < phonebook.GetLength(0); i++)
            {
                for (int j = 0; j < phonebook.GetLength(1); j++)
                {
                    if (phonebook[i, 0] == null)
                    {
                        Console.Write(phonebook[i, 0] = "Noname ");
                        continue;
                    }
                    if (phonebook[i, j] == null)
                    {
                        Console.Write(phonebook[i, 1] = "No phone number");
                        continue;
                    }

                    Console.Write(phonebook[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            #endregion

            #region 3. Написать программу, выводящую введённую пользователем строку в обратном порядке.
            Console.WriteLine("Enter a word");
            string userWord = Console.ReadLine();
            char[] _userWord = new char[userWord.Length];
            for (int i = userWord.Length-1, j = 0; i >=0 && j < userWord.Length; i--,j++)
            {
                _userWord[j] = userWord[i];
            }
            Console.WriteLine(_userWord);
            Console.WriteLine();

            #endregion

            #region 4. «Морской бой»
            //Вывести на экран массив 10х10, состоящий из символов X и O,
            //где Х — элементы кораблей, а О — свободные клетки.

            string[,] seaBattle = new string[10,11];
            seaBattle[2, 3] = "X";
            seaBattle[2, 4] = "X";
            seaBattle[2, 5] = "X";
            seaBattle[2, 6] = "X";

            seaBattle[1, 9] = "X";
            seaBattle[2, 9] = "X";
            seaBattle[3, 9] = "X";

            seaBattle[5, 5] = "X";
            seaBattle[5, 6] = "X";
            seaBattle[5, 7] = "X";

            seaBattle[8, 1] = "X";
            seaBattle[9, 1] = "X";

            seaBattle[9, 9] = "X";
            seaBattle[9, 10] = "X";

            seaBattle[6, 3] = "X";
            seaBattle[7, 3] = "X";

            seaBattle[0, 1] = "X";
            seaBattle[7, 9] = "X";
            seaBattle[0, 6] = "X";
            seaBattle[8, 6] = "X";

            Console.Write("".PadLeft(2));

            for (char i = 'A'; i < 'K'; i++)
            {
                Console.Write($"{i}".PadLeft(2));
            }
            Console.WriteLine();

            for (int i = 0; i < seaBattle.GetLength(0); i++)
            {
                seaBattle[i, 0] = (i+1).ToString();

                for (int j = 0; j < seaBattle.GetLength(1); j++)
                {
                    if (seaBattle[i, j] == null)
                    {
                        seaBattle[i, j] = "-";
                    }
                    Console.Write(seaBattle[i, j].PadLeft(2));
                }
                Console.WriteLine();
            }
            #endregion
        }
    }
}
