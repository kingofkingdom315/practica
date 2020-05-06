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

namespace prac
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void a_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            int D;
            if (Convert.ToInt32(a.Text) != 0)
            {
                D = Convert.ToInt32(b.Text) * Convert.ToInt32(b.Text) - 4 * Convert.ToInt32(a.Text) * Convert.ToInt32(c.Text);
                if (D > 0)
                    r.Text = "есть";
                else
                    r.Text = "нет";
            }
            else
                r.Text = "нет";

        }

        private void r_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void c_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
