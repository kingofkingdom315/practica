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
            float sS;
            sS = ((float.Parse(x2.Text) - float.Parse(x1.Text)) * (float.Parse(y3.Text) - float.Parse(y1.Text))) - ((float.Parse(x3.Text) - float.Parse(x1.Text)) * (float.Parse(y2.Text) - float.Parse(y1.Text)));
            if (sS < 0)
                sS *= -1;
            S.Text = Convert.ToString(sS/2);
        }
    }
}
