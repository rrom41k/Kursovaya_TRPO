
namespace Курсовая_ТРПО
{
    partial class Edit_Form
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
            this.label2 = new System.Windows.Forms.Label();
            this.Code_Box = new System.Windows.Forms.TextBox();
            this.Name_Box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Country_Box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Batch_Box = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Price_Box = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Sort_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(541, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите код товара который хотите отредактировать, и заполните \r\nполя, которые ну" +
    "жно изменить:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(13, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Код товара";
            // 
            // Code_Box
            // 
            this.Code_Box.Location = new System.Drawing.Point(216, 67);
            this.Code_Box.Name = "Code_Box";
            this.Code_Box.Size = new System.Drawing.Size(326, 27);
            this.Code_Box.TabIndex = 2;
            // 
            // Name_Box
            // 
            this.Name_Box.Location = new System.Drawing.Point(216, 101);
            this.Name_Box.Name = "Name_Box";
            this.Name_Box.Size = new System.Drawing.Size(326, 27);
            this.Name_Box.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(13, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Название";
            // 
            // Country_Box
            // 
            this.Country_Box.Location = new System.Drawing.Point(216, 134);
            this.Country_Box.Name = "Country_Box";
            this.Country_Box.Size = new System.Drawing.Size(326, 27);
            this.Country_Box.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(13, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Страна импортёр";
            // 
            // Batch_Box
            // 
            this.Batch_Box.Location = new System.Drawing.Point(216, 167);
            this.Batch_Box.Name = "Batch_Box";
            this.Batch_Box.Size = new System.Drawing.Size(326, 27);
            this.Batch_Box.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(13, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Расмер партии";
            // 
            // Price_Box
            // 
            this.Price_Box.Location = new System.Drawing.Point(216, 199);
            this.Price_Box.Name = "Price_Box";
            this.Price_Box.Size = new System.Drawing.Size(326, 27);
            this.Price_Box.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(13, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 23);
            this.label6.TabIndex = 9;
            this.label6.Text = "Стоимость за шт.  в у.е.";
            // 
            // Sort_Button
            // 
            this.Sort_Button.BackColor = System.Drawing.Color.MintCream;
            this.Sort_Button.Location = new System.Drawing.Point(311, 242);
            this.Sort_Button.Name = "Sort_Button";
            this.Sort_Button.Size = new System.Drawing.Size(139, 34);
            this.Sort_Button.TabIndex = 11;
            this.Sort_Button.Text = "Редактировать";
            this.Sort_Button.UseVisualStyleBackColor = false;
            this.Sort_Button.Click += new System.EventHandler(this.Sort_Button_Click);
            // 
            // Edit_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(554, 288);
            this.Controls.Add(this.Sort_Button);
            this.Controls.Add(this.Price_Box);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Batch_Box);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Country_Box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Name_Box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Code_Box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Edit_Form";
            this.Text = "Edit_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Code_Box;
        private System.Windows.Forms.TextBox Name_Box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Country_Box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Batch_Box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Price_Box;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Sort_Button;
    }
}