using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Fpract
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            int a, b;
            a = Convert.ToInt32(A.Text);
            b = Convert.ToInt32(B.Text);
            string s = "";
            if (a < b)
            {
                int j;
                j = a;
                for (int i = 0; i <= b - a; i++)
                {
                    if (j % 2 == 0 && j != 0 && j % 10 != 0)
                    {
                        s += Convert.ToString(j)+", ";
                    }
                    j++;
                }
                ForT.Text = s;
                s = "";
                j = a;
                while (j <= b)
                {
                    if (j % 2 == 0 && j != 0 && j % 10 != 0)
                    {
                        s += Convert.ToString(j) + ", ";
                    }
                    j++;
                }
                WhileT.Text = s;
                s = "";
                j = a;
                do
                {
                    if (j % 2 == 0 && j != 0 && j % 10 != 0)
                    {
                        s += Convert.ToString(j) + ", ";
                    }
                    j++;
                }
                while (j <= b);
                DoWhileT.Text = s;
                s = "";
            }
            else
            {
                s = "A должно быть меньше B";
                ForT.Text = s;
                WhileT.Text = s;
                DoWhileT.Text = s;
            }
        }
    }
}
