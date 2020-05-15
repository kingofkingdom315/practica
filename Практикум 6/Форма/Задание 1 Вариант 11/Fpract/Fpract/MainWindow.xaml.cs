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
            int r = 0,n = Convert.ToInt32(N.Text),m = Convert.ToInt32(M.Text);
            int[] mas = new int[n];
            int[,] mas1 = new int[n, m];
            for (int i = 0; i < Convert.ToInt32(N.Text); i++)
            {
                mas[i] = i;
                s += "mas1[" + i + "] = " + i + "\r";
                if (i % 2 == 0)
                {
                    r += mas[i] * mas[i];
                }
            }
            R1.Text = s;
            Rez1.Text = Convert.ToString(r);
            s = "";
            r = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mas1[i, j] = j;
                    s += "mas1[" + i + "][" + j + "] = " + j + "\r";
                    if (i % 2 == 0)
                    {
                        r += mas1[i, j] * mas1[i, j];
                    }
                    else if (j % 2 == 0)
                    {
                        r += mas1[i, j] * mas1[i, j];
                    }
                }
            }
            R2.Text = s;
            Rez2.Text = Convert.ToString(r);
        }
    }
}
