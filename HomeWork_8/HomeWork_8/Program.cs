using System;

namespace HomeWork_8
{
    class Program
    {
        static void PlacingNumbersInASpiral(int size)
        {
            int[,] arrayNumbers = new int[size,size];

            int numberOfPasses = size/2;
            if (size % 2 != 0)
            {
                numberOfPasses += 1;
            }

            for (int i = 0,k = 1; i < numberOfPasses; i++)
            {
                for (int j = i; j < size-i; j++)
                    arrayNumbers[i, j] = k++;
                
                for (int j = i+1; j < arrayNumbers.GetLength(0) - i; j++)
                    arrayNumbers[j, arrayNumbers.GetLength(1)-1 - i] = k++;

                for (int j = arrayNumbers.GetLength(1)-2-i; j >=i; j--)
                    arrayNumbers[arrayNumbers.GetLength(0) - 1 - i, j] = k++;

                for (int j = arrayNumbers.GetLength(0)-2 -i; j >=1+ i; j--)
                    arrayNumbers[j, i] = k++;
            }

            for (int i = 0; i < arrayNumbers.GetLength(0); i++)
            {
                for (int j = 0; j < arrayNumbers.GetLength(1); j++)
                {
                    Console.Write($"{arrayNumbers[i,j]}".PadRight(3));
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            
            PlacingNumbersInASpiral(5);
            //1  2  3  4  5
            //16 17 18 19 6
            //15 24 25 20 7
            //14 23 22 21 8
            //13 12 11 10 9
        }
    }
}
