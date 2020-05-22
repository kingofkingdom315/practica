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
            string s = S.Text;
            int a = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] >= 48 && s[i] <= 57)
                {
                    a += Convert.ToInt32(Convert.ToString(s[i]));
                }
            }
            A.Text = Convert.ToString(a);
            Console.WriteLine(a);

        }
    }
}
