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

        static double f(double x)
        {
            try
            {
                if (x == 2) throw new Exception();
                else if (x == 0) throw new Exception();
                else return Math.Log(x / (x - 2), Math.E);
            }
            catch
            {
                throw;
            }
        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                String s = "";
                double a = double.Parse(A.Text);
                double b = double.Parse(B.Text);
                double h = double.Parse(H.Text);
                for (double i = a; i <= b; i += h)
                    try
                    {
                        s += "y(" + i + ") = " + f(i) + "\r";
                    }
                    catch
                    {
                        s += "y(" + i + ") = ошибка" + "\r";
                    }
                R1.Text = s;
            }
            catch (FormatException)
            {
                R1.Text = "Неверный формат ввода данных";
            }
            catch
            {
                R1.Text = "Неизвестная ошибка";
            }


        }
    }
}
