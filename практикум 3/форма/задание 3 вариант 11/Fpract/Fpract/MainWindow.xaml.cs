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
        static double f(Double x)
        {
            double t;
            if (x <= 5)
                t = x * x + 5;
            else if (x < 20)
                t = 0;
            else
                t = 1;
            return t;
        }
        static void f(double x, out double y)
        {
            if (x <= 5)
                y = x * x + 5;
            else if (x < 20)
                y = 0;
            else
                y = 1;
        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            double y;
            string s = "";
            if (Convert.ToDouble(A.Text) < Convert.ToDouble(B.Text))
            {
                for (Double i = Convert.ToDouble(A.Text); i <= Convert.ToDouble(B.Text); i += Convert.ToDouble(H.Text))
                    s+="f(" + i + ") = " + f(i) + "\n";
                R1.Text = s;
                s = "";
                for (Double i = Convert.ToDouble(A.Text); i <= Convert.ToDouble(B.Text); i += Convert.ToDouble(H.Text))
                {
                    f(i, out y);
                    s += "f(" + i + ") = " + y + "\n";
                }
                R2.Text = s;
            }
            else
            {
                s = "A должно быть меньше B";
            }

        }
    }
}
