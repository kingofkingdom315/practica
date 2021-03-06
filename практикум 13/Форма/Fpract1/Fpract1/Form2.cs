using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fpract1
{
    public partial class Form2  : Form 
    {
        int f, q, i = 1;
        
        public Form2(int a, int b)
        {
            f = a;
            q = b;
            string s = "Введите данные фигуры номер 1";
            InitializeComponent();
            outInfo.Text = s;
            if (a == 1)
            {
                textBox4.Dispose();
                DX.Dispose();
                DY.Dispose();
            }
            else if (a == 2)
            {
                textBox2.Dispose();
                BX.Dispose();
                BY.Dispose();
                textBox4.Dispose();
                DX.Dispose();
                DY.Dispose();
                textBox1.Text = "цент";
                textBox3.Text = "R";
                CY.Dispose();
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (i <= q)
            {
                i++;
                if (f == 0)
                {
                    string outf;
                    double[] A = new double[4];
                    double[] B = new double[4];
                    A[0] = Convert.ToDouble(AX.Text);
                    A[1] = Convert.ToDouble(BX.Text);
                    A[2] = Convert.ToDouble(CX.Text);
                    A[3] = Convert.ToDouble(DX.Text);
                    B[0] = Convert.ToDouble(AY.Text);
                    B[1] = Convert.ToDouble(BY.Text);
                    B[2] = Convert.ToDouble(CY.Text);
                    B[3] = Convert.ToDouble(DY.Text);
                    Rectangle x = new Rectangle(A, B);
                    outf = x.outRectangle();
                    outInfo.Text += outf;
                    outf = "";
                    if (i <= q)
                    {
                        outInfo.Text += "Введите данные фигуры номер " + i.ToString() + ";";
                    }
                }
                else if (f == 1)
                {
                    string outf;
                    double[] A = new double[3];
                    double[] B = new double[3];
                    A[0] = Convert.ToDouble(AX.Text);
                    A[1] = Convert.ToDouble(BX.Text);
                    A[2] = Convert.ToDouble(CX.Text);
                    B[0] = Convert.ToDouble(AY.Text);
                    B[1] = Convert.ToDouble(BY.Text);
                    B[2] = Convert.ToDouble(CY.Text);
                    Triangle x = new Triangle(A, B);
                    outf = x.outTriangle();
                    outInfo.Text += outf;
                    outf = "";
                    if (i <= q)
                    {
                        outInfo.Text += "Введите данные фигуры номер " + i.ToString() + ";";
                    }
                }
                else
                {
                    string outf;
                    double[] A = new double[3];
                    A[0] = Convert.ToDouble(AX.Text);
                    A[1] = Convert.ToDouble(AY.Text);
                    A[2] = Convert.ToDouble(CX.Text);
                    Circle x = new Circle(A[0], A[1], A[2]);
                    outf = x.outCircle();
                    outInfo.Text += outf;
                    outf = "";
                    if (i <= q)
                    {
                        outInfo.Text += "Введите данные фигуры номер " + i.ToString() + ";";
                    }
                }
            }
        }
    }
}
