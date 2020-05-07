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
            switch (Convert.ToInt32(m.Text) % 12)
            {
                case 0:
                    r.Text = "Январь";
                    break;
                case 1:
                    r.Text = "Февраль";
                    break;
                case 2:
                    r.Text = "Март";
                    break;
                case 3:
                    r.Text = "Апрель";
                    break;
                case 4:
                    r.Text = "Май";
                    break;
                case 5:
                    r.Text = "Июнь";
                    break;
                case 6:
                    r.Text = "Июлб";
                    break;
                case 7:
                    r.Text = "Август";
                    break;
                case 8:
                    r.Text = "Сентябрь";
                    break;
                case 9:
                    r.Text = "Октябрь";
                    break;
                case 10:
                    r.Text = "Ноябрь";
                    break;
                case 11:
                    r.Text = "Декабрь";
                    break;
            }

        }
    }
}
