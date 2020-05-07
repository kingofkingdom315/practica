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
            int x, y;
            x = Convert.ToInt32(A.Text);
            y = Convert.ToInt32(B.Text);
            if (x < 0)
                x *= -1;
            if (y < 0)
                y *= -1;
            if (x < 40)
            {
                if (y < 40)
                    r.Text = "Да";
                else if (y == 40)
                    r.Text = "На гране";
                else
                    r.Text = "Нет";
            }
            else if (x == 40)
            {
                if (y == 40 || y < 40)
                    r.Text = "На гране";
                else
                    r.Text = "Нет";
            }
            else
                r.Text = "Нет";

        }
    }
}
