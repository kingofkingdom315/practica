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
        static string f(int a)
        {
            int b, x, y, z;
            if (a >= 10)
            {
                b = a;
                z = 0;
                while (b > 10)
                {
                    b = b / 10;
                    z++;
                }
                x = a / Convert.ToInt32(Math.Pow(10, Convert.ToDouble(z)));
                y = a % 10;
                b = y * Convert.ToInt32(Math.Pow(10, Convert.ToDouble(z))) + a % Convert.ToInt32(Math.Pow(10, Convert.ToDouble(z)));
                b = b / 10 * 10 + x;
                return Convert.ToString(b);
            }
            else
            {
                return "Нужно минимум двухзначное и положительное число";
            }
        }
        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            Chislo.Text = f(Convert.ToInt32(A.Text));
        }
    }
}
