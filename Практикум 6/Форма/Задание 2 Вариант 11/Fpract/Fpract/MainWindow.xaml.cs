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
            string s = "";
            Random rn = new Random();
            int n = Convert.ToInt32(N.Text), max = -100000, min = 1000000, x = 0, y = 0;
            int[] mas = new int[n];
            for (int i = 0; i < n; i++)
            {
                mas[i] = rn.Next(0,10);
                s += "mas[" + i + "] = " + mas[i] + "\r";
                if (mas[i] >= max)
                {
                    x = i;
                    max = mas[i];
                }
                else if (mas[i] <= min)
                {
                    y = i;
                    min = mas[i];
                }
            }
            R1.Text = s;
            max = 0;
            if (x < y)
            {
                for (int i = x + 1; i < y; i++)
                {
                    max += mas[i];
                }
                Rez1.Text = Convert.ToString(max);
            }
            else
            {
                Rez1.Text = "Максимальный элемент находится после минммального";
            }

        }
    }
}
