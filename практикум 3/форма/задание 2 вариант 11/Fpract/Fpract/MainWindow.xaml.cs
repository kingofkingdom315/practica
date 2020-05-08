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
            double y;
            if (x <= 5)
                y = x * x + 5;
            else if (x < 20)
                y = 0;
            else
                y = 1;
            return y;
        }
        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            String s = "";
            if (Convert.ToDouble(A.Text) < Convert.ToDouble(B.Text) && Convert.ToDouble(H.Text) > 0)
                for (Double i = Convert.ToDouble(A.Text); i <= Convert.ToDouble(B.Text); i += Convert.ToDouble(H.Text))
                    s += "f(" + i + ") = " + f(i) + "\n";
            else if (Convert.ToDouble(H.Text) > 0)
                s = "A должно быть меньше B";
            else if (Convert.ToDouble(A.Text) < Convert.ToDouble(B.Text))
                s = "H должен быть больше 0";
            else
                s = "A должно быть меньше B и H должен быть больше 0";
            R.Text = s;
        }
    }
}
