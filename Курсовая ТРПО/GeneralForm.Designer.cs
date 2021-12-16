
namespace Курсовая_ТРПО
{
    partial class GeneralForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Table = new System.Windows.Forms.DataGridView();
            this.Add_button = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.Sort_button = new System.Windows.Forms.Button();
            this.Edit_button = new System.Windows.Forms.Button();
            this.EditPrice_button = new System.Windows.Forms.Button();
            this.DeleteMin = new System.Windows.Forms.Button();
            this.Refresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Find_Box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Result_label = new System.Windows.Forms.Label();
            this.Min_Label = new System.Windows.Forms.Label();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Batch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            this.SuspendLayout();
            // 
            // Table
            // 
            this.Table.BackgroundColor = System.Drawing.Color.MintCream;
            this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code,
            this._Name,
            this.Country,
            this.Batch,
            this.Price});
            this.Table.Location = new System.Drawing.Point(12, 12);
            this.Table.Name = "Table";
            this.Table.RowHeadersWidth = 51;
            this.Table.RowTemplate.Height = 29;
            this.Table.Size = new System.Drawing.Size(681, 416);
            this.Table.TabIndex = 0;
            // 
            // Add_button
            // 
            this.Add_button.BackColor = System.Drawing.Color.MintCream;
            this.Add_button.Location = new System.Drawing.Point(699, 12);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(220, 35);
            this.Add_button.TabIndex = 4;
            this.Add_button.Text = "Добавить товар";
            this.Add_button.UseVisualStyleBackColor = false;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // Delete_button
            // 
            this.Delete_button.BackColor = System.Drawing.Color.MintCream;
            this.Delete_button.Location = new System.Drawing.Point(699, 53);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(220, 35);
            this.Delete_button.TabIndex = 5;
            this.Delete_button.Text = "Удалить товар";
            this.Delete_button.UseVisualStyleBackColor = false;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // Sort_button
            // 
            this.Sort_button.BackColor = System.Drawing.Color.MintCream;
            this.Sort_button.Location = new System.Drawing.Point(700, 135);
            this.Sort_button.Name = "Sort_button";
            this.Sort_button.Size = new System.Drawing.Size(220, 35);
            this.Sort_button.TabIndex = 6;
            this.Sort_button.Text = "Поиск по стране";
            this.Sort_button.UseVisualStyleBackColor = false;
            this.Sort_button.Click += new System.EventHandler(this.Sort_button_Click);
            // 
            // Edit_button
            // 
            this.Edit_button.BackColor = System.Drawing.Color.MintCream;
            this.Edit_button.Location = new System.Drawing.Point(699, 94);
            this.Edit_button.Name = "Edit_button";
            this.Edit_button.Size = new System.Drawing.Size(220, 35);
            this.Edit_button.TabIndex = 7;
            this.Edit_button.Text = "Редактировать товар";
            this.Edit_button.UseVisualStyleBackColor = false;
            this.Edit_button.Click += new System.EventHandler(this.Edit_button_Click);
            // 
            // EditPrice_button
            // 
            this.EditPrice_button.BackColor = System.Drawing.Color.MintCream;
            this.EditPrice_button.Location = new System.Drawing.Point(699, 176);
            this.EditPrice_button.Name = "EditPrice_button";
            this.EditPrice_button.Size = new System.Drawing.Size(220, 35);
            this.EditPrice_button.TabIndex = 8;
            this.EditPrice_button.Text = "Увеличить стоимость товара";
            this.EditPrice_button.UseVisualStyleBackColor = false;
            this.EditPrice_button.Click += new System.EventHandler(this.EditPrice_button_Click);
            // 
            // DeleteMin
            // 
            this.DeleteMin.BackColor = System.Drawing.Color.MintCream;
            this.DeleteMin.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeleteMin.Location = new System.Drawing.Point(699, 393);
            this.DeleteMin.Name = "DeleteMin";
            this.DeleteMin.Size = new System.Drawing.Size(220, 35);
            this.DeleteMin.TabIndex = 9;
            this.DeleteMin.Text = "Удалить товар мин. стоимости";
            this.DeleteMin.UseVisualStyleBackColor = false;
            this.DeleteMin.Click += new System.EventHandler(this.DeleteMin_Click);
            // 
            // Refresh
            // 
            this.Refresh.BackColor = System.Drawing.Color.MintCream;
            this.Refresh.Location = new System.Drawing.Point(699, 352);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(220, 35);
            this.Refresh.TabIndex = 10;
            this.Refresh.Text = "Обновить данные";
            this.Refresh.UseVisualStyleBackColor = false;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(700, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Код:";
            // 
            // Find_Box
            // 
            this.Find_Box.Location = new System.Drawing.Point(749, 217);
            this.Find_Box.Name = "Find_Box";
            this.Find_Box.Size = new System.Drawing.Size(170, 27);
            this.Find_Box.TabIndex = 12;
            this.Find_Box.TextChanged += new System.EventHandler(this.Change);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(699, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 40);
            this.label2.TabIndex = 13;
            this.label2.Text = "Суммарная стоимость товаров\r\nпо задонному коду:";
            // 
            // Result_label
            // 
            this.Result_label.AutoSize = true;
            this.Result_label.Location = new System.Drawing.Point(842, 267);
            this.Result_label.Name = "Result_label";
            this.Result_label.Size = new System.Drawing.Size(0, 20);
            this.Result_label.TabIndex = 14;
            // 
            // Min_Label
            // 
            this.Min_Label.AutoSize = true;
            this.Min_Label.Location = new System.Drawing.Point(700, 299);
            this.Min_Label.Name = "Min_Label";
            this.Min_Label.Size = new System.Drawing.Size(209, 40);
            this.Min_Label.TabIndex = 15;
            this.Min_Label.Text = "Минимальная сумма товара\r\nравна:";
            // 
            // Code
            // 
            this.Code.HeaderText = "Код товара";
            this.Code.MinimumWidth = 6;
            this.Code.Name = "Code";
            this.Code.Width = 125;
            // 
            // _Name
            // 
            this._Name.HeaderText = "Название";
            this._Name.MinimumWidth = 6;
            this._Name.Name = "_Name";
            this._Name.Width = 125;
            // 
            // Country
            // 
            this.Country.HeaderText = "Страна импортёр";
            this.Country.MinimumWidth = 6;
            this.Country.Name = "Country";
            this.Country.Width = 125;
            // 
            // Batch
            // 
            this.Batch.HeaderText = "Размер партии";
            this.Batch.MinimumWidth = 6;
            this.Batch.Name = "Batch";
            this.Batch.Width = 125;
            // 
            // Price
            // 
            this.Price.HeaderText = "Стоимость за штуку в у.е.";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 125;
            // 
            // GeneralForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(926, 437);
            this.Controls.Add(this.Min_Label);
            this.Controls.Add(this.Result_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Find_Box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.DeleteMin);
            this.Controls.Add(this.EditPrice_button);
            this.Controls.Add(this.Edit_button);
            this.Controls.Add(this.Sort_button);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.Table);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "GeneralForm";
            this.Text = "Органайзер";
            this.Activated += new System.EventHandler(this.GeneralForm_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Button Sort_button;
        private System.Windows.Forms.Button Edit_button;
        private System.Windows.Forms.Button EditPrice_button;
        private System.Windows.Forms.Button DeleteMin;
        public System.Windows.Forms.DataGridView Table;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Find_Box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Result_label;
        private System.Windows.Forms.Label Min_Label;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn _Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Country;
        private System.Windows.Forms.DataGridViewTextBoxColumn Batch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}

