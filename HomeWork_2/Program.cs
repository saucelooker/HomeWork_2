using System;


namespace MidTemp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите минимальную суточную температуру: ");
            sbyte minTemp = sbyte.Parse(Console.ReadLine());
            Console.Write("Введите максимальную суточную температуру: ");
            sbyte maxTemp = sbyte.Parse(Console.ReadLine());
            Console.Write("Введите номер месяца от 1 до 12: ");
            sbyte numberMonth = sbyte.Parse(Console.ReadLine());
            double midTemp = (double)(minTemp + maxTemp)/ 2;
            if (midTemp > 0 && (numberMonth == 1 || numberMonth == 2 || numberMonth == 12))
                Console.WriteLine($"Среднесуточная температура равна: {midTemp}, а за окном дождливая зима.");
            else
                Console.WriteLine($"Среднесуточная температура равна: {midTemp}, а за окном {(MonthList.monthList)numberMonth}");

            if (numberMonth%2==0)
                Console.WriteLine("Кстати, число выбранного тобой месяца - четное.");
            else
                Console.WriteLine("Кстати, число выбранного тобой месяца - нечетное.");
        }
    }
}
