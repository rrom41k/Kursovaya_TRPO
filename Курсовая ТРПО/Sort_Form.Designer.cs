
namespace Курсовая_ТРПО
{
    partial class Sort_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Sort_Button = new System.Windows.Forms.Button();
            this.Sort_Box1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Name_Sort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price_Sort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Для поиска необходимых товаров введите\r\nназвание страны";
            // 
            // Sort_Button
            // 
            this.Sort_Button.BackColor = System.Drawing.Color.MintCream;
            this.Sort_Button.Location = new System.Drawing.Point(377, 45);
            this.Sort_Button.Name = "Sort_Button";
            this.Sort_Button.Size = new System.Drawing.Size(158, 34);
            this.Sort_Button.TabIndex = 3;
            this.Sort_Button.Text = "Найти";
            this.Sort_Button.UseVisualStyleBackColor = false;
            this.Sort_Button.Click += new System.EventHandler(this.Sort_Button_Click);
            // 
            // Sort_Box1
            // 
            this.Sort_Box1.Location = new System.Drawing.Point(377, 12);
            this.Sort_Box1.Name = "Sort_Box1";
            this.Sort_Box1.Size = new System.Drawing.Size(158, 27);
            this.Sort_Box1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name_Sort,
            this.Price_Sort});
            this.dataGridView1.Location = new System.Drawing.Point(12, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(523, 248);
            this.dataGridView1.TabIndex = 5;
            // 
            // Name_Sort
            // 
            this.Name_Sort.HeaderText = "Наименование";
            this.Name_Sort.MinimumWidth = 6;
            this.Name_Sort.Name = "Name_Sort";
            this.Name_Sort.ReadOnly = true;
            this.Name_Sort.Width = 240;
            // 
            // Price_Sort
            // 
            this.Price_Sort.HeaderText = "Суммарная стоимость партии";
            this.Price_Sort.MinimumWidth = 6;
            this.Price_Sort.Name = "Price_Sort";
            this.Price_Sort.ReadOnly = true;
            this.Price_Sort.Width = 240;
            // 
            // Sort_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(551, 345);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Sort_Box1);
            this.Controls.Add(this.Sort_Button);
            this.Controls.Add(this.label1);
            this.Name = "Sort_Form";
            this.Text = "Sort_Form";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Sort_Button;
        private System.Windows.Forms.TextBox Sort_Box1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_Sort;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price_Sort;
    }
}