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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            int bB;
            bB = Convert.ToInt32(B.Text) / 10 + Convert.ToInt32(B.Text) % 10;
            if (bB % Convert.ToInt32(A.Text) == 0)
                r.Text = "Кратно";
            else
                r.Text = "Не кратно";
        }
    }
}
