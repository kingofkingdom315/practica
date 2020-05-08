using System;

namespace pract
{
    class Program
    {
        static double f(Double x)
        {
            double t;
            if (x <= 5)
                t = x * x + 5;
            else if (x < 20)
                t = 0;
            else
                t = 1;
            return t;
        }
        static void f(double x, out double y)
        {
            if (x <= 5)
                y = x * x + 5;
            else if (x < 20)
                y = 0;
            else
                y = 1;
        }
        static void Main(string[] args)
        {
            Double y;
            Console.WriteLine("Введите A");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите B");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите H");
            double h = Convert.ToDouble(Console.ReadLine());
            if (a < b)
            {
                for (Double i = a; i <= b; i += h)
                    Console.WriteLine("f(" + i + ") = " + f(i));
                for (Double i = a; i <= b; i += h)
                {
                    f(i, out y);
                    Console.WriteLine("f(" + i + ") = " + y);
                }
            }
            else
            {
                Console.WriteLine("A должно быть меньше B");
            }
            Console.ReadLine();
        }
    }
}
