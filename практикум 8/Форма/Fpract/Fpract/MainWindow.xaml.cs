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
using System.Text.RegularExpressions;

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
            String s = S.Text;
            Regex reg = new Regex(@"\b[0-9]{2}-[0-9]{2}-[0-9]{2}\b");
            Regex reg1 = new Regex(@"\b[0-9]{3}-[0-9]{3}\b");
            Regex reg2 = new Regex(@"\b[0-9]{3}-[0-9]{2}-[0-9]{2}\b");
            MatchCollection matches = reg.Matches(s);
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                    A.Text = match.Value + "\n";
            }
            else
            {
                A.Text = "Совпадений не найдено";
            }
            matches = reg1.Matches(s);
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                    A.Text += match.Value + "\n";
            }
            else
            {
                A.Text += "Совпадений не найдено";
            }
            matches = reg2.Matches(s);
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                    A.Text += match.Value;
            }
            else
            {
                A.Text += "Совпадений не найдено";
            }

        }
    }
}
