using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fpract1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Point a = new Point(-5, 12);
            string s = "";
            s += a.cordout();
            s += a.XO() + ", ";
            a.moving(5, -12);
            s += a.cordout();
            a.cordx = 6;
            s += a.cordx + ", ";
            a.cordy = 6;
            s += a.cordy + ", ";
            s += a.cordout();
            a.Scal = 4;
            s += a.cordout();
            a++;
            s += a.cordout();
            a = a + 3;
            s += a.cordout();
            OutInf.Text = s;
        }

        private void OutInf_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
