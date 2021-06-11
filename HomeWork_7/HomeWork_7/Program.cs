using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Lesson_7
{
    class Cross
    {
        static int SIZE_X = 5;
        static int SIZE_Y = 5;

        static char[,] field = new char[SIZE_Y, SIZE_X];

        static char PLAYER_DOT = 'X';
        static char AI_DOT = 'O';
        static char EMPTY_DOT = '.';

        static int flagMove = 0;
        static int numberOfCellsToWin = 5;

        static Random random = new Random();

        private static void InitField()
        {
            for (int i = 0; i < SIZE_Y; i++)
            {
                for (int j = 0; j < SIZE_X; j++)
                {
                    field[i, j] = EMPTY_DOT;
                }
            }
        }

        private static void PrintField()
        {
            Console.Clear();
            Console.WriteLine("-----------");
            for (int i = 0; i < SIZE_Y; i++)
            {
                Console.Write("|");
                for (int j = 0; j < SIZE_X; j++)
                {
                    Console.Write(field[i, j] + "|");
                }
                Console.WriteLine();
            }
            Console.WriteLine("-----------");
        }
        private static void SetSym(int y, int x, char sym)
        {
            field[y, x] = sym;
        }

        private static bool IsCellValid(int y, int x)
        {
            if (x < 0 || y < 0 || x > SIZE_X - 1 || y > SIZE_Y - 1)
            {
                return false;
            }

            return field[y, x] == EMPTY_DOT;
        }

        private static void playerMove()
        {
            int x, y;
            flagMove++;
            do
            {
                Console.WriteLine("Координат по строке ");
                Console.WriteLine("Введите координаты вашего хода в диапозоне от 1 до " + SIZE_Y);
                x = int.Parse(Console.ReadLine()) - 1;
                Console.WriteLine("Координат по столбцу ");
                Console.WriteLine("Введите координаты вашего хода в диапозоне от 1 до " + SIZE_X);
                y = int.Parse(Console.ReadLine()) - 1;
            } while (!IsCellValid(y, x));
            SetSym(y, x, PLAYER_DOT);
        }

        private static void AiMove()
        {
            int x, y;
            do
            {
                x = random.Next(0, SIZE_X);
                y = random.Next(0, SIZE_Y);
            } while (!IsCellValid(y, x));
            SetSym(y, x, AI_DOT);
        }

        private static bool IsFieldFull()
        {
            for (int i = 0; i < SIZE_Y; i++)
            {
                for (int j = 0; j < SIZE_X; j++)
                {
                    if (field[i, j] == EMPTY_DOT)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private static bool CheckWin(char sym)
        {
            List<string> winList = new List<string>();
            string winCombination = "";
            string factWinCombination = "";
            for (int i = 0; i < numberOfCellsToWin-1; i++)
            {
                winCombination += sym;
            }

            if (flagMove == numberOfCellsToWin)
            {
                for (int i = 0; i < field.GetLength(0); i++)
                {
                    for (int j = 0; j < field.GetLength(1); j++)
                    {
                        factWinCombination += field[i, j];
                    }
                    winList.Add(factWinCombination);
                    factWinCombination = "";
                }

                for (int i = 0; i < field.GetLength(1); i++)
                {
                    for (int j = 0; j < field.GetLength(0); j++)
                    {
                        factWinCombination += field[j, i];
                    }
                    winList.Add(factWinCombination);
                    factWinCombination = "";
                }

                for (int k = 0; k < field.GetLength(0); k++)
                {
                    for (int i = k; i < field.GetLength(0); i++)
                    {
                        for (int j = 0; j < field.GetLength(1); j++)
                        {
                            if (i == j+k)
                            {
                                factWinCombination += field[i, j];
                                break;
                            }
                        }
                    }
                    if (factWinCombination.Length >= numberOfCellsToWin)
                    {
                        winList.Add(factWinCombination);
                        factWinCombination = "";
                    }
                    else factWinCombination = "";
                }

                for (int k = 1; k < field.GetLength(0); k++)
                {
                    for (int i = 0; i < field.GetLength(0); i++)
                    {
                        for (int j = k; j < field.GetLength(1); j++)
                        {
                            if (i+k == j)
                            {
                                factWinCombination += field[i, j];
                               break;
                            }
                        }
                    }
                    if (factWinCombination.Length >= numberOfCellsToWin)
                    {
                        winList.Add(factWinCombination);
                        factWinCombination = "";
                    }
                    else factWinCombination = "";
                }

                for (int k = 0; k < field.GetLength(0); k++)
                {
                    for (int i = field.GetLength(0)-1; i >= 0; i--)
                    {
                        for (int j = 0; j < field.GetLength(1); j++)
                        {
                            if (i == field.GetLength(0) - 1 - j - k)
                            {
                                factWinCombination += field[i, j];
                                break;
                            }
                        }
                    }
                    if (factWinCombination.Length >= numberOfCellsToWin)
                    {
                        winList.Add(factWinCombination);
                        factWinCombination = "";
                    }
                    else factWinCombination = "";
                }

                for (int k = 0; k < field.GetLength(1); k++)
                {
                    for (int i = 1; i < field.GetLength(1); i++)
                    {
                        for (int j = field.GetLength(0)-1; j >=0; j--)
                        {
                            if (i == field.GetLength(1) - j + k)
                            {
                                factWinCombination += field[i, j];
                                break;
                            }
                        }
                    }
                    if (factWinCombination.Length >= numberOfCellsToWin)
                    {
                        winList.Add(factWinCombination);
                        factWinCombination = "";
                    }
                    else factWinCombination = "";
                }

                foreach (var item in winList)
                {
                    if (item.Contains(winCombination))
                    {
                        return true;
                    }
                }
                
            }
            return false;
        }

        static void Main(string[] args)
        {
            InitField();
            PrintField();
            do
            {
                playerMove();
                Console.WriteLine("Ваш ход на поле");
                PrintField();
                if (CheckWin(PLAYER_DOT))
                {
                    Console.WriteLine("Вы выиграли");
                    break;
                }
                else if (IsFieldFull()) break;
                AiMove();
                Console.WriteLine("Ход Компа на поле");
                PrintField();
                if (CheckWin(AI_DOT))
                {
                    Console.WriteLine("Выиграли Комп");
                    break;
                }
                else if (IsFieldFull()) break;
            } while (true);
            Console.WriteLine("!Конец игры!");
        }

    }
}
