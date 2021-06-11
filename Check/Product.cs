using System.Collections.Generic;

namespace HomeWork_2
{

    public class Product
    {
        public List<string> nameProduct = new List<string>();
        public List<int> price = new List<int>();

        public Product()
        {
            nameProduct.Add("Кирпич пустотелый одинарный М-150");
            nameProduct.Add("Цемент ПЦ-400 Д 20 (мешках)");
            nameProduct.Add("Щебень фракция 20х40 т.");
            nameProduct.Add("Гвозди жидкие/ 310 мл");
            nameProduct.Add("Еще какая-то ненужная ерунда ");

            price.Add(8176);
            price.Add(5400);
            price.Add(2400);
            price.Add(652);
            price.Add(153022);
        }

    }
}

