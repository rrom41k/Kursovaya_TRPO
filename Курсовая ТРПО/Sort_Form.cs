using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Курсовая_ТРПО
{
    public partial class Sort_Form : Form
    {
        List<Product> SortList = new List<Product>();
        public Sort_Form(List<Product> products)
        {
            InitializeComponent();
            this.SortList = products;
        }

        private void Sort_Button_Click(object sender, EventArgs e)
        {
            if (Sort_Box1.Text != "")
            {
                foreach (Product item in SortList)
                {
                    if (item.country_importer == Sort_Box1.Text)
                    {
                        dataGridView1.Rows.Add(item.name, item.price * item.batch_size);
                    }
                }
            }
            else
                MessageBox.Show("Вы не ввели страну");
        }
    }
}
