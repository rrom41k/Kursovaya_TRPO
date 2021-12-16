using System;
using System.Collections.Generic;
using System.Text;

namespace Курсовая_ТРПО
{
    public class Product
    {
        public int code_product; // шифр товара
        public string name; // наименование товара
        public string country_importer; // страна, импортируемая товар
        public int batch_size; // размер партии, поставляемая в штуках
        public double price; // стоимость 1 штуки в у.е.

        public Product(int code_product, string name, string country_importer, int batch_size, double price)
        {
            this.code_product = code_product;
            this.name = name;
            this.country_importer = country_importer;
            this.batch_size = batch_size;
            this.price = price;
        }
    }
}
