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
        static int f(int n, int m1, int m2, int nx)
        {
            m1 = Math.Abs(m1) - 6 * m2;
            if (nx != n)
            {
                nx++;
                return f(n, m2, m1, nx);
            }
            else
                return m1;
        }
        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt32(N.Text) > 2)
            {
                R.Text = Convert.ToString(f(Convert.ToInt32(N.Text), -10, 2, 3));
            }
            else
                R.Text = "Чичло n должно быть больше 2";


        }
    }
}
