using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Курсовая_ТРПО
{
    public partial class Edit_Form : Form
    {
        public Edit_Form()
        {
            InitializeComponent();
        }

        private void Sort_Button_Click(object sender, EventArgs e)
        {
            int index = 0;
            bool isNum = true;
            double num;
            if (Code_Box.Text != "")
            {
                foreach (Product item in GeneralForm.table_of_products)
                    if (item.code_product == Int16.Parse(Code_Box.Text))
                        index = item.code_product;

                if (Name_Box.Text != "")
                {
                    GeneralForm.table_of_products[index - 1].name = Name_Box.Text; 
                }

                if (Country_Box.Text != "")
                {
                    GeneralForm.table_of_products[index - 1].country_importer = Country_Box.Text; 
                }

                if (Batch_Box.Text != "")
                {
                    if (isNum == int.TryParse(Batch_Box.Text, out index))
                    {
                        GeneralForm.table_of_products[index - 1].batch_size = Int16.Parse(Batch_Box.Text); 
                    }
                    else
                        MessageBox.Show("В поле должны быть только целые числа");
                }
                

                if (Price_Box.Text != "")
                {
                    if (isNum == double.TryParse(Price_Box.Text, out num))
                    {
                        GeneralForm.table_of_products[index - 1].price = Double.Parse(Price_Box.Text); 
                    }
                    else
                        MessageBox.Show("В поле должы быть только числа");
                }
                
                this.Close();

            }
            else
                MessageBox.Show("Вы не ввели код товара");
        }
    }
}
