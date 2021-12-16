using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using ��������_����; 

namespace TestProject2
{
    [TestClass]
    public class Shablon_Add_Test
    {
        [TestMethod]
        public void Add_Product_To_The_Table()
        {
            // �������� ������
            List<Product> products = new List<Product>();
            Product product = new Product(1, "����", "�������", 100, 1000);
            products.Add(product);
            product = new Product(3, "���", "�������", 500, 250);
            products.Add(product);
            product = new Product(4, "�����", "��������", 10000, 25);
            products.Add(product);
            Product expected = new Product(2, "Beer", "Germany", 200, 10);
            int index = 0;

            // �������� ��������� ���������� ����� � ������ ���������

            foreach (Product item in products)
            {
                if (item.code_product - index < 2)
                    index = item.code_product;
            }
            index++;

            Product result = new Product(index, "Beer", "Germany", 200, 10);
            GeneralForm.table_of_products.Add(product);

            // �������� ���������� ������ � ������������
            Assert.AreEqual(expected.code_product, result.code_product);

        }
    }
}
