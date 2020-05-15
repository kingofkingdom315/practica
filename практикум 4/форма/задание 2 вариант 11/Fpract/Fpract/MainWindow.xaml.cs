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
        public void f(int n, int nx, ref string t)
        {
            if (n % nx == 0 && n != nx)
            {
                t += Convert.ToString(nx) + "\n";
                nx++;
                f(n, nx, ref t);
            }
            else if (n != nx)
            {
                nx++;
                f(n, nx, ref t);
            }
            else
            {
                t += Convert.ToString(n) + "\n";
            }

        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            string s = "";
            if (Convert.ToInt32(N.Text) > 0)
            {
                f(Convert.ToInt32(N.Text), 1,ref s);
                R.Text = s;
            }
            else
                R.Text = "Чичло n должно быть больше 0";


        }
    }
}
