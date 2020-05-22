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
            s = s.Replace(",", " ");
            s = s.Replace(".", " ");
            s = s.Replace("?", " ");
            s = s.Replace("!", " ");
            for (int i = 0; i < s.Length; i++)
                s = s.Replace("  ", " ");
            string[] s1 = s.Split(' ');
            s = s1[0];
            for (int i = 1; i < s1.Length; i++)
                if (s.Length < s1[i].Length)
                    s = s1[i];
                else if (s.Length == s1[i].Length)
                    s += ", " + s1[i];
            A.Text = s;
        }
    }
}
