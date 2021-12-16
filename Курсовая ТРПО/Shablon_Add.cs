using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Курсовая_ТРПО
{
    public partial class Shablon_Add : Form
    {
       
        public Shablon_Add()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = 0;
            int num;
            double Num;
            bool isNum = true;
            if ((isNum == int.TryParse(Batch_Box.Text, out num)) && (isNum == double.TryParse(Price_Box.Text, out Num)))
            {
                foreach (Product item in GeneralForm.table_of_products)
                {
                    if (item.code_product - index < 2)
                        index = item.code_product;
                }
                index++;

                Product product = new Product(index, Name_Box.Text, Country_Box.Text, Convert.ToInt32(Batch_Box.Text), Convert.ToDouble(Price_Box.Text));
                GeneralForm.table_of_products.Add(product);

                this.Close();
            }
            else
                MessageBox.Show("В поле 'Размер партии' должны быть только целые числа, а в поле 'стоимость' только числа");
            
            
        }
    }
}
