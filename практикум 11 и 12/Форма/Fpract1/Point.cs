using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fpract1
{
    class Point
    {
        public double x;
        public double y;
        public Point()
        {
            this.x = 0;
            this.y = 0;
        }
        public Point(double a, double b)
        {
            this.x = a;
            this.y = b;
        }
        public double this[int i]
        {
            get
            {
                if (i == 0)
                    return x;
                if (i == 1) return y;
                throw new Exception("Error");
            }
        }
        public static bool operator false(Point obj)
        {
            if (obj.x != obj.y)
                return false;
            return true;
        }
        public static bool operator true(Point obj)
        {
            if (obj.x == obj.y)
                return true;
            return false;
        }
        public static explicit operator String(Point obj)
        {
            return obj.x + ", " + obj.y;
        }
        public static Point operator ++(Point c1)
        {
            c1.x += 1;
            c1.y += 1;
            return c1;
        }
        public static Point operator +(Point c1, Double a)
        {
            c1.x = c1.x + a;
            c1.y = c1.y + a;
            return c1;
        }
        public string cordout()
        {
            return ("x = " + x + ", y = " + y + ", ");
        }
        public double XO()
        {
            return Math.Sqrt(this.x * this.x + this.y * this.y);
        }
        public void moving(double a, double b)
        {
            this.x = this.x + a;
            this.y = this.y + b;
        }
        public double cordx
        {
            get
            {
                return this.x;
            }
            set
            {
                this.x = value;
            }
        }
        public double cordy
        {
            get
            {
                return this.y;
            }
            set
            {
                this.y = value;
            }
        }
        public double Scal
        {
            set
            {
                this.x = this.x * value;
                this.y = this.y * value;
            }
        }

    }
}
