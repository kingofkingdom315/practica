namespace Fpract1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Figurebox = new System.Windows.Forms.ListBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.quantity = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 15);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(57, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Фигура";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 183);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "ОК";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Figurebox
            // 
            this.Figurebox.DisplayMember = "Прямоугольник";
            this.Figurebox.FormattingEnabled = true;
            this.Figurebox.ItemHeight = 16;
            this.Figurebox.Items.AddRange(new object[] {
            "прямоугольник",
            "триугольник",
            "окружность"});
            this.Figurebox.Location = new System.Drawing.Point(17, 48);
            this.Figurebox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Figurebox.Name = "Figurebox";
            this.Figurebox.Size = new System.Drawing.Size(112, 52);
            this.Figurebox.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(16, 110);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(85, 22);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "Количество";
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(16, 143);
            this.quantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(113, 22);
            this.quantity.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(157, 228);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Figurebox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Tag = "";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox Figurebox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox quantity;
    }
}

