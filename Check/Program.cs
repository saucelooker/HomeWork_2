using System;

namespace HomeWork_2
{
    class Program
    {

        static void Main(string[] args)
        {
            var product = new Product();
            string nameCashier = "Петя";
            double sum = 0;
            var sb = new System.Text.StringBuilder();
            Console.WriteLine("ООО \"СуперЧек.ru\"".PadRight(27).PadLeft(37));
            Console.WriteLine("Чек N 4201".PadRight(24).PadLeft(37));
            Console.WriteLine($"Кассир: {nameCashier}".PadRight(26).PadLeft(37));
            for (int i = 0, j = 1; i < product.price.Count; i++, j++)
            {
                Console.WriteLine($"{j}.{product.nameProduct[i]}");
                int countNumbers = 22 - product.price[i].ToString().Length; //Вычисление количесва пробелов взависимости от количества знаков в стоимости
                Console.WriteLine($"  Стоимость{"".PadRight(countNumbers, '.')}{product.price[i]} руб");
                Console.WriteLine();
                sum += product.price[i];
            }
            Console.WriteLine("".PadRight(37, '='));
            Console.WriteLine(sb);
            Console.WriteLine($"Всего{"".PadRight(22, '.')}{sum} руб");
            Console.WriteLine($"ККМ 00000000 ИНН 000000000000{"",-3}N4201");
            Console.WriteLine($"{DateTime.Now}{"",-14}{ nameCashier}");
            Console.WriteLine($"ПРОДАЖА{"",-25}N2890");
            Console.WriteLine($"1{"",-30}{sum}");
            Console.WriteLine($"ИТОГО{"",-22}{sum} руб");
            Console.WriteLine();
            Console.WriteLine("ФП".PadRight(20, '|').PadLeft(37, '|'));
            Console.WriteLine("ЭКЛЗ 0000000000".PadLeft(36));
            Console.WriteLine("00043327 #084432".PadLeft(37));
        }
    }
}

