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
using System.IO;

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
            int n = int.Parse(S.Text);
            string text = System.IO.File.ReadAllText("f.txt");
            string[] s = text.Split('\n');
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].Length == n+1)
                {
                    text = s[i];
                }
            }
            A.Text = text;
        }
    }
}
