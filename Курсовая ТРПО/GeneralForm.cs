using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовая_ТРПО
{
    public partial class GeneralForm : Form
    {
        public static List<Product> table_of_products = new List<Product>();
        

        public GeneralForm()
        {
            InitializeComponent();
            ShowList(table_of_products);
            Product product = new Product(1, "Вино", "Франция", 100, 1000);
            table_of_products.Add(product);
            product = new Product(2, "Сыр", "Испания", 500, 250);
            table_of_products.Add(product);
            product = new Product(3, "Перец", "Болгария", 10000, 25);
            table_of_products.Add(product);


        }
        
        
        private void Add_button_Click(object sender, EventArgs e)
        {
            Shablon_Add shablon_Add = new Shablon_Add();
            shablon_Add.Show();
        }
        public void ShowList(List<Product> table)
        {
            Table.Rows.Clear();
            foreach (Product item in table)
                Table.Rows.Add(item.code_product, item.name, item.country_importer, item.batch_size, item.price);
            
        }

        public void Refresh_Click(object sender, EventArgs e)
        {
            ShowList(table_of_products);
        }

        private void GeneralForm_Activated(object sender, EventArgs e)
        {
            ShowList(table_of_products);
            double min = double.MaxValue;
            foreach (Product item in table_of_products)
                if (item.price < min)
                    min = item.price;

            if (min != double.MaxValue)
                Min_Label.Text = $"Минимальная сумма товара\nравна: {min}";
            else
                Min_Label.Text = "Минимальная сумма товара\nравна:";
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            Shablon_Delete shablon_Delete = new Shablon_Delete();
            shablon_Delete.Show();
        }

        private void Sort_button_Click(object sender, EventArgs e)
        {
            Sort_Form sort_Form = new Sort_Form(table_of_products);
            sort_Form.Show();
        }

        private void DeleteMin_Click(object sender, EventArgs e)
        {
            Product product = new Product(0, "", "", 0, 0);
            double min = double.MaxValue;
            try
            {
                foreach (Product item in table_of_products)
                    if (item.price < min)
                    {
                        product = item;
                        min = item.price;
                    }

                table_of_products.Remove(product);
                ShowList(table_of_products);
            }
            catch
            {
                MessageBox.Show("В таблице больше не осталось товаров.\nВ противном случае обратитесь к администратору.");
            }
        }

        private void Edit_button_Click(object sender, EventArgs e)
        {
            Edit_Form edit_Form = new Edit_Form();
            edit_Form.Show();
        }

        private void EditPrice_button_Click(object sender, EventArgs e)
        {
            Inscrease inscrease = new Inscrease();
            inscrease.Show();
        }

        private void Change(object sender, EventArgs e)
        {
            double sum = 0;
            if (Find_Box.Text != "")
            {
                foreach (Product item in table_of_products)
                {
                    if (item.code_product == Int32.Parse(Find_Box.Text))
                    {
                        sum += item.price * item.batch_size;
                    }
                    Result_label.Text = $"{sum}";
                }
            }
            else
                Result_label.Text = "0";
        }

        
    }
}
