using System;

namespace ArrayException
{
    
    class Program
    {
        static void ValidationArray(string [,] inputArray)
        {

            if (inputArray.GetLength(0) !=4 || inputArray.GetLength(1)!=4)
            {
                throw new MyArraySizeException();
            }
            
            int sum = 0;
            for (int i = 0; i < inputArray.GetLength(0); i++)
            {
                for (int j = 0; j < inputArray.GetLength(1); j++)
                {
                    try
                    {
                        sum += int.Parse(inputArray[i, j]);

                    }
                    catch (Exception ex)
                    {
                        throw new MyArrayDataException(i,j);
                    }
                }
                
            }
            Console.WriteLine($"Сумма всех элементов массива равна {sum}");
        }
        static void Main(string[] args)
        {
            int row = 4, column = 5;
            string[,] mass = new string[column, row];
            Random random = new Random();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    mass[i, j] = random.Next(-1, 100).ToString();
                }
            }

            mass[1, 3] = "hello";
            
            try
            {
                ValidationArray(mass);

            }
            catch (MyArrayDataException ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            catch (MyArraySizeException ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
