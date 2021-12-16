using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Курсовая_ТРПО
{
    public partial class Inscrease : Form
    {
        int index = 0;
        public Inscrease()
        {
            InitializeComponent();
        }

        private void Sort_Button_Click(object sender, EventArgs e)
        {
            bool isNum = true;
            int num;
            if (Price_Label.Text != "")
                    if (Price_Box.Text != "" && isNum == int.TryParse(Price_Box.Text, out num))
                    {
                        double X = Int32.Parse(Price_Label.Text) / 100 * Int32.Parse(Price_Box.Text);
                        GeneralForm.table_of_products[index-1].price = GeneralForm.table_of_products[index - 1].price + X;
                    this.Close();
                    }
                    else
                        MessageBox.Show("Вы не задали на сколько процентов надо увеличить стоимость или ввели не в правильном формате");
            else
                MessageBox.Show("Товар не выбран");
        }

        private void Changes(object sender, EventArgs e)
        {
            bool isNum = true;
            int num;
            if (Code_Box.Text != "")
                if (isNum == int.TryParse(Code_Box.Text, out num))
                {
                    foreach (Product item in GeneralForm.table_of_products)
                        if (item.code_product == Int16.Parse(Code_Box.Text))
                        {
                            Price_Label.Text = $"{item.price}";
                            index = item.code_product;
                        }
                }
                else
                    MessageBox.Show("Вы вводите не в верном формате, код может содержать только целые числа");
        }
    }
}
