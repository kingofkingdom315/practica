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
            string s = "";
            double n = double.Parse(S.Text);
            Random r = new Random();
            FileStream f = new FileStream("f.dat", FileMode.Open);
            BinaryWriter fOut = new BinaryWriter(f);
            double a;
            for (Double i = 0; i < n; i++)
            {
                a = r.Next(-10,10);
                fOut.Write(a);
                s += a + "\n";
            }
            C.Text = s;
            s = "";
            fOut.Close();
            f = new FileStream("f.dat", FileMode.Open);
            BinaryReader fIn = new BinaryReader(f);
            long m = f.Length;
            for (long i = 0; i < m; i += 8)
            {
                f.Seek(i, SeekOrigin.Begin);
                a = fIn.ReadDouble();
                if (a < 0)
                    s += a + "\n";
            }
            A.Text = s;
            fIn.Close();
            f.Close();
        }
    }
}
