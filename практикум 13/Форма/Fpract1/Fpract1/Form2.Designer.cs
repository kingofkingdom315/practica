namespace Fpract1
{
    partial class Form2
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.AX = new System.Windows.Forms.TextBox();
            this.BX = new System.Windows.Forms.TextBox();
            this.CX = new System.Windows.Forms.TextBox();
            this.DX = new System.Windows.Forms.TextBox();
            this.AY = new System.Windows.Forms.TextBox();
            this.CY = new System.Windows.Forms.TextBox();
            this.DY = new System.Windows.Forms.TextBox();
            this.BY = new System.Windows.Forms.TextBox();
            this.outInfo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(17, 16);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(74, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Точка А";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(161, 13);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(74, 22);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Точка В";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(17, 102);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(74, 22);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "Точка C";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(161, 99);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(74, 22);
            this.textBox4.TabIndex = 3;
            this.textBox4.Text = "Точка D";
            // 
            // AX
            // 
            this.AX.Location = new System.Drawing.Point(17, 46);
            this.AX.Name = "AX";
            this.AX.Size = new System.Drawing.Size(34, 22);
            this.AX.TabIndex = 4;
            // 
            // BX
            // 
            this.BX.Location = new System.Drawing.Point(161, 42);
            this.BX.Name = "BX";
            this.BX.Size = new System.Drawing.Size(34, 22);
            this.BX.TabIndex = 5;
            // 
            // CX
            // 
            this.CX.Location = new System.Drawing.Point(17, 132);
            this.CX.Name = "CX";
            this.CX.Size = new System.Drawing.Size(34, 22);
            this.CX.TabIndex = 6;
            // 
            // DX
            // 
            this.DX.Location = new System.Drawing.Point(161, 129);
            this.DX.Name = "DX";
            this.DX.Size = new System.Drawing.Size(34, 22);
            this.DX.TabIndex = 7;
            // 
            // AY
            // 
            this.AY.Location = new System.Drawing.Point(57, 46);
            this.AY.Name = "AY";
            this.AY.Size = new System.Drawing.Size(34, 22);
            this.AY.TabIndex = 8;
            // 
            // CY
            // 
            this.CY.Location = new System.Drawing.Point(57, 132);
            this.CY.Name = "CY";
            this.CY.Size = new System.Drawing.Size(34, 22);
            this.CY.TabIndex = 9;
            // 
            // DY
            // 
            this.DY.Location = new System.Drawing.Point(201, 129);
            this.DY.Name = "DY";
            this.DY.Size = new System.Drawing.Size(34, 22);
            this.DY.TabIndex = 10;
            // 
            // BY
            // 
            this.BY.Location = new System.Drawing.Point(201, 43);
            this.BY.Name = "BY";
            this.BY.Size = new System.Drawing.Size(34, 22);
            this.BY.TabIndex = 11;
            // 
            // outInfo
            // 
            this.outInfo.Location = new System.Drawing.Point(17, 161);
            this.outInfo.Multiline = true;
            this.outInfo.Name = "outInfo";
            this.outInfo.ReadOnly = true;
            this.outInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.outInfo.Size = new System.Drawing.Size(299, 381);
            this.outInfo.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(241, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Вывод";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.outInfo);
            this.Controls.Add(this.BY);
            this.Controls.Add(this.DY);
            this.Controls.Add(this.CY);
            this.Controls.Add(this.AY);
            this.Controls.Add(this.DX);
            this.Controls.Add(this.CX);
            this.Controls.Add(this.BX);
            this.Controls.Add(this.AX);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox AX;
        private System.Windows.Forms.TextBox BX;
        private System.Windows.Forms.TextBox CX;
        private System.Windows.Forms.TextBox DX;
        private System.Windows.Forms.TextBox AY;
        private System.Windows.Forms.TextBox CY;
        private System.Windows.Forms.TextBox DY;
        private System.Windows.Forms.TextBox BY;
        private System.Windows.Forms.TextBox outInfo;
        private System.Windows.Forms.Button button1;
    }
}