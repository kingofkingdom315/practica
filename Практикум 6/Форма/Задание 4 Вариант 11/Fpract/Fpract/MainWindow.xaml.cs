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
            int n = Convert.ToInt32(N.Text);
            int[,] mas = new int[n,n];
            int[,] masr = new int[n, 3];
            for (int i = 0; i < n; i++)  
            {
                for (int j = 0; j < n; j++)
                {
                    mas[i, j] = rn.Next(0, 10);
                    s +=  mas[i,j] + " ";
                    if (mas[i, j] % 2 != 0)
                    {
                        masr[j, 0] = mas[i, j];
                        masr[j, 1] = i + 1;
                        masr[j, 2] = j + 1;
                    }
                }
                s += "\r";
            }
            R1.Text = s;
            s = "";
            for (int i = 0; i < n; i++)
            {
                s += masr[i, 0] + " i = " + masr[i, 1] + " j = " + masr[i, 2] + "\r";
            }
            Rez1.Text = s;

        }
    }
}
